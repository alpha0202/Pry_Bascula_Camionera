using CapaDatos;
using DevExpress.XtraEditors;
using IntegracionSAP_Dll;
using Pry_Basculas_SAP.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP
{
    public partial class frm_Cambiar_transportista : DevExpress.XtraEditors.XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        List<Parametros> LstParametros = new List<Parametros>();
        private string idP_consulta;
        private string trans_actual;
        private string Nit_Transportista_Nuevo;
        private string Nombre_transportista_Nuevo;
        public frm_Cambiar_transportista()
        {
            InitializeComponent();
        }





        //BUSCAR POR ID PESAJE EL TRANSPORTISTA ACTUAL
        private void txt_DigitaID_Leave(object sender, EventArgs e)
        {
            idP_consulta = txt_DigitaID.Text;
            
            if (!string.IsNullOrEmpty(idP_consulta))
            {
                idP_consulta = idP_consulta.PadLeft(10, '0');

                string respuesta_transportista = $" SELECT D.TRANSPORTISTA FROM [BASCULAS_SAP].[DBO].[TB_DATOS_ACTIVOS] D INNER JOIN [BASCULAS_SAP].[DBO].[CAPTURA_PESAJES] C ON D.ID_PESAJE = C.ID_PESAJE WHERE D.ID_PESAJE = {idP_consulta} AND C.ESTADO IN ('P', 'Y', 'C')";
                DataTable res_trans = Datos.ObtenerDataTable(respuesta_transportista);
                if (res_trans.Rows.Count != 0)
                {
                    trans_actual = res_trans.Rows[0]["transportista"].ToString();
                    if (trans_actual.ToString() == "")
                    {
                        XtraMessageBox.Show($"NO SE ENCONTRÓ INFORMACIÓN DE TRANSPORTISTA PARA EL ID: {idP_consulta}.\r\nREVISAR NOMBRE DE TRANSPORTISTA EN SAP.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_DigitaID.Text = "";
                        return;
                    }
                    else
                    {
                        txt_transActual.Visible = true;
                        txt_transActual.Enabled = false;
                        txt_transActual.Text = trans_actual;
                        txt_DigitaID.Text = idP_consulta;
                        txt_DigitaID.Enabled = false;
                        btn_newBusqueda.Visible = true;
                        btn_newBusqueda.Enabled = true;
                    }
                }
                else
                {
                    XtraMessageBox.Show($"EL ID: {idP_consulta} NO SE ENCUENTRA EN PROCESO, EN ESPERA DE CONFIRMACIÓN O CERRADOS.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_DigitaID.Text = "";
                    txt_transActual.Visible = false;
                    txt_transActual.Text = "";
                }
            }
            else
            {
                XtraMessageBox.Show($"NO HA DIGITADO EL ID DE PESAJE PARA CONSULTAR", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DigitaID.Text = "";
                txt_transActual.Visible = false;
                txt_transActual.Text = "";

            }

        }


        //BUSCAR POR NIT EL NUEVO TRANSPORTISTA
        private void txt_nit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nit.Text))
            {
                txt_NomTrans.Text = string.Empty;
                txt_NomTrans.Visible = false;
                txt_nit.Text = string.Empty;
                return;
            }
            else
            {
                try
                {
                    DataTable dtTransportistas = metodosIntegracion.Listar_Transportistas();

                    DataTable filterTable = dtTransportistas.AsEnumerable()
                                         .Where(r => r.Field<string>("SORTL") == txt_nit.Text.Trim())
                                         //.OrderByDescending(o => o.Field<string>("FPROCESO"))
                                         .CopyToDataTable();

                    if (filterTable.Rows.Count != 0)
                    {
                        string nom_transportista = filterTable.Rows[0]["MCOD1"].ToString();
                        txt_NomTrans.Visible = true;
                        txt_NomTrans.Text = nom_transportista;
                        Nit_Transportista_Nuevo = txt_nit.Text;
                        Nombre_transportista_Nuevo = nom_transportista;
                        btn_CambiarTrans.Enabled = true;
                    }
                    else
                    {
                        throw new Exception($"NO EXISTE REGISTRO DEL TRANSPORTISTA CON NIT: {txt_nit.Text}");
                        txt_nit.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + $"\r\nNO EXISTE REGISTRO DEL TRANSPORTISTA CON NIT: {txt_nit.Text}", "ATENCIÓN");
                    txt_nit.Text = string.Empty;
                    txt_NomTrans.Text = string.Empty;
                }

            }
        }


        private void btn_CambiarTrans_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_nit.Text) && !string.IsNullOrEmpty(txt_transActual.Text) && !string.IsNullOrEmpty(txt_nit.Text) && !string.IsNullOrEmpty(txt_NomTrans.Text))
            {
               
                if (XtraMessageBox.Show($"SE VA A REALIZAR EL CAMBIO DE TRANSPORTISTA DE **{trans_actual}** \r\r\n A ESTE NUEVO **{Nombre_transportista_Nuevo}**. \r\r\n¿DESEA CONTINUAR CON EL CAMBIO?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    Cambiar_TransportistaSP(idP_consulta,Nit_Transportista_Nuevo,Nombre_transportista_Nuevo);
                }

            }
            else
            {
                XtraMessageBox.Show($"LOS CAMPOS DEBEN ESTAR DILIGENCIADOS CORRECTAMENTE PARA CONTINUAR.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar_Elementos();
            }

        }


        private void Cambiar_TransportistaSP(string idPesaje, string nitTransNuevo, string nombTransNuevo)
        {
            LstParametros.Add(new Parametros("@idPesaje", idPesaje, SqlDbType.VarChar));
            LstParametros.Add(new Parametros("@nit_NuevoTrans", nitTransNuevo, SqlDbType.VarChar));
            LstParametros.Add(new Parametros("@Nom_NuevoTrans", nombTransNuevo, SqlDbType.VarChar));
            var sendData = Datos.SPGetEscalar("SP_Cambiar_Transportista", LstParametros);
            if (sendData.ToString() == "OK")
            { 
                XtraMessageBox.Show($"CAMBIO REALIZADO CORRECTAMENTE.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar_Elementos();    
            }

        }




        private void btn_newBusqueda_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"¿Cambiará de ID de pesaje?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Limpiar_Elementos();


            }
        }



        /**digitar solo números**/

        private void Digitar_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void txt_DigitaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Digitar_SoloNumeros(sender,e);
        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Digitar_SoloNumeros(sender, e);
        }
        private void Limpiar_Elementos()
        {
            txt_DigitaID.Text = string.Empty;
            txt_DigitaID.Enabled = true;
            txt_transActual.Text = string.Empty;
            txt_transActual.Visible = false;
            txt_nit.Text = string.Empty;
            txt_NomTrans.Text = string.Empty;
            txt_NomTrans.Visible = false;
            btn_newBusqueda.Enabled = false;
            btn_newBusqueda.Visible = false;
            btn_CambiarTrans.Enabled = false;
        }
    }
}
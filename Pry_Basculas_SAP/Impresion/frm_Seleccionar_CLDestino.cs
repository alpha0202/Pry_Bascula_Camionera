using CapaDatos;
using DevExpress.XtraEditors;
using IntegracionSAP_Dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP.Impresion
{
    public partial class frm_Seleccionar_CLDestino : DevExpress.XtraEditors.XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();


        private string _idPesaje;
        public frm_Seleccionar_CLDestino(string idpesaje)
        {
            _idPesaje = idpesaje;
            InitializeComponent();

        }

        private DataTable CL_Destinos()
        {
            //DataTable dtCl_Destinos = metodosIntegracion.Listar_ClDestinos();

            string sql = $"SELECT [Cod_CL_Destino],[Descripcion_CentroLog_Destino] FROM[BASCULAS_SAP].[dbo].[TB_CENTROS_LOGI_DESTINO]";
            DataTable dtCl_Destinos = Datos.ObtenerDataTable(sql);

            txt_idPesaje.Text = _idPesaje;
            cbo_destinos.DataSource = dtCl_Destinos;       
            cbo_destinos.DisplayMember = "Descripcion_CentroLog_Destino";
            cbo_destinos.ValueMember = "Cod_CL_Destino";
            //lbl_seleccion.Text = cbo_destinos.SelectedIndex.ToString() ;  
            //lbl_seleccion.Text = cbo_destinos.SelectedItem.ToString();

            return dtCl_Destinos;

        }


        


        private void frm_Seleccionar_CLDestino_Load(object sender, EventArgs e)
        {
            CL_Destinos();
        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"¿CONFIRMAR EL CENTRO LOGISTICO DE DESTINO PARA EL ID PESAJE: {_idPesaje}", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                string clDestino = lbl_seleccion.Text;
                //[BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS]
                string sql = $"UPDATE [BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS] set [BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS].centroLogistico_destino = '{clDestino}' FROM [BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS]a INNER JOIN [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] cp ON a.id_pesaje = cp.id_pesaje  WHERE a.id_pesaje = '{_idPesaje}' and  cp.estado in ('C','Y') ";
                string respuesta = (string)Datos.GetEscalar(sql);
                if (respuesta == "" || respuesta is null )
                {
                    XtraMessageBox.Show($"CENTRO LOGÍSTICO DESTINO ACTUALIZADO PARA ID: {_idPesaje}", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }

            }

        }

        private void cbo_destinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbo_destinos.GetItemText(cbo_destinos.SelectedItem);
            lbl_seleccion.Text = selectedValue;
        }
    }
}
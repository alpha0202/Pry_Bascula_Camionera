using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDatos;
using System.Security.Principal;
using System.DirectoryServices;
using DevExpress.XtraEditors;
using Pry_Basculas_SAP.Class;
using DevExpress.XtraGrid.Views.Grid;
using System.Configuration;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Pry_Basculas_SAP
{
    public partial class frmVista_PesajesActivos : XtraForm
    {
        frm_Captua_PesoBasculas frmCaptura = new frm_Captua_PesoBasculas();
        UserActiveDirectory usuarioAD = new UserActiveDirectory() ;
        Basculas bascula = new Basculas();
        string ipBascula = ConfigurationManager.AppSettings["Ip_bascula"];
        string userAd;


        public frmVista_PesajesActivos()
        {
            InitializeComponent();
            CargueListadosPesajes();
           
            //evita problemas para abrir y cerrar el llamado del formulario  captura de pesos.
            if (frmCaptura is null)
            {
                frmCaptura = new frm_Captua_PesoBasculas();

            }
            else if (!frmCaptura.IsHandleCreated)
            {
                frmCaptura = new frm_Captua_PesoBasculas();
            }


            bascula.GetBascula_byIP(ipBascula);

        }

        public void ConfirmacionCaptura(string confirma)
        {
            if (confirma == "ok")
                RecargarGridListadoPesajes();
            else
                return;

        }


        private void Form1_Load(object sender, EventArgs e)
        {


            List<Parametros> LstParametros = new List<Parametros>();
            userAd = usuarioAD.GetCurrentUserAD();

            ////string sql = $"select count(*) from t101_Usuarios where f101_Usuario = ALIAR\\{userAd}   ";
            //LstParametros.Add(new Parametros("@user", userAd, SqlDbType.VarChar));
            //var contador = Datos.SPGetEscalar("SP_GetPermisos_UserAD", LstParametros);
            //var countPermisos = Convert.ToInt32(contador);

            //if (countPermisos < 1)
            //    XtraMessageBox.Show("Error: EL USUARIO NO ESTA AUTORIZADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }


        public void CargueListadosPesajes()
        {

            var dt = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");
                gcPesajesActivosSAP.DataSource = dt;
                gvVista_ListadoActivo.OptionsView.ColumnAutoWidth = false;
                gcPesajesActivosSAP.ForceInitialize();
                gvVista_ListadoActivo.BestFitColumns();
               

        }


        public void RecargarGridListadoPesajes()
        {
            //gcPesajesActivosSAP.DataSource = null;
            //gcPesajesActivosSAP.DataSource = dtRefresh;
            DataTable dtRefresh = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");
            try
            {
                gcPesajesActivosSAP.BeginUpdate();
                gvVista_ListadoActivo.Columns.Clear();
                gcPesajesActivosSAP.DataSource = null;
                gcPesajesActivosSAP.DataSource = dtRefresh;
                gvVista_ListadoActivo.RefreshData();

            }
            finally
            {
                gcPesajesActivosSAP.EndUpdate();
            }


            #region pruebas 

            //decimal pesoUno, pesoDos, pesoNeto;
            //string usuarioPesaje1, usuarioPesaje2, tiqueteBascula;


            //foreach (DataRow item in dtRefresh.Rows)
            //{
            //    pesoUno = decimal.Parse(item["peso1"].ToString());
            //    pesoDos = decimal.Parse(item["peso2"].ToString());
            //    pesoNeto = decimal.Parse(item["peso_neto"].ToString());
            //    usuarioPesaje1 = item["usuario_pesaje1"].ToString();
            //    usuarioPesaje2 = item["usuario_pesaje2"].ToString();
            //    tiqueteBascula = item["tiquete_bascula"].ToString();


            //}


            //ArrayList rows = new ArrayList();
            //Int32[] selectedRowHandles = gvVista_ListadoActivo.GetSelectedRows();
            //for (int i = 0; i < selectedRowHandles.Length; i++)
            //{
            //    int selectedRowHandle = selectedRowHandles[i];
            //    if (selectedRowHandle >= 0)
            //        rows.Add(gvVista_ListadoActivo.GetDataRow(selectedRowHandle));
            //}

            //try
            //{
            //    gcPesajesActivosSAP.BeginUpdate();
            //    //for (int i = 0; i < rows.Count; i++)
            //    //{
            //    //    DataRow row = rows[i] as DataRow;
            //    //    // Change the field value.
            //    //    row["peso1"] = pesoUno;
            //    //}


            //}
            //finally
            //{
            //    gcPesajesActivosSAP.EndUpdate();
            //}
            #endregion
        }




        private void repositoryItemButtonEjecutarPesaje_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            ArrayList rows = new ArrayList();
            string idPesaje;
            decimal cantidadUmb;
            decimal cantidadUmp;
            decimal numBascula;
            string placaVehiculo;

            Int32[] selectedRowHandles = gvVista_ListadoActivo.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gvVista_ListadoActivo.GetDataRow(selectedRowHandle));

                    DataRow row = rows[i] as DataRow;

                idPesaje = row.Field<string>("id_pesaje");
                cantidadUmb = row.Field<decimal>("cantidad_umb");
                cantidadUmp = row.Field<decimal>("cantidad_ump");
                numBascula = row.Field<decimal>("num_bascula");
                placaVehiculo = row.Field<string>("placa_cabezote").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);

               frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo );

            }

           

            rows.Clear();

           this.Hide();
            frmCaptura.ShowDialog();
            
           
        }








        private void repositoryItemButtonConfirmar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            XtraMessageBox.Show("Validando...","CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnEndForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmCaptura.Dispose();
            this.Close();
            
        }
    }

}

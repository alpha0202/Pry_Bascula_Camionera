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
using IntegracionSAP_Dll;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace Pry_Basculas_SAP
{
    public partial class frmVista_PesajesActivos : XtraForm
    {
        frm_Filtrar_placa ppal = new frm_Filtrar_placa();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();


        Basculas bascula = new Basculas();
        string ipBascula = ConfigurationManager.AppSettings["Ip_bascula"];
        string puertoCOM = ConfigurationManager.AppSettings["PUERTO"];
        string numeroBascula = ConfigurationManager.AppSettings["NUM_BASCULA"];
        string userAd, nombreUser, numberBascula, descBascula;
      
        
       


        public frmVista_PesajesActivos()
        {
            
            InitializeComponent();
            
           
            //evita problemas para abrir y cerrar el llamado del formulario  captura de pesos.
            //if (frmCaptura is null)
            //{
            //    frmCaptura = new frm_Captua_PesoBasculas();

            //}
            //else if (!frmCaptura.IsHandleCreated)
            //{
            //    frmCaptura = new frm_Captua_PesoBasculas();
            //}


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

            //string sql = $"select count(*) from t101_Usuarios where f101_Usuario = ALIAR\\{userAd}   ";
            LstParametros.Add(new Parametros("@user", userAd, SqlDbType.VarChar));
            LstParametros.Add(new Parametros("@numBascula", numeroBascula, SqlDbType.Int));
            DataTable dt = Datos.SPObtenerDataTable("SP_GetPermisos_UserAD", LstParametros);
            //var countPermisos = Convert.ToInt32(contador);

            if (dt.Rows.Count != 0)
            {
                nombreUser = dt.Rows[0]["nombre_usuario"].ToString();
                descBascula = dt.Rows[0]["descripcion"].ToString();
                numberBascula = dt.Rows[0]["num_bascula"].ToString();
                
                lblGetUsuario.Text = nombreUser;
                lblGetBascula.Text = string.Concat(numberBascula,"-",descBascula);
                CargueListadosPesajes();
            }   
            else
            {
                XtraMessageBox.Show("Error: USUARIO NO AUTORIZADO PARA ESTA BÁSCULA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }


        public void CargueListadosPesajes()
        {

            DataTable dataFromSAP = metodosIntegracion.CargarData_PesajesActivos();
            DataTable filterTableSAP = dataFromSAP.AsEnumerable()
                               .Where(r => r.Field<string>("STATUS") == "00")
                               .CopyToDataTable();



            DataTable dt = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");
           

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



        //boton de la grilla para capturar pesos.
        private void repositoryItemButtonEjecutarPesaje_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            frm_Captura_PesoBasculas frmCaptura = new frm_Captura_PesoBasculas();
            ArrayList rows = new ArrayList();
            string idPesaje;
            decimal cantidadUmb;
            decimal cantidadUmp;
            decimal numBascula;
            string tipoProceso;
            string procesoDetalle;
            string tipoPesaje;
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
                tipoProceso = row.Field<string>("tipo_proceso");
                tipoPesaje = row.Field<string>("tipo_pesaje");
                procesoDetalle = row.Field<string>("proceso");
                placaVehiculo = row.Field<string>("placa_cabezote").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);
                frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numBascula, tipoProceso, tipoPesaje, procesoDetalle, placaVehiculo );

            } 

            rows.Clear();

           
            frmCaptura.StartPosition = FormStartPosition.CenterScreen;
            frmCaptura.ShowDialog();
            frmCaptura.Dispose();
            
           
        }



        //confirmar para realizar consulta con inventario 
        private void repositoryItemButtonConfirmar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            List<Parametros> LstParametros = new List<Parametros>();
            string idPesajeSelected;
            string materialSelected;
            string conductorSelected;
            string tiqueteSelected;
            string centroLog;
            decimal netoSelected;
            DataRow celdasSelected = gvVista_ListadoActivo.GetDataRow(gvVista_ListadoActivo.FocusedRowHandle);

            idPesajeSelected = celdasSelected.Field<string>("id_pesaje");
            materialSelected = celdasSelected.Field<string>("material_sap");
            conductorSelected = celdasSelected.Field<string>("conductor").Trim();
            tiqueteSelected = celdasSelected.Field<string>("tiquete_bascula");
            centroLog = celdasSelected.Field<string>("centro_logistico");
            netoSelected = celdasSelected.Field<decimal>("peso_neto");
            

            string sql = $"SELECT * FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {idPesajeSelected} AND estado ='P' ";
            var dt = Datos.ObtenerDataTable(sql);

            if(dt.Rows.Count != 0)
            {
               XtraMessageBox.Show("SE DEBE COMPLETAR EL PROCESO PENDIENTE PARA REALIZAR LA CONFIRMACIÓN.","ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable inventario = metodosIntegracion.CargarSaldos(centroLog,materialSelected);

            if(inventario.Rows.Count == 0 )
            {
                XtraMessageBox.Show($"NO SE ENCONTRÓ INVENTARIO PARA EL MATERIAL {materialSelected} \r\nDEL CENTRO LOGÍSTICO {centroLog}.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string  saldoInv = inventario.Rows[0]["LABST"].ToString();
            decimal saldoMaterial = decimal.Parse(saldoInv);

            if (netoSelected <= saldoMaterial)
            {
                LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));

                var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);

                XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. SALDO DISPONIBLE PARA LA TRANSACCIÓN.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                XtraMessageBox.Show("SOBREPASA EL SALDO DISPONIBLE DEL MATERIAL.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }





        private void gvVista_ListadoActivo_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            DataRow dr = view.GetDataRow(info.RowHandle);

            try
            {
                frm_DetalleSelectedRow frmDetalle = new frm_DetalleSelectedRow(dr[0].ToString())
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frmDetalle.ShowDialog();
                frmDetalle.Dispose();


            }
            catch (Exception)
            {

                throw;
            }




        }

        //personalización de filas según el estado, pintará con el color correspondiente.
        private void gvVista_ListadoActivo_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.RowHandle >= 0)
            {
                
                string state = View.GetRowCellDisplayText(e.RowHandle, View.Columns["estado"]).Trim();
                if (state == "A")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (state == "P")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }
                else if (state == "Y")
                {
                    e.Appearance.BackColor = Color.LightSkyBlue;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (state == "C")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.SeaShell;

                }
            }


        }


        private void btnEndForm_Click(object sender, EventArgs e)
        {
            //frmCaptura.Dispose();
            this.Dispose();
            this.Close();
            
        }

        private void btnConsultarPlaca_Click(object sender, EventArgs e)
        {
           //frm_Principal_EnviarDatos ppal = new frm_Principal_EnviarDatos();
            ppal.ShowDialog();
            ppal.Dispose();
        }

        private void frmVista_PesajesActivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmCaptura.Dispose();
            //frmCaptura.Close();
            //ppal.Dispose();
            this.Dispose();
            this.Close();

        }
    }

}

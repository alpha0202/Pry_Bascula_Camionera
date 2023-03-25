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
using DevExpress.XtraLayout;

namespace Pry_Basculas_SAP
{
    public partial class frmVista_PesajesActivos : XtraForm
    {
        frm_Filtrar_placa ppal = new frm_Filtrar_placa();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        UtilitiesSP utilidadesSP = new UtilitiesSP();
        FrmCustom custom = new FrmCustom();
       
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();


        Basculas bascula = new Basculas();
        string ipBascula = ConfigurationManager.AppSettings["Ip_bascula"];
        string puertoCOM = ConfigurationManager.AppSettings["PUERTO"];
        string numeroBascula = ConfigurationManager.AppSettings["NUM_BASCULA"];
        string userAd, nombreUser, numberBascula, descBascula;
        DataTable dataFromSAP;
        DataTable filterTableSAP;




        public frmVista_PesajesActivos()
        {
            
            InitializeComponent();
            time_live.Start();

            //evita problemas para abrir y cerrar el llamado del formulario  captura de pesos.
            if (ppal is null)
            {
                ppal = new frm_Filtrar_placa();

            }
            else if (!ppal.IsHandleCreated)
            {
                ppal = new frm_Filtrar_placa();
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

            //string sql = "  DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            //Datos.GetEscalar(sql);


            //dataFromSAP = metodosIntegracion.CargarData_PesajesActivos();
            //filterTableSAP = dataFromSAP.AsEnumerable()
            //                   .Where(r => r.Field<string>("STATUS") == "00")
            //                   .CopyToDataTable();

            ////Guardar toda la data para luego ser cruzada con el filtro de la plata
            //utilidadesSP.GuardarData_FromSAP(filterTableSAP);


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
                RecargarGridListadoPesajes();
            }   
            else
            {
                XtraMessageBox.Show("Error: USUARIO NO AUTORIZADO PARA ESTA BÁSCULA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }

        //cargar listados en proceso
        public void CargueListadosPesajes()
        {

            DataTable dt = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");

            try
            {
                gcPesajesActivosSAP.BeginUpdate();
                gcPesajesActivosSAP.DataSource = dt;
                gvVista_ListadoActivo.OptionsView.ColumnAutoWidth = false;
                gcPesajesActivosSAP.ForceInitialize();
                gvVista_ListadoActivo.BestFitColumns();
                gvVista_ListadoActivo.RefreshData();

            }
           finally
            {

                gcPesajesActivosSAP.EndUpdate();
            }
               

        }


        //carga desde frm de busqueda por placa
        public void RecargarGridListadoPesajes()
        {
           
            DataTable dtRefresh = Datos.SPObtenerDataTable("SP_Cargue_DetalleSeleccionado_Pesajes");
            //DataTable dtRefresh = Datos.SPObtenerDataTable("SP_RefrescarData_FiltradaPlacas");
            try
            {
                grc_ControlFiltrado.BeginUpdate();
                //gvVista_ListadoActivo.Columns.Clear();
                grc_ControlFiltrado.DataSource = dtRefresh;
                grv_VistaFiltrado.OptionsView.ColumnAutoWidth = false;
                grc_ControlFiltrado.ForceInitialize();
                grv_VistaFiltrado.BestFitColumns();
                grv_VistaFiltrado.RefreshData();
                
            }
            finally
            {
                grc_ControlFiltrado.EndUpdate();
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

        #region recibir datos de data grid a data grid(prueba)
        //public void RecibeDatosFiltrados(DataRow Filter)
        //{

        //    DataTable table = new DataTable();
        //    DataColumn column;
        //    DataRow newRow;


        //    table.Columns.Add("IDPESAJE", typeof(string));
        //    table.Columns.Add("TPROCESO", typeof(string));
        //    table.Columns.Add("TPESAJE", typeof(string));
        //    table.Columns.Add("FPROCESO", typeof(string));
        //    table.Columns.Add("VBELN", typeof(string));
        //    table.Columns.Add("EBELN", typeof(string));
        //    table.Columns.Add("TKNUM", typeof(string));
        //    table.Columns.Add("VBELN2", typeof(string));
        //    table.Columns.Add("MATNR", typeof(string));
        //    table.Columns.Add("ADD01", typeof(string));
        //    table.Columns.Add("ADD02", typeof(string));
        //    table.Columns.Add("DPLBG", typeof(string));
        //    table.Columns.Add("TEXT1", typeof(string));
        //    table.Columns.Add("WERKS", typeof(string));
        //    table.Columns.Add("BASCULA", typeof(string));
        //    table.Columns.Add("LFIMG", typeof(string));
        //    table.Columns.Add("MEINS", typeof(string));
        //    table.Columns.Add("PIKMG", typeof(string));
        //    table.Columns.Add("UMP", typeof(string));
        //    table.Columns.Add("CHARG", typeof(string));
        //    table.Columns.Add("ZTQ_BASC", typeof(string));
        //    table.Columns.Add("LKIMG_REAL", typeof(string));
        //    table.Columns.Add("PIKMG_REAL", typeof(string));
        //    table.Columns.Add("MBLNR", typeof(string));
        //    table.Columns.Add("STATUS", typeof(string));
        //    table.Columns.Add("MAKT", typeof(string));


        //    newRow = table.NewRow();
        //    table.Rows.Add(newRow);
        //    var ds = table.DataSet;

        //    //foreach (var item in Filter.ItemArray)
        //    //{
        //    //}
        //}
        #endregion




        //boton de la grilla para capturar pesos.
        private void repositoryItemButtonEjecutarPesaje_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            frm_Captura_PesoBasculas frmCaptura = new frm_Captura_PesoBasculas();
            ArrayList rows = new ArrayList();
            string idPesaje;
            string cantidadUmb;
            string cantidadUmp;
            string undUmb;
            string undUmp;
            //decimal numBascula;
            string tipoProceso;
            string descProceso;
            
            string tipoPesaje;
            string placaVehiculo;

            Int32[] selectedRowHandles = gvVista_ListadoActivo.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gvVista_ListadoActivo.GetDataRow(selectedRowHandle));

                DataRow row = rows[i] as DataRow;

                idPesaje = row.Field<string>("IDPESAJE");
                cantidadUmb = row.Field<string>("LFIMG");
                cantidadUmp = row.Field<string>("PIKMG");
                undUmb = row.Field<string>("MEINS");
                undUmp = row.Field<string>("UMP");
                //numBascula = row.Field<decimal>("num_bascula");
                descProceso = row.Field<string>("proceso");
                tipoProceso = row.Field<string>("TPROCESO");
                tipoPesaje = row.Field<string>("TPESAJE");            
                placaVehiculo = row.Field<string>("ADD01").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);
                frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numeroBascula, tipoProceso, tipoPesaje, descProceso, placaVehiculo, undUmb, undUmp, row );

            } 

            rows.Clear();

           
            frmCaptura.StartPosition = FormStartPosition.CenterScreen;
            frmCaptura.ShowDialog();
            CargueListadosPesajes();
            frmCaptura.Dispose();
            
           
        }

        //iniciar proceso de registros activos.
        private void repositoryItemButton_IniciarProceso_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Captura_PesoBasculas frmCaptura = new frm_Captura_PesoBasculas();
            ArrayList rows = new ArrayList();
            string idPesaje;
            string cantidadUmb;
            string cantidadUmp;
            string undUmb;
            string undUmp;
            //decimal numBascula;
            string tipoProceso;
            string descProceso;

            string tipoPesaje;
            string placaVehiculo;

            Int32[] selectedRowHandles = grv_VistaFiltrado.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(grv_VistaFiltrado.GetDataRow(selectedRowHandle));

                DataRow row = rows[i] as DataRow;

                idPesaje = row.Field<string>("IDPESAJE");
                cantidadUmb = row.Field<string>("LFIMG");
                cantidadUmp = row.Field<string>("PIKMG");
                undUmb = row.Field<string>("MEINS");
                undUmp = row.Field<string>("UMP");
                //numBascula = row.Field<decimal>("num_bascula");
                descProceso = row.Field<string>("proceso");
                tipoProceso = row.Field<string>("TPROCESO");
                tipoPesaje = row.Field<string>("TPESAJE");
                placaVehiculo = row.Field<string>("ADD01").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);
                frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numeroBascula, tipoProceso, tipoPesaje, descProceso, placaVehiculo, undUmb, undUmp, row);

            }

            rows.Clear();

            frmCaptura.StartPosition = FormStartPosition.CenterScreen;
            frmCaptura.ShowDialog();
            CargueListadosPesajes();
            frmCaptura.Dispose();



        }


        //confirmar para realizar consulta con inventario 
        private void repositoryItemButtonConfirmar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            List<Parametros> LstParametros = new List<Parametros>();
            string idPesajeSelected;
            string materialSelected;
            string descMaterialSelected;
            string conductorSelected;
            string tiqueteSelected;
            string centroLog;
            string meins;
            string lfimg;
            string ump;
            string charg;
            string lgort ="";
            decimal netoSelected;
            decimal validarExceso = 0;
            DataRow celdasSelected = gvVista_ListadoActivo.GetDataRow(gvVista_ListadoActivo.FocusedRowHandle);

            idPesajeSelected = celdasSelected.Field<string>("IDPESAJE").Trim();
            materialSelected = celdasSelected.Field<string>("MATNR").Trim();
            descMaterialSelected = celdasSelected.Field<string>("MAKT").Trim();
            conductorSelected = celdasSelected.Field<string>("TEXT1").Trim();
            meins= celdasSelected.Field<string>("MEINS").Trim(); // und medida
            lfimg = celdasSelected.Field<string>("LFIMG").Trim(); //unidades 
            ump = celdasSelected.Field<string>("UMP").Trim();
            tiqueteSelected = celdasSelected.Field<string>("tiquete_bascula").Trim();
            centroLog = celdasSelected.Field<string>("WERKS").Trim(); //centro logístico
            charg = celdasSelected.Field<string>("CHARG").Trim();  //lote 
            netoSelected = celdasSelected.Field<decimal>("peso_neto");
            

            string sql = $"SELECT * FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {idPesajeSelected} AND estado ='P' ";
            var dt = Datos.ObtenerDataTable(sql);

            if(dt.Rows.Count != 0)
            {
               XtraMessageBox.Show("SE DEBE COMPLETAR EL PROCESO <b>PENDIENTE</b> PARA REALIZAR LA CONFIRMACIÓN.","ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable inventario = metodosIntegracion.CargarSaldos(centroLog,charg, materialSelected);

            if(inventario.Rows.Count == 0 )
            {
                XtraMessageBox.Show($"NO SE ENCONTRÓ INVENTARIO PARA EL MATERIAL {materialSelected} - {descMaterialSelected} \r\nDEL CENTRO LOGÍSTICO {centroLog}.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar si existe inventario
            //string  saldoInv = inventario.Rows[0]["LABST"].ToString();
            decimal saldoMaterialInv = decimal.Parse(inventario.Rows[0]["LABST"].ToString());

           

            if (netoSelected <= saldoMaterialInv)
            {
                //Retornar datos de captura reales a SAP.
               object result =  metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, lfimg, netoSelected.ToString().Trim());
               
                if(result.ToString() == "0")
                {

                    LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                    LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                    var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);

                    XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CargueListadosPesajes();

                }

            }
            else
            {

                 XtraMessageBox.Show($"EL MATERIAL {materialSelected} - {descMaterialSelected}, ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string porcentajeTolerancia = "SELECT PORCENTAJE_EXCESO FROM [BASCULAS_SAP].[dbo].[PARAMETROS_GENERALES]";
                DataTable res_dt = Datos.ObtenerDataTable(porcentajeTolerancia);
                decimal paramExeceso = decimal.Parse(res_dt.Rows[0]["porcentaje_exceso"].ToString());

                validarExceso = saldoMaterialInv + (saldoMaterialInv * (paramExeceso/100));

                if (validarExceso >= netoSelected)
                {
                    DataTable ajusteInv = metodosIntegracion.AjustarInventario(centroLog, lgort, materialSelected, charg, lfimg, meins, netoSelected.ToString(), ump);

                }
                else
                {

                }





            }

        }




        //DOBLE CILC PARA EL DETALLE DE LA FILA SELECCIONADA LISTADO EN PROCESO.
        private void gvVista_ListadoActivo_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            DataRow dr = view.GetDataRow(info.RowHandle);

            try
            {
                frm_DetalleSelectedRow frmDetalle = new frm_DetalleSelectedRow(dr[0].ToString(),"2")
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                frmDetalle.ShowDialog(Owner);
                frmDetalle.Dispose();


            }
            catch (Exception)
            {

                throw;
            }




        }

        //DOBLE CLICK DETALLE FILA SELECCIONADA LISTADO ACTIVO
        private void grv_VistaFiltrado_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            DataRow dr = view.GetDataRow(info.RowHandle);

            try
            {
                frm_DetalleSelectedRow frmDetalle = new frm_DetalleSelectedRow(dr[0].ToString(),"1")
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
                string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["status_ser"]).Trim();

                //if (status == "00")
                //{
                //    e.Appearance.BackColor = Color.Yellow;
                //    e.Appearance.BackColor2 = Color.SeaShell;
                //}
                //if (status == "A")
                //{
                //    e.Appearance.BackColor = Color.Yellow;
                //    e.Appearance.BackColor2 = Color.SeaShell;
                //}


                if (state == "")
                {
                    e.Appearance.BackColor = Color.LightGoldenrodYellow;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                if (state == "A")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
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
                    e.HighPriority = true;
                }
                //else if (state == "C")
                //{
                //    e.Appearance.BackColor = Color.LightGreen;
                //    e.Appearance.BackColor2 = Color.SeaShell;
                //    e.HighPriority = true;

                //}
            }


        }

     
        //estilo filas grid seleccionados activos.
        private void grv_VistaFiltrado_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            string state = View.GetRowCellDisplayText(e.RowHandle, View.Columns["estado"]).Trim();
            if (state == "A")
            {
                e.Appearance.BackColor = Color.YellowGreen;
                e.Appearance.BackColor2 = Color.SeaShell;
            }
        }


     
        //CONSULTAR PLACA
        private void btnConsultarPlaca_Click(object sender, EventArgs e)
        {
            frm_Filtrar_placa filtrarPlaca = new frm_Filtrar_placa();
            filtrarPlaca.ShowDialog();
            RecargarGridListadoPesajes();
            filtrarPlaca.Dispose();


        }

      


        private void btnEndForm_Click(object sender, EventArgs e)
        {
            //frmCaptura.Dispose();
            this.Close();
            this.Dispose();
            
        }


        private void time_live_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm tt");
            //lbl_segundos.Text = DateTime.Now.ToString("ss");
            lbl_date.Text= DateTime.Now.ToString("dd MMMM yyyy");
            lbl_Day.Text = DateTime.Now.ToString("dddd");
        }

        private void frmVista_PesajesActivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = "DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            Datos.GetEscalar(sql);
        }

     
        private void frmVista_PesajesActivos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string sql = "  DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            //Datos.GetEscalar(sql);
            //frmCaptura.Dispose();
            //frmCaptura.Close();
            //ppal.Dispose();
            this.Dispose();
            this.Close();

        }

        private void AbrirFormulario(string titulo, Form formulario)
        {

            Form child = default;
            foreach (Form f in MdiChildren)
            {
                if (f.Name == formulario.Name)
                {
                    child = f;
                    break;
                }
            }

            if (child is null)
            {
                child = formulario;
                child.Text = titulo;
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                child.Activate();
            }

        }

        private void btn_CapManual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Administracion_pesaje frm_Administracion_Pesaje = new frm_Administracion_pesaje();
            frm_Administracion_Pesaje.Show(Owner);
        }

   
        private void btn_AbrirReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Report_ProcesosCerrados frm_reporte = new frm_Report_ProcesosCerrados();
            frm_reporte.Show(Owner);
        }



        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            custom.ShowDialog(Owner);
           
        }





    }




  
}

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
using Pry_Basculas_SAP.Impresion;
using DevExpress.XtraReports.UI;
using Pry_Basculas_SAP.Reportes;
using System.Reflection;


namespace Pry_Basculas_SAP
{
    public partial class frmVista_PesajesActivos : XtraForm
    {
        public Version Version { get; }

        frm_Filtrar_placa ppal = new frm_Filtrar_placa();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        UtilitiesSP utilidadesSP = new UtilitiesSP();
        FrmCustom custom = new FrmCustom();
       

        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        RFC_SAP_Interface.rfc_Connector conector = new RFC_SAP_Interface.rfc_Connector();


        Basculas bascula = new Basculas();
        string ambienteSAP = ConfigurationManager.AppSettings["AMBIENTE_SAP"];
        string puertoCOM = ConfigurationManager.AppSettings["PUERTO_COM"];
        string numeroBascula = ConfigurationManager.AppSettings["NUM_BASCULA"];
        string userAd, nombreUser, numberBascula, descBascula, perfilUsuario;
        //DataTable dataFromSAP;
        //DataTable filterTableSAP;


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


            //bascula.GetBascula_byIP(ipBascula);

        }

        public void ConfirmacionCaptura(string confirma)
        {
            if (confirma == "ok")
                RecargarGridListadoPesajes();
            else
                return;

        }

        public string UsuarioSeleccionado(string usuario)
        {


            if (usuario != "")
            {
                userAd = usuario;

            }
            else
            {
                userAd = usuarioAD.GetCurrentUserAD();
            }

           

            return userAd;
        }


        private void Form1_Load(object sender, EventArgs e)

        {
            //conector.DatosCredenciales(ambienteSAP);

            //string sql = "  DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            //Datos.GetEscalar(sql);


            //dataFromSAP = metodosIntegracion.CargarData_PesajesActivos();
            //filterTableSAP = dataFromSAP.AsEnumerable()
            //                   .Where(r => r.Field<string>("STATUS") == "00")
            //                   .CopyToDataTable();

            ////Guardar toda la data para luego ser cruzada con el filtro de la plata
            //utilidadesSP.GuardarData_FromSAP(filterTableSAP);

         

            //UsuarioSeleccionado(userAd);

            Assembly thisAssem = typeof(frmVista_PesajesActivos).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();
            Version ver = thisAssemName.Version;

            lbl_ensamblado.Text = ver.ToString();

            tool_version.Text = ver.ToString();

            if(ambienteSAP == "D")
            {
                tool_mandante.Text = "340";
            }
            else
            {
                tool_mandante.Text = "380";
            }




            List<Parametros> LstParametros = new List<Parametros>();
            userAd = usuarioAD.GetCurrentUserAD();

            //string sql = $"select count(*) from t101_Usuarios where f101_Usuario = ALIAR\\{userAd}   ";
            //LstParametros.Add(new Parametros("@user", "user", SqlDbType.VarChar));
            //LstParametros.Add(new Parametros("@numBascula", "0005", SqlDbType.Int));
            LstParametros.Add(new Parametros("@user", userAd.ToLower().Trim(), SqlDbType.VarChar));
            LstParametros.Add(new Parametros("@numBascula", numeroBascula, SqlDbType.VarChar));
            var dt = Datos.SPObtenerDataTable("SP_GetPermisos_UserAD", LstParametros);


            if (dt.Rows.Count != 0)
            {
                string acceso_total = dt.Rows[0]["ACCESO"].ToString();

                if (acceso_total == "DIRECTOR DE LOGISTICA" || acceso_total == "SUPERVISOR TIPO B" || acceso_total == "DESARROLLADOR")
                {
                    nombreUser = "USUARIO SUPERVISOR";
                    descBascula = "SUPERVISOR BÁSCULA";
                    perfilUsuario = acceso_total;
                    //nombreUser = dt.Rows[0]["nombre_usuario"].ToString();
                    //numberBascula = "";

                    lblGetUsuario.Text = nombreUser;
                    //lblGetBascula.Text = string.Concat(numberBascula, "-", descBascula);
                    lblGetBascula.Text =  descBascula;
                    lblGetPerfil.Text = perfilUsuario;
                    CargueListadosPesajes();
                    RecargarGridListadoPesajes();
                }
                else
                {
                    nombreUser = dt.Rows[0]["nombre_usuario"].ToString();
                    descBascula = dt.Rows[0]["descripcion"].ToString();
                    numberBascula = dt.Rows[0]["num_bascula"].ToString();
                    perfilUsuario = dt.Rows[0]["descripcion_perfil"].ToString();

                    lblGetUsuario.Text = nombreUser;
                    lblGetBascula.Text = string.Concat(numberBascula, "-", descBascula);
                    lblGetPerfil.Text = perfilUsuario;
                    CargueListadosPesajes();
                    RecargarGridListadoPesajes();
                }

            }
            else
            {
                XtraMessageBox.Show("Error: USUARIO NO AUTORIZADO PARA ESTA BÁSCULA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConsultarPlaca.Enabled = false;
                btn_ChangeTrans.Enabled = false;
                barSubItem1.Enabled = false;

            }
        }

        //cargar listados en proceso
        public void CargueListadosPesajes()
        {

            List<Parametros> LstParametros = new List<Parametros>();
            LstParametros.Add(new Parametros("@numBascula", numeroBascula, SqlDbType.VarChar));
            DataTable dt = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes",LstParametros);

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
            List<Parametros> LstParametros = new List<Parametros>();
            LstParametros.Add(new Parametros("@numBascula", numeroBascula, SqlDbType.VarChar));
            DataTable dtRefresh = Datos.SPObtenerDataTable("SP_Cargue_DetalleSeleccionado_Pesajes",LstParametros);
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



        //iniciar proceso captura desde registros activos.
        private void repositoryItemButton_IniciarProceso_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Captura_PesoBasculas frmCaptura = new frm_Captura_PesoBasculas();
            ArrayList rows = new ArrayList();
            string idPesaje;
            string cantidadUmb;
            string cantidadUmp;
            string undUmb;
            string undUmp;
            string numBascula;
            string tipoProceso;
            string descProceso;
            string CodMaterial;
            string Material;
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
                numBascula = row.Field<string>("BASCULA");
                descProceso = row.Field<string>("proceso");
                tipoProceso = row.Field<string>("TPROCESO");
                tipoPesaje = row.Field<string>("TPESAJE");
                CodMaterial = row.Field<string>("MATNR");
                Material = row.Field<string>("MAKT");
                placaVehiculo = row.Field<string>("ADD01").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);
                frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numBascula, tipoProceso, tipoPesaje, descProceso, CodMaterial, Material, placaVehiculo, undUmb, undUmp, row);

            }

            rows.Clear();

            frmCaptura.StartPosition = FormStartPosition.CenterScreen;
            frmCaptura.ShowDialog();
            CargueListadosPesajes();
            RecargarGridListadoPesajes();

            frmCaptura.Dispose();



        }


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
            string numBascula;
            string tipoProceso;
            string descProceso;
            string CodMaterial;
            string Material;
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
                numBascula = row.Field<string>("BASCULA");
                descProceso = row.Field<string>("proceso");
                tipoProceso = row.Field<string>("TPROCESO");
                CodMaterial = row.Field<string>("MATNR");
                Material = row.Field<string>("MAKT");
                tipoPesaje = row.Field<string>("TPESAJE");
                placaVehiculo = row.Field<string>("ADD01").Trim();

                //new frm_Captua_PesoBasculas(idPesaje, cantidadUmb, cantidadUmp, numBascula, placaVehiculo);
                frmCaptura.MostrarDatos_Formulario(idPesaje, cantidadUmb, cantidadUmp, numBascula, tipoProceso, tipoPesaje, descProceso, CodMaterial, Material, placaVehiculo, undUmb, undUmp, row);

            }

            rows.Clear();


            frmCaptura.StartPosition = FormStartPosition.CenterScreen;
            frmCaptura.ShowDialog();
            CargueListadosPesajes();
            //frmCaptura.Dispose();


        }


        //confirmar proceso terminado, validar inventario y/o ajuste.
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
            string pikmg;
            string charg;
            string lgort = "";
            string tipoProcesoSelected;
            string tipoPesajeSelected;
            decimal netoSelected;
            decimal validarExceso = 0;
            decimal saldoMaterialInv = 0;
            decimal saldoMat_InvCwmLabst = 0;
            DataRow celdasSelected = gvVista_ListadoActivo.GetDataRow(gvVista_ListadoActivo.FocusedRowHandle);

            idPesajeSelected = celdasSelected.Field<string>("IDPESAJE").Trim();
            materialSelected = celdasSelected.Field<string>("MATNR").Trim();
            descMaterialSelected = celdasSelected.Field<string>("MAKT").Trim();
            conductorSelected = celdasSelected.Field<string>("TEXT1").Trim();
            meins = celdasSelected.Field<string>("MEINS").Trim(); // und medida LFIMG
            lfimg = celdasSelected.Field<string>("LFIMG").Trim(); // valor solicitado LFIMG
            pikmg = celdasSelected.Field<string>("PIKMG").Trim(); //valor solicitado PIKMG
            ump = celdasSelected.Field<string>("UMP").Trim(); //und medida ump
            netoSelected = celdasSelected.Field<decimal>("peso_neto");// peso real a enviar
            tiqueteSelected = celdasSelected.Field<string>("tiquete_bascula").Trim();
            centroLog = celdasSelected.Field<string>("WERKS").Trim(); //centro logístico
            charg = celdasSelected.Field<string>("CHARG").Trim();  //lote 
            tipoPesajeSelected = celdasSelected.Field<string>("TPESAJE");
            tipoProcesoSelected = celdasSelected.Field<string>("TPROCESO");


            string sql = $"SELECT * FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {idPesajeSelected} AND estado ='P' ";
            var dt = Datos.ObtenerDataTable(sql);

            if (dt.Rows.Count != 0)
            {
                XtraMessageBox.Show("SE DEBE COMPLETAR EL PROCESO PENDIENTE PARA REALIZAR LA CONFIRMACIÓN.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            #region material de KG a Lt
            //si el material  es en litros LT, para convertir los KG a LT

            if (materialSelected == "000000000000250298")
            {
                int valRetorno = 0;
                DataTable result = new DataTable();

                decimal valorDividir = 1.032M;

                decimal cantLitros = (netoSelected / valorDividir);
                string cantLitros_st = cantLitros.ToString("F3");

                //Retornar datos de captura reales a SAP.
                (valRetorno, result) = metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, cantLitros_st, "0");

                if (valRetorno == 0)
                {
                    if (result.Rows.Count > 1 || result != null)
                    {
                        string actualiza_Kg_Lt = $"UPDATE [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] SET [kilogramos_a_litros] ={cantLitros}  WHERE id_pesaje = {idPesajeSelected}";
                        var resUpdtate = Datos.GetEscalar(actualiza_Kg_Lt);


                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@VALOR_EXCESO", 0, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@DOC_AJUSTE", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                        var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);

                        //XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. ¿DESEA REALIZAR LA IMPRESIÓN DEL TIQUETE?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            if (tipoProcesoSelected == "TR" && tipoPesajeSelected == "01")
                            {
                                AgregarCLDestino(idPesajeSelected);

                            }


                            var reporte = new XtraReport_EtiquetaBascula();
                            reporte.Parameters["id_pesaje"].Value = idPesajeSelected;
                            reporte.RequestParameters = false;
                            var pt = new ReportPrintTool(reporte);
                            pt.AutoShowParametersPanel = false;
                            pt.ShowPreviewDialog();

                        }
                        string msgRes_dt;
                        msgRes_dt = result.Rows[0]["MESSAGE"].ToString();
                        XtraMessageBox.Show($"{msgRes_dt}", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@MENSAJE", msgRes_dt, SqlDbType.VarChar));
                        var enviarResp = Datos.SPGetEscalar("SP_Guardar_log_ErroresRetorno", LstParametros);

                    }
                    else
                    {
                        string actualiza_Kg_Lt = $"UPDATE [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] SET [kilogramos_a_litros] ={cantLitros}  WHERE id_pesaje = {idPesajeSelected}";
                        var resUpdtate = Datos.GetEscalar(actualiza_Kg_Lt);


                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@VALOR_EXCESO", 0, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@DOC_AJUSTE", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                        var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);

                        //XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. ¿DESEA REALIZAR LA IMPRESIÓN DEL TIQUETE?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            if (tipoProcesoSelected == "TR" && tipoPesajeSelected == "01")
                            {
                                AgregarCLDestino(idPesajeSelected);

                            }


                            var reporte = new XtraReport_EtiquetaBascula();
                            reporte.Parameters["id_pesaje"].Value = idPesajeSelected;
                            reporte.RequestParameters = false;
                            var pt = new ReportPrintTool(reporte);
                            pt.AutoShowParametersPanel = false;
                            pt.ShowPreviewDialog();

                        }
                    }


                }
                else
                {
                    string msgError;
                    msgError = result.Rows[0]["MESSAGE"].ToString();
                    XtraMessageBox.Show($"Se produjo un error en el retorno de datos SAP: {msgError}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MENSAJE", msgError, SqlDbType.VarChar));
                    var enviarError = Datos.SPGetEscalar("SP_Guardar_log_ErroresRetorno", LstParametros);
                    LstParametros.Clear();
                }

                CargueListadosPesajes();
                return;
            }

            #endregion





            #region 

            //CONSULTAR EL INVENTARIO DEL MATERIAL
            DataTable inventario = metodosIntegracion.CargarSaldos(centroLog, charg, materialSelected);

            if (inventario.Rows.Count == 0)
            {
                XtraMessageBox.Show($"NO SE ENCONTRÓ INVENTARIO PARA EL MATERIAL {materialSelected} - {descMaterialSelected} \r\nDEL CENTRO LOGÍSTICO {centroLog}.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar si existe inventario
            //string  saldoInv = inventario.Rows[0]["LABST"].ToString();
            //decimal netoPesado = decimal.Parse(netoSelected);
            decimal netoPesado = netoSelected;

            /***Si maneja doble unidad de medida.**/
            if (lfimg != "0,000" && meins != "" && pikmg != "0,000" && ump != "")
            {
                //saldoMat_InvCwmLabst = decimal.Parse(inventario.Rows[0]["/CWM/LABST"].ToString());
                saldoMaterialInv = decimal.Parse(inventario.Rows[0]["/CWM/LABST"].ToString());

            }
            else
            {
                saldoMaterialInv = decimal.Parse(inventario.Rows[0]["LABST"].ToString());

            }



            if (netoPesado <= saldoMaterialInv)
            {
                int valRetorno = 0;
                DataTable result = new DataTable();
                //Retornar datos de captura reales a SAP.

                if (lfimg != "0,000" && meins != "" && pikmg != "0,000" && ump != "")
                {                                                            //idpesaje      //tiqueteBascula  umb     ump
                    (valRetorno, result) = metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, lfimg, netoSelected.ToString().Trim());
                }
                else
                {                                                            //idpesaje      //tiqueteBascula  //cant Pesada Real en umb     //cant Pesada Real en ump
                    (valRetorno, result) = metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, netoSelected.ToString().Trim(), "0");

                }


                if (valRetorno == 0)
                {
                    if (result.Rows.Count > 1 || result != null)
                    {

                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@VALOR_EXCESO", 0, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@DOC_AJUSTE", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                        var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);


                        //XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. ¿DESEA REALIZAR LA IMPRESIÓN DEL TIQUETE?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            if (tipoProcesoSelected == "TR" && tipoPesajeSelected == "01")
                            {
                                AgregarCLDestino(idPesajeSelected);

                            }

                            var reporte = new XtraReport_EtiquetaBascula();
                            reporte.Parameters["id_pesaje"].Value = idPesajeSelected;
                            reporte.RequestParameters = false;
                            var pt = new ReportPrintTool(reporte);
                            pt.AutoShowParametersPanel = false;
                            pt.ShowPreviewDialog();

                        }


                        string msgRes_dt;
                        msgRes_dt = result.Rows[0]["MESSAGE"].ToString();
                        XtraMessageBox.Show($"{msgRes_dt}", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@MENSAJE", msgRes_dt, SqlDbType.VarChar));
                        var enviarResp = Datos.SPGetEscalar("SP_Guardar_log_ErroresRetorno", LstParametros);
                    }
                    else
                    {
                        LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@VALOR_EXCESO", 0, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@DOC_AJUSTE", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                        var sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);


                        //XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. ¿DESEA REALIZAR LA IMPRESIÓN DEL TIQUETE?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            if (tipoProcesoSelected == "TR" && tipoPesajeSelected == "01")
                            {
                                AgregarCLDestino(idPesajeSelected);

                            }

                            var reporte = new XtraReport_EtiquetaBascula();
                            reporte.Parameters["id_pesaje"].Value = idPesajeSelected;
                            reporte.RequestParameters = false;
                            var pt = new ReportPrintTool(reporte);
                            pt.AutoShowParametersPanel = false;
                            pt.ShowPreviewDialog();

                        }

                    }

                }
                else
                {
                    string msgError;
                    msgError = result.Rows[0]["MESSAGE"].ToString();
                    XtraMessageBox.Show($"Se produjo un error en el retorno de datos SAP: {msgError}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MENSAJE", msgError, SqlDbType.VarChar));
                    var enviarError = Datos.SPGetEscalar("SP_Guardar_log_ErroresRetorno", LstParametros);
                }
                LstParametros.Clear();
                CargueListadosPesajes();


            }
            else
            {
                /***si no cumple, se debe verificar si el porcentaje de tolerancia es suficiente, si es así, se procede al ajuste de inv.**/

                string porcentajeTolerancia = "SELECT PORCENTAJE_EXCESO FROM [BASCULAS_SAP].[dbo].[PARAMETROS_GENERALES]";
                DataTable res_dt = Datos.ObtenerDataTable(porcentajeTolerancia);
                decimal paramExeceso = decimal.Parse(res_dt.Rows[0]["porcentaje_exceso"].ToString());

                validarExceso = saldoMaterialInv + (saldoMaterialInv * (paramExeceso / 100));

                if (validarExceso >= netoPesado)
                {
                    if (XtraMessageBox.Show("SE CUMPLE CON EL PORCENTAJE DE EXCESO,SE PROCEDE A REALIZAR EL AJUSTE DE INVENTARIO.", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        string docAjuste = "";
                        DataTable ajusteInv = metodosIntegracion.AjustarInventario(centroLog, lgort, materialSelected, charg, lfimg, meins, netoPesado.ToString(), ump);
                        if (ajusteInv.Rows.Count > 0)
                        {

                            docAjuste = (ajusteInv.Rows[0]["MBLNR"] == DBNull.Value) ? "" : ajusteInv.Rows[0]["MBLNR"].ToString();



                            //Retornar datos de captura reales a SAP.
                            int valRetorno = 0;
                            DataTable result = new DataTable();


                            if (lfimg != "0,000" && meins != "" && pikmg != "0,000" && ump != "")
                            {                                                            //idpesaje      //tiqueteBascula  umb     ump
                                (valRetorno, result) = metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, lfimg, netoSelected.ToString().Trim());
                            }
                            else
                            {                                                            //idpesaje      //tiqueteBascula  //cant Pesada Real en umb     //cant Pesada Real en ump
                                (valRetorno, result) = metodosIntegracion.RetornarDatos(idPesajeSelected, tiqueteSelected, netoSelected.ToString().Trim(), "0");

                            }


                            if (valRetorno == 0)
                            {

                                LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@TIQUETE_BASCULA", tiqueteSelected, SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@CONDUCTOR", conductorSelected, SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@PESO_NETO", netoSelected, SqlDbType.Decimal));
                                LstParametros.Add(new Parametros("@VALOR_EXCESO", 0, SqlDbType.Decimal));
                                LstParametros.Add(new Parametros("@USUARIO_CONFIRMA", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@DOC_AJUSTE", docAjuste, SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@CONFIRMADO_SAP", "OK", SqlDbType.VarChar));

                                var _sendData = Datos.SPGetEscalar("SP_Confirmar_Pesajes", LstParametros);

                                //XtraMessageBox.Show("CONFIRMACIÓN CORRECTA.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                if (XtraMessageBox.Show("CONFIRMACIÓN CORRECTA. ¿DESEA REALIZAR LA IMPRESIÓN DEL TIQUETE?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
                                {

                                    if (tipoProcesoSelected == "TR" && tipoPesajeSelected == "01")
                                    {
                                        AgregarCLDestino(idPesajeSelected);
                                       
                                    }


                                    var reporte = new XtraReport_EtiquetaBascula();
                                    reporte.Parameters["id_pesaje"].Value = idPesajeSelected;
                                    reporte.RequestParameters = false;
                                    var pt = new ReportPrintTool(reporte);
                                    pt.AutoShowParametersPanel = false;
                                    pt.ShowPreviewDialog();

                                }

                            }
                            else
                            {
                                string msgError;
                                msgError = result.Rows[0]["MESSAGE"].ToString();
                                XtraMessageBox.Show($"Se produjo un error en el retorno de datos SAP: {msgError}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                LstParametros.Add(new Parametros("@ID_PESAJE", idPesajeSelected, SqlDbType.VarChar));
                                LstParametros.Add(new Parametros("@MENSAJE", msgError, SqlDbType.VarChar));
                                var enviarError = Datos.SPGetEscalar("SP_Guardar_log_ErroresRetorno", LstParametros);
                            }
                            LstParametros.Clear();
                            CargueListadosPesajes();
                            return;


                        }
                        else
                        {
                            string resultadoAjuste = "";
                            resultadoAjuste = (ajusteInv.Rows[0]["MESSAGE"] == DBNull.Value) ? "" : ajusteInv.Rows[0]["MESSAGE"].ToString();
                            XtraMessageBox.Show($"Se produjo un error con la función de ajuste SAP: {resultadoAjuste}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CargueListadosPesajes();
                            return;
                        }

                    }
                    else
                    {
                        return;
                    }



                }
                else
                {
                    XtraMessageBox.Show($"EL MATERIAL {materialSelected} - {descMaterialSelected}, \r\nCON PESO NETO {netoSelected},\r\r\nNO CUMPLE CON EL PORCENTAJE DE EXCESO {validarExceso}\r \r\n DEBE REVISAR INVENTARIO DEL MATERIAL.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //no se hace nada 


                    CargueListadosPesajes();
                }



            }
            #endregion

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
                frm_DetalleSelectedRow frmDetalle = new frm_DetalleSelectedRow(dr[0].ToString(), "2")
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
                frm_DetalleSelectedRow frmDetalle = new frm_DetalleSelectedRow(dr[0].ToString(), "1")
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


        //personalización filas grid seleccionados activos.
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



        private void frmVista_PesajesActivos_FormClosing(object sender, FormClosingEventArgs e)
        {

            //if (XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

            string sql = "DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            Datos.GetEscalar(sql);

        }




        //salir del formulario
        private void btn_GetOut_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de salir de la aplicación?\n \r\nAl salir, perderá el listado de procesos activos\r\ny deberá volver a buscar la placa del vehículo. ", "INFORMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Close();

            }
        }



        //abrir listado de procesos para imprimir tiquete
        private void btn_AbrirReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Report_ProcesosCerrados frm_reporte = new frm_Report_ProcesosCerrados();
            frm_reporte.Show(Owner);
        }


        //abrir reporte de procesos cerrados.
        private void btn_AbrirCerrados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Report_Reportes_cerrados frm_repCerrados = new frm_Report_Reportes_cerrados();
            frm_repCerrados.Show(Owner);
          
        }



        private void btn_CapManual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frm_Administracion_pesaje frm_Administracion_Pesaje = new frm_Administracion_pesaje();
            //frm_Administracion_Pesaje.Show(Owner);
            frm_Test_CapturaBascula test = new frm_Test_CapturaBascula();
            test.Show(Owner);

        }

      
        //Mostrar información de los tipos de estados.
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            custom.ShowDialog(Owner);

        }

        //llamar formulario para cambio de usuario
        private void btn_cambiarUsr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_CambiarUsuario_Aplicacion usrChance = new frm_CambiarUsuario_Aplicacion();
            usrChance.ShowDialog(Owner);
            // UsuarioSeleccionado(userAd);
            //this.Close();
        }


        /***llamar formulario para agregar CL de destino.**/
        private void AgregarCLDestino(string idPesaje)
        {
            frm_Seleccionar_CLDestino clDestinos = new frm_Seleccionar_CLDestino(idPesaje);

            clDestinos.ShowDialog(Owner);
            clDestinos.Dispose();

        }


        /**cambiar transportista**/
        private void btn_ChangeTrans_Click(object sender, EventArgs e)
        {
            frm_Cambiar_transportista transpor = new frm_Cambiar_transportista();
            transpor.ShowDialog(Owner);
            CargueListadosPesajes();
            transpor.Dispose();
        }

        //RELOJ
        private void time_live_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm tt");
            //lbl_segundos.Text = DateTime.Now.ToString("ss");
            lbl_date.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lbl_Day.Text = DateTime.Now.ToString("dddd");
        }



    }





}

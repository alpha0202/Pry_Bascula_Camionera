using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Pry_Basculas_SAP.Class;
using IntegracionSAP_Dll;
using System.Text.RegularExpressions;
using System.Collections;
using CapaDatos;
using DevExpress.XtraGrid.Views.Grid;

namespace Pry_Basculas_SAP
{
    public partial class frm_Filtrar_placa : XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        string          id_pesaje;
        string          tipo_proceso;
        string          tipo_pesaje;
        string          fecha_proceso;
        string          doc_comercial;
        string          doc_compra;
        string          doc_transporte;
        string          Ent_salida_sap;
        string          material_sap;
        string          desc_material;
        string          posicion;
        string          placa_cabezote;
        string          plac_trailer;
        string          fecha_carga;
        string          conductor;
        string          transportista;
        string          centro_logistico;
        string          num_bascula;
        string          cantidad_umb;
        string          umb;
        string          cantidad_ump;
        string          ump;
        string          lote_sap;
        string          ztq_basc;
        string          cant_real_umb;
        string          cant_real_ump;
        string          doc_material;
        string          estado_consumo_servicio;
        private string  placaCabezote;



        public frm_Filtrar_placa()
        {
            InitializeComponent();
        }

       

        public void BuscarPlantillaActiva(string placa)
        {
            List<Parametros> LstParametros = new List<Parametros>();
            var placaValida = Utilities.ValidarPlaca_Cabezote(placa);

            if (string.IsNullOrEmpty(placaValida))
            {
                txtPlacaCabezote.Text = "";
                return;
            }


            DataTable dataFiltrada = metodosIntegracion.FiltrarData_PlacaCabezote(placaValida);
         
            
            if(dataFiltrada.Rows.Count == 0)
            {
                XtraMessageBox.Show($"NO SE ENCONTRARON REGISTROS ASOCIADOS A LA PLACA {placaValida}.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlacaCabezote.Text = "";
                return;

            }

            try
            {

                DataTable filterTable = dataFiltrada.AsEnumerable()
                                     .Where(r => r.Field<string>("STATUS") == "00")
                                     .OrderByDescending(o => o.Field<string>("FPROCESO"))
                                     .CopyToDataTable();
                
                if(filterTable.Rows.Count != 0)
                {
                    CargarGridFiltroPlaca(filterTable);
                    txtPlacaCabezote.Text = "";
                }
                else
                {
                    txtPlacaCabezote.Text = "";
                    throw new Exception($"NO EXISTEN REGISTROS ACTIVOS PARA LA PLACA {placaValida}");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ATENCIÓN");
                txtPlacaCabezote.Text = "";
                return;
            }




        }

        public  void CargarGridFiltroPlaca(DataTable dt)
        {
            grd_ControlBusquedaPlaca.DataSource = dt;
            grd_ViewBusquedaPlaca.OptionsView.ColumnAutoWidth = false;
            grd_ControlBusquedaPlaca.ForceInitialize();
            grd_ViewBusquedaPlaca.BestFitColumns();
           
        }



        public void btn_BuscarData_Click(object sender, EventArgs e)
        {
            placaCabezote = txtPlacaCabezote.Text;
            BuscarPlantillaActiva(placaCabezote);
        }

        private void btn_EnvSeleccionados_Click(object sender, EventArgs e)
        {
            frmVista_PesajesActivos frmListadosActivos = new frmVista_PesajesActivos();
            List<Parametros> LstParametros = new List<Parametros>();
            ArrayList rowsSelected = new ArrayList();
            object sendData = null;
            string respuesta = (string)sendData;


            // Add the selected rows to the list.
            Int32[] selectedRowHandles = grd_ViewBusquedaPlaca.GetSelectedRows();
          

            if (selectedRowHandles == null || selectedRowHandles.Count() == 0)
            {
                XtraMessageBox.Show($"Debe seleccionar al menos un registro.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                
                    rowsSelected.Add(grd_ViewBusquedaPlaca.GetDataRow(selectedRowHandle));

                     
                    DataRow dataRow = rowsSelected[i] as DataRow;
                    //frmListadosActivos.RecibeDatosFiltrados(dataRow);

                    id_pesaje               = dataRow.Field<string>("IDPESAJE");
                    tipo_proceso            = dataRow.Field<string>("TPROCESO");
                    tipo_pesaje             = dataRow.Field<string>("TPESAJE");
                    fecha_proceso           = dataRow.Field<string>("FPROCESO");
                    doc_comercial           = dataRow.Field<string>("VBELN");
                    doc_compra              = dataRow.Field<string>("EBELN");
                    doc_transporte          = dataRow.Field<string>("TKNUM");
                    Ent_salida_sap          = dataRow.Field<string>("VBELN2");
                    material_sap            = dataRow.Field<string>("MATNR");
                    desc_material           = dataRow.Field<string>("MAKT");
                    posicion                = dataRow.Field<string>("POSNR");
                    placa_cabezote          = dataRow.Field<string>("ADD01");
                    plac_trailer            = dataRow.Field<string>("ADD02");
                    fecha_carga             = dataRow.Field<string>("DPLBG");
                    conductor               = dataRow.Field<string>("TEXT1");
                    transportista           = dataRow.Field<string>("AGENTE");
                    centro_logistico        = dataRow.Field<string>("WERKS");
                    num_bascula             = dataRow.Field<string>("BASCULA");
                    cantidad_umb            = dataRow.Field<string>("LFIMG");
                    umb                     = dataRow.Field<string>("MEINS");
                    cantidad_ump            = dataRow.Field<string>("PIKMG");
                    ump                     = dataRow.Field<string>("UMP");
                    lote_sap                = dataRow.Field<string>("CHARG");
                    ztq_basc                = dataRow.Field<string>("ZTQ_BASC");
                    cant_real_umb           = dataRow.Field<string>("LKIMG_REAL");
                    cant_real_ump           = dataRow.Field<string>("PIKMG_REAL");
                    doc_material            = dataRow.Field<string>("MBLNR");
                    estado_consumo_servicio = dataRow.Field<string>("STATUS");

                    LstParametros.Add(new Parametros("@IDPESAJE",id_pesaje, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@TPROCESO" , tipo_proceso, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@TPESAJE" , tipo_pesaje, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@FPROCESO", fecha_proceso, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@VBELN" , doc_comercial, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@EBELN" , doc_compra, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@TKNUM" , doc_transporte, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@VBELN2", Ent_salida_sap, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MATNR" , material_sap, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MAKT", desc_material, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@POSNR" , posicion, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@ADD01" , placa_cabezote, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@ADD02" , plac_trailer, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@DPLBG" , fecha_carga, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@TEXT1" , conductor, SqlDbType.VarChar));  
                    LstParametros.Add(new Parametros("@AGENTE" , transportista, SqlDbType.VarChar));  
                    LstParametros.Add(new Parametros("@WERKS" , centro_logistico, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@BASCULA" , num_bascula, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@LFIMG" , cantidad_umb, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MEINS" , umb, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@PIKMG" , cantidad_ump, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@UMP" , ump, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@CHARG" , lote_sap, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@ZTQ_BASC" , ztq_basc, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@LKIMG_REAL" , cant_real_umb, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@PIKMG_REAL" , cant_real_ump, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@MBLNR" , doc_material, SqlDbType.VarChar));
                    LstParametros.Add(new Parametros("@STATUS" , estado_consumo_servicio, SqlDbType.VarChar));
                
                    sendData = Datos.SPGetEscalar("SP_Guardar_FilasSeleccionadas", LstParametros);
                if (sendData.ToString() != "OK")
                {
                    XtraMessageBox.Show($"NOTA: {sendData} ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //return;
                }
                LstParametros.Clear();
            }
            if (sendData.ToString() == "OK")
            {
                
                XtraMessageBox.Show($"REGISTROS ENVIADOS.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // frmListadosActivos.RecargarGridListadoPesajes();
                //this.Dispose();
                //this.Close();
                //grd_ViewBusquedaPlaca.ClearSelection();
                //frmListadosActivos.ShowDialog();
                this.Hide();
            }
            else
            {
                
                grd_ViewBusquedaPlaca.ClearSelection();
                return;
            }
           

        }




        private void frm_Filtrar_placa_Load(object sender, EventArgs e)
        {
            //string sql = "DELETE [BASCULAS_SAP].[dbo].[TB_FILTRO_PLACA] ";
            //Datos.GetEscalar(sql);
        }

        private void txtPlacaCabezote_KeyDown(object sender, KeyEventArgs e)
        {
            //If e.KeyCode = Keys.Enter Then


            if(e.KeyCode == Keys.Enter)
            {
                btn_BuscarData.PerformClick();
            }
        }
    }
}
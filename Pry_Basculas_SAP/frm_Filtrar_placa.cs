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

namespace Pry_Basculas_SAP
{
    public partial class frm_Filtrar_placa : XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        public frm_Filtrar_placa()
        {
            InitializeComponent();
        }

       
        private string placaCabezote;

        public void BuscarPlantillaActiva(string placa)
        {
            List<Parametros> LstParametros = new List<Parametros>();
           var placaValida = Utilities.ValidarPlaca_Cabezote(placa);
           
            if (string.IsNullOrEmpty(placaValida))
                return;


            DataTable dataFiltrada = metodosIntegracion.FiltrarData_PlacaCabezote(placaValida);

            DataTable filterTable = dataFiltrada.AsEnumerable()
                                 .Where(r => r.Field<string>("STATUS") == "00")
                                 .CopyToDataTable();

            //LstParametros.Add(new Parametros("@placaCabezote", placaValida, SqlDbType.VarChar));
            //var dt = Datos.SPObtenerDataTable("SP_Buscar_PlantillaActiva_by_PlacaBascula", LstParametros);
            CargarGridFiltroPlaca(filterTable);


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

            ArrayList rowsSelected = new ArrayList();

            // Add the selected rows to the list.
            Int32[] selectedRowHandles = grd_ViewBusquedaPlaca.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rowsSelected.Add(grd_ViewBusquedaPlaca.GetDataRow(selectedRowHandle));
            }
            try
            {
                //grd_ViewBusquedaPlaca.BeginUpdate();
                //for (int i = 0; i < rowsSelected.Count; i++)
                //{
                //    DataRow row = rowsSelected[i] as DataRow;
                //    // Change the field value.
                //    row["Discontinued"] = true;
                //}
            }
            finally
            {
                //grd_ViewBusquedaPlaca.EndUpdate();
            }

        }
    }
}
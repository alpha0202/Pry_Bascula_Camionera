using CapaDatos;
using DevExpress.XtraEditors;
using Pry_Basculas_SAP.Impresion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Pry_Basculas_SAP

{
    public partial class frm_Report_ProcesosCerrados : XtraForm
    {

        private string _filtroDate;

        public frm_Report_ProcesosCerrados()
        {
            InitializeComponent();
        }

        private void frm_Report_ProcesosCerrados_Load(object sender, EventArgs e)
        {
            
            _filtroDate = dtp_dateFilter.Value.ToString("yyyy-MM-dd");


            CargaReporte_ProcesosCerrados(_filtroDate);




            ToolTip dateFilter = new ToolTip();

            dateFilter.ToolTipTitle = "Filtrar por fechas";
            dateFilter.UseFading = true;
            dateFilter.UseAnimation = true;
            dateFilter.IsBalloon = true;
            dateFilter.AutoPopDelay = 5000;
            dateFilter.InitialDelay = 1000;
            dateFilter.ReshowDelay = 400;
            dateFilter.SetToolTip(this.dtp_dateFilter, "Selecciona la fecha para ver los procesos cerrados y listos para imprimir el tiquete de bascula.");

       
        }

        public void CargaReporte_ProcesosCerrados(string filtroDate)
        {
           
            List<Parametros> LstParametros = new List<Parametros>();
            LstParametros.Add(new Parametros("@fechaFiltro", filtroDate, SqlDbType.VarChar));
            DataTable dt = Datos.SPObtenerDataTable("SP_Cargar_Impresión_FormatosBasculas_by_Date",LstParametros);

            try
            {
                grc_ControlProcesosClose.BeginUpdate();
                grc_ControlProcesosClose.DataSource = dt;
                grv_VistaProcesosClose.OptionsView.ColumnAutoWidth = false;
                grc_ControlProcesosClose.ForceInitialize();
                grv_VistaProcesosClose.BestFitColumns();
                grv_VistaProcesosClose.RefreshData();

            }
            finally
            {

                grc_ControlProcesosClose.EndUpdate();
            }

            LstParametros.Clear();
        }

        private void repositoryItemButton_ImprimirFormato_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var reporte = new XtraReport_EtiquetaBascula();
            ArrayList rows = new ArrayList();
            string idPesaje;
            Int32[] selectedRowHandles = grv_VistaProcesosClose.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(grv_VistaProcesosClose.GetDataRow(selectedRowHandle));

                DataRow row = rows[i] as DataRow;

                idPesaje = row.Field<string>("IDPESAJE");

                reporte.Parameters["id_pesaje"].Value = idPesaje;
                reporte.RequestParameters = false;
                var pt = new ReportPrintTool(reporte);
                pt.AutoShowParametersPanel = false;
                pt.ShowPreviewDialog();
            }

            rows.Clear();


        }

    
        //filtrar por día seleccionado
        private void dtp_dateFilter_ValueChanged(object sender, EventArgs e)
        {
            string dateFilter;
            dateFilter = dtp_dateFilter.Value.ToString("yyyy-MM-dd");
            CargaReporte_ProcesosCerrados(dateFilter);
        }

        private void repositoryItemComboBox_Select_CL_Destino_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
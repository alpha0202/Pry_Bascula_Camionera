using CapaDatos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP.Reportes
{
    public partial class frm_Report_Reportes_cerrados : DevExpress.XtraEditors.XtraForm
    {
        public frm_Report_Reportes_cerrados()
        {
            InitializeComponent();
        }
        private void frm_Report_Reportes_cerrados_Load(object sender, EventArgs e)
        {
            Cargar_ReporteProcesosCerrados();
        }


        public void Cargar_ReporteProcesosCerrados()
        {

            DataTable dt = Datos.SPObtenerDataTable("SP_Reporte_ProcesosCerrados");

            try
            {
                grc_ControlReportCerrrado.BeginUpdate();
                grc_ControlReportCerrrado.DataSource = dt;
                grv_VistaReportCerrado.OptionsView.ColumnAutoWidth = false;
                grc_ControlReportCerrrado.ForceInitialize();
                grv_VistaReportCerrado.BestFitColumns();
                grv_VistaReportCerrado.RefreshData();
            }
            finally
            {
                grc_ControlReportCerrrado.EndUpdate();
            }
        }

        private void btn_exportarEx_Click(object sender, EventArgs e)
        {
            string fecha_exporta = DateTime.Now.ToString("dd-MM-yyyy");

            string path = $"Reporte_Pesajes_Cerrados_{fecha_exporta}.xlsx";

            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.SheetName = "Pesajes Cerrados";

            grc_ControlReportCerrrado.ExportToXlsx(path,advOptions);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }
    }
}
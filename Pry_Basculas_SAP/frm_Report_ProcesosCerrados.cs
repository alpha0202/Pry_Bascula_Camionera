using CapaDatos;
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

namespace Pry_Basculas_SAP
{
    public partial class frm_Report_ProcesosCerrados : DevExpress.XtraEditors.XtraForm
    {
        public frm_Report_ProcesosCerrados()
        {
            InitializeComponent();
        }

        private void frm_Report_ProcesosCerrados_Load(object sender, EventArgs e)
        {
            CargaReporte_ProcesosCerrados();
        }

        public void CargaReporte_ProcesosCerrados()
        {


            DataTable dt = Datos.SPObtenerDataTable("SP_Reporte_ProcesosCerrados");

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


        }


    }
}
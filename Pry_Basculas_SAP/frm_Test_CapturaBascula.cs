using DevExpress.XtraEditors;
using Pry_Basculas_SAP.Class;
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
    public partial class frm_Test_CapturaBascula : DevExpress.XtraEditors.XtraForm
    {

        Basculas bascula = new Basculas();
        
        public frm_Test_CapturaBascula()
        {
            InitializeComponent();
        }


        public void Get_DataCatch(string catchData)
        {
            txt_datoCapturado.Text = catchData;
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            //txt_datoCapturado.Text =  bascula.CapturarPeso_PortSerial();
            txt_datoCapturado.Text =  bascula.SacarNumeros("68552,000 kg");
        }
    }
}
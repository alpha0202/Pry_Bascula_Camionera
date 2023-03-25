using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
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
    public partial class frm_Administracion_pesaje : DevExpress.XtraEditors.XtraForm
    {
        public frm_Administracion_pesaje()
        {
            InitializeComponent();
        }

        private void frm_Administracion_pesaje_Load(object sender, EventArgs e)
        {
            LoginUserControl myControl = new LoginUserControl();
            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Autorizar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // do something
            }
        }



       
    }
}
using DevExpress.XtraEditors;
using IntegracionSAP_Dll;
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
    public partial class frm_Cambiar_transportista : DevExpress.XtraEditors.XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        public frm_Cambiar_transportista()
        {
            InitializeComponent();
        }






        private void btn_CambiarTrans_Click(object sender, EventArgs e)
        {
        }

        private void txt_nit_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_nit.Text))
            {
                return;
            }
            else
            {
                try
                {
                    DataTable dtTransportistas = metodosIntegracion.Listar_Transportistas();

                    DataTable filterTable = dtTransportistas.AsEnumerable()
                                         .Where(r => r.Field<string>("SORTL") == txt_nit.Text.Trim())
                                         //.OrderByDescending(o => o.Field<string>("FPROCESO"))
                                         .CopyToDataTable();

                    if(filterTable.Rows.Count !=0)
                    {
                        string paramExeceso = filterTable.Rows[0]["MCOD1"].ToString();
                        txt_NomTrans.Visible = true;
                        txt_NomTrans.Text = paramExeceso;
                    }
                    else
                    {
                        throw new Exception($"NO EXISTEN REGISTRO DEL TRANSPORTISTA CON NIT: {txt_nit.Text}");
                        txt_nit.Text = string.Empty;
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ATENCIÓN");
                }

            }
        }
    }
}
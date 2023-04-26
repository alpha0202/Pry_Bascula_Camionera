using CapaDatos;
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

namespace Pry_Basculas_SAP.Impresion
{
    public partial class frm_Seleccionar_CLDestino : DevExpress.XtraEditors.XtraForm
    {
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();


        private string _idPesaje;
        public frm_Seleccionar_CLDestino(string idpesaje)
        {
            _idPesaje = idpesaje;
            InitializeComponent();

        }

        private DataTable CL_Destinos()
        {
            DataTable dtCl_Destinos = metodosIntegracion.Listar_ClDestinos();

            txt_idPesaje.Text = _idPesaje;
            cbo_destinos.DataSource = dtCl_Destinos;
            cbo_destinos.DisplayMember = "NAME1";
            cbo_destinos.ValueMember = "NAME1";
            lbl_seleccion.Text = cbo_destinos.SelectedItem.ToString();



            return dtCl_Destinos;


        }


        


        private void frm_Seleccionar_CLDestino_Load(object sender, EventArgs e)
        {
            CL_Destinos();
        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"¿CONFIRMAR EL CENTRO LOGISTICO DE DESTINO PARA EL ID PESAJE: {_idPesaje}", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                //[BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS]
                string sql = $"UPDATE set [centroLogistico_destino] = {lbl_seleccion.Text} [BASCULAS_SAP].[dbo].[TB_DATOS_ACTIVOS] WHERE id_pesaje = {_idPesaje} ";
                var respuesta = Datos.GetEscalar(sql);

            }

        }
    }
}
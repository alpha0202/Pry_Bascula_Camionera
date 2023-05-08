using CapaDatos;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP
{
    public partial class frm_CambiarUsuario_Aplicacion : DevExpress.XtraEditors.XtraForm
    {
        frmVista_PesajesActivos ppal = new frmVista_PesajesActivos();
        private string numBascula = ConfigurationManager.AppSettings["NUM_BASCULA"];
        private string userValue;

        public frm_CambiarUsuario_Aplicacion()
        {
            InitializeComponent();
        }


        private DataTable CambiarUsuario_App()
        {

            string sql = $"SELECT  u.[usuario],u.[nombre_usuario],u.[estado],b.num_bascula,b.descripcion FROM [BASCULAS_SAP].[dbo].[USUARIOS] u  inner join [BASCULAS_SAP].[dbo].[BASCULAS] b on u.num_bascula = b.num_bascula where b.num_bascula = '{numBascula}'";
            DataTable dtUsuarios = Datos.ObtenerDataTable(sql);

            cbo_SeleccionarUsuario.Items.Insert(0, "---");
            cbo_SeleccionarUsuario.DataSource = dtUsuarios;
            cbo_SeleccionarUsuario.DisplayMember = "nombre_usuario";
            cbo_SeleccionarUsuario.ValueMember = "usuario";
            lbl_usrSeleccionado.Text = "";
            lbl_NombreBascula.Text = dtUsuarios.Rows[0]["descripcion"].ToString();
            //lbl_usrSeleccionado.Text = cbo_SeleccionarUsuario.SelectedItem.ToString();


            return dtUsuarios;

        }




        private void cbo_SeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            userValue = cbo_SeleccionarUsuario.GetItemText(cbo_SeleccionarUsuario.SelectedValue);
            lbl_usrSeleccionado.Text = userValue;

        }

        private void frm_CambiarUsuario_Aplicacion_Load(object sender, EventArgs e)
        {
            
            CambiarUsuario_App();
        }


        private void UsuarioSeleccionado(string usrSeleccionado)
        {


            ppal.UsuarioSeleccionado(userValue);
           
        }


        private void btn_CambiarUsuario_Click(object sender, EventArgs e)
        {

            UsuarioSeleccionado(userValue);
            //ppal.Close();
            //ppal.ShowDialog(Owner);
            //this.Dispose();
            //this.Hide();
        }
    }
}
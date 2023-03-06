
using CapaDatos;
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
using DevExpress.LookAndFeel;
using System.Windows.Forms;

namespace Pry_Basculas_SAP
{
    public partial class frm_Captua_PesoBasculas : XtraForm
    {
        List<Parametros> LstParametros = new List<Parametros>();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        

        private string _idPesaje;
        private decimal _cantidadUMB;
        private decimal _cantidadUMP;
        private decimal _numeroBascula;
        private string _PlacaCabezote;
        private string _printTicket;
        private string _ConfirmaCaptura;
         

        public frm_Captua_PesoBasculas()
        {
                 
            InitializeComponent();
          
        }


        public void MostrarDatos_Formulario(string id_pesaje, decimal cant_umb, decimal cant_ump, decimal numBascula, string placa)
        {

            _idPesaje = id_pesaje;
            _cantidadUMB = cant_umb;
            _cantidadUMP = cant_ump;
            _numeroBascula = numBascula;
            _PlacaCabezote = placa;

            txtIdPesaje.Text = _idPesaje;
            txtUmb.Text = _cantidadUMB.ToString();
            txtUmp.Text = _cantidadUMP.ToString();
            txtPlaca.Text = _PlacaCabezote;
            txtNumBascula.Text = _numeroBascula.ToString(); ;

        }



        private void btnCapturaPeso_Click(object sender, EventArgs e)
        {
            var peso1Cap = txtPesoCapturado.Text;
            GuardarCaptura_Pesaje(peso1Cap);
            txtPesoCapturado.Text = string.Empty;
            this.Dispose();
            this.Close();
            frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();

            frmListasAct.ShowDialog();


        }


        private void GuardarCaptura_Pesaje(string pesaje)
        {

            object enviarData = "";
            object sendData = "";
            string sql = $"SELECT TOP 1 1 FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje}" ;
            var dt = Datos.ObtenerDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                //traer el consecutivo de la tabla basculas
                LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@tiquete_salida", "", SqlDbType.VarChar, ParameterDirection.Output));
                _printTicket = (string)Datos.SPGetEscalar("SP_ConsecutivoTiquete_Basculas", LstParametros);
                LstParametros.Clear();

                LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@SALIDA_TICKET", _printTicket, SqlDbType.VarChar));

                sendData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);
                LstParametros.Clear();
                
            }
            else
            {

                LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@SALIDA_TICKET", "", SqlDbType.VarChar));

                enviarData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);


                LstParametros.Clear();
               

            }

            if (enviarData == "" || sendData == "")
                _ConfirmaCaptura = "ok";
            frmVista_PesajesActivos frmPesajesAct = new frmVista_PesajesActivos();
           // DataTable dtNew = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");
          
            frmPesajesAct.ConfirmacionCaptura(_ConfirmaCaptura);


        }


        private void VerificarCapturasPesos()
        {
            string sql = $"SELECT [peso1],[peso2],[peso_neto],[estado] FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje} AND [estado] = 'T' ";
            var dt = Datos.ObtenerDataTable(sql);

            if (dt.Rows.Count > 0)
            {
                lblCapt1.Text = dt.Rows[0]["peso1"].ToString();
                lblCapt2.Text = dt.Rows[0]["peso2"].ToString();
                lblPesoNeto.Text = dt.Rows[0]["peso_neto"].ToString();
                btnCapturarPeso.Enabled = false;
                txtPesoCapturado.Enabled = false;
                grbInfoCaptura.BackColor = Color.MediumSeaGreen;

            }    
          

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            frmListasAct.ShowDialog();
            

        }

        private void frm_Captua_PesoBasculas_Load(object sender, EventArgs e)
        {
            VerificarCapturasPesos();
        }

        private void frm_Captua_PesoBasculas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            frmListasAct.ShowDialog();
        }
    }
}
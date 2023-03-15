
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
using static Pry_Basculas_SAP.Class.EnumTipoPesajes;

namespace Pry_Basculas_SAP
{
    public partial class frm_Captura_PesoBasculas : XtraForm
    {
        List<Parametros> LstParametros = new List<Parametros>();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();

        private string _idPesaje;
        private decimal _cantidadUMB;
        private decimal _cantidadUMP;
        private decimal _numeroBascula;
        private string _PlacaCabezote;
        private string _tipoProceso;
        private string _tipoPesaje;
        private string _procesoDetalle;
        private string _printTicket;
        private string _ConfirmaCaptura;
         

        public frm_Captura_PesoBasculas()
        {
            //frmVista_PesajesActivos frmPesajesAct = new frmVista_PesajesActivos();
                 
            InitializeComponent();
          
        }


        public void MostrarDatos_Formulario(string id_pesaje, decimal cant_umb, decimal cant_ump, decimal numBascula, string tipoProc, string tipoPesaje, string procDetalle, string placa)
        {

            _idPesaje = id_pesaje;
            _cantidadUMB = cant_umb;
            _cantidadUMP = cant_ump;
            _numeroBascula = numBascula;
            _tipoProceso = tipoProc;
            _tipoPesaje = tipoPesaje;
            _procesoDetalle = procDetalle;
            _PlacaCabezote = placa;

            txtIdPesaje.Text = _idPesaje;
            txtTipoProceso.Text = _procesoDetalle;
            txtUmb.Text = _cantidadUMB.ToString();
            txtUmp.Text = _cantidadUMP.ToString();
            txtPlaca.Text = _PlacaCabezote;
            txtNumBascula.Text = _numeroBascula.ToString(); ;

        }



        private void btnCapturaPeso_Click(object sender, EventArgs e)
        {
            var peso1Cap = txtPesoCapturado.Text;
            if (string.IsNullOrWhiteSpace(peso1Cap))
            {
                XtraMessageBox.Show($"Debe establecer el valor de pesaje. ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
                GuardarCaptura_Pesaje(peso1Cap);
                txtPesoCapturado.Text = string.Empty;
                this.Dispose();
                this.Hide();
                frmListasAct.ShowDialog();
                frmListasAct.Dispose();

            }


        }


        private void GuardarCaptura_Pesaje(string pesaje)
        {
            frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            object enviarData = "";
            object sendData = "";
            decimal pesajeUno = 0 ;

            string sql = $"SELECT * FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje}" ;
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
                pesajeUno = decimal.Parse(dt.Rows[0]["peso1"].ToString());

                if (_tipoProceso == "VN" && _tipoPesaje == "01")
                { if (pesajeUno < decimal.Parse(pesaje))
                    {
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@SALIDA_TICKET", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));

                        enviarData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);
                        LstParametros.Clear();

                    }
                    else
                    {
                        XtraMessageBox.Show($"El primer pesaje SUPERA la segunda captura\r\ndel proceso {_idPesaje} - {_procesoDetalle}.\r\nSe debe verificar los pesajes para esta operación. ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (_tipoProceso == "TR" && _tipoPesaje == "01")
                {
                    if (pesajeUno < decimal.Parse(pesaje))
                    {
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@SALIDA_TICKET", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));

                        enviarData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);
                        LstParametros.Clear();
                    }
                    else
                    {
                        XtraMessageBox.Show($"El primer pesaje SUPERA la segunda captura\r\ndel proceso {_idPesaje} - {_procesoDetalle}.\r\nSe debe verificar los pesajes para esta operación. ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                }
                else if(_tipoProceso == "TR" && _tipoPesaje == "02")
                {
                    if(pesajeUno> decimal.Parse(pesaje))
                    {
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                        LstParametros.Add(new Parametros("@SALIDA_TICKET", "", SqlDbType.VarChar));
                        LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));

                        enviarData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);
                        LstParametros.Clear();
                    }
                    else
                    {
                        XtraMessageBox.Show($"El primer pesaje es INFERIOR a la segunda captura\r\ndel proceso {_idPesaje} - {_procesoDetalle}.\r\nSe debe verificar los pesajes para esta operación. ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }


                }


            }

            if (enviarData == "" || sendData == "")
                _ConfirmaCaptura = "ok";

            // DataTable dtNew = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");

            frmListasAct.ConfirmacionCaptura(_ConfirmaCaptura);
           


        }


        private void VerificarCapturasPesos()
        {
            string estadoProc;
            string sql = $"SELECT [peso1],[peso2],[peso_neto],[estado] FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje}"; //AND[estado] = 'Y'
            DataTable dt = Datos.ObtenerDataTable(sql);


            if (dt.Rows.Count > 0)
            {
                estadoProc = dt.Rows[0]["estado"].ToString().Trim();
                if (estadoProc == "P")
                {
                    lblCapt1.Text = dt.Rows[0]["peso1"].ToString();
                }
                else
                {

                    lblCapt1.Text = dt.Rows[0]["peso1"].ToString();
                    lblCapt2.Text = dt.Rows[0]["peso2"].ToString();
                    lblPesoNeto.Text = dt.Rows[0]["peso_neto"].ToString();
                    btnCapturarPeso.Enabled = false;
                    txtPesoCapturado.Enabled = false;
                    grbInfoCaptura.BackColor = Color.MediumSeaGreen;

                    XtraMessageBox.Show($"OPERACIÓN DE CAPTURA CULMINADA, PENDIENTE POR CONFIRMACIÓN. \r\nPoceso {_idPesaje} - {_procesoDetalle} ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }


        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            //frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            //frmPesajesAct.ShowDialog();
            //frmPesajesAct.Dispose();
            

        }

        private void frm_Captua_PesoBasculas_Load(object sender, EventArgs e)
        {
            VerificarCapturasPesos();
        }

        private void frm_Captua_PesoBasculas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
           //frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            //frmPesajesAct.ShowDialog();
            //frmPesajesAct.Dispose();
        }
    }
}
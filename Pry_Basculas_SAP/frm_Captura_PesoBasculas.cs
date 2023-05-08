
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
using IntegracionSAP_Dll;
using System.Configuration;

namespace Pry_Basculas_SAP
{
    public partial class frm_Captura_PesoBasculas : XtraForm
    {
        List<Parametros> LstParametros = new List<Parametros>();
        UserActiveDirectory usuarioAD = new UserActiveDirectory();
        UtilitiesSP utilidadesSP = new UtilitiesSP();
        MetodosIntegracion metodosIntegracion = new MetodosIntegracion();
        Basculas bascula = new Basculas();
        string tipoCapturas = ConfigurationManager.AppSettings["TIPO_CAPTURAS"];


        private string _idPesaje;
        private string _cantidadUMB;
        private string _cantidadUMP;
        private string _undUMB;
        private string _undUMP;
        private string _numeroBascula;
        private string _PlacaCabezote;
        private string _tipoProceso;
        private string _tipoPesaje;
        private string _codMaterial;
        private string _Material;
        private string _procesoDetalle;
        private string _printTicket;
        private string _ConfirmaCaptura;
        private DataRow _dataRow;
         

        public frm_Captura_PesoBasculas()
        {
            
                 
            InitializeComponent();
          
        }


        public void MostrarDatos_Formulario(string id_pesaje, string cant_umb, string cant_ump, string numBascula, string tipoProc, string tipoPesaje, string procDetalle, string codMaterial, string material, string placa, string undUMB, string undUMP, DataRow row)
        {

            _idPesaje = id_pesaje;
            _cantidadUMB = cant_umb.Trim();
            _cantidadUMP = cant_ump.Trim();
            _undUMB = undUMB;
            _undUMP = undUMP;
            _numeroBascula = numBascula.Trim();
            _tipoProceso = tipoProc;
            _tipoPesaje = tipoPesaje;
            _procesoDetalle = procDetalle;
            _codMaterial = codMaterial;
            _Material = material;
            _PlacaCabezote = placa;
            _dataRow = row;


            txtIdPesaje.Text = _idPesaje;
            txtTipoProceso.Text = _procesoDetalle;
            txtMaterial.Text = _Material.Trim();
            txtUmb.Text = _cantidadUMB.ToString().Trim();
            txt_undUMB.Text = _undUMB.Trim();
            txt_undUMP.Text = _undUMP.Trim();
            txtUmp.Text = _cantidadUMP.ToString().Trim();
            txtPlaca.Text = _PlacaCabezote.Trim();
            txtNumBascula.Text = _numeroBascula.ToString(); ;

        }

        private void ModoCapturas(string tipoCaptura)
        {
            switch (tipoCaptura)
            {
                case "A":
                    ///***Captura por puerto COM****/
                    txtPesoCapturado.Text = bascula.CapturarPeso_PortSerial();
                   
                    break;
                default:
                    txtPesoCapturado.Enabled = true;
                    txtPesoCapturado.BackColor = Color.White;
                    btnCapturarPeso.Enabled = false;
                    
                    break;
            }
        }

        private void btnCapturaPeso_Click(object sender, EventArgs e)
        {
            ModoCapturas(tipoCapturas);
            //txtPesoCapturado.Enabled = false;
            //txtPesoCapturado.BackColor = Color.White;
            //btnCapturarPeso.Enabled = false;

            ///***Captura por puerto COM****/
            //txtPesoCapturado.Text = bascula.CapturarPeso_PortSerial();




        }


        private void GuardarCaptura_Pesaje(string pesaje)
        {
            frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
            object enviarData = "";
            object sendData = "";
            decimal pesajeUno = 0 ;

            string sql = $"SELECT * FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje}" ;
            var dt = Datos.ObtenerDataTable(sql);

            //Confirma si es el primer pesaje, buscando resultados anteriores a travez del id pesaje
            if (dt.Rows.Count == 0)
            {
                //traer el consecutivo de la tabla basculas
                LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@tiquete_salida", "", SqlDbType.VarChar, ParameterDirection.Output));
                _printTicket = (string)Datos.SPGetEscalar("SP_ConsecutivoTiquete_Basculas", LstParametros);
                LstParametros.Clear();

                LstParametros.Add(new Parametros("@ID_PESAJE", _idPesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMB", _cantidadUMB, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@CANT_PESADA_UMP", _cantidadUMP, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@USUARIO_PESAJE", usuarioAD.GetCurrentUserAD(), SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PESO_CAPTURADO", pesaje, SqlDbType.Decimal));
                LstParametros.Add(new Parametros("@SALIDA_TICKET", _printTicket, SqlDbType.VarChar));

                sendData = Datos.SPGetEscalar("SP_Guardar_CapturaPesajes", LstParametros);

                XtraMessageBox.Show($"mensaje {sendData}");

                DataTable respuestaGet = metodosIntegracion.Cambiar_estadoConsumo(_idPesaje);

                //retorna el status =  01 a SAP para validar su consumo en los listados.
                //DataTable resRetorno = metodosIntegracion.RetornarDatos(_idPesaje,"01", _cantidadUMB, "0,000");

                LstParametros.Clear();
            }
            else
            {
                pesajeUno = decimal.Parse(dt.Rows[0]["peso1"].ToString());

                if (_tipoProceso == "VN" && _tipoPesaje == "01")
                { if (pesajeUno < decimal.Parse(pesaje))
                    {
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.VarChar));
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
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.VarChar));
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
                        LstParametros.Add(new Parametros("@NUM_BASCULA", _numeroBascula, SqlDbType.VarChar));
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
            {
                _ConfirmaCaptura = "ok";
                frmListasAct.ConfirmacionCaptura(_ConfirmaCaptura);
                utilidadesSP.GuardarData_Capturada(_dataRow);
               


            }

            // DataTable dtNew = Datos.SPObtenerDataTable("SP_Cargue_PlaneacionesPesajes");

           


        }


        private void VerificarCapturasPesos()
        {
            string estadoProc;
            string sql = $"SELECT [peso1],[peso2],[peso_neto],[tara],[peso_bruto],[estado] FROM [BASCULAS_SAP].[dbo].[CAPTURA_PESAJES] WHERE id_pesaje = {_idPesaje}"; //AND[estado] = 'Y'
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
                    lblTara.Text = dt.Rows[0]["tara"].ToString();
                    lblPesoBruto.Text = dt.Rows[0]["peso_bruto"].ToString();
                    lblPesoNeto.Text = dt.Rows[0]["peso_neto"].ToString();
                    btnCapturarPeso.Enabled = false;
                    txtPesoCapturado.Enabled = false;
                    btn_guardarCaptura.Enabled = false;
                    grbInfoCaptura.BackColor = Color.MediumSeaGreen;

                    XtraMessageBox.Show($"OPERACIÓN DE CAPTURA CULMINADA, PENDIENTE POR CONFIRMACIÓN.\n \r\nProceso {_idPesaje} - {_procesoDetalle} ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

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
            btnCapturarPeso.Enabled = true;
            
            VerificarCapturasPesos();


            if(tipoCapturas == "A")
            {
                tool_ModoCaptura.Text = "Automático";
            }
            else
            {
                tool_ModoCaptura.Text = "Manual";
            }

            ///***Captura por puerto COM****/
            //txtPesoCapturado.Text = bascula.CapturarPeso_PortSerial();
        }


        private void btn_guardarCaptura_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Está seguro de guardar la captura del pesaje?", "CONFIRMACIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, (DevExpress.Utils.DefaultBoolean)MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                var peso1Cap = txtPesoCapturado.Text;
                if (string.IsNullOrWhiteSpace(peso1Cap))
                {
                    XtraMessageBox.Show($"SE DEBE ESTABLER EL PESO A CAPTURAR. ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
                    GuardarCaptura_Pesaje(peso1Cap);
                    txtPesoCapturado.Text = string.Empty;
                    //this.Dispose();
                    this.Hide();
                    //frmListasAct.ShowDialog();
                    //frmListasAct.Dispose();

                }


            }
            else
            {
                txtPesoCapturado.Enabled = false;
                txtPesoCapturado.Text = string.Empty;
                btnCapturarPeso.BackColor = Color.DeepSkyBlue;
            }
        }
    }
        //private void frm_Captua_PesoBasculas_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.Hide();
        //   //frmVista_PesajesActivos frmListasAct = new frmVista_PesajesActivos();
        //    //frmPesajesAct.ShowDialog();
        //    //frmPesajesAct.Dispose();
        //}
}
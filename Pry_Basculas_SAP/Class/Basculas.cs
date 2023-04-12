using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using System.Data;
using System.Threading;
using System.Web.UI.DataVisualization.Charting;
using Microsoft.VisualBasic;
using CompareMethod = Microsoft.VisualBasic.CompareMethod;
using CapaDatos;
using System.Configuration;

namespace Pry_Basculas_SAP.Class
{
    class Basculas
    {
        private string Ip;
        private string Puerto;
        private string TipoBascula;
        private string Estado;
        private int NroPesos;
        private decimal Tolerancia;
        private decimal Tiempo;
        private decimal ToleranciaMerma;
        private string DescripcionBascula;
        private decimal NumBascula;
        private string Prefijo;
        private decimal Consecutivo;
        public SerialPort mySerialPort = new SerialPort();

        public decimal _ToleranciaMerma
        {
            get
            {
                return ToleranciaMerma;
            }
            set
            {
                ToleranciaMerma = value;
            }
        }

        public decimal _Tiempo
        {
            get
            {
                return Tiempo;
            }
            set
            {
                Tiempo = value;
            }
        }



        public decimal _Tolerancia
        {
            get
            {
                return Tolerancia;
            }
            set
            {
                Tolerancia = value;
            }
        }


        public int _nroPesos
        {
            get
            {
                return NroPesos;
            }
            set
            {
                NroPesos = value;
            }
        }


        public string _Estado
        {
            get
            {
                return Estado;
            }
            set
            {
                Estado = value;
            }
        }

        public string _TipoBascula
        {
            get
            {
                return TipoBascula;
            }
            set
            {
                TipoBascula = value;
            }
        }

        public string _Puerto
        {
            get
            {
                return Puerto;
            }
            set
            {
                Puerto = value;
            }
        }

        public string _Ip
        {
            get
            {
                return Ip;
            }
            set
            {
                Ip = value;
            }
        }

        public string _DescripcionBascula
        {
            get
            {
                return DescripcionBascula;
            }
            set
            {
                DescripcionBascula = value;
            }
        }


        public decimal _NumBascula
        {
            get
            {
                return NumBascula;
            }
            set
            {
                NumBascula = value;
            }
        }


        public string _Prefijo
        {
            get
            {
                return Prefijo;
            }
            set
            {
                Prefijo = value;
            }
        }


        public decimal _Consecutivo
        {
            get
            {
                return Consecutivo;
            }
            set
            {
                Consecutivo = value;
            }
        }



        public string CapturarPeso(decimal RowIdBascula)
        {
            var bascula = new Basculas();
            SerialPort mySerialPort;
            try
            {

                bascula = GetBascula(RowIdBascula);
                if (bascula.Estado != "A")
                {
                    throw new ArgumentException("Estado de bascula diferente de activo");
                    return default;
                }
                if (bascula.TipoBascula == "1")
                {
                    var listPesos = new List<decimal>();
                    decimal pesoPromedio = 0m;
                    int cont = 1;

                    while (cont <= bascula.NroPesos)
                    {
                        Thread.Sleep((int)bascula.Tiempo);

                        var tcpClient = new TcpClient();
                        NetworkStream networkStream;
                        // Dim sendBytes As [Byte]()
                        string lSt_Caracter;
                        string lSt_Valor = "";
                        // If tcpClient.Connected Then
                        // tcpClient.Close()
                        // End If

                        tcpClient.Connect(bascula._Ip, int.Parse(bascula._Puerto));
                        networkStream = tcpClient.GetStream();
                        // sendBytes = System.Text.Encoding.ASCII.GetBytes("%z")
                        // sendBytes = System.Text.Encoding.ASCII.GetBytes("%p")
                        // networkStream.Write(sendBytes, 0, sendBytes.Length)
                        // Read the NetworkStream into a byte buffer.
                        var bytes = new byte[tcpClient.ReceiveBufferSize + 1];
                        networkStream.Read(bytes, 0, tcpClient.ReceiveBufferSize);
                        // Output the data received from the host to the console.
                        string lSt_Sarta = "";
                        lSt_Sarta = Encoding.ASCII.GetString(bytes);

                        // ----------------------------ESTE ES EL CODIGO NUEVO----------------------------'
                        int lIn_Pos;
                        lIn_Pos = lIn_Pos = Strings.InStr(lSt_Sarta, "Net", CompareMethod.Text);
                        lSt_Sarta = Strings.Mid(lSt_Sarta, 1, lIn_Pos);
                        //c# equivalente
                        lSt_Sarta =lSt_Sarta.Substring(1, lIn_Pos);

                        // ----------------------------ESTE ES EL CODIGO NUEVO----------------------------'
                        lSt_Sarta = Strings.Replace(Strings.Trim(lSt_Sarta), ",", ".");
                        
                        //c# equivalente 
                        lSt_Sarta = lSt_Sarta.Trim().Replace(",", ".");

                        // 'VALIDAR QUE LA BASCULA NO TENGA TARA
                        // lIn_Pos = 0
                        // lIn_Pos = InStr(lSt_Sarta, "Tare", CompareMethod.Text)
                        // If CDbl(Mid(lSt_Sarta, lIn_Pos + 4, 9)) <> 0 Then
                        // Throw New ArgumentException("Existe Una Tara")
                        // End If


                        // tcpClient.Close()
                        for (int i = lSt_Sarta.Length; i >= 1; i -= 1)
                        {
                            lSt_Caracter = "";
                            lSt_Caracter = Strings.Mid(lSt_Sarta, i, 1);
                            //c# equivalente 
                            lSt_Caracter = lSt_Sarta.Substring(i, 1);

                            // lSt_Caracter = Replace(lSt_Caracter, ",", ".")
                            if (!string.IsNullOrEmpty(lSt_Valor.Trim()) & string.IsNullOrEmpty(lSt_Caracter.Trim()))
                                break;
                            if (Information.IsNumeric(lSt_Caracter) | lSt_Caracter == ".")
                            {
                                // If IsNumeric(lSt_Caracter) Then
                                lSt_Valor = lSt_Caracter + lSt_Valor;
                            }
                        }

                        if (Information.IsNumeric(lSt_Valor))
                        {
                            listPesos.Add(decimal.Parse(lSt_Valor));
                            pesoPromedio = pesoPromedio + decimal.Parse(lSt_Valor);
                            cont = cont + 1;
                        }



                    }

                    pesoPromedio = pesoPromedio / bascula.NroPesos;

                    foreach (decimal peso in listPesos)
                    {
                        if (Math.Abs(peso - pesoPromedio) > bascula.Tolerancia)
                        {
                            throw new ArgumentException("bascula no estabilizada");
                            return default;
                        }

                    }



                    return pesoPromedio.ToString();
                }

                else if (bascula.TipoBascula == "2")
                {
                    var listPesos = new List<decimal>();
                    decimal pesoPromedio = 0m;
                    int cont = 1;
                    string lSt_Estable = "";

                    while (cont <= bascula.NroPesos)
                    {
                        string lSt_Sarta = "";
                        string lSt_Caracter;
                        string lSt_Valor = "";

                        string lSt_Sarta2 = "";
                        int lBy_Lecturas = 1;
                        bool lBo_Sarta = false;
                        mySerialPort = new SerialPort("COM23", 9600, Parity.None, 8, StopBits.One);
                        mySerialPort.Open();
                        Thread.Sleep(500);
                        mySerialPort.Write("%p");
                        Thread.Sleep(800);

                        lSt_Sarta = mySerialPort.ReadExisting();
                        // If Not IsNumeric(Len(lSt_Sarta)) Or Len(lSt_Sarta) < 3 Then
                        // 'Throw New ArgumentException("peso no valido")
                        // MsgBox("peso no valido")
                        // Exit Function
                        // End If

                        // lSt_Estable = Mid(lSt_Sarta, Len(lSt_Sarta) - 2, 1)

                        // If Not (lSt_Estable = " " Or lSt_Estable = "S") Then
                        // 'Throw New ArgumentException("bascula no estabilizada")
                        // MsgBox("bascula no estabilizada")
                        // Exit Function
                        // End If

                        for (int i = 1, loopTo = Strings.Len(lSt_Sarta); i <= loopTo; i++)
                        {
                            lSt_Caracter = "";
                            lSt_Caracter = Strings.Mid(lSt_Sarta, i, 1);
                            if (!string.IsNullOrEmpty(Strings.Trim(lSt_Valor)) & string.IsNullOrEmpty(Strings.Trim(lSt_Caracter)))
                                break;
                            if (Information.IsNumeric(lSt_Caracter) | lSt_Caracter == ".")
                            {
                                // If IsNumeric(lSt_Caracter) Then
                                lSt_Valor = lSt_Valor + lSt_Caracter;
                            }
                        }

                        mySerialPort.Close();

                        if (Information.IsNumeric(lSt_Valor))
                        {
                            listPesos.Add(decimal.Parse(lSt_Valor));
                            pesoPromedio = pesoPromedio + decimal.Parse(lSt_Valor);
                            cont = cont + 1;


                            // lSt_Estable = Mid(lSt_Sarta, Len(lSt_Sarta) - 2, 1)

                            // If Not (lSt_Estable = " " Or lSt_Estable = "S") Then
                            // Throw New ArgumentException("bascula no estabilizada")
                            // 'MsgBox("bascula no estabilizada")
                            // Exit Function
                            // End If


                            if (lSt_Sarta.Contains("M"))
                            {
                                throw new ArgumentException("bascula no estabilizada");
                                // MsgBox("bascula no estabilizada")
                                return default;
                            }

                        }
                    }

                    pesoPromedio = pesoPromedio / bascula.NroPesos;

                    foreach (decimal peso in listPesos)
                    {
                        if (Math.Abs(peso - pesoPromedio) > bascula.Tolerancia)
                        {
                            throw new ArgumentException("bascula no estabilizada");
                            return default;
                        }

                    }

                    return pesoPromedio.ToString();
                }

                else if (bascula.TipoBascula == "3")
                {

                    var listPesos = new List<decimal>();
                    decimal pesoPromedio = 0m;
                    int cont = 1;
                    string lSt_Estable = "";
                    while (cont <= bascula.NroPesos)
                    {

                        var tcpClient = new TcpClient();
                        NetworkStream networkStream;
                        byte[] sendBytes;
                        string lSt_Sarta = "";
                        string lSt_Caracter;
                        string lSt_Valor = "";
                        int lIn_Pos = 0;

                        tcpClient.Connect(bascula._Ip, int.Parse(bascula._Puerto));
                        networkStream = tcpClient.GetStream();
                        sendBytes = Encoding.ASCII.GetBytes("p");
                        Thread.Sleep(500);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        var bytes = new byte[tcpClient.ReceiveBufferSize + 1];
                        networkStream.Read(bytes, 0, tcpClient.ReceiveBufferSize);

                        lSt_Sarta = "";
                        lSt_Sarta = Encoding.ASCII.GetString(bytes);

                        for (int i = 1, loopTo1 = Strings.Len(lSt_Sarta); i <= loopTo1; i++)
                        {
                            lSt_Caracter = "";
                            lSt_Caracter = Strings.Mid(lSt_Sarta, i, 1);
                            if (!string.IsNullOrEmpty(Strings.Trim(lSt_Valor)) & string.IsNullOrEmpty(Strings.Trim(lSt_Caracter)))
                                break;
                            if (Information.IsNumeric(lSt_Caracter) | lSt_Caracter == ".")
                            {
                                // If IsNumeric(lSt_Caracter) Then
                                lSt_Valor = lSt_Valor + lSt_Caracter;
                            }
                        }

                        if (Information.IsNumeric(lSt_Valor))
                        {
                            listPesos.Add(decimal.Parse(lSt_Valor));
                            pesoPromedio = pesoPromedio + decimal.Parse(lSt_Valor);
                            cont = cont + 1;

                            if (lSt_Sarta.Contains("M"))
                            {
                                throw new ArgumentException("bascula no estabilizada");
                                // MsgBox("bascula no estabilizada")
                                return default;
                            }

                        }

                        // Dim captura As String = Mid(lSt_Sarta, 1, 8)

                        // If IsNumeric(captura) Then
                        // listPesos.Add(captura)
                        // pesoPromedio = pesoPromedio + CDec(captura)
                        // cont = cont + 1
                        // 'lSt_Estable = Mid(lSt_Sarta, Len(lSt_Sarta) - 2, 1)
                        // 'If Not (lSt_Estable = " " Or lSt_Estable = "S") Then
                        // '    Throw New ArgumentException("bascula no estabilizada")
                        // '    'MsgBox("bascula no estabilizada")
                        // '    Exit Function
                        // 'End If

                        // End If
                    }

                    pesoPromedio = pesoPromedio / bascula.NroPesos;

                    foreach (decimal peso in listPesos)
                    {
                        if (Math.Abs(peso - pesoPromedio) > bascula.Tolerancia)
                        {
                            throw new ArgumentException("bascula no estabilizada");
                            return default;
                        }

                    }

                    return pesoPromedio.ToString();
                }

                else
                {
                    // si no se encontro el tipo de bascula
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
                mySerialPort.Close();
            }

        }

        public void CapturarPeso_PortSerial()
        {
            string lSt_Sarta = "";
            string lSt_Sarta2 = "";
            int lBy_Lecturas = 1;
            bool lBo_Sarta = false;
            string lSt_Caracter = "";
            string lSt_Valor = "";
            int lIn_PosPunto = 0;
            string puertoCOM = ConfigurationManager.AppSettings["COM"].ToString();

            //si el llamado se hace por IP
            /****  string IP = ConfigurationManager.AppSettings["IP"].ToString();
                   string PUERTO = ConfigurationManager.AppSettings["PUERTO"].ToString();
                   var tcpClient = new TcpClient();
                   NetworkStream networkStream;
                   tcpClient.Connect(IP, int.Parse(PUERTO));
                   networkStream = tcpClient.GetStream();
                   var bytes = new byte[tcpClient.ReceiveBufferSize + 1];
                   networkStream.Read(bytes, 0, tcpClient.ReceiveBufferSize);
                   lSt_Sarta = Encoding.ASCII.GetString(bytes);  *****/



            //llamado por puerto serial
            mySerialPort = new SerialPort(puertoCOM, 9600, Parity.None, 8, StopBits.One);

           // mySerialPort.Close();


            mySerialPort.Open();


            Thread.Sleep(500);
            mySerialPort.Write("%p");
            Thread.Sleep(500);

            lSt_Sarta = mySerialPort.ReadExisting();

            if (lSt_Sarta.Length >= 16)
            {
                //lSt_Sarta = Strings.Mid(lSt_Sarta, 1, 16);
                //c# equivalente
                lSt_Sarta = lSt_Sarta.Substring(1, 16);
            }



            //recorrido de la sarta para sacar la parte numérica del dato completo.
            for (int i = 1, loopTo = lSt_Sarta.Length; i <= loopTo; i++)
            {
                //lSt_Caracter = Strings.Mid(lSt_Sarta, i, 1);
                lSt_Caracter = lSt_Sarta.Substring(i, 1);
                if (!string.IsNullOrEmpty(lSt_Valor.Trim()) && string.IsNullOrEmpty(lSt_Caracter.Trim()))
                    break;
                if (EsNumero(lSt_Caracter) || lSt_Caracter == ".")
                {
                    
                    lSt_Valor = lSt_Valor + lSt_Caracter;
                }

                //if (Information.IsNumeric(lSt_Caracter) || lSt_Caracter == ".")
                //{
                //    // If IsNumeric(lSt_Caracter) Then
                //    lSt_Valor = lSt_Valor + lSt_Caracter;
                //}
            }

            mySerialPort.Close();


        }

        
        public Basculas GetBascula(decimal numBascula)
        {
            Basculas bascula = new Basculas();
           // var conexion = new clsConexionNew();
         
            var dt = Datos.ObtenerDataTable("select * from BASCULAS WHERE num_bascula = " + numBascula.ToString());
            DataRow dr = dt.Rows[0];
            bascula._NumBascula = decimal.Parse(dr["num_bascula"].ToString());
            bascula._Ip = dr["ip_bascula"].ToString();
            bascula._DescripcionBascula = dr["descripcion"].ToString();
            bascula._Prefijo = dr["prefijo"].ToString();
            bascula._Consecutivo = decimal.Parse(dr["consecutivo"].ToString());
            return bascula;
        }  
       


        public Basculas GetBascula_byIP(string Ip)
        {
            Basculas basculaIp = new Basculas();

            List<Parametros> LstParametros = new List<Parametros>();
            LstParametros.Add(new Parametros("@IP_bascula", Ip, SqlDbType.VarChar));
            var dt = Datos.SPObtenerDataTable("SP_Get_Bascula_byIp",LstParametros);
            DataRow dr = dt.Rows[0] ;

            basculaIp._NumBascula = decimal.Parse(dr["num_bascula"].ToString());
            basculaIp._Ip = dr["ip_bascula"].ToString();
            basculaIp._DescripcionBascula = dr["descripcion"].ToString();
            basculaIp._Prefijo = dr["prefijo"].ToString();
            basculaIp._Consecutivo = decimal.Parse(dr["consecutivo"].ToString());

            return basculaIp;
        }


        //public DataTable GetListBasculas(string co)
        //{
        //    string sql = " select f106_RowID,f106_Descripcion from t106_BasculasPorCO where f106_CO = '" + co + "'";
        //    DataTable dt = Datos.ObtenerDataTable(sql);
        //    return dt;
        //}

        public static bool EsNumero(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

    }
}

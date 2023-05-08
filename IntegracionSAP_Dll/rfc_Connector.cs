using CapaData;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RFC_SAP_Interface
{
    public class rfc_Connector : IDestinationConfiguration
    {
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;
        private string _ambiente;

        //public string Ambiente
        //{
        //    get { return this._ambiente; }
        //    set { this._ambiente = ConfigurationManager.AppSettings["NUM_BASCULA"]; ; }
        //}

        public bool ChangeEventsSupported()
        {
            return false;
        }

        //DataTable credenciales = new DataTable();
        //string AppServerHost, systemNumber, systemId, usuario, password, client, SAPRouter;


        //public string DatosCredenciales( string ambiente)
        //{
        //    _ambiente = ambiente;
        //    //string sql = $"SELECT [ambiente],[AppServerHost],[systemNumber],[systemId],[usuario],[password],[client],[SAPRouter] FROM [BASCULAS_SAP].[dbo].[TB_PARAMETROS_SAP_CONNECTOR] WHERE ambiente = '{ambiente}'";
        //    //credenciales = Datos.ObtenerDataTable(sql);

        //    //AppServerHost = credenciales.Rows[0]["AppServerHost"].ToString().Trim();
        //    //systemNumber = credenciales.Rows[0]["systemNumber"].ToString().Trim();
        //    //systemId = credenciales.Rows[0]["systemId"].ToString().Trim();
        //    //usuario = credenciales.Rows[0]["usuario"].ToString().Trim();
        //    //password = credenciales.Rows[0]["password"].ToString().Trim();
        //    //client = credenciales.Rows[0]["client"].ToString().Trim();
        //    //SAPRouter = credenciales.Rows[0]["SAPRouter"].ToString().Trim();

        //    return _ambiente;
        //}

       

        public RfcConfigParameters GetParameters(string destinationName)
        {
            if ("SE37".Equals(destinationName))
            {             
                RfcConfigParameters parms = new RfcConfigParameters();
                _ambiente = ConfigurationManager.AppSettings["AMBIENTE_SAP"];
                if (_ambiente == "D")
                {
                    parms.Add(RfcConfigParameters.AppServerHost, "10.253.2.27");
                    parms.Add(RfcConfigParameters.SystemNumber, "00");
                    parms.Add(RfcConfigParameters.SystemID, "A4D");
                    parms.Add(RfcConfigParameters.User, "INTEGRADOR");
                    parms.Add(RfcConfigParameters.Password, "Inicio.2023$");
                    parms.Add(RfcConfigParameters.Client, "340");
                    parms.Add(RfcConfigParameters.SAPRouter, "/H/179.50.79.116");
                    parms.Add(RfcConfigParameters.Language, "ES");
                    parms.Add(RfcConfigParameters.Name, "SE37");
                    parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600");
                    parms.Add(RfcConfigParameters.PoolSize, "10");
                    parms.Add(RfcConfigParameters.MessageServerHost, "10.253.2.27");
                    return parms;

                }
                else
                {

                    parms.Add(RfcConfigParameters.AppServerHost, "10.253.2.31");
                    parms.Add(RfcConfigParameters.SystemNumber, "00");
                    parms.Add(RfcConfigParameters.SystemID, "A4P");
                    parms.Add(RfcConfigParameters.User, "INTEGRADOR");
                    parms.Add(RfcConfigParameters.Password, "Inicio.2023$");
                    parms.Add(RfcConfigParameters.Client, "380");
                    parms.Add(RfcConfigParameters.SAPRouter, "/H/179.50.79.116");
                    parms.Add(RfcConfigParameters.Language, "ES");
                    parms.Add(RfcConfigParameters.Name, "SE37");
                    parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600");
                    parms.Add(RfcConfigParameters.PoolSize, "10");
                    parms.Add(RfcConfigParameters.MessageServerHost, "10.253.2.31");
                    return parms;
                }

            }
            

            else
            {
                
                return null;
            }
        }




    }
}

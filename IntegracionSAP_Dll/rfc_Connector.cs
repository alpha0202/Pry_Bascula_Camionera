using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RFC_SAP_Interface
{
    public class rfc_Connector : IDestinationConfiguration
    {
        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public bool ChangeEventsSupported()
        {
            return false;
        }

        public RfcConfigParameters GetParameters(string destinationName)
        {
            if ("SE37".Equals(destinationName))
            {

                RfcConfigParameters parms = new RfcConfigParameters();
                parms.Add(RfcConfigParameters.AppServerHost, "10.253.2.27");
                parms.Add(RfcConfigParameters.SystemNumber, "00");
                parms.Add(RfcConfigParameters.SystemID, "A4D");
                parms.Add(RfcConfigParameters.User, "INTEGRADOR");
                parms.Add(RfcConfigParameters.Password, "Inicio.2023$");
                parms.Add(RfcConfigParameters.Client, "330");
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
                return null;
            }
        }
    }
}

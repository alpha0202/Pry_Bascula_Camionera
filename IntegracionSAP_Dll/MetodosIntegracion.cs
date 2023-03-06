using RFC_SAP_Interface;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;

namespace IntegracionSAP_Dll
{
    class MetodosIntegracion
    {
        DataTable resultDt1 = new DataTable();
        DataTable resultDt2 = new DataTable();


        public MetodosIntegracion(DataTable dt1, DataTable dt2)
        {
            (dt1, dt2) = readdata();


            string sql = "  DELETE [INTERFACES_SAP].[dbo].[ENCABEZADO_PROVEEDORES] ";
            Datos.GetEscalar(sql);

            foreach (DataRow dr in dt1.Rows)
            {
                sql = "INSERT INTO[dbo].[ENCABEZADO_PROVEEDORES]" +
                                "([NUMERO_PAGO]" +
                                ",[DOCUMENTO_SAP_PAGO]" +
                                ",[NIT_PROVEERDOR]" +
                                ",[NOMBRE_PROVEERDOR]" +
                                ",[NRO_CTA_BANC_PROV]" +
                                ",[COD_BANCO_PROV]" +
                                ",[VAL_PAGADO_INTERNA_SAP])" +
                     " VALUES " +
                           "( '" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "','" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "' )";

                Datos.GetEscalar(sql);

            }


            sql = "  DELETE [INTERFACES_SAP].[dbo].[DETALLE_PROVEEDORES]";
            Datos.GetEscalar(sql);

            foreach (DataRow dr in dt2.Rows)
            {
                sql = "INSERT INTO[dbo].[DETALLE_PROVEEDORES]" +
                                 "([NUMERO_PAGO]" +
                                 ",[DOCUMENTO_SAP_PAGO]" +
                                 ",[NRO_FACTURA_PROV]" +
                                 ",[DESC_RET_APLICADA]" +
                                 ",[CIUDAD_ICA]" +
                                 ",[PORC_APLICADO_RET]" +
                                 ",[VALOR_RETENCION])" +
                     " VALUES " +
                           "( '" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "','" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "' )";

                Datos.GetEscalar(sql);

            }


        }





        static (DataTable, DataTable) readdata()
        {


            RfcDestinationManager.RegisterDestinationConfiguration(new rfc_Connector());
            RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
            RfcRepository repo = prd.Repository;
            IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_PAGOSPRV");

            soBapi.SetValue("P_BURKS", "1000");
            soBapi.SetValue("P_DATE", "20230118");
            //soBapi.SetValue("P_MONTH", "11");
            soBapi.Invoke(prd);
            IRfcTable IT_HEADER = soBapi.GetTable("IT_HEADER");
            IRfcTable IT_ITEM = soBapi.GetTable("IT_ITEM");

            //IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("BAPI_MATERIAL_GET_ALL");
            //getDataSAP.SetValue("MATERIAL", "100002");
            //getDataSAP.Invoke(GlobalData.rfcDestination);
            //IRfcTable IT_KNA1 = getDataSAP.GetTable("MATERIALDESCRIPTION");
            //DataSet materiales = new DataSet();
            //materiales.Tables.Add(ConvertToDotNetTable(IT_KNA1));
            //DGV1.DataSource = materiales.Tables[0];


            //IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("BAPI_MONITOR_GETLIST");
            //getDataSAP.Invoke(GlobalData.rfcDestination);
            //IRfcTable IT_KNA1 = getDataSAP.GetTable("BAPILIST");
            //DataSet materiales = new DataSet();
            //materiales.Tables.Add(ConvertToDotNetTable(IT_KNA1));
            //DGV1.DataSource = materiales.Tables[0];

            //IRfcFunction getDataSAP = GlobalData.rfcRepository.CreateFunction("Z_MDFN_CO35");

            //getDataSAP.SetValue("P_BUKRS", "1000");
            //getDataSAP.SetValue("P_YEAR", "2022");
            //getDataSAP.SetValue("P_MONTH", "11");

            //getDataSAP.Invoke(GlobalData.rfcDestination);
            //IRfcTable IT_KNA1 = getDataSAP.GetTable("IT_OUTTAB");




            DataSet HeadProveedores = new DataSet();
            HeadProveedores.Tables.Add(ConvertToDotNetTable(IT_HEADER));
            HeadProveedores.Tables.Add(ConvertToDotNetTable(IT_ITEM));
            DataTable result_IT_HEADER = HeadProveedores.Tables[0];
            DataTable result_IT_ITEM = HeadProveedores.Tables[1];

            return (result_IT_HEADER, result_IT_ITEM);

        }


        static DataTable ConvertToDotNetTable(IRfcTable RFCTable)
        {
            DataTable dtTable = new DataTable();
            for (int item = 0; item < RFCTable.ElementCount; item++)
            {
                RfcElementMetadata metadata = RFCTable.GetElementMetadata(item);
                dtTable.Columns.Add(metadata.Name);
            }

            foreach (IRfcStructure row in RFCTable)
            {
                DataRow dr = dtTable.NewRow();
                for (int item = 0; item < RFCTable.ElementCount; item++)
                {
                    RfcElementMetadata metadata = RFCTable.GetElementMetadata(item);
                    if (metadata.DataType == RfcDataType.BCD && metadata.Name == "ABC")
                    {
                        dr[item] = row.GetInt(metadata.Name);
                    }
                    else
                    {
                        dr[item] = row.GetString(metadata.Name);
                    }
                }

                dtTable.Rows.Add(dr);
            }

            return dtTable;
        }


        static DataTable CreateDataTable(DataTable dt, IRfcTable rfcTable)
        {
            foreach (IRfcStructure row in rfcTable)
            {
                DataRow newRow = dt.NewRow();
                for (int element = 0; element < rfcTable.ElementCount; element++)
                {
                    RfcElementMetadata metadata = rfcTable.GetElementMetadata(element);
                    var nrow = newRow[element];
                    var rrow = row.GetString(metadata.Name);
                    newRow[element] = row.GetString(metadata.Name);

                }
                dt.Rows.Add(newRow);
            }

            return dt;

        }
    }
}

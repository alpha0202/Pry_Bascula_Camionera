﻿using RFC_SAP_Interface;
using DevExpress.XtraEditors;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;

using System.Windows.Forms;

namespace IntegracionSAP_Dll
{
    public class MetodosIntegracion
    {
        DataTable resultDt1 = new DataTable();
        DataTable resultDt2 = new DataTable();
        rfc_Connector rfc_Connector = new rfc_Connector();
        public MetodosIntegracion()
        {

        }

        public class Consecutivo
        {
            private static int _consecutivo = 0;

            public static int GetConsecutivo()
            {
                return ++_consecutivo;
            }
        }




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


        #region Metodos consulta SAP para basculas

        //método consultar los saldos de los materiales.
        public DataTable CargarSaldos(string CL, string lote, string Material)
        {
                DataTable resultDt_Saldos = new DataTable();
            try
            {
                if (string.IsNullOrEmpty(CL.Trim()))
                {
                    throw new Exception("No se puede realizar petición sin en el parámetro CENTRO LOGÍSTICO.");
                    
                }
                else
                {

                    RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                    RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                    RfcRepository repo = prd.Repository;
                    IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_SALDOS");
                    soBapi.SetValue("P_WERKS", CL); //1208 importante
                    soBapi.SetValue("P_CHARG", lote); //lote, puede faltar este dato
                    soBapi.SetValue("P_LGORT", ""); //almacen
                    soBapi.SetValue("P_MATNR", Material); //"000000000000200000"
                    soBapi.Invoke(prd);
                    IRfcTable IT_KNA1 = soBapi.GetTable("IT_SALDOS");
                    DataSet DtSetSaldos = new DataSet();
                    DtSetSaldos.Tables.Add(ConvertToDotNetTable(IT_KNA1));
                    resultDt_Saldos = DtSetSaldos.Tables[0];



                    return resultDt_Saldos;


                }

              
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK);
                return resultDt_Saldos;

            }

            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }
        }


        //Consultar descripción del material
        public string DescripcionMaterial(string codMaterial) 
        {
            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_MATERIAL");
                soBapi.SetValue("V_MATNR", codMaterial); //"000000000000100017" cod material para recibir su descripción.            
                soBapi.Invoke(prd);
                string res = (string)soBapi.GetValue("V_MAKTX");
              

                return res;
            }
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }


        }


        //metodo para ajuste de inventarios 
        public DataTable AjustarInventario(string CL, string lgort, string Material, string charg, string menge, string mei, string netoCalculado, string cw)
        {


            int consecutivo = Consecutivo.GetConsecutivo();
            DataTable resultDt_Ajuste = new DataTable();
            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_AJUSTEINV_BASCULAS");
                soBapi.SetValue("V_WERKS", CL); //1208 centro logístico
                soBapi.SetValue("V_LGORT", "1000");  //almacen (no viene actualmente)
                IRfcTable dtParametros = soBapi.GetTable("IT_MAT");

                dtParametros.Append();
                dtParametros.SetValue("ZEILE", consecutivo); //"1" CONSECUTIVO PROPIO 
                dtParametros.SetValue("MATNR", Material); // COD MATERIAL
                dtParametros.SetValue("CHARG", charg); //LOTE SI LO MANEJA
                dtParametros.SetValue("MENGE", netoCalculado); //VALOR NETO CALCULADO QUE VA A REALIZAR EL AJUSTE
                dtParametros.SetValue("MEINS", cw); //UNID MEDIDA UNIDADES (UN
                dtParametros.SetValue("/CWM/MENGE", 0); //PESAJE FINAL(NETO KG)
                dtParametros.SetValue("/CWM/MEINS", ""); // UMP(UNID MEDIDADE DEL PESAJE KG)
                soBapi.SetValue("IT_MAT", dtParametros);
                
                soBapi.Invoke(prd);
                IRfcTable IT_KNA1 = soBapi.GetTable("IT_LOG");
                //var res = soBapi.GetValue("V_IBLNR");

                DataSet dsAjuste = new DataSet();
                dsAjuste.Tables.Add(ConvertToDotNetTable(IT_KNA1));
                resultDt_Ajuste = dsAjuste.Tables[0];



                return resultDt_Ajuste;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK);
                return resultDt_Ajuste;

            }



            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }
        }

        //enviar información de retorno a SAP 
        public (int, DataTable) RetornarDatos(string idPesaje, string tiqueteBascula, string umb,  string netoCalculado)
        {
            string statusNum = "02";
            int valorRetorno = 0;
            DataTable resultDt_Retorno = new DataTable();
            object res;
            try
            {
                if (tiqueteBascula == "01" && netoCalculado == "0,000")
                {
                    statusNum = "01";
                    tiqueteBascula = "";
                    umb = "0,000";

                }

                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("ZSD_FM_SCALE_MONITOR_RECEIVER");
                //soBapi.SetValue("V_WERKS", CL); //1208 centro logístico
                //soBapi.SetValue("V_LGORT", "1000");  //almacen (no viene actualmente)
                IRfcTable dtParametros = soBapi.GetTable("IT_REQUEST");

                dtParametros.Append();
                dtParametros.SetValue("IDPESAJE", idPesaje); //ID PESAJE 
                dtParametros.SetValue("ZTQ_BASC", tiqueteBascula); // ETIQUETA DE BASCULA
                dtParametros.SetValue("LKIMG_REAL", umb); // CANTIDAD PESADA REAL EN UMB
                dtParametros.SetValue("PIKMG_REAL", netoCalculado); // CANTIDAD PESADA REAL EN UMP (PESO NETO)
                dtParametros.SetValue("STATUS", statusNum); //ESTADO DE CONSUMO --> SE CAMBIA A 01 O´ 02

                soBapi.SetValue("IT_REQUEST", dtParametros);

                soBapi.Invoke(prd);
                res = soBapi.GetValue("EX_V_SUBRC");
                IRfcTable EX_T_RETURN = soBapi.GetTable("EX_T_RETURN");

                DataSet dsRes_Retorno = new DataSet();
                dsRes_Retorno.Tables.Add(ConvertToDotNetTable(EX_T_RETURN));
                resultDt_Retorno = dsRes_Retorno.Tables[0];
                valorRetorno = Convert.ToInt32(res);
                return (valorRetorno,resultDt_Retorno);

            }
            catch (Exception ex)
            {

                //throw new Exception(ex.Message);
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
                valorRetorno = -1;
                resultDt_Retorno.Columns.Add("MESSAGE", typeof(string));
                resultDt_Retorno.Rows.Add(ex.Message);

                return (valorRetorno, resultDt_Retorno);
            }

            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }
        }





        //método para cargar toda la data de pesajes de SAP.
        public DataTable CargarData_PesajesActivos()
        {
            
            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_BASCULA");
                soBapi.Invoke(prd);
                IRfcTable IT_KNA1 = soBapi.GetTable("IT_TABLE");
                DataSet dsListadoAct = new DataSet();
                dsListadoAct.Tables.Add(ConvertToDotNetTable(IT_KNA1));
                DataTable resultDt_ListadoAct = dsListadoAct.Tables[0];
           

                return resultDt_ListadoAct;

            }
            catch (Exception){throw;}
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) {throw;}
            }

        }


        //método para cargar toda la data de pesajes de SAP.
        public DataTable Cambiar_estadoConsumo(string idpesaje)
        {

            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("ZSD_FM_WEIGHING_DATA_GET");
                soBapi.Invoke(prd);
                IRfcTable IT_KNA1 = soBapi.GetTable("IS_REQUEST");
                DataSet dsListadoAct = new DataSet();
                dsListadoAct.Tables.Add(ConvertToDotNetTable(IT_KNA1));
                DataTable resultDt_ListadoAct = dsListadoAct.Tables[0];


                return resultDt_ListadoAct;

            }
            catch (Exception) { throw; }
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }

        }



        //Método para traer la data desde SAP a partir de la placa digitada.
        public DataTable FiltrarData_PlacaCabezote(string Placa)
        {


            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_BASCULA");
                soBapi.SetValue("PLACA", Placa); //1208
                soBapi.Invoke(prd);
                IRfcTable IT_KNA1 = soBapi.GetTable("IT_TABLE");
                DataSet dsFiltroPlaca = new DataSet();
                dsFiltroPlaca.Tables.Add(ConvertToDotNetTable(IT_KNA1));
                DataTable resultDt_FiltroPlaca = dsFiltroPlaca.Tables[0];

                return resultDt_FiltroPlaca;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }

        }


        //método para listar todas las empresas transportistas.
        public DataTable Listar_Transportistas()
        {

            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_TRANSPORTISTA");
                soBapi.Invoke(prd);
                IRfcTable IT_TRANS = soBapi.GetTable("IT_TRANS");
                DataSet dsListTransportista = new DataSet();
                dsListTransportista.Tables.Add(ConvertToDotNetTable(IT_TRANS));
                DataTable DT_LstTrans = dsListTransportista.Tables[0];


                return DT_LstTrans;

            }
            catch (Exception) { throw; }
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }

        }

        //método para listar centros logísticos para destinos en básculas.
        public DataTable Listar_ClDestinos()
        {

            try
            {
                RfcDestinationManager.RegisterDestinationConfiguration(rfc_Connector);
                RfcDestination prd = RfcDestinationManager.GetDestination("SE37");
                RfcRepository repo = prd.Repository;
                IRfcFunction soBapi = repo.CreateFunction("Z_MDFN_DESTINOS");
                soBapi.Invoke(prd);
                IRfcTable IT_WERKS = soBapi.GetTable("IT_WERKS");
                DataSet ds_lstDestinos = new DataSet();
                ds_lstDestinos.Tables.Add(ConvertToDotNetTable(IT_WERKS));
                DataTable dt_lstDestinos = ds_lstDestinos.Tables[0];


                return dt_lstDestinos;

            }
            catch (Exception) { throw; }
            finally
            {
                try
                {   //se debe quitar el registro de la conexión si se desea realizar una nueva consulta
                    RfcDestinationManager.UnregisterDestinationConfiguration(rfc_Connector);
                }
                catch (Exception) { throw; }
            }



        }


        #endregion


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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Pry_Basculas_SAP.Class
{
    class UtilitiesSP
    {
        string id_pesaje;
        string tipo_proceso;
        string tipo_pesaje;
        string fecha_proceso;
        string doc_comercial;
        string doc_compra;
        string doc_transporte;
        string Ent_salida_sap;
        string material_sap;
        string desc_material;
        string posicion;
        string placa_cabezote;
        string plac_trailer;
        string fecha_carga;
        string conductor;
        string transportista;
        string centro_logistico;
        string num_bascula;
        string cantidad_umb;
        string umb;
        string cantidad_ump;
        string ump;
        string lote_sap;
        string ztq_basc;
        string cant_real_umb;
        string cant_real_ump;
        string doc_material;
        string estado_consumo_servicio;
        public UtilitiesSP()
        {

        }


        //public void GuardarData_FromSAP(DataTable dt)
        //{
        //    List<Parametros> LstParametros = new List<Parametros>();

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        id_pesaje = item["IDPESAJE"].ToString();
        //        tipo_proceso = item["TPROCESO"].ToString();
        //        tipo_pesaje = item["TPESAJE"].ToString();
        //        fecha_proceso = item["FPROCESO"].ToString();
        //        doc_comercial = item["VBELN"].ToString();
        //        doc_compra = item["EBELN"].ToString();
        //        doc_transporte = item["TKNUM"].ToString();
        //        Ent_salida_sap = item["VBELN2"].ToString();
        //        material_sap = item["MATNR"].ToString();
        //        posicion = item["POSNR"].ToString();
        //        placa_cabezote = item["ADD01"].ToString();
        //        plac_trailer = item["ADD02"].ToString();
        //        fecha_carga = item["DPLBG"].ToString();
        //        conductor = item["TEXT1"].ToString();
        //        centro_logistico = item["WERKS"].ToString();
        //        num_bascula = item["BASCULA"].ToString();
        //        cantidad_umb = item["LFIMG"].ToString();
        //        umb = item["MEINS"].ToString();
        //        cantidad_ump = item["PIKMG"].ToString();
        //        ump = item["UMP"].ToString();
        //        lote_sap = item["CHARG"].ToString();
        //        ztq_basc = item["ZTQ_BASC"].ToString();
        //        cant_real_umb = item["LKIMG_REAL"].ToString();
        //        cant_real_ump = item["PIKMG_REAL"].ToString();
        //        doc_material = item["MBLNR"].ToString();
        //        estado_consumo_servicio = item["STATUS"].ToString();

        //        LstParametros.Add(new Parametros("@IDPESAJE", id_pesaje, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@TPROCESO", tipo_proceso, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@TPESAJE", tipo_pesaje, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@FPROCESO", fecha_proceso, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@VBELN", doc_comercial, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@EBELN", doc_compra, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@TKNUM", doc_transporte, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@VBELN2", Ent_salida_sap, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@MATNR", material_sap, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@POSNR", posicion, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@ADD01", placa_cabezote, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@ADD02", plac_trailer, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@DPLBG", fecha_carga, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@TEXT1", conductor, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@WERKS", centro_logistico, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@BASCULA", num_bascula, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@LFIMG", cantidad_umb, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@MEINS", umb, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@PIKMG", cantidad_ump, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@UMP", ump, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@CHARG", lote_sap, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@ZTQ_BASC", ztq_basc, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@LKIMG_REAL", cant_real_umb, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@PIKMG_REAL", cant_real_ump, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@MBLNR", doc_material, SqlDbType.VarChar));
        //        LstParametros.Add(new Parametros("@STATUS", estado_consumo_servicio, SqlDbType.VarChar));
           
        //        var sendData = Datos.SPGetEscalar("SP_Guardar_Data_SAP", LstParametros);
        //        LstParametros.Clear();
        //    }

        //}



        public void GuardarData_Capturada(DataRow dtRow)
        {
            List<Parametros> LstParametros = new List<Parametros>();

           
            
                id_pesaje = dtRow.Field<string>("IDPESAJE").ToString();
                tipo_proceso = dtRow.Field<string>("TPROCESO").ToString();
                tipo_pesaje = dtRow.Field<string>("TPESAJE").ToString();
                fecha_proceso = dtRow.Field<string>("FPROCESO").ToString();
                doc_comercial = dtRow.Field<string>("VBELN").ToString();
                doc_compra = dtRow.Field<string>("EBELN").ToString();
                doc_transporte = dtRow.Field<string>("TKNUM").ToString();
                Ent_salida_sap = dtRow.Field<string>("VBELN2").ToString();
                material_sap = dtRow.Field<string>("MATNR").ToString();
                desc_material = dtRow.Field<string>("MAKT").ToString();
                posicion = dtRow.Field<string>("POSNR").ToString();
                placa_cabezote = dtRow.Field<string>("ADD01").ToString();
                plac_trailer = dtRow.Field<string>("ADD02").ToString();
                fecha_carga = dtRow.Field<string>("DPLBG").ToString().Trim();
                conductor = dtRow.Field<string>("TEXT1").ToString().Trim();
                transportista = dtRow.Field<string>("AGENTE").ToString().Trim();
                centro_logistico = dtRow.Field<string>("WERKS").ToString();
                num_bascula = dtRow.Field<string>("BASCULA").ToString();
                cantidad_umb = dtRow.Field<string>("LFIMG").ToString();
                umb = dtRow.Field<string>("MEINS").ToString();
                cantidad_ump = dtRow.Field<string>("PIKMG").ToString();
                ump = dtRow.Field<string>("UMP").ToString();
                lote_sap = dtRow.Field<string>("CHARG").ToString();
                ztq_basc = dtRow.Field<string>("ZTQ_BASC").ToString();
                cant_real_umb = dtRow.Field<string>("LKIMG_REAL").ToString();
                cant_real_ump = dtRow.Field<string>("PIKMG_REAL").ToString();
                doc_material = dtRow.Field<string>("MBLNR").ToString();
                estado_consumo_servicio = dtRow.Field<string>("STATUS").ToString();

                LstParametros.Add(new Parametros("@IDPESAJE", id_pesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@TPROCESO", tipo_proceso, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@TPESAJE", tipo_pesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@FPROCESO", fecha_proceso, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@VBELN", doc_comercial, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@EBELN", doc_compra, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@TKNUM", doc_transporte, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@VBELN2", Ent_salida_sap, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@MATNR", material_sap, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@MAKT", desc_material, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@POSNR", posicion, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@ADD01", placa_cabezote, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@ADD02", plac_trailer, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@DPLBG", fecha_carga, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@TEXT1", conductor, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@AGENTE", transportista, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@WERKS", centro_logistico, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@BASCULA", num_bascula, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@LFIMG", cantidad_umb, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@MEINS", umb, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PIKMG", cantidad_ump, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@UMP", ump, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@CHARG", lote_sap, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@ZTQ_BASC", ztq_basc, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@LKIMG_REAL", cant_real_umb, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@PIKMG_REAL", cant_real_ump, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@MBLNR", doc_material, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@STATUS", estado_consumo_servicio, SqlDbType.VarChar));

                var sendData = Datos.SPGetEscalar("SP_Guardar_DataCapturada", LstParametros);
                LstParametros.Clear();
            

        }

    }
}

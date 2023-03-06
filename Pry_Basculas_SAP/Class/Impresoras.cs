using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace Pry_Basculas_SAP.Class
{
   public class Impresoras
    {


        public List<Printer> GetImpresoras(string co)
        {
            try
            {
                string sql = "select f105_RowID, f105_Impresora from t105_ImpresorasPorCO where f105_Estado = 'A' and f105_CO = '" + co + "'";
                var listImpresoras = new List<Printer>();
                var dt = new DataTable();
                
                dt = Datos.ObtenerDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    var i = new Printer();
                    i._RowId = decimal.Parse(dr["f105_RowID"].ToString());
                    i._Impresora = dr["f105_Impresora"].ToString();
                    listImpresoras.Add(i);
                }
                return listImpresoras;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


        public DataTable GetListImpresoras(string co)
        {
            string sql = " select f105_RowID, f105_Descripcion from t105_ImpresorasPorCO where f105_CO = '" + co + "'";
            
            var dt = new DataTable();
            dt = Datos.ObtenerDataTable(sql);
            return dt;
        }




    }
}

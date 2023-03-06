using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_Basculas_SAP.Class
{
   public class Printer
    {

        private decimal RowId;
        private string Impresora;


        public string _Impresora
        {
            get
            {
                return Impresora;
            }
            set
            {
                Impresora = value;
            }
        }

        public decimal _RowId
        {
            get
            {
                return RowId;
            }
            set
            {
                RowId = value;
            }
        }


    }
}

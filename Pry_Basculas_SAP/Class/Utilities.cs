using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP.Class
{
   public static class Utilities
    {

      

        //método para establecer solo letras con expresión regular
        public static string CleanName(this string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^a-zA-ZñÑ\s\u00C0-\u017F]", "");
            }

            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        //método para establecer solo números con expresión regular
        public static string CleanId(this string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^0-9]*$", "");
            }

            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        //Métodos para validar la entrda de placas vehículos.
        public static  string ValidarPlaca_Cabezote(string placa)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(placa)) 
                {
                    throw new Exception("DEBE DIGITAR LA PLACA."); 
                }

                else if (placa.Trim().Length >7) { 
                    
                    throw new Exception("SUPERA LA CANTIDAD DE CARACTERES DE UNA PLACA."); 
                    
                
                }

                //placa = placa.Insert(3,"-").Trim();

                /*
                 *  Verifica se o caractere da posição 4 é uma letra, se sim, aplica a validação para o formato de placa do Mercosul,
                 *  senão, aplica a validação do formato de placa padrão.
                 */
                if (char.IsLetter(placa, 1))
                {

                    //string Patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+.]";
                    placa =  Regex.Replace(placa, @"[^a-zA-Z0-9]", "");
                   

                    /*
                     *  Verifica se a placa está no formato: três letras, um número, uma letra e dois números.
                     */
                    // var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");

                    //var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{3}|[a-zA-Z]{3}[0-9]{2}[a-zA-Z]");
                    //return padraoMercosul.IsMatch(placa, padraoMercosul);
                    return placa.Insert(3, "-").Trim();
                }
                else
                {
                    //// Verifica se os 3 primeiros caracteres são letras e se os 4 últimos são números.
                    //var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{3}");
                    //return padraoNormal.IsMatch(placa);

                    throw new Exception("PLACA DEBE EMPEZAR CON LETRA");
                }

                //return placa = placa.Insert(3, "-").Trim();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message, "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }
            //return placa;
        }



       

    }
}

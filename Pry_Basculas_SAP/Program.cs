using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Pry_Basculas_SAP.Impresion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pry_Basculas_SAP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVista_PesajesActivos());
        }
    }
}

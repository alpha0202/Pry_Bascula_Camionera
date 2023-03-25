using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_Basculas_SAP.Class
{
    class Personalizaciones
    {

       


    }

    public class FrmCustom : XtraForm
    {

        public FrmCustom()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            this.Controls.Add(lc);
            lc.BeginUpdate();
            try
            {
                LabelControl lblA = new LabelControl() { Name = "lbla", Text = "   A: Activo    ", Font = new Font("Cascadia Code", 10, FontStyle.Bold), BackColor = Color.YellowGreen };
                LabelControl lblP = new LabelControl() { Name = "lblp", Text = "   P: Proceso   ", Font = new Font("Cascadia Code", 10, FontStyle.Bold), BackColor = Color.Salmon };
                LabelControl lblY = new LabelControl() { Name = "lbly", Text = "   Y: Terminado ", Font = new Font("Cascadia Code", 10, FontStyle.Bold), BackColor = Color.LightSkyBlue };

                lc.Root.GroupBordersVisible = false;
                //lc.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
                LayoutControlGroup grupoDetalle = lc.Root.AddGroup();
                grupoDetalle.Name = "GrupoDetalle";
                grupoDetalle.Text = "Descripción Estados.";


                LayoutControlItem item3 = grupoDetalle.AddItem();
                item3.Text = "Estado: ";
                item3.Control = lblA;
                LayoutControlItem item1 = grupoDetalle.AddItem();
                item1.Text = "Estado: ";
                item1.Control = lblP;
                LayoutControlItem item2 = grupoDetalle.AddItem();
                item2.Text = "Estado: ";
                item2.Control = lblY;


                // Add an empty resizable region below the last added layout item.
                EmptySpaceItem emptySpace11 = new EmptySpaceItem();
                emptySpace11.Parent = grupoDetalle;




                // Bind a control to the layout item.
                //TextEdit textEdit1 = new TextEdit();
                //textEdit1.Name = "TextEdit1";
                //item1.Control = textEdit1;
                //item1.Text = "Name";





                //TextEdit teLogin = new TextEdit();
                //TextEdit tePassword = new TextEdit();

                //CheckEdit ceKeep = new CheckEdit() { Text = "Keep me signed in" };
                //SeparatorControl separatorControl = new SeparatorControl();
                //lc.AddItem(String.Empty, teLogin).TextVisible = false;
                //lc.AddItem(String.Empty, tePassword).TextVisible = false;
                //lc.AddItem(String.Empty, ceKeep);


                //this.Controls.Add(lc);
                //this.Height = 100;
                //this.Dock = DockStyle.Top;
                //lc.Root.Add(grupoDetalle);
            }
            finally
            {
                lc.EndUpdate();
            }

        }
    }


    public class LoginUserControl : XtraUserControl
    {
        public LoginUserControl()
        {
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            TextEdit teLogin = new TextEdit();
            TextEdit tePassword = new TextEdit();
            ///CheckEdit ceKeep = new CheckEdit() { Text = "Keep me signed in" };
            SeparatorControl separatorControl = new SeparatorControl();
            lc.AddItem(String.Empty, teLogin).TextVisible = false;
            lc.AddItem(String.Empty, tePassword).TextVisible = false;
            //lc.AddItem(String.Empty, ceKeep);
            this.Controls.Add(lc);
            this.Height = 100;
            this.Dock = DockStyle.Top;

        }
    }


}

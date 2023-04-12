
namespace Pry_Basculas_SAP
{
    partial class frm_Cambiar_transportista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.btn_CambiarTrans = new DevExpress.XtraEditors.SimpleButton();
            this.txt_nit = new DevExpress.XtraEditors.TextEdit();
            this.txt_NomTrans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NomTrans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.txt_NomTrans);
            this.xtraScrollableControl1.Controls.Add(this.txt_nit);
            this.xtraScrollableControl1.Controls.Add(this.btn_CambiarTrans);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(12, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(606, 344);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // btn_CambiarTrans
            // 
            this.btn_CambiarTrans.Location = new System.Drawing.Point(3, 258);
            this.btn_CambiarTrans.Name = "btn_CambiarTrans";
            this.btn_CambiarTrans.Size = new System.Drawing.Size(121, 34);
            this.btn_CambiarTrans.TabIndex = 0;
            this.btn_CambiarTrans.Text = "CAMBIAR";
            this.btn_CambiarTrans.Click += new System.EventHandler(this.btn_CambiarTrans_Click);
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(3, 182);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(121, 20);
            this.txt_nit.TabIndex = 1;
            this.txt_nit.Leave += new System.EventHandler(this.txt_nit_Leave);
            // 
            // txt_NomTrans
            // 
            this.txt_NomTrans.Enabled = false;
            this.txt_NomTrans.Location = new System.Drawing.Point(179, 182);
            this.txt_NomTrans.Name = "txt_NomTrans";
            this.txt_NomTrans.Size = new System.Drawing.Size(395, 20);
            this.txt_NomTrans.TabIndex = 2;
            this.txt_NomTrans.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 153);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "DIGITAR NIT";
            // 
            // frm_Cambiar_transportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 360);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.LargeImage = global::Pry_Basculas_SAP.Properties.Resources.contact_32x32;
            this.Name = "frm_Cambiar_transportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR TRANSPORTISTA";
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NomTrans.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CambiarTrans;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_NomTrans;
        private DevExpress.XtraEditors.TextEdit txt_nit;
    }
}
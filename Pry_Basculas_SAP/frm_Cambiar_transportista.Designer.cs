
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
            this.btn_newBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NomTrans = new DevExpress.XtraEditors.TextEdit();
            this.txt_nit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_transActual = new DevExpress.XtraEditors.TextEdit();
            this.txt_DigitaID = new DevExpress.XtraEditors.TextEdit();
            this.btn_CambiarTrans = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NomTrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_transActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DigitaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.btn_newBusqueda);
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.btn_CambiarTrans);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(12, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(675, 380);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // btn_newBusqueda
            // 
            this.btn_newBusqueda.Enabled = false;
            this.btn_newBusqueda.Location = new System.Drawing.Point(551, 329);
            this.btn_newBusqueda.Name = "btn_newBusqueda";
            this.btn_newBusqueda.Size = new System.Drawing.Size(120, 38);
            this.btn_newBusqueda.TabIndex = 4;
            this.btn_newBusqueda.Text = "NUEVA BUSQUEDA";
            this.btn_newBusqueda.Visible = false;
            this.btn_newBusqueda.Click += new System.EventHandler(this.btn_newBusqueda_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txt_NomTrans);
            this.panelControl2.Controls.Add(this.txt_nit);
            this.panelControl2.Location = new System.Drawing.Point(3, 179);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(668, 113);
            this.panelControl2.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl8.Location = new System.Drawing.Point(3, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(14, 23);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "2";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(224, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(221, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "BUSCAR NIT DE NUEVO TRANSPORTISTA";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(181, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "NUEVO TRANSPORTISTA";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "DIGITAR NIT";
            // 
            // txt_NomTrans
            // 
            this.txt_NomTrans.Enabled = false;
            this.txt_NomTrans.Location = new System.Drawing.Point(181, 75);
            this.txt_NomTrans.Name = "txt_NomTrans";
            this.txt_NomTrans.Size = new System.Drawing.Size(467, 20);
            this.txt_NomTrans.TabIndex = 9;
            this.txt_NomTrans.Visible = false;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(5, 75);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(121, 20);
            this.txt_nit.TabIndex = 2;
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            this.txt_nit.Leave += new System.EventHandler(this.txt_nit_Leave);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_transActual);
            this.panelControl1.Controls.Add(this.txt_DigitaID);
            this.panelControl1.Location = new System.Drawing.Point(3, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(668, 108);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl7.Location = new System.Drawing.Point(3, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 23);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(159, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(350, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "BUSCAR TRANSPORTISTA ACTUAL FILTRADO POR ID DE PESAJE";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(181, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "TRANSPORTISTA ACTUAL ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "DIGITAR ID PESAJE";
            // 
            // txt_transActual
            // 
            this.txt_transActual.Enabled = false;
            this.txt_transActual.Location = new System.Drawing.Point(181, 59);
            this.txt_transActual.Name = "txt_transActual";
            this.txt_transActual.Size = new System.Drawing.Size(467, 20);
            this.txt_transActual.TabIndex = 4;
            this.txt_transActual.Visible = false;
            // 
            // txt_DigitaID
            // 
            this.txt_DigitaID.Location = new System.Drawing.Point(5, 59);
            this.txt_DigitaID.Name = "txt_DigitaID";
            this.txt_DigitaID.Size = new System.Drawing.Size(121, 20);
            this.txt_DigitaID.TabIndex = 1;
            this.txt_DigitaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DigitaID_KeyPress);
            this.txt_DigitaID.Leave += new System.EventHandler(this.txt_DigitaID_Leave);
            // 
            // btn_CambiarTrans
            // 
            this.btn_CambiarTrans.AppearanceDisabled.BackColor = System.Drawing.Color.Snow;
            this.btn_CambiarTrans.AppearanceDisabled.Options.UseBackColor = true;
            this.btn_CambiarTrans.Enabled = false;
            this.btn_CambiarTrans.ImageOptions.Image = global::Pry_Basculas_SAP.Properties.Resources.replace_32x32;
            this.btn_CambiarTrans.Location = new System.Drawing.Point(6, 329);
            this.btn_CambiarTrans.Name = "btn_CambiarTrans";
            this.btn_CambiarTrans.Size = new System.Drawing.Size(132, 38);
            this.btn_CambiarTrans.TabIndex = 3;
            this.btn_CambiarTrans.Text = "CAMBIAR";
            this.btn_CambiarTrans.Click += new System.EventHandler(this.btn_CambiarTrans_Click);
            // 
            // frm_Cambiar_transportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 396);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.LargeImage = global::Pry_Basculas_SAP.Properties.Resources.contact_32x32;
            this.Name = "frm_Cambiar_transportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR TRANSPORTISTA";
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NomTrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_transActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DigitaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CambiarTrans;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_transActual;
        private DevExpress.XtraEditors.TextEdit txt_DigitaID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_NomTrans;
        private DevExpress.XtraEditors.TextEdit txt_nit;
        private DevExpress.XtraEditors.SimpleButton btn_newBusqueda;
    }
}
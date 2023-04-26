
namespace Pry_Basculas_SAP.Impresion
{
    partial class frm_Seleccionar_CLDestino
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
            this.cbo_destinos = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_idPesaje = new DevExpress.XtraEditors.TextEdit();
            this.btn_Aplicar = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_seleccion = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idPesaje.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.lbl_seleccion);
            this.xtraScrollableControl1.Controls.Add(this.btn_Aplicar);
            this.xtraScrollableControl1.Controls.Add(this.txt_idPesaje);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.cbo_destinos);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(618, 244);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // cbo_destinos
            // 
            this.cbo_destinos.FormattingEnabled = true;
            this.cbo_destinos.Location = new System.Drawing.Point(258, 70);
            this.cbo_destinos.Name = "cbo_destinos";
            this.cbo_destinos.Size = new System.Drawing.Size(304, 21);
            this.cbo_destinos.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(258, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "CENTROS LOGÍSTICOS DE DESTINO";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ID PESAJE";
            // 
            // txt_idPesaje
            // 
            this.txt_idPesaje.Location = new System.Drawing.Point(75, 71);
            this.txt_idPesaje.Name = "txt_idPesaje";
            this.txt_idPesaje.Size = new System.Drawing.Size(126, 20);
            this.txt_idPesaje.TabIndex = 4;
            // 
            // btn_Aplicar
            // 
            this.btn_Aplicar.Location = new System.Drawing.Point(487, 182);
            this.btn_Aplicar.Name = "btn_Aplicar";
            this.btn_Aplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aplicar.TabIndex = 5;
            this.btn_Aplicar.Text = "Aplicar";
            this.btn_Aplicar.Click += new System.EventHandler(this.btn_Aplicar_Click);
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.Location = new System.Drawing.Point(258, 97);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(4, 13);
            this.lbl_seleccion.TabIndex = 6;
            this.lbl_seleccion.Text = ".";
            // 
            // frm_Seleccionar_CLDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 244);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frm_Seleccionar_CLDestino";
            this.Text = "CENTRO LOGÍSTICO DE DESTINO";
            this.Load += new System.EventHandler(this.frm_Seleccionar_CLDestino_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idPesaje.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.ComboBox cbo_destinos;
        private DevExpress.XtraEditors.TextEdit txt_idPesaje;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Aplicar;
        private DevExpress.XtraEditors.LabelControl lbl_seleccion;
    }
}
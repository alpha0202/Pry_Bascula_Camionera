
namespace Pry_Basculas_SAP
{
    partial class frm_Test_CapturaBascula
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
            this.txt_datoCapturado = new DevExpress.XtraEditors.TextEdit();
            this.btn_capturar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_datoCapturado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_datoCapturado
            // 
            this.txt_datoCapturado.Location = new System.Drawing.Point(93, 57);
            this.txt_datoCapturado.Name = "txt_datoCapturado";
            this.txt_datoCapturado.Size = new System.Drawing.Size(140, 20);
            this.txt_datoCapturado.TabIndex = 0;
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(93, 92);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(140, 32);
            this.btn_capturar.TabIndex = 1;
            this.btn_capturar.Text = "CAPTURAR";
            this.btn_capturar.Click += new System.EventHandler(this.btn_capturar_Click);
            // 
            // frm_Test_CapturaBascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(this.btn_capturar);
            this.Controls.Add(this.txt_datoCapturado);
            this.Name = "frm_Test_CapturaBascula";
            this.Text = "frm_Test_CapturaBascula";
            ((System.ComponentModel.ISupportInitialize)(this.txt_datoCapturado.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_datoCapturado;
        private DevExpress.XtraEditors.SimpleButton btn_capturar;
    }
}
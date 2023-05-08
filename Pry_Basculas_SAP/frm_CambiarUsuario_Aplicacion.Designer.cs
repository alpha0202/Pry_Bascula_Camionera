
namespace Pry_Basculas_SAP
{
    partial class frm_CambiarUsuario_Aplicacion
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
            this.cbo_SeleccionarUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usrSeleccionado = new DevExpress.XtraEditors.LabelControl();
            this.btn_CambiarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_NombreBascula = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cbo_SeleccionarUsuario
            // 
            this.cbo_SeleccionarUsuario.FormattingEnabled = true;
            this.cbo_SeleccionarUsuario.Location = new System.Drawing.Point(55, 85);
            this.cbo_SeleccionarUsuario.Name = "cbo_SeleccionarUsuario";
            this.cbo_SeleccionarUsuario.Size = new System.Drawing.Size(387, 21);
            this.cbo_SeleccionarUsuario.TabIndex = 0;
            this.cbo_SeleccionarUsuario.SelectedIndexChanged += new System.EventHandler(this.cbo_SeleccionarUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elegir usuario para la báscula: ";
            // 
            // lbl_usrSeleccionado
            // 
            this.lbl_usrSeleccionado.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_usrSeleccionado.Appearance.Options.UseFont = true;
            this.lbl_usrSeleccionado.Location = new System.Drawing.Point(55, 126);
            this.lbl_usrSeleccionado.Name = "lbl_usrSeleccionado";
            this.lbl_usrSeleccionado.Size = new System.Drawing.Size(7, 13);
            this.lbl_usrSeleccionado.TabIndex = 2;
            this.lbl_usrSeleccionado.Text = "*";
            // 
            // btn_CambiarUsuario
            // 
            this.btn_CambiarUsuario.Location = new System.Drawing.Point(55, 173);
            this.btn_CambiarUsuario.Name = "btn_CambiarUsuario";
            this.btn_CambiarUsuario.Size = new System.Drawing.Size(87, 23);
            this.btn_CambiarUsuario.TabIndex = 3;
            this.btn_CambiarUsuario.Text = "Cambiar usuario";
            this.btn_CambiarUsuario.Click += new System.EventHandler(this.btn_CambiarUsuario_Click);
            // 
            // lbl_NombreBascula
            // 
            this.lbl_NombreBascula.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreBascula.Appearance.Options.UseFont = true;
            this.lbl_NombreBascula.Location = new System.Drawing.Point(223, 47);
            this.lbl_NombreBascula.Name = "lbl_NombreBascula";
            this.lbl_NombreBascula.Size = new System.Drawing.Size(7, 13);
            this.lbl_NombreBascula.TabIndex = 4;
            this.lbl_NombreBascula.Text = "*";
            // 
            // frm_CambiarUsuario_Aplicacion
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 225);
            this.Controls.Add(this.lbl_NombreBascula);
            this.Controls.Add(this.btn_CambiarUsuario);
            this.Controls.Add(this.lbl_usrSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_SeleccionarUsuario);
            this.IconOptions.LargeImage = global::Pry_Basculas_SAP.Properties.Resources.customer_32x32;
            this.Name = "frm_CambiarUsuario_Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Usuario";
            this.Load += new System.EventHandler(this.frm_CambiarUsuario_Aplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_SeleccionarUsuario;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl lbl_usrSeleccionado;
        private DevExpress.XtraEditors.SimpleButton btn_CambiarUsuario;
        private DevExpress.XtraEditors.LabelControl lbl_NombreBascula;
    }
}
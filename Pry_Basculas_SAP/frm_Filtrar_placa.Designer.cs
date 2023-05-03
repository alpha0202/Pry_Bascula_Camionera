
namespace Pry_Basculas_SAP
{
    partial class frm_Filtrar_placa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Filtrar_placa));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.btn_EnvSeleccionados = new DevExpress.XtraEditors.SimpleButton();
            this.grd_ControlBusquedaPlaca = new DevExpress.XtraGrid.GridControl();
            this.grd_ViewBusquedaPlaca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_BuscarData = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlacaCabezote = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ControlBusquedaPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ViewBusquedaPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlacaCabezote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.btn_EnvSeleccionados);
            this.xtraScrollableControl1.Controls.Add(this.grd_ControlBusquedaPlaca);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(12, 3);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1061, 502);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // btn_EnvSeleccionados
            // 
            this.btn_EnvSeleccionados.AppearancePressed.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_EnvSeleccionados.AppearancePressed.Options.UseBackColor = true;
            this.btn_EnvSeleccionados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EnvSeleccionados.ImageOptions.Image")));
            this.btn_EnvSeleccionados.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_EnvSeleccionados.Location = new System.Drawing.Point(12, 443);
            this.btn_EnvSeleccionados.Name = "btn_EnvSeleccionados";
            this.btn_EnvSeleccionados.Size = new System.Drawing.Size(168, 35);
            this.btn_EnvSeleccionados.TabIndex = 5;
            this.btn_EnvSeleccionados.Text = "Enviar Seleccionados";
            this.btn_EnvSeleccionados.Click += new System.EventHandler(this.btn_EnvSeleccionados_Click);
            // 
            // grd_ControlBusquedaPlaca
            // 
            this.grd_ControlBusquedaPlaca.Location = new System.Drawing.Point(12, 180);
            this.grd_ControlBusquedaPlaca.MainView = this.grd_ViewBusquedaPlaca;
            this.grd_ControlBusquedaPlaca.Name = "grd_ControlBusquedaPlaca";
            this.grd_ControlBusquedaPlaca.Size = new System.Drawing.Size(1038, 257);
            this.grd_ControlBusquedaPlaca.TabIndex = 4;
            this.grd_ControlBusquedaPlaca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_ViewBusquedaPlaca});
            // 
            // grd_ViewBusquedaPlaca
            // 
            this.grd_ViewBusquedaPlaca.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn7,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn12,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn13,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn14,
            this.gridColumn11,
            this.gridColumn15});
            this.grd_ViewBusquedaPlaca.GridControl = this.grd_ControlBusquedaPlaca;
            this.grd_ViewBusquedaPlaca.Name = "grd_ViewBusquedaPlaca";
            this.grd_ViewBusquedaPlaca.OptionsSelection.MultiSelect = true;
            this.grd_ViewBusquedaPlaca.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grd_ViewBusquedaPlaca.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grd_ViewBusquedaPlaca.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.grd_ViewBusquedaPlaca.OptionsView.AllowHtmlDrawHeaders = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID PESAJE";
            this.gridColumn1.FieldName = "IDPESAJE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TIPO PROCESO";
            this.gridColumn2.FieldName = "TPROCESO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 83;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "TIPO PESAJE";
            this.gridColumn7.FieldName = "TPESAJE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "FECHA PROCESO";
            this.gridColumn3.FieldName = "FPROCESO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 92;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "MATERIAL";
            this.gridColumn8.FieldName = "MATNR";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "DESC MATERIAL";
            this.gridColumn12.FieldName = "MAKT";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn12.OptionsFilter.AllowFilter = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 86;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "PLACA CABEZOTE";
            this.gridColumn4.FieldName = "ADD01";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 95;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CONDUCTOR";
            this.gridColumn5.FieldName = "TEXT1";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TRANSPORTISTA";
            this.gridColumn13.FieldName = "AGENTE";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 9;
            this.gridColumn13.Width = 90;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CENTRO LOGÍSITCO";
            this.gridColumn6.FieldName = "WERKS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            this.gridColumn6.Width = 107;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "LOTE";
            this.gridColumn9.FieldName = "CHARG";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CANTIDAD UMB";
            this.gridColumn10.FieldName = "LFIMG";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 12;
            this.gridColumn10.Width = 84;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "CANTIDAD UMP";
            this.gridColumn11.FieldName = "PIKMG";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsEditForm.UseEditorColRowSpan = false;
            this.gridColumn11.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 14;
            this.gridColumn11.Width = 86;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_BuscarData);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtPlacaCabezote);
            this.panelControl1.Location = new System.Drawing.Point(318, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(372, 158);
            this.panelControl1.TabIndex = 3;
            // 
            // btn_BuscarData
            // 
            this.btn_BuscarData.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BuscarData.FlatAppearance.BorderSize = 0;
            this.btn_BuscarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarData.Location = new System.Drawing.Point(38, 106);
            this.btn_BuscarData.Name = "btn_BuscarData";
            this.btn_BuscarData.Size = new System.Drawing.Size(296, 36);
            this.btn_BuscarData.TabIndex = 4;
            this.btn_BuscarData.Text = "BUSCAR";
            this.btn_BuscarData.UseVisualStyleBackColor = false;
            this.btn_BuscarData.Click += new System.EventHandler(this.btn_BuscarData_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Placa Cabezote";
            // 
            // txtPlacaCabezote
            // 
            this.txtPlacaCabezote.Location = new System.Drawing.Point(186, 43);
            this.txtPlacaCabezote.Name = "txtPlacaCabezote";
            this.txtPlacaCabezote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaCabezote.Properties.Appearance.Options.UseFont = true;
            this.txtPlacaCabezote.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPlacaCabezote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPlacaCabezote.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPlacaCabezote.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacaCabezote.Properties.MaxLength = 7;
            this.txtPlacaCabezote.Size = new System.Drawing.Size(148, 24);
            this.txtPlacaCabezote.TabIndex = 0;
            this.txtPlacaCabezote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlacaCabezote_KeyDown);
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "UNID MEDIDA UMB";
            this.gridColumn14.FieldName = "MEINS";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            this.gridColumn14.Width = 98;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "UNID MEDIDA UMP";
            this.gridColumn15.FieldName = "UMP";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.AllowFocus = false;
            this.gridColumn15.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 15;
            this.gridColumn15.Width = 98;
            // 
            // frm_Filtrar_placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 527);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.LargeImage = global::Pry_Basculas_SAP.Properties.Resources.find_32x32;
            this.Name = "frm_Filtrar_placa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONSULTAR PLACA";
            this.Load += new System.EventHandler(this.frm_Filtrar_placa_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ControlBusquedaPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ViewBusquedaPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlacaCabezote.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SimpleButton btn_EnvSeleccionados;
        private DevExpress.XtraGrid.GridControl grd_ControlBusquedaPlaca;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_ViewBusquedaPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn_BuscarData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPlacaCabezote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    }
}
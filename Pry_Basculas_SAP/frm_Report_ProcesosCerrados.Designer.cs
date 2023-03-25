
namespace Pry_Basculas_SAP
{
    partial class frm_Report_ProcesosCerrados
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
            this.grc_ControlProcesosClose = new DevExpress.XtraGrid.GridControl();
            this.grv_VistaProcesosClose = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tip_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_mate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc_mate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiquete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ControlProcesosClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_VistaProcesosClose)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.grc_ControlProcesosClose);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1087, 592);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // grc_ControlProcesosClose
            // 
            this.grc_ControlProcesosClose.Location = new System.Drawing.Point(16, 46);
            this.grc_ControlProcesosClose.MainView = this.grv_VistaProcesosClose;
            this.grc_ControlProcesosClose.Name = "grc_ControlProcesosClose";
            this.grc_ControlProcesosClose.Size = new System.Drawing.Size(1053, 257);
            this.grc_ControlProcesosClose.TabIndex = 0;
            this.grc_ControlProcesosClose.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_VistaProcesosClose});
            // 
            // grv_VistaProcesosClose
            // 
            this.grv_VistaProcesosClose.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.tip_proceso,
            this.t_pesaje,
            this.desc,
            this.fecha_proceso,
            this.cd_mate,
            this.desc_mate,
            this.placa,
            this.gridColumn1,
            this.conductor,
            this.gridColumn2,
            this.tiquete,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grv_VistaProcesosClose.GridControl = this.grc_ControlProcesosClose;
            this.grv_VistaProcesosClose.Name = "grv_VistaProcesosClose";
            // 
            // id
            // 
            this.id.Caption = "ID PESAJE";
            this.id.FieldName = "IDPESAJE";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsColumn.AllowFocus = false;
            this.id.OptionsFilter.AllowAutoFilter = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            // 
            // tip_proceso
            // 
            this.tip_proceso.Caption = "TIPO PROCESO";
            this.tip_proceso.FieldName = "TPROCESO";
            this.tip_proceso.Name = "tip_proceso";
            this.tip_proceso.OptionsColumn.AllowEdit = false;
            this.tip_proceso.OptionsColumn.AllowFocus = false;
            this.tip_proceso.OptionsFilter.AllowAutoFilter = false;
            this.tip_proceso.Visible = true;
            this.tip_proceso.VisibleIndex = 1;
            this.tip_proceso.Width = 83;
            // 
            // t_pesaje
            // 
            this.t_pesaje.Caption = "TIPO PESAJE";
            this.t_pesaje.FieldName = "TPESAJE";
            this.t_pesaje.Name = "t_pesaje";
            this.t_pesaje.OptionsColumn.AllowEdit = false;
            this.t_pesaje.OptionsColumn.AllowFocus = false;
            this.t_pesaje.OptionsFilter.AllowAutoFilter = false;
            this.t_pesaje.Visible = true;
            this.t_pesaje.VisibleIndex = 2;
            // 
            // desc
            // 
            this.desc.Caption = "DESC PROCESO";
            this.desc.FieldName = "proceso";
            this.desc.Name = "desc";
            this.desc.OptionsColumn.AllowEdit = false;
            this.desc.OptionsColumn.AllowFocus = false;
            this.desc.OptionsFilter.AllowAutoFilter = false;
            this.desc.Visible = true;
            this.desc.VisibleIndex = 3;
            this.desc.Width = 85;
            // 
            // fecha_proceso
            // 
            this.fecha_proceso.Caption = "FECHA PROCESO";
            this.fecha_proceso.FieldName = "FPROCESO";
            this.fecha_proceso.Name = "fecha_proceso";
            this.fecha_proceso.OptionsColumn.AllowEdit = false;
            this.fecha_proceso.OptionsColumn.AllowFocus = false;
            this.fecha_proceso.OptionsFilter.AllowAutoFilter = false;
            this.fecha_proceso.Visible = true;
            this.fecha_proceso.VisibleIndex = 4;
            this.fecha_proceso.Width = 92;
            // 
            // cd_mate
            // 
            this.cd_mate.Caption = "COD MATERIAL";
            this.cd_mate.FieldName = "MATNR";
            this.cd_mate.Name = "cd_mate";
            this.cd_mate.OptionsColumn.AllowEdit = false;
            this.cd_mate.OptionsColumn.AllowFocus = false;
            this.cd_mate.OptionsFilter.AllowAutoFilter = false;
            this.cd_mate.Visible = true;
            this.cd_mate.VisibleIndex = 5;
            this.cd_mate.Width = 83;
            // 
            // desc_mate
            // 
            this.desc_mate.Caption = "MATERIAL";
            this.desc_mate.FieldName = "MAKT";
            this.desc_mate.Name = "desc_mate";
            this.desc_mate.OptionsColumn.AllowEdit = false;
            this.desc_mate.OptionsColumn.AllowFocus = false;
            this.desc_mate.OptionsFilter.AllowFilter = false;
            this.desc_mate.Visible = true;
            this.desc_mate.VisibleIndex = 6;
            // 
            // placa
            // 
            this.placa.Caption = "PLACA CABEZOTE";
            this.placa.FieldName = "ADD01";
            this.placa.Name = "placa";
            this.placa.OptionsColumn.AllowEdit = false;
            this.placa.OptionsColumn.AllowFocus = false;
            this.placa.OptionsFilter.AllowAutoFilter = false;
            this.placa.Visible = true;
            this.placa.VisibleIndex = 7;
            this.placa.Width = 95;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "FECHA CARGA";
            this.gridColumn1.FieldName = "DPLBG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 79;
            // 
            // conductor
            // 
            this.conductor.Caption = "CONDUCTOR";
            this.conductor.FieldName = "TEXT1";
            this.conductor.Name = "conductor";
            this.conductor.OptionsColumn.AllowEdit = false;
            this.conductor.OptionsColumn.AllowFocus = false;
            this.conductor.OptionsFilter.AllowAutoFilter = false;
            this.conductor.OptionsFilter.AllowFilter = false;
            this.conductor.Visible = true;
            this.conductor.VisibleIndex = 9;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "BASCULA";
            this.gridColumn2.FieldName = "BASCULA";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 10;
            // 
            // tiquete
            // 
            this.tiquete.Caption = "TIQUETE BASCULA";
            this.tiquete.FieldName = "tiquete_bascula";
            this.tiquete.Name = "tiquete";
            this.tiquete.OptionsColumn.AllowEdit = false;
            this.tiquete.OptionsColumn.AllowFocus = false;
            this.tiquete.OptionsFilter.AllowAutoFilter = false;
            this.tiquete.OptionsFilter.AllowFilter = false;
            this.tiquete.Visible = true;
            this.tiquete.VisibleIndex = 11;
            this.tiquete.Width = 99;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TIEMPOS ENTRE CAPTURAS (MIN)";
            this.gridColumn3.FieldName = "tiempo_total_capturas";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 12;
            this.gridColumn3.Width = 173;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FECHA_CONFIRMACION";
            this.gridColumn4.FieldName = "fecha_confirmacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 13;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CONFIRMA ENVIO A SAP";
            this.gridColumn5.FieldName = "confirma_Receiver_sap";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 14;
            this.gridColumn5.Width = 128;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "AJUSTE INV";
            this.gridColumn6.FieldName = "mblnr_ajuste_inv";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 15;
            // 
            // frm_Report_ProcesosCerrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.SvgImage = global::Pry_Basculas_SAP.Properties.Resources.bluedatabarsolid;
            this.Name = "frm_Report_ProcesosCerrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCESOS CERRADOS";
            this.Load += new System.EventHandler(this.frm_Report_ProcesosCerrados_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grc_ControlProcesosClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_VistaProcesosClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.GridControl grc_ControlProcesosClose;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_VistaProcesosClose;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn tip_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn t_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn desc;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn cd_mate;
        private DevExpress.XtraGrid.Columns.GridColumn desc_mate;
        private DevExpress.XtraGrid.Columns.GridColumn placa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn conductor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn tiquete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}
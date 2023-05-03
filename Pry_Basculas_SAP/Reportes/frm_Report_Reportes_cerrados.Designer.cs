
namespace Pry_Basculas_SAP.Reportes
{
    partial class frm_Report_Reportes_cerrados
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.btn_exportarEx = new DevExpress.XtraEditors.SimpleButton();
            this.grc_ControlReportCerrrado = new DevExpress.XtraGrid.GridControl();
            this.grv_VistaReportCerrado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tip_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_comer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_comp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_trans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cd_mate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc_mate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiquete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.print_formato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButton_ImprimirFormato = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_ControlReportCerrrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_VistaReportCerrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButton_ImprimirFormato)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.btn_exportarEx);
            this.xtraScrollableControl1.Controls.Add(this.grc_ControlReportCerrrado);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1393, 738);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // btn_exportarEx
            // 
            this.btn_exportarEx.Appearance.Options.UseTextOptions = true;
            this.btn_exportarEx.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.btn_exportarEx.ImageOptions.Image = global::Pry_Basculas_SAP.Properties.Resources.exporttoxlsx_32x32;
            this.btn_exportarEx.Location = new System.Drawing.Point(12, 12);
            this.btn_exportarEx.Name = "btn_exportarEx";
            this.btn_exportarEx.Size = new System.Drawing.Size(143, 40);
            this.btn_exportarEx.TabIndex = 4;
            this.btn_exportarEx.Text = "Exportar Excel";
            this.btn_exportarEx.Click += new System.EventHandler(this.btn_exportarEx_Click);
            // 
            // grc_ControlReportCerrrado
            // 
            this.grc_ControlReportCerrrado.Location = new System.Drawing.Point(12, 55);
            this.grc_ControlReportCerrrado.MainView = this.grv_VistaReportCerrado;
            this.grc_ControlReportCerrrado.Name = "grc_ControlReportCerrrado";
            this.grc_ControlReportCerrrado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButton_ImprimirFormato});
            this.grc_ControlReportCerrrado.Size = new System.Drawing.Size(1369, 649);
            this.grc_ControlReportCerrrado.TabIndex = 1;
            this.grc_ControlReportCerrrado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_VistaReportCerrado});
            // 
            // grv_VistaReportCerrado
            // 
            this.grv_VistaReportCerrado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.tip_proceso,
            this.t_pesaje,
            this.desc,
            this.doc_comer,
            this.doc_comp,
            this.doc_trans,
            this.gridColumn7,
            this.fecha_proceso,
            this.cd_mate,
            this.desc_mate,
            this.placa,
            this.gridColumn12,
            this.gridColumn1,
            this.conductor,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn2,
            this.gridColumn18,
            this.tiquete,
            this.gridColumn3,
            this.gridColumn16,
            this.gridColumn20,
            this.gridColumn17,
            this.gridColumn21,
            this.gridColumn11,
            this.gridColumn19,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn8,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.print_formato,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn22});
            this.grv_VistaReportCerrado.GridControl = this.grc_ControlReportCerrrado;
            this.grv_VistaReportCerrado.Name = "grv_VistaReportCerrado";
            // 
            // id
            // 
            this.id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.id.AppearanceCell.Options.UseFont = true;
            this.id.Caption = "ID PESAJE";
            this.id.FieldName = "IDPESAJE";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsColumn.AllowFocus = false;
            this.id.OptionsFilter.AllowAutoFilter = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 58;
            // 
            // tip_proceso
            // 
            this.tip_proceso.Caption = "TIPO PROCESO";
            this.tip_proceso.FieldName = "TPROCESO";
            this.tip_proceso.Name = "tip_proceso";
            this.tip_proceso.OptionsColumn.AllowEdit = false;
            this.tip_proceso.OptionsColumn.AllowFocus = false;
            this.tip_proceso.OptionsFilter.AllowAutoFilter = false;
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
            this.desc.VisibleIndex = 1;
            this.desc.Width = 85;
            // 
            // doc_comer
            // 
            this.doc_comer.Caption = "DOC COMERCIAL";
            this.doc_comer.FieldName = "VBELN";
            this.doc_comer.Name = "doc_comer";
            this.doc_comer.OptionsColumn.AllowEdit = false;
            this.doc_comer.OptionsColumn.AllowFocus = false;
            this.doc_comer.OptionsFilter.AllowAutoFilter = false;
            this.doc_comer.OptionsFilter.AllowFilter = false;
            this.doc_comer.Visible = true;
            this.doc_comer.VisibleIndex = 3;
            this.doc_comer.Width = 92;
            // 
            // doc_comp
            // 
            this.doc_comp.Caption = "DOC COMPRA";
            this.doc_comp.FieldName = "EBELN";
            this.doc_comp.Name = "doc_comp";
            this.doc_comp.OptionsColumn.AllowEdit = false;
            this.doc_comp.OptionsColumn.AllowFocus = false;
            this.doc_comp.OptionsFilter.AllowAutoFilter = false;
            this.doc_comp.Visible = true;
            this.doc_comp.VisibleIndex = 4;
            this.doc_comp.Width = 76;
            // 
            // doc_trans
            // 
            this.doc_trans.Caption = "DOC TRANSPORTE";
            this.doc_trans.FieldName = "TKNUM";
            this.doc_trans.Name = "doc_trans";
            this.doc_trans.OptionsColumn.AllowEdit = false;
            this.doc_trans.OptionsColumn.AllowFocus = false;
            this.doc_trans.OptionsFilter.AllowAutoFilter = false;
            this.doc_trans.Visible = true;
            this.doc_trans.VisibleIndex = 5;
            this.doc_trans.Width = 99;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CENTRO LOG";
            this.gridColumn7.FieldName = "WERKS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 72;
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
            this.fecha_proceso.VisibleIndex = 2;
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
            this.cd_mate.VisibleIndex = 7;
            this.cd_mate.Width = 83;
            // 
            // desc_mate
            // 
            this.desc_mate.Caption = "MATERIAL";
            this.desc_mate.FieldName = "MAKT";
            this.desc_mate.Name = "desc_mate";
            this.desc_mate.OptionsColumn.AllowEdit = false;
            this.desc_mate.OptionsColumn.AllowFocus = false;
            this.desc_mate.OptionsFilter.AllowAutoFilter = false;
            this.desc_mate.Visible = true;
            this.desc_mate.VisibleIndex = 8;
            this.desc_mate.Width = 58;
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
            this.placa.VisibleIndex = 9;
            this.placa.Width = 95;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "PLACA TRAILER";
            this.gridColumn12.FieldName = "ADD02";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 10;
            this.gridColumn12.Width = 85;
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
            this.gridColumn1.VisibleIndex = 11;
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
            this.conductor.VisibleIndex = 12;
            this.conductor.Width = 72;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "NIT TRANSPORTISTA";
            this.gridColumn10.FieldName = "NIT_AGENTE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 13;
            this.gridColumn10.Width = 111;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "TRANSPORTISTA";
            this.gridColumn9.FieldName = "AGENTE";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 14;
            this.gridColumn9.Width = 91;
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
            this.gridColumn2.VisibleIndex = 15;
            this.gridColumn2.Width = 53;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "DESCRIPCIÓN BÁSCULA";
            this.gridColumn18.FieldName = "DESC_BASCULA";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.AllowFocus = false;
            this.gridColumn18.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 17;
            this.gridColumn18.Width = 125;
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
            this.tiquete.VisibleIndex = 16;
            this.tiquete.Width = 99;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "TIEMPOS ENTRE CAPTURAS (MIN)";
            this.gridColumn3.FieldName = "tiempo_total_capturas";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 23;
            this.gridColumn3.Width = 173;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "PESAJE 1";
            this.gridColumn16.FieldName = "peso1";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsColumn.AllowFocus = false;
            this.gridColumn16.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 18;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "FECHA-HORA PESAJE 1";
            this.gridColumn20.DisplayFormat.FormatString = "DateTime \"d/MM/yyyy hh:mm tt\"";
            this.gridColumn20.FieldName = "date_capt1";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsColumn.AllowFocus = false;
            this.gridColumn20.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 19;
            this.gridColumn20.Width = 122;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "PESAJE 2";
            this.gridColumn17.FieldName = "peso2";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.OptionsColumn.AllowFocus = false;
            this.gridColumn17.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 20;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "FECHA-HORA PESAJE 2";
            this.gridColumn21.DisplayFormat.FormatString = "DateTime \"d/MM/yyyy hh:mm tt\"";
            this.gridColumn21.FieldName = "date_capt2";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.OptionsColumn.AllowFocus = false;
            this.gridColumn21.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 21;
            this.gridColumn21.Width = 122;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.Caption = "PESO NETO ";
            this.gridColumn11.FieldName = "peso_neto";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 22;
            this.gridColumn11.Width = 67;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "TARA";
            this.gridColumn19.FieldName = "tara";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsColumn.AllowFocus = false;
            this.gridColumn19.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 26;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CONFIRMADO POR";
            this.gridColumn8.FieldName = "usuario_confirmacion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 29;
            this.gridColumn8.Width = 101;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FECHA_CONFIRMACION";
            this.gridColumn4.DisplayFormat.FormatString = "d/MM/yyyy hh:mm tt";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "fecha_confirmacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 24;
            this.gridColumn4.Width = 127;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "CONFIRMA ENVIO A SAP";
            this.gridColumn5.FieldName = "confirma_Receiver_sap";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 25;
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
            this.gridColumn6.VisibleIndex = 30;
            this.gridColumn6.Width = 65;
            // 
            // print_formato
            // 
            this.print_formato.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.print_formato.AppearanceCell.Options.UseFont = true;
            this.print_formato.Caption = "IMPRIMIR TIQUETE";
            this.print_formato.ColumnEdit = this.repositoryItemButton_ImprimirFormato;
            this.print_formato.FieldName = "print";
            this.print_formato.Name = "print_formato";
            this.print_formato.OptionsFilter.AllowAutoFilter = false;
            this.print_formato.OptionsFilter.AllowFilter = false;
            this.print_formato.ToolTip = "imprimir formato de salida.";
            this.print_formato.Width = 109;
            // 
            // repositoryItemButton_ImprimirFormato
            // 
            this.repositoryItemButton_ImprimirFormato.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Pry_Basculas_SAP.Properties.Resources.report_32x32;
            this.repositoryItemButton_ImprimirFormato.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButton_ImprimirFormato.Name = "repositoryItemButton_ImprimirFormato";
            this.repositoryItemButton_ImprimirFormato.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "NUEVO TRANSPORTISTA";
            this.gridColumn13.FieldName = "AGENTE_NUEVO";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.AllowFocus = false;
            this.gridColumn13.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 31;
            this.gridColumn13.Width = 128;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "NUEVO NIT TRANSPORTISTA";
            this.gridColumn14.FieldName = "NIT_AGENTE_NUEVO";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 32;
            this.gridColumn14.Width = 148;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "FECHA CAMBIO TRANSPORTISTA";
            this.gridColumn15.FieldName = "FECHA_CAMBIO_AGENTE";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.AllowFocus = false;
            this.gridColumn15.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn15.OptionsFilter.AllowFilter = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 33;
            this.gridColumn15.Width = 170;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "OBSERVACIONES";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 34;
            this.gridColumn22.Width = 92;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "PESO BRUTO";
            this.gridColumn23.FieldName = "peso_bruto";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.OptionsColumn.AllowFocus = false;
            this.gridColumn23.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 27;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "KILOGRAMOS - LITROS";
            this.gridColumn24.FieldName = "kilogramos_a_litros";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.OptionsColumn.AllowFocus = false;
            this.gridColumn24.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 28;
            this.gridColumn24.Width = 120;
            // 
            // frm_Report_Reportes_cerrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 738);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.LargeImage = global::Pry_Basculas_SAP.Properties.Resources.boreport2_32x321;
            this.Name = "frm_Report_Reportes_cerrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE PROCESOS CERRADOS";
            this.Load += new System.EventHandler(this.frm_Report_Reportes_cerrados_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grc_ControlReportCerrrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_VistaReportCerrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButton_ImprimirFormato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.GridControl grc_ControlReportCerrrado;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_VistaReportCerrado;
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
        private DevExpress.XtraGrid.Columns.GridColumn print_formato;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButton_ImprimirFormato;
        private DevExpress.XtraGrid.Columns.GridColumn doc_comer;
        private DevExpress.XtraGrid.Columns.GridColumn doc_comp;
        private DevExpress.XtraGrid.Columns.GridColumn doc_trans;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.SimpleButton btn_exportarEx;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
    }
}
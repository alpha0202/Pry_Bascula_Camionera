
namespace Pry_Basculas_SAP
{
    partial class frmVista_PesajesActivos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVista_PesajesActivos));
            this.gcPesajesActivosSAP = new DevExpress.XtraGrid.GridControl();
            this.gvVista_ListadoActivo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.material_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.placa_cabezote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.centro_logistico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiquete_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_capt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_capt2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiempo_total_capturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso_neto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccionPesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEjecutarPesaje = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.AccionConfirmar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonConfirmar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEndForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsultarPlaca = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDatosUser = new DevExpress.XtraEditors.PanelControl();
            this.lblGetBascula = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblGetUsuario = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcPesajesActivosSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVista_ListadoActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEjecutarPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatosUser)).BeginInit();
            this.pnlDatosUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcPesajesActivosSAP
            // 
            this.gcPesajesActivosSAP.Location = new System.Drawing.Point(12, 133);
            this.gcPesajesActivosSAP.MainView = this.gvVista_ListadoActivo;
            this.gcPesajesActivosSAP.Name = "gcPesajesActivosSAP";
            this.gcPesajesActivosSAP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEjecutarPesaje,
            this.repositoryItemButtonConfirmar});
            this.gcPesajesActivosSAP.Size = new System.Drawing.Size(1758, 549);
            this.gcPesajesActivosSAP.TabIndex = 0;
            this.gcPesajesActivosSAP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVista_ListadoActivo});
            // 
            // gvVista_ListadoActivo
            // 
            this.gvVista_ListadoActivo.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvVista_ListadoActivo.Appearance.Row.Options.UseFont = true;
            this.gvVista_ListadoActivo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gvVista_ListadoActivo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_pesaje,
            this.proceso,
            this.fecha_proceso,
            this.material_sap,
            this.placa_cabezote,
            this.conductor,
            this.centro_logistico,
            this.almacen,
            this.tiquete_bascula,
            this.peso1,
            this.date_capt1,
            this.peso2,
            this.date_capt2,
            this.tiempo_total_capturas,
            this.peso_neto,
            this.AccionPesaje,
            this.AccionConfirmar,
            this.ESTADO,
            this.estado_proceso});
            this.gvVista_ListadoActivo.GridControl = this.gcPesajesActivosSAP;
            this.gvVista_ListadoActivo.GroupCount = 1;
            this.gvVista_ListadoActivo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "estado", null, "")});
            this.gvVista_ListadoActivo.Name = "gvVista_ListadoActivo";
            this.gvVista_ListadoActivo.OptionsSelection.MultiSelect = true;
            this.gvVista_ListadoActivo.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvVista_ListadoActivo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ESTADO, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvVista_ListadoActivo.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvVista_ListadoActivo_RowStyle);
            this.gvVista_ListadoActivo.DoubleClick += new System.EventHandler(this.gvVista_ListadoActivo_DoubleClick);
            // 
            // id_pesaje
            // 
            this.id_pesaje.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pesaje.AppearanceCell.Options.UseFont = true;
            this.id_pesaje.AppearanceCell.Options.UseTextOptions = true;
            this.id_pesaje.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_pesaje.AppearanceHeader.Options.UseTextOptions = true;
            this.id_pesaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id_pesaje.Caption = "ID_PESAJE";
            this.id_pesaje.FieldName = "id_pesaje";
            this.id_pesaje.Name = "id_pesaje";
            this.id_pesaje.OptionsColumn.AllowEdit = false;
            this.id_pesaje.Visible = true;
            this.id_pesaje.VisibleIndex = 0;
            this.id_pesaje.Width = 89;
            // 
            // proceso
            // 
            this.proceso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceso.AppearanceCell.Options.UseFont = true;
            this.proceso.Caption = "TIPO_PROCESO";
            this.proceso.FieldName = "proceso";
            this.proceso.Name = "proceso";
            this.proceso.OptionsColumn.AllowEdit = false;
            this.proceso.Visible = true;
            this.proceso.VisibleIndex = 1;
            // 
            // fecha_proceso
            // 
            this.fecha_proceso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_proceso.AppearanceCell.Options.UseFont = true;
            this.fecha_proceso.AppearanceCell.Options.UseTextOptions = true;
            this.fecha_proceso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_proceso.AppearanceHeader.Options.UseTextOptions = true;
            this.fecha_proceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_proceso.Caption = "FECHA_PROCESO";
            this.fecha_proceso.DisplayFormat.FormatString = "d-M-yyyy";
            this.fecha_proceso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fecha_proceso.FieldName = "fecha_proceso";
            this.fecha_proceso.Name = "fecha_proceso";
            this.fecha_proceso.OptionsColumn.AllowEdit = false;
            this.fecha_proceso.Visible = true;
            this.fecha_proceso.VisibleIndex = 2;
            this.fecha_proceso.Width = 89;
            // 
            // material_sap
            // 
            this.material_sap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material_sap.AppearanceCell.Options.UseFont = true;
            this.material_sap.AppearanceHeader.Options.UseTextOptions = true;
            this.material_sap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.material_sap.Caption = "MATERIAL_SAP";
            this.material_sap.FieldName = "material_sap";
            this.material_sap.Name = "material_sap";
            this.material_sap.OptionsColumn.AllowEdit = false;
            this.material_sap.Visible = true;
            this.material_sap.VisibleIndex = 3;
            this.material_sap.Width = 89;
            // 
            // placa_cabezote
            // 
            this.placa_cabezote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_cabezote.AppearanceCell.Options.UseFont = true;
            this.placa_cabezote.AppearanceHeader.Options.UseTextOptions = true;
            this.placa_cabezote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.placa_cabezote.Caption = "PLACA_CABEZOTE";
            this.placa_cabezote.FieldName = "placa_cabezote";
            this.placa_cabezote.Name = "placa_cabezote";
            this.placa_cabezote.OptionsColumn.AllowEdit = false;
            this.placa_cabezote.Visible = true;
            this.placa_cabezote.VisibleIndex = 4;
            this.placa_cabezote.Width = 89;
            // 
            // conductor
            // 
            this.conductor.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductor.AppearanceCell.Options.UseFont = true;
            this.conductor.AppearanceCell.Options.UseTextOptions = true;
            this.conductor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.conductor.AppearanceHeader.Options.UseTextOptions = true;
            this.conductor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.conductor.Caption = "CONDUCTOR";
            this.conductor.FieldName = "conductor";
            this.conductor.Name = "conductor";
            this.conductor.OptionsColumn.AllowEdit = false;
            this.conductor.Visible = true;
            this.conductor.VisibleIndex = 5;
            this.conductor.Width = 62;
            // 
            // centro_logistico
            // 
            this.centro_logistico.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centro_logistico.AppearanceCell.Options.UseFont = true;
            this.centro_logistico.AppearanceCell.Options.UseTextOptions = true;
            this.centro_logistico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.centro_logistico.AppearanceHeader.Options.UseTextOptions = true;
            this.centro_logistico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.centro_logistico.Caption = "CENTRO_LOGISTICO";
            this.centro_logistico.FieldName = "centro_logistico";
            this.centro_logistico.Name = "centro_logistico";
            this.centro_logistico.OptionsColumn.AllowEdit = false;
            this.centro_logistico.Visible = true;
            this.centro_logistico.VisibleIndex = 6;
            this.centro_logistico.Width = 96;
            // 
            // almacen
            // 
            this.almacen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacen.AppearanceCell.Options.UseFont = true;
            this.almacen.AppearanceCell.Options.UseTextOptions = true;
            this.almacen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.almacen.AppearanceHeader.Options.UseTextOptions = true;
            this.almacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.almacen.Caption = "ALMACEN";
            this.almacen.FieldName = "almacen";
            this.almacen.Name = "almacen";
            this.almacen.OptionsColumn.AllowEdit = false;
            this.almacen.Visible = true;
            this.almacen.VisibleIndex = 7;
            this.almacen.Width = 79;
            // 
            // tiquete_bascula
            // 
            this.tiquete_bascula.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiquete_bascula.AppearanceCell.Options.UseFont = true;
            this.tiquete_bascula.AppearanceHeader.Options.UseTextOptions = true;
            this.tiquete_bascula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tiquete_bascula.Caption = "TIQUETE_BASCULA";
            this.tiquete_bascula.FieldName = "tiquete_bascula";
            this.tiquete_bascula.Name = "tiquete_bascula";
            this.tiquete_bascula.OptionsColumn.AllowEdit = false;
            this.tiquete_bascula.Visible = true;
            this.tiquete_bascula.VisibleIndex = 8;
            this.tiquete_bascula.Width = 74;
            // 
            // peso1
            // 
            this.peso1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso1.AppearanceCell.Options.UseFont = true;
            this.peso1.AppearanceCell.Options.UseTextOptions = true;
            this.peso1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.peso1.AppearanceHeader.Options.UseTextOptions = true;
            this.peso1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.peso1.Caption = "PESO 1";
            this.peso1.DisplayFormat.FormatString = "0.00";
            this.peso1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.peso1.FieldName = "peso1";
            this.peso1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.peso1.Name = "peso1";
            this.peso1.OptionsColumn.AllowEdit = false;
            this.peso1.Visible = true;
            this.peso1.VisibleIndex = 9;
            this.peso1.Width = 76;
            // 
            // date_capt1
            // 
            this.date_capt1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_capt1.AppearanceCell.Options.UseFont = true;
            this.date_capt1.AppearanceCell.Options.UseTextOptions = true;
            this.date_capt1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_capt1.Caption = "FECHA_CAPTURA 1";
            this.date_capt1.FieldName = "date_capt1";
            this.date_capt1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.date_capt1.Name = "date_capt1";
            this.date_capt1.OptionsColumn.AllowEdit = false;
            this.date_capt1.OptionsColumn.AllowFocus = false;
            this.date_capt1.OptionsFilter.AllowAutoFilter = false;
            this.date_capt1.OptionsFilter.AllowFilter = false;
            this.date_capt1.Visible = true;
            this.date_capt1.VisibleIndex = 10;
            this.date_capt1.Width = 101;
            // 
            // peso2
            // 
            this.peso2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso2.AppearanceCell.Options.UseFont = true;
            this.peso2.AppearanceCell.Options.UseTextOptions = true;
            this.peso2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.peso2.AppearanceHeader.Options.UseTextOptions = true;
            this.peso2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.peso2.Caption = "PESO 2";
            this.peso2.FieldName = "peso2";
            this.peso2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.peso2.Name = "peso2";
            this.peso2.OptionsColumn.AllowEdit = false;
            this.peso2.Visible = true;
            this.peso2.VisibleIndex = 11;
            this.peso2.Width = 78;
            // 
            // date_capt2
            // 
            this.date_capt2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_capt2.AppearanceCell.Options.UseFont = true;
            this.date_capt2.AppearanceCell.Options.UseTextOptions = true;
            this.date_capt2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.date_capt2.Caption = "FECHA_CAPTURA 2";
            this.date_capt2.DisplayFormat.FormatString = "d";
            this.date_capt2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_capt2.FieldName = "date_capt2";
            this.date_capt2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.date_capt2.Name = "date_capt2";
            this.date_capt2.OptionsColumn.AllowEdit = false;
            this.date_capt2.OptionsColumn.AllowFocus = false;
            this.date_capt2.OptionsFilter.AllowAutoFilter = false;
            this.date_capt2.OptionsFilter.AllowFilter = false;
            this.date_capt2.Visible = true;
            this.date_capt2.VisibleIndex = 12;
            this.date_capt2.Width = 84;
            // 
            // tiempo_total_capturas
            // 
            this.tiempo_total_capturas.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_total_capturas.AppearanceCell.Options.UseFont = true;
            this.tiempo_total_capturas.AppearanceCell.Options.UseTextOptions = true;
            this.tiempo_total_capturas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tiempo_total_capturas.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tiempo_total_capturas.AppearanceHeader.Options.UseFont = true;
            this.tiempo_total_capturas.Caption = "TIEMPO_CAPTURA(MIN)";
            this.tiempo_total_capturas.DisplayFormat.FormatString = "0";
            this.tiempo_total_capturas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tiempo_total_capturas.FieldName = "tiempo_total_capturas";
            this.tiempo_total_capturas.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.tiempo_total_capturas.Name = "tiempo_total_capturas";
            this.tiempo_total_capturas.OptionsColumn.AllowEdit = false;
            this.tiempo_total_capturas.OptionsColumn.AllowFocus = false;
            this.tiempo_total_capturas.OptionsFilter.AllowAutoFilter = false;
            this.tiempo_total_capturas.OptionsFilter.AllowFilter = false;
            this.tiempo_total_capturas.Visible = true;
            this.tiempo_total_capturas.VisibleIndex = 14;
            this.tiempo_total_capturas.Width = 76;
            // 
            // peso_neto
            // 
            this.peso_neto.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso_neto.AppearanceCell.Options.UseFont = true;
            this.peso_neto.AppearanceCell.Options.UseTextOptions = true;
            this.peso_neto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.peso_neto.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.peso_neto.AppearanceHeader.Options.UseFont = true;
            this.peso_neto.AppearanceHeader.Options.UseTextOptions = true;
            this.peso_neto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.peso_neto.Caption = "PESO_NETO";
            this.peso_neto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.peso_neto.FieldName = "peso_neto";
            this.peso_neto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.peso_neto.Name = "peso_neto";
            this.peso_neto.OptionsFilter.AllowAutoFilter = false;
            this.peso_neto.OptionsFilter.AllowFilter = false;
            this.peso_neto.Visible = true;
            this.peso_neto.VisibleIndex = 13;
            this.peso_neto.Width = 78;
            // 
            // AccionPesaje
            // 
            this.AccionPesaje.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccionPesaje.AppearanceCell.Options.UseFont = true;
            this.AccionPesaje.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.AccionPesaje.AppearanceHeader.Options.UseFont = true;
            this.AccionPesaje.AppearanceHeader.Options.UseForeColor = true;
            this.AccionPesaje.AppearanceHeader.Options.UseTextOptions = true;
            this.AccionPesaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccionPesaje.Caption = "REALIZAR PESAJE";
            this.AccionPesaje.ColumnEdit = this.repositoryItemButtonEjecutarPesaje;
            this.AccionPesaje.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.AccionPesaje.Name = "AccionPesaje";
            this.AccionPesaje.OptionsFilter.AllowAutoFilter = false;
            this.AccionPesaje.OptionsFilter.AllowFilter = false;
            this.AccionPesaje.Visible = true;
            this.AccionPesaje.VisibleIndex = 15;
            this.AccionPesaje.Width = 78;
            // 
            // repositoryItemButtonEjecutarPesaje
            // 
            this.repositoryItemButtonEjecutarPesaje.AutoHeight = false;
            editorButtonImageOptions1.Image = global::Pry_Basculas_SAP.Properties.Resources.weightedpies_32x32;
            this.repositoryItemButtonEjecutarPesaje.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEjecutarPesaje.Name = "repositoryItemButtonEjecutarPesaje";
            this.repositoryItemButtonEjecutarPesaje.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEjecutarPesaje.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEjecutarPesaje_ButtonClick);
            // 
            // AccionConfirmar
            // 
            this.AccionConfirmar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccionConfirmar.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccionConfirmar.AppearanceHeader.Options.UseBackColor = true;
            this.AccionConfirmar.AppearanceHeader.Options.UseFont = true;
            this.AccionConfirmar.AppearanceHeader.Options.UseForeColor = true;
            this.AccionConfirmar.Caption = "CONFIRMAR";
            this.AccionConfirmar.ColumnEdit = this.repositoryItemButtonConfirmar;
            this.AccionConfirmar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.AccionConfirmar.Name = "AccionConfirmar";
            this.AccionConfirmar.Visible = true;
            this.AccionConfirmar.VisibleIndex = 16;
            this.AccionConfirmar.Width = 93;
            // 
            // repositoryItemButtonConfirmar
            // 
            this.repositoryItemButtonConfirmar.AutoHeight = false;
            editorButtonImageOptions2.Image = global::Pry_Basculas_SAP.Properties.Resources.apply_32x32;
            this.repositoryItemButtonConfirmar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonConfirmar.Name = "repositoryItemButtonConfirmar";
            this.repositoryItemButtonConfirmar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonConfirmar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonConfirmar_ButtonClick);
            // 
            // ESTADO
            // 
            this.ESTADO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO.AppearanceCell.Options.UseFont = true;
            this.ESTADO.Caption = "ESTADO";
            this.ESTADO.FieldName = "estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Visible = true;
            this.ESTADO.VisibleIndex = 17;
            // 
            // estado_proceso
            // 
            this.estado_proceso.Caption = "state";
            this.estado_proceso.FieldName = "estado";
            this.estado_proceso.Name = "estado_proceso";
            this.estado_proceso.OptionsColumn.AllowEdit = false;
            this.estado_proceso.OptionsColumn.AllowFocus = false;
            this.estado_proceso.OptionsFilter.AllowAutoFilter = false;
            this.estado_proceso.OptionsFilter.AllowFilter = false;
            // 
            // btnEndForm
            // 
            this.btnEndForm.ImageOptions.Image = global::Pry_Basculas_SAP.Properties.Resources.forward_32x321;
            this.btnEndForm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEndForm.ImageOptions.ImageToTextIndent = -15;
            this.btnEndForm.Location = new System.Drawing.Point(1648, 688);
            this.btnEndForm.Name = "btnEndForm";
            this.btnEndForm.Size = new System.Drawing.Size(122, 52);
            this.btnEndForm.TabIndex = 1;
            this.btnEndForm.Text = "Terminar";
            this.btnEndForm.Click += new System.EventHandler(this.btnEndForm_Click);
            // 
            // btnConsultarPlaca
            // 
            this.btnConsultarPlaca.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPlaca.Appearance.Options.UseFont = true;
            this.btnConsultarPlaca.Location = new System.Drawing.Point(12, 688);
            this.btnConsultarPlaca.Name = "btnConsultarPlaca";
            this.btnConsultarPlaca.Size = new System.Drawing.Size(122, 52);
            this.btnConsultarPlaca.TabIndex = 2;
            this.btnConsultarPlaca.Text = "Consultar Placa ";
            this.btnConsultarPlaca.Click += new System.EventHandler(this.btnConsultarPlaca_Click);
            // 
            // pnlDatosUser
            // 
            this.pnlDatosUser.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlDatosUser.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.pnlDatosUser.Appearance.Options.UseBackColor = true;
            this.pnlDatosUser.Appearance.Options.UseBorderColor = true;
            this.pnlDatosUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDatosUser.Controls.Add(this.lblGetBascula);
            this.pnlDatosUser.Controls.Add(this.labelControl3);
            this.pnlDatosUser.Controls.Add(this.lblGetUsuario);
            this.pnlDatosUser.Controls.Add(this.labelControl1);
            this.pnlDatosUser.Location = new System.Drawing.Point(12, 48);
            this.pnlDatosUser.Name = "pnlDatosUser";
            this.pnlDatosUser.Size = new System.Drawing.Size(573, 49);
            this.pnlDatosUser.TabIndex = 3;
            // 
            // lblGetBascula
            // 
            this.lblGetBascula.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetBascula.Appearance.Options.UseFont = true;
            this.lblGetBascula.Location = new System.Drawing.Point(339, 17);
            this.lblGetBascula.Name = "lblGetBascula";
            this.lblGetBascula.Size = new System.Drawing.Size(16, 14);
            this.lblGetBascula.TabIndex = 3;
            this.lblGetBascula.Text = "**";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(278, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "BASCULA:";
            // 
            // lblGetUsuario
            // 
            this.lblGetUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetUsuario.Appearance.Options.UseFont = true;
            this.lblGetUsuario.Location = new System.Drawing.Point(94, 17);
            this.lblGetUsuario.Name = "lblGetUsuario";
            this.lblGetUsuario.Size = new System.Drawing.Size(16, 14);
            this.lblGetUsuario.TabIndex = 1;
            this.lblGetUsuario.Text = "**";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "USUARIO: ";
            // 
            // frmVista_PesajesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 806);
            this.Controls.Add(this.pnlDatosUser);
            this.Controls.Add(this.btnConsultarPlaca);
            this.Controls.Add(this.btnEndForm);
            this.Controls.Add(this.gcPesajesActivosSAP);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmVista_PesajesActivos.IconOptions.LargeImage")));
            this.Name = "frmVista_PesajesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO PESAJES ACTIVOS EN SAP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVista_PesajesActivos_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPesajesActivosSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVista_ListadoActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEjecutarPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatosUser)).EndInit();
            this.pnlDatosUser.ResumeLayout(false);
            this.pnlDatosUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPesajesActivosSAP;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEjecutarPesaje;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVista_ListadoActivo;
        private DevExpress.XtraGrid.Columns.GridColumn id_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn material_sap;
        private DevExpress.XtraGrid.Columns.GridColumn placa_cabezote;
        private DevExpress.XtraGrid.Columns.GridColumn conductor;
        private DevExpress.XtraGrid.Columns.GridColumn centro_logistico;
        private DevExpress.XtraGrid.Columns.GridColumn almacen;
        private DevExpress.XtraGrid.Columns.GridColumn AccionPesaje;
        private DevExpress.XtraGrid.Columns.GridColumn tiquete_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn peso1;
        private DevExpress.XtraGrid.Columns.GridColumn peso2;
        private DevExpress.XtraGrid.Columns.GridColumn AccionConfirmar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonConfirmar;
        private DevExpress.XtraGrid.Columns.GridColumn peso_neto;
        private DevExpress.XtraEditors.SimpleButton btnEndForm;
        private DevExpress.XtraEditors.SimpleButton btnConsultarPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn date_capt1;
        private DevExpress.XtraGrid.Columns.GridColumn date_capt2;
        private DevExpress.XtraGrid.Columns.GridColumn tiempo_total_capturas;
        private DevExpress.XtraEditors.PanelControl pnlDatosUser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblGetUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn proceso;
        private DevExpress.XtraEditors.LabelControl lblGetBascula;
        private DevExpress.XtraGrid.Columns.GridColumn ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn estado_proceso;
    }
}



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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVista_PesajesActivos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcPesajesActivosSAP = new DevExpress.XtraGrid.GridControl();
            this.gvVista_ListadoActivo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado_cons_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pedido_traslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.doc_transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ent_salida_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.material_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.placa_cabezote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plac_trailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_carga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.centro_logistico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.num_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad_umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad_ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cant_pesada_real_umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cant_pesada_real_ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lote_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiquete_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.peso_neto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user_pesaje1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user_pesaje2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccionPesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEjecutarPesaje = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.AccionConfirmar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonConfirmar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEndForm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcPesajesActivosSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVista_ListadoActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEjecutarPesaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPesajesActivosSAP
            // 
            this.gcPesajesActivosSAP.Location = new System.Drawing.Point(12, 23);
            this.gcPesajesActivosSAP.MainView = this.gvVista_ListadoActivo;
            this.gcPesajesActivosSAP.Name = "gcPesajesActivosSAP";
            this.gcPesajesActivosSAP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEjecutarPesaje,
            this.repositoryItemButtonConfirmar});
            this.gcPesajesActivosSAP.Size = new System.Drawing.Size(1810, 492);
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
            this.estado_cons_servicio,
            this.tipo_proceso,
            this.tipo_pesaje,
            this.fecha_proceso,
            this.doc_comercial,
            this.pedido_traslado,
            this.doc_transporte,
            this.ent_salida_sap,
            this.material_sap,
            this.placa_cabezote,
            this.plac_trailer,
            this.fecha_carga,
            this.conductor,
            this.centro_logistico,
            this.num_bascula,
            this.cantidad_umb,
            this.umb,
            this.cantidad_ump,
            this.ump,
            this.cant_pesada_real_umb,
            this.cant_pesada_real_ump,
            this.lote_sap,
            this.almacen,
            this.tiquete_bascula,
            this.peso1,
            this.peso2,
            this.peso_neto,
            this.user_pesaje1,
            this.user_pesaje2,
            this.AccionPesaje,
            this.AccionConfirmar});
            this.gvVista_ListadoActivo.GridControl = this.gcPesajesActivosSAP;
            this.gvVista_ListadoActivo.Name = "gvVista_ListadoActivo";
            this.gvVista_ListadoActivo.OptionsSelection.MultiSelect = true;
            this.gvVista_ListadoActivo.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvVista_ListadoActivo.OptionsView.ShowGroupPanel = false;
            // 
            // id_pesaje
            // 
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
            this.id_pesaje.Width = 65;
            // 
            // estado_cons_servicio
            // 
            this.estado_cons_servicio.AppearanceCell.Options.UseTextOptions = true;
            this.estado_cons_servicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.estado_cons_servicio.AppearanceHeader.Options.UseTextOptions = true;
            this.estado_cons_servicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.estado_cons_servicio.Caption = "ESTADO_CONSUMO";
            this.estado_cons_servicio.FieldName = "estado_consumo_servicio";
            this.estado_cons_servicio.Name = "estado_cons_servicio";
            this.estado_cons_servicio.OptionsColumn.AllowEdit = false;
            this.estado_cons_servicio.Visible = true;
            this.estado_cons_servicio.VisibleIndex = 1;
            this.estado_cons_servicio.Width = 100;
            // 
            // tipo_proceso
            // 
            this.tipo_proceso.AppearanceCell.Options.UseTextOptions = true;
            this.tipo_proceso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tipo_proceso.AppearanceHeader.Options.UseTextOptions = true;
            this.tipo_proceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tipo_proceso.Caption = "TIPO_PROCESO";
            this.tipo_proceso.FieldName = "tipo_proceso";
            this.tipo_proceso.Name = "tipo_proceso";
            this.tipo_proceso.OptionsColumn.AllowEdit = false;
            this.tipo_proceso.Visible = true;
            this.tipo_proceso.VisibleIndex = 2;
            this.tipo_proceso.Width = 65;
            // 
            // tipo_pesaje
            // 
            this.tipo_pesaje.AppearanceCell.Options.UseTextOptions = true;
            this.tipo_pesaje.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tipo_pesaje.AppearanceHeader.Options.UseTextOptions = true;
            this.tipo_pesaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tipo_pesaje.Caption = "TIPO_PESAJE";
            this.tipo_pesaje.FieldName = "tipo_pesaje";
            this.tipo_pesaje.Name = "tipo_pesaje";
            this.tipo_pesaje.OptionsColumn.AllowEdit = false;
            this.tipo_pesaje.Visible = true;
            this.tipo_pesaje.VisibleIndex = 3;
            this.tipo_pesaje.Width = 65;
            // 
            // fecha_proceso
            // 
            this.fecha_proceso.AppearanceCell.Options.UseTextOptions = true;
            this.fecha_proceso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_proceso.AppearanceHeader.Options.UseTextOptions = true;
            this.fecha_proceso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_proceso.Caption = "FECHA_PROCESO";
            this.fecha_proceso.DisplayFormat.FormatString = "d/M/yyyy";
            this.fecha_proceso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fecha_proceso.FieldName = "fecha_proceso";
            this.fecha_proceso.Name = "fecha_proceso";
            this.fecha_proceso.OptionsColumn.AllowEdit = false;
            this.fecha_proceso.Visible = true;
            this.fecha_proceso.VisibleIndex = 4;
            this.fecha_proceso.Width = 65;
            // 
            // doc_comercial
            // 
            this.doc_comercial.AppearanceHeader.Options.UseTextOptions = true;
            this.doc_comercial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.doc_comercial.Caption = "DOC_COMERCIAL";
            this.doc_comercial.FieldName = "doc_comercial";
            this.doc_comercial.Name = "doc_comercial";
            this.doc_comercial.OptionsColumn.AllowEdit = false;
            this.doc_comercial.Visible = true;
            this.doc_comercial.VisibleIndex = 5;
            this.doc_comercial.Width = 65;
            // 
            // pedido_traslado
            // 
            this.pedido_traslado.AppearanceHeader.Options.UseTextOptions = true;
            this.pedido_traslado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pedido_traslado.Caption = "PEDIDO_TRASLADO";
            this.pedido_traslado.FieldName = "pedido_traslado";
            this.pedido_traslado.Name = "pedido_traslado";
            this.pedido_traslado.OptionsColumn.AllowEdit = false;
            this.pedido_traslado.Visible = true;
            this.pedido_traslado.VisibleIndex = 6;
            this.pedido_traslado.Width = 65;
            // 
            // doc_transporte
            // 
            this.doc_transporte.Caption = "DOC_TRANSPORTE";
            this.doc_transporte.FieldName = "doc_transporte";
            this.doc_transporte.Name = "doc_transporte";
            this.doc_transporte.OptionsColumn.AllowEdit = false;
            this.doc_transporte.Visible = true;
            this.doc_transporte.VisibleIndex = 7;
            this.doc_transporte.Width = 65;
            // 
            // ent_salida_sap
            // 
            this.ent_salida_sap.Caption = "ENT_SALIDA_SAP";
            this.ent_salida_sap.FieldName = "ent_salida_sap";
            this.ent_salida_sap.Name = "ent_salida_sap";
            this.ent_salida_sap.OptionsColumn.AllowEdit = false;
            this.ent_salida_sap.Visible = true;
            this.ent_salida_sap.VisibleIndex = 8;
            this.ent_salida_sap.Width = 65;
            // 
            // material_sap
            // 
            this.material_sap.AppearanceHeader.Options.UseTextOptions = true;
            this.material_sap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.material_sap.Caption = "MATERIAL_SAP";
            this.material_sap.FieldName = "material_sap";
            this.material_sap.Name = "material_sap";
            this.material_sap.OptionsColumn.AllowEdit = false;
            this.material_sap.Visible = true;
            this.material_sap.VisibleIndex = 9;
            this.material_sap.Width = 65;
            // 
            // placa_cabezote
            // 
            this.placa_cabezote.AppearanceHeader.Options.UseTextOptions = true;
            this.placa_cabezote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.placa_cabezote.Caption = "PLACA_CABEZOTE";
            this.placa_cabezote.FieldName = "placa_cabezote";
            this.placa_cabezote.Name = "placa_cabezote";
            this.placa_cabezote.OptionsColumn.AllowEdit = false;
            this.placa_cabezote.Visible = true;
            this.placa_cabezote.VisibleIndex = 10;
            this.placa_cabezote.Width = 65;
            // 
            // plac_trailer
            // 
            this.plac_trailer.AppearanceHeader.Options.UseTextOptions = true;
            this.plac_trailer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.plac_trailer.Caption = "PLACA_TRAILER";
            this.plac_trailer.FieldName = "plac_trailer";
            this.plac_trailer.Name = "plac_trailer";
            this.plac_trailer.OptionsColumn.AllowEdit = false;
            this.plac_trailer.Visible = true;
            this.plac_trailer.VisibleIndex = 11;
            this.plac_trailer.Width = 65;
            // 
            // fecha_carga
            // 
            this.fecha_carga.AppearanceCell.Options.UseTextOptions = true;
            this.fecha_carga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_carga.AppearanceHeader.Options.UseTextOptions = true;
            this.fecha_carga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fecha_carga.Caption = "FECHA_CARGA";
            this.fecha_carga.DisplayFormat.FormatString = "d/M/yyyy";
            this.fecha_carga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fecha_carga.FieldName = "fecha_carga";
            this.fecha_carga.Name = "fecha_carga";
            this.fecha_carga.OptionsColumn.AllowEdit = false;
            this.fecha_carga.Visible = true;
            this.fecha_carga.VisibleIndex = 12;
            this.fecha_carga.Width = 65;
            // 
            // conductor
            // 
            this.conductor.AppearanceCell.Options.UseTextOptions = true;
            this.conductor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.conductor.AppearanceHeader.Options.UseTextOptions = true;
            this.conductor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.conductor.Caption = "CONDUCTOR";
            this.conductor.FieldName = "conductor";
            this.conductor.Name = "conductor";
            this.conductor.OptionsColumn.AllowEdit = false;
            this.conductor.Visible = true;
            this.conductor.VisibleIndex = 13;
            this.conductor.Width = 65;
            // 
            // centro_logistico
            // 
            this.centro_logistico.AppearanceHeader.Options.UseTextOptions = true;
            this.centro_logistico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.centro_logistico.Caption = "CENTRO_LOGISTICO";
            this.centro_logistico.FieldName = "centro_logistico";
            this.centro_logistico.Name = "centro_logistico";
            this.centro_logistico.OptionsColumn.AllowEdit = false;
            this.centro_logistico.Visible = true;
            this.centro_logistico.VisibleIndex = 14;
            this.centro_logistico.Width = 65;
            // 
            // num_bascula
            // 
            this.num_bascula.AppearanceHeader.Options.UseTextOptions = true;
            this.num_bascula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.num_bascula.Caption = "NUMERO_BASCULA";
            this.num_bascula.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.num_bascula.FieldName = "num_bascula";
            this.num_bascula.Name = "num_bascula";
            this.num_bascula.OptionsColumn.AllowEdit = false;
            this.num_bascula.Visible = true;
            this.num_bascula.VisibleIndex = 15;
            this.num_bascula.Width = 65;
            // 
            // cantidad_umb
            // 
            this.cantidad_umb.AppearanceHeader.Options.UseTextOptions = true;
            this.cantidad_umb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cantidad_umb.Caption = "CANTIDAD_UMB";
            this.cantidad_umb.DisplayFormat.FormatString = "\"0.00\"";
            this.cantidad_umb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidad_umb.FieldName = "cantidad_umb";
            this.cantidad_umb.Name = "cantidad_umb";
            this.cantidad_umb.OptionsColumn.AllowEdit = false;
            this.cantidad_umb.Visible = true;
            this.cantidad_umb.VisibleIndex = 16;
            this.cantidad_umb.Width = 65;
            // 
            // umb
            // 
            this.umb.AppearanceCell.Options.UseTextOptions = true;
            this.umb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.umb.AppearanceHeader.Options.UseTextOptions = true;
            this.umb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.umb.Caption = "UMB";
            this.umb.FieldName = "umb";
            this.umb.Name = "umb";
            this.umb.OptionsColumn.AllowEdit = false;
            this.umb.Visible = true;
            this.umb.VisibleIndex = 17;
            this.umb.Width = 65;
            // 
            // cantidad_ump
            // 
            this.cantidad_ump.AppearanceHeader.Options.UseTextOptions = true;
            this.cantidad_ump.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cantidad_ump.Caption = "CANTIDAD_UMP";
            this.cantidad_ump.DisplayFormat.FormatString = "\"0.00\"";
            this.cantidad_ump.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidad_ump.FieldName = "cantidad_ump";
            this.cantidad_ump.Name = "cantidad_ump";
            this.cantidad_ump.OptionsColumn.AllowEdit = false;
            this.cantidad_ump.Visible = true;
            this.cantidad_ump.VisibleIndex = 18;
            this.cantidad_ump.Width = 65;
            // 
            // ump
            // 
            this.ump.AppearanceCell.Options.UseTextOptions = true;
            this.ump.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ump.AppearanceHeader.Options.UseTextOptions = true;
            this.ump.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ump.Caption = "UMP";
            this.ump.FieldName = "ump";
            this.ump.Name = "ump";
            this.ump.OptionsColumn.AllowEdit = false;
            this.ump.Visible = true;
            this.ump.VisibleIndex = 19;
            this.ump.Width = 65;
            // 
            // cant_pesada_real_umb
            // 
            this.cant_pesada_real_umb.AppearanceCell.Options.UseTextOptions = true;
            this.cant_pesada_real_umb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cant_pesada_real_umb.AppearanceHeader.Options.UseTextOptions = true;
            this.cant_pesada_real_umb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cant_pesada_real_umb.Caption = "CANTIDAD_PESADA_REAL_UMB";
            this.cant_pesada_real_umb.FieldName = "cant_pesada_real_umb";
            this.cant_pesada_real_umb.Name = "cant_pesada_real_umb";
            this.cant_pesada_real_umb.OptionsColumn.AllowEdit = false;
            this.cant_pesada_real_umb.Visible = true;
            this.cant_pesada_real_umb.VisibleIndex = 22;
            // 
            // cant_pesada_real_ump
            // 
            this.cant_pesada_real_ump.AppearanceHeader.Options.UseTextOptions = true;
            this.cant_pesada_real_ump.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cant_pesada_real_ump.Caption = "CANTIDAD_PESADA_REAL_UMP";
            this.cant_pesada_real_ump.FieldName = "peso_neto";
            this.cant_pesada_real_ump.Name = "cant_pesada_real_ump";
            this.cant_pesada_real_ump.OptionsColumn.AllowEdit = false;
            this.cant_pesada_real_ump.Visible = true;
            this.cant_pesada_real_ump.VisibleIndex = 24;
            // 
            // lote_sap
            // 
            this.lote_sap.AppearanceCell.Options.UseTextOptions = true;
            this.lote_sap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lote_sap.Caption = "LOTE_SAP";
            this.lote_sap.FieldName = "lote_sap";
            this.lote_sap.Name = "lote_sap";
            this.lote_sap.OptionsColumn.AllowEdit = false;
            this.lote_sap.Visible = true;
            this.lote_sap.VisibleIndex = 20;
            this.lote_sap.Width = 65;
            // 
            // almacen
            // 
            this.almacen.AppearanceCell.Options.UseTextOptions = true;
            this.almacen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.almacen.AppearanceHeader.Options.UseTextOptions = true;
            this.almacen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.almacen.Caption = "ALMACEN";
            this.almacen.FieldName = "almacen";
            this.almacen.Name = "almacen";
            this.almacen.OptionsColumn.AllowEdit = false;
            this.almacen.Visible = true;
            this.almacen.VisibleIndex = 21;
            // 
            // tiquete_bascula
            // 
            this.tiquete_bascula.AppearanceHeader.Options.UseTextOptions = true;
            this.tiquete_bascula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tiquete_bascula.Caption = "TIQUETE_BASCULA";
            this.tiquete_bascula.FieldName = "tiquete_bascula";
            this.tiquete_bascula.Name = "tiquete_bascula";
            this.tiquete_bascula.OptionsColumn.AllowEdit = false;
            this.tiquete_bascula.Visible = true;
            this.tiquete_bascula.VisibleIndex = 23;
            // 
            // peso1
            // 
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
            this.peso1.VisibleIndex = 27;
            // 
            // peso2
            // 
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
            this.peso2.VisibleIndex = 28;
            // 
            // peso_neto
            // 
            this.peso_neto.AppearanceHeader.Options.UseTextOptions = true;
            this.peso_neto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.peso_neto.Caption = "PESO_NETO";
            this.peso_neto.FieldName = "peso_neto";
            this.peso_neto.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.peso_neto.Name = "peso_neto";
            this.peso_neto.OptionsFilter.AllowAutoFilter = false;
            this.peso_neto.OptionsFilter.AllowFilter = false;
            this.peso_neto.Visible = true;
            this.peso_neto.VisibleIndex = 29;
            // 
            // user_pesaje1
            // 
            this.user_pesaje1.Caption = "USUARIO PESAJE 1";
            this.user_pesaje1.FieldName = "usuario_pesaje1";
            this.user_pesaje1.Name = "user_pesaje1";
            this.user_pesaje1.OptionsColumn.AllowEdit = false;
            this.user_pesaje1.Visible = true;
            this.user_pesaje1.VisibleIndex = 25;
            // 
            // user_pesaje2
            // 
            this.user_pesaje2.Caption = "USUARIO PESAJE 2";
            this.user_pesaje2.FieldName = "usuario_pesaje2";
            this.user_pesaje2.Name = "user_pesaje2";
            this.user_pesaje2.OptionsColumn.AllowEdit = false;
            this.user_pesaje2.Visible = true;
            this.user_pesaje2.VisibleIndex = 26;
            // 
            // AccionPesaje
            // 
            this.AccionPesaje.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.AccionPesaje.AppearanceHeader.Options.UseFont = true;
            this.AccionPesaje.AppearanceHeader.Options.UseTextOptions = true;
            this.AccionPesaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AccionPesaje.Caption = "REALIZAR PESAJE";
            this.AccionPesaje.ColumnEdit = this.repositoryItemButtonEjecutarPesaje;
            this.AccionPesaje.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.AccionPesaje.Name = "AccionPesaje";
            this.AccionPesaje.OptionsFilter.AllowAutoFilter = false;
            this.AccionPesaje.OptionsFilter.AllowFilter = false;
            this.AccionPesaje.Visible = true;
            this.AccionPesaje.VisibleIndex = 30;
            // 
            // repositoryItemButtonEjecutarPesaje
            // 
            this.repositoryItemButtonEjecutarPesaje.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.repositoryItemButtonEjecutarPesaje.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEjecutarPesaje.Name = "repositoryItemButtonEjecutarPesaje";
            this.repositoryItemButtonEjecutarPesaje.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEjecutarPesaje.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEjecutarPesaje_ButtonClick);
            // 
            // AccionConfirmar
            // 
            this.AccionConfirmar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.AccionConfirmar.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccionConfirmar.AppearanceHeader.Options.UseFont = true;
            this.AccionConfirmar.AppearanceHeader.Options.UseForeColor = true;
            this.AccionConfirmar.Caption = "CONFIRMAR";
            this.AccionConfirmar.ColumnEdit = this.repositoryItemButtonConfirmar;
            this.AccionConfirmar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.AccionConfirmar.Name = "AccionConfirmar";
            this.AccionConfirmar.Visible = true;
            this.AccionConfirmar.VisibleIndex = 31;
            // 
            // repositoryItemButtonConfirmar
            // 
            this.repositoryItemButtonConfirmar.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.repositoryItemButtonConfirmar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonConfirmar.Name = "repositoryItemButtonConfirmar";
            this.repositoryItemButtonConfirmar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonConfirmar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonConfirmar_ButtonClick);
            // 
            // btnEndForm
            // 
            this.btnEndForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEndForm.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEndForm.ImageOptions.ImageToTextIndent = -15;
            this.btnEndForm.Location = new System.Drawing.Point(1688, 672);
            this.btnEndForm.Name = "btnEndForm";
            this.btnEndForm.Size = new System.Drawing.Size(134, 52);
            this.btnEndForm.TabIndex = 1;
            this.btnEndForm.Text = "Terminar";
            this.btnEndForm.Click += new System.EventHandler(this.btnEndForm_Click);
            // 
            // frmVista_PesajesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 749);
            this.Controls.Add(this.btnEndForm);
            this.Controls.Add(this.gcPesajesActivosSAP);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmVista_PesajesActivos.IconOptions.LargeImage")));
            this.Name = "frmVista_PesajesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADO PESAJES ACTIVOS EN SAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPesajesActivosSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVista_ListadoActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEjecutarPesaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonConfirmar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPesajesActivosSAP;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEjecutarPesaje;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVista_ListadoActivo;
        private DevExpress.XtraGrid.Columns.GridColumn id_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn pedido_traslado;
        private DevExpress.XtraGrid.Columns.GridColumn doc_transporte;
        private DevExpress.XtraGrid.Columns.GridColumn ent_salida_sap;
        private DevExpress.XtraGrid.Columns.GridColumn material_sap;
        private DevExpress.XtraGrid.Columns.GridColumn placa_cabezote;
        private DevExpress.XtraGrid.Columns.GridColumn plac_trailer;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_carga;
        private DevExpress.XtraGrid.Columns.GridColumn conductor;
        private DevExpress.XtraGrid.Columns.GridColumn centro_logistico;
        private DevExpress.XtraGrid.Columns.GridColumn num_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad_umb;
        private DevExpress.XtraGrid.Columns.GridColumn umb;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad_ump;
        private DevExpress.XtraGrid.Columns.GridColumn ump;
        private DevExpress.XtraGrid.Columns.GridColumn lote_sap;
        private DevExpress.XtraGrid.Columns.GridColumn almacen;
        private DevExpress.XtraGrid.Columns.GridColumn estado_cons_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn AccionPesaje;
        private DevExpress.XtraGrid.Columns.GridColumn cant_pesada_real_umb;
        private DevExpress.XtraGrid.Columns.GridColumn cant_pesada_real_ump;
        private DevExpress.XtraGrid.Columns.GridColumn tiquete_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn doc_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn peso1;
        private DevExpress.XtraGrid.Columns.GridColumn peso2;
        private DevExpress.XtraGrid.Columns.GridColumn user_pesaje1;
        private DevExpress.XtraGrid.Columns.GridColumn user_pesaje2;
        private DevExpress.XtraGrid.Columns.GridColumn AccionConfirmar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonConfirmar;
        private DevExpress.XtraGrid.Columns.GridColumn peso_neto;
        private DevExpress.XtraEditors.SimpleButton btnEndForm;
    }
}


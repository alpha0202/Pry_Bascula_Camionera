
namespace Pry_Basculas_SAP
{
    partial class frm_DetalleSelectedRow
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gdv_documentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.docu_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ped_traslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.docu_transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ent_sal_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cen_logistico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.almacenStorage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd_ControlDetalle = new DevExpress.XtraGrid.GridControl();
            this.gdv_VistaDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_pesaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.material_sap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.placa_cabezote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plac_trailer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecha_carga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conductor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.num_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad_umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad_ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cant_pesada_real_umb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cant_pesada_real_ump = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado_consumo_servicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiquete_bascula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ControlDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_VistaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gdv_documentos
            // 
            this.gdv_documentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.docu_comercial,
            this.ped_traslado,
            this.docu_transporte,
            this.Ent_sal_sap,
            this.cen_logistico,
            this.almacenStorage,
            this.lote});
            this.gdv_documentos.GridControl = this.grd_ControlDetalle;
            this.gdv_documentos.Name = "gdv_documentos";
            // 
            // docu_comercial
            // 
            this.docu_comercial.Caption = "DOCUMENTO COMERCIAL";
            this.docu_comercial.FieldName = "doc_comercial";
            this.docu_comercial.Name = "docu_comercial";
            this.docu_comercial.Visible = true;
            this.docu_comercial.VisibleIndex = 0;
            // 
            // ped_traslado
            // 
            this.ped_traslado.Caption = "PEDIDO DE TRASLADO";
            this.ped_traslado.FieldName = "pedido_traslado";
            this.ped_traslado.Name = "ped_traslado";
            this.ped_traslado.Visible = true;
            this.ped_traslado.VisibleIndex = 1;
            // 
            // docu_transporte
            // 
            this.docu_transporte.Caption = "DOCUMENTO TRANSPORTE";
            this.docu_transporte.FieldName = "doc_transporte";
            this.docu_transporte.Name = "docu_transporte";
            this.docu_transporte.Visible = true;
            this.docu_transporte.VisibleIndex = 2;
            // 
            // Ent_sal_sap
            // 
            this.Ent_sal_sap.Caption = "ENTREGA DE SALIDA SAP";
            this.Ent_sal_sap.FieldName = "Ent_salida_sap";
            this.Ent_sal_sap.Name = "Ent_sal_sap";
            this.Ent_sal_sap.Visible = true;
            this.Ent_sal_sap.VisibleIndex = 3;
            // 
            // cen_logistico
            // 
            this.cen_logistico.Caption = "CENTRO LOGÍSTICO";
            this.cen_logistico.FieldName = "centro_logistico";
            this.cen_logistico.Name = "cen_logistico";
            this.cen_logistico.Visible = true;
            this.cen_logistico.VisibleIndex = 4;
            // 
            // almacenStorage
            // 
            this.almacenStorage.Caption = "ALMACEN";
            this.almacenStorage.FieldName = "almacen";
            this.almacenStorage.Name = "almacenStorage";
            this.almacenStorage.Visible = true;
            this.almacenStorage.VisibleIndex = 5;
            // 
            // lote
            // 
            this.lote.Caption = "LOTE";
            this.lote.FieldName = "lote_sap";
            this.lote.Name = "lote";
            this.lote.Visible = true;
            this.lote.VisibleIndex = 6;
            // 
            // grd_ControlDetalle
            // 
            gridLevelNode1.LevelTemplate = this.gdv_documentos;
            gridLevelNode1.RelationName = "Documentos";
            this.grd_ControlDetalle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_ControlDetalle.Location = new System.Drawing.Point(12, 34);
            this.grd_ControlDetalle.MainView = this.gdv_VistaDetalle;
            this.grd_ControlDetalle.Name = "grd_ControlDetalle";
            this.grd_ControlDetalle.Size = new System.Drawing.Size(1093, 339);
            this.grd_ControlDetalle.TabIndex = 0;
            this.grd_ControlDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdv_VistaDetalle,
            this.gdv_documentos});
            // 
            // gdv_VistaDetalle
            // 
            this.gdv_VistaDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gdv_VistaDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gdv_VistaDetalle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gdv_VistaDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_pesaje,
            this.tipo_proceso,
            this.tipo_pesaje,
            this.fecha_proceso,
            this.material_sap,
            this.placa_cabezote,
            this.plac_trailer,
            this.fecha_carga,
            this.conductor,
            this.num_bascula,
            this.cantidad_umb,
            this.umb,
            this.cantidad_ump,
            this.ump,
            this.cant_pesada_real_umb,
            this.cant_pesada_real_ump,
            this.estado_consumo_servicio,
            this.tiquete_bascula,
            this.estado});
            this.gdv_VistaDetalle.GridControl = this.grd_ControlDetalle;
            this.gdv_VistaDetalle.GroupCount = 1;
            this.gdv_VistaDetalle.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gdv_VistaDetalle.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gdv_VistaDetalle.Name = "gdv_VistaDetalle";
            this.gdv_VistaDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gdv_VistaDetalle.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gdv_VistaDetalle.OptionsBehavior.AutoExpandAllGroups = true;
            this.gdv_VistaDetalle.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.tipo_proceso, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gdv_VistaDetalle.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gdv_VistaDetalle_MasterRowExpanded);
            // 
            // id_pesaje
            // 
            this.id_pesaje.Caption = "ID_PESAJE";
            this.id_pesaje.FieldName = "id_pesaje";
            this.id_pesaje.Name = "id_pesaje";
            this.id_pesaje.OptionsColumn.AllowEdit = false;
            this.id_pesaje.OptionsFilter.AllowAutoFilter = false;
            this.id_pesaje.Visible = true;
            this.id_pesaje.VisibleIndex = 0;
            // 
            // tipo_proceso
            // 
            this.tipo_proceso.Caption = "TIPO_PROCESO";
            this.tipo_proceso.FieldName = "tipo_proceso";
            this.tipo_proceso.Name = "tipo_proceso";
            this.tipo_proceso.OptionsColumn.AllowEdit = false;
            this.tipo_proceso.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.tipo_proceso.OptionsFilter.AllowAutoFilter = false;
            this.tipo_proceso.Visible = true;
            this.tipo_proceso.VisibleIndex = 1;
            // 
            // tipo_pesaje
            // 
            this.tipo_pesaje.Caption = "TIPO_PESAJE";
            this.tipo_pesaje.FieldName = "tipo_pesaje";
            this.tipo_pesaje.Name = "tipo_pesaje";
            this.tipo_pesaje.Visible = true;
            this.tipo_pesaje.VisibleIndex = 1;
            // 
            // fecha_proceso
            // 
            this.fecha_proceso.Caption = "FECHA_PROCESO";
            this.fecha_proceso.DisplayFormat.FormatString = "d-MM-yyyy";
            this.fecha_proceso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fecha_proceso.FieldName = "fecha_proceso";
            this.fecha_proceso.Name = "fecha_proceso";
            this.fecha_proceso.Visible = true;
            this.fecha_proceso.VisibleIndex = 2;
            // 
            // material_sap
            // 
            this.material_sap.Caption = "MATERIAL SAP";
            this.material_sap.FieldName = "material_sap";
            this.material_sap.Name = "material_sap";
            this.material_sap.Visible = true;
            this.material_sap.VisibleIndex = 3;
            // 
            // placa_cabezote
            // 
            this.placa_cabezote.Caption = "PLACA_CABEZOTE";
            this.placa_cabezote.FieldName = "placa_cabezote";
            this.placa_cabezote.Name = "placa_cabezote";
            this.placa_cabezote.Visible = true;
            this.placa_cabezote.VisibleIndex = 4;
            // 
            // plac_trailer
            // 
            this.plac_trailer.Caption = "PLACA_TRAILER";
            this.plac_trailer.FieldName = "plac_trailer";
            this.plac_trailer.Name = "plac_trailer";
            this.plac_trailer.Visible = true;
            this.plac_trailer.VisibleIndex = 5;
            // 
            // fecha_carga
            // 
            this.fecha_carga.Caption = "FECHA DE CARGA";
            this.fecha_carga.FieldName = "fecha_carga";
            this.fecha_carga.Name = "fecha_carga";
            this.fecha_carga.Visible = true;
            this.fecha_carga.VisibleIndex = 6;
            // 
            // conductor
            // 
            this.conductor.Caption = "CONDUCTOR";
            this.conductor.FieldName = "conductor";
            this.conductor.Name = "conductor";
            this.conductor.Visible = true;
            this.conductor.VisibleIndex = 7;
            // 
            // num_bascula
            // 
            this.num_bascula.Caption = "NUMERO DE BÁSCULA";
            this.num_bascula.FieldName = "num_bascula";
            this.num_bascula.Name = "num_bascula";
            this.num_bascula.Visible = true;
            this.num_bascula.VisibleIndex = 8;
            // 
            // cantidad_umb
            // 
            this.cantidad_umb.Caption = "CANTIDAD UMB";
            this.cantidad_umb.FieldName = "cantidad_umb";
            this.cantidad_umb.Name = "cantidad_umb";
            this.cantidad_umb.Visible = true;
            this.cantidad_umb.VisibleIndex = 9;
            // 
            // umb
            // 
            this.umb.Caption = "UMB";
            this.umb.FieldName = "umb";
            this.umb.Name = "umb";
            this.umb.Visible = true;
            this.umb.VisibleIndex = 10;
            // 
            // cantidad_ump
            // 
            this.cantidad_ump.Caption = "CANTIDAD UMP";
            this.cantidad_ump.FieldName = "cantidad_ump";
            this.cantidad_ump.Name = "cantidad_ump";
            this.cantidad_ump.Visible = true;
            this.cantidad_ump.VisibleIndex = 11;
            // 
            // ump
            // 
            this.ump.Caption = "UMP";
            this.ump.FieldName = "ump";
            this.ump.Name = "ump";
            this.ump.Visible = true;
            this.ump.VisibleIndex = 12;
            // 
            // cant_pesada_real_umb
            // 
            this.cant_pesada_real_umb.Caption = "CANTIDAD REAL UMB";
            this.cant_pesada_real_umb.FieldName = "cant_pesada_real_umb";
            this.cant_pesada_real_umb.Name = "cant_pesada_real_umb";
            this.cant_pesada_real_umb.Visible = true;
            this.cant_pesada_real_umb.VisibleIndex = 13;
            // 
            // cant_pesada_real_ump
            // 
            this.cant_pesada_real_ump.Caption = "CANTIDAD REAL UMP";
            this.cant_pesada_real_ump.FieldName = "cant_pesada_real_ump";
            this.cant_pesada_real_ump.Name = "cant_pesada_real_ump";
            this.cant_pesada_real_ump.Visible = true;
            this.cant_pesada_real_ump.VisibleIndex = 14;
            // 
            // estado_consumo_servicio
            // 
            this.estado_consumo_servicio.Caption = "ESTADO CONSUMO DEL SERVICIO";
            this.estado_consumo_servicio.FieldName = "estado_consumo_servicio";
            this.estado_consumo_servicio.Name = "estado_consumo_servicio";
            this.estado_consumo_servicio.Visible = true;
            this.estado_consumo_servicio.VisibleIndex = 15;
            // 
            // tiquete_bascula
            // 
            this.tiquete_bascula.Caption = "TIQUETE BASCULA";
            this.tiquete_bascula.FieldName = "tiquete_bascula";
            this.tiquete_bascula.Name = "tiquete_bascula";
            this.tiquete_bascula.Visible = true;
            this.tiquete_bascula.VisibleIndex = 16;
            // 
            // estado
            // 
            this.estado.Caption = "ESTADO PROCESO PESAJE";
            this.estado.FieldName = "estado";
            this.estado.Name = "estado";
            this.estado.Visible = true;
            this.estado.VisibleIndex = 17;
            // 
            // frm_DetalleSelectedRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 403);
            this.Controls.Add(this.grd_ControlDetalle);
            this.Name = "frm_DetalleSelectedRow";
            this.Text = "Detalle Fila Seleccionada";
            this.Load += new System.EventHandler(this.frm_DetalleSelectedRow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ControlDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_VistaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_ControlDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gdv_VistaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn id_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_pesaje;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_proceso;
        private DevExpress.XtraGrid.Columns.GridColumn material_sap;
        private DevExpress.XtraGrid.Columns.GridColumn placa_cabezote;
        private DevExpress.XtraGrid.Columns.GridColumn plac_trailer;
        private DevExpress.XtraGrid.Columns.GridColumn fecha_carga;
        private DevExpress.XtraGrid.Columns.GridColumn conductor;
        private DevExpress.XtraGrid.Columns.GridColumn num_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad_umb;
        private DevExpress.XtraGrid.Columns.GridColumn umb;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad_ump;
        private DevExpress.XtraGrid.Columns.GridColumn ump;
        private DevExpress.XtraGrid.Columns.GridColumn cant_pesada_real_umb;
        private DevExpress.XtraGrid.Columns.GridColumn cant_pesada_real_ump;
        private DevExpress.XtraGrid.Columns.GridColumn estado_consumo_servicio;
        private DevExpress.XtraGrid.Columns.GridColumn tiquete_bascula;
        private DevExpress.XtraGrid.Columns.GridColumn estado;
        private DevExpress.XtraGrid.Views.Grid.GridView gdv_documentos;
        private DevExpress.XtraGrid.Columns.GridColumn docu_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn ped_traslado;
        private DevExpress.XtraGrid.Columns.GridColumn docu_transporte;
        private DevExpress.XtraGrid.Columns.GridColumn Ent_sal_sap;
        private DevExpress.XtraGrid.Columns.GridColumn cen_logistico;
        private DevExpress.XtraGrid.Columns.GridColumn almacenStorage;
        private DevExpress.XtraGrid.Columns.GridColumn lote;
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using DevExpress.XtraGrid.Views.Grid;

namespace Pry_Basculas_SAP
{
    public partial class frm_DetalleSelectedRow : XtraForm
    {
      private string _idPesajeSelected;
        private string _tipoSeleccion;



        public frm_DetalleSelectedRow(string idPesajeSel, string tipoSeleccion)
        {

            InitializeComponent();
            _idPesajeSelected = idPesajeSel;
            _tipoSeleccion = tipoSeleccion;
        }

        private void frm_DetalleSelectedRow_Load(object sender, EventArgs e)
        {
            CargueDetalleSeleccionado(_idPesajeSelected,_tipoSeleccion);
        }


        private void CargueDetalleSeleccionado(string idPesaje, string tipoSeleccion)
        {
            try
            {
                List<Parametros> LstParametros = new List<Parametros>();

                LstParametros.Add(new Parametros("@idPesaje", idPesaje, SqlDbType.VarChar));
                LstParametros.Add(new Parametros("@tipoSeleccion", tipoSeleccion, SqlDbType.VarChar));
                DataTable dt = Datos.SPObtenerDataTable("SP_Detalle_FilaSeleccionada", LstParametros);
                grd_ControlDetalle.DataSource = dt;
                gdv_VistaDetalle.OptionsView.ColumnAutoWidth = false;
                grd_ControlDetalle.ForceInitialize();
                gdv_VistaDetalle.BestFitColumns();

            }
            catch (Exception ex)
            {

                throw;
            }


        }


     
        private void gdv_VistaDetalle_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == 0 && view.GetDetailView(e.RowHandle, e.RelationIndex) != null)
            {
                ((GridView)view.GetDetailView(e.RowHandle, e.RelationIndex)).BestFitColumns();
            }
        }
    }
}
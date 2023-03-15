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



        public frm_DetalleSelectedRow(string idPesajeSel)
        {

            _idPesajeSelected = idPesajeSel;
            InitializeComponent();
        }

        private void frm_DetalleSelectedRow_Load(object sender, EventArgs e)
        {
            CargueDetalleSeleccionado();
        }


        private void CargueDetalleSeleccionado()
        {
            try
            {
                List<Parametros> LstParametros = new List<Parametros>();

                LstParametros.Add(new Parametros("@id_pesaje", _idPesajeSelected, SqlDbType.VarChar));
                DataTable dt = Datos.SPObtenerDataTable("SP_Cargue_DetalleSeleccionado_Pesajes", LstParametros);
                grd_ControlDetalle.DataSource = dt;
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
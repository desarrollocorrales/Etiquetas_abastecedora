using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Utilidades;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Produccion;
using Seguimiento_y_Control.Reportes;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_ImprimirTarima : Form
    {
        private pedidos_internos oPedido;

        public Frm_ImprimirTarima()
        {
            InitializeComponent();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            Frm_BuscarPedido frmBuscarPedido = new Frm_BuscarPedido(0);
            frmBuscarPedido.ShowDialog();
            oPedido = frmBuscarPedido.Pedido;
            if (oPedido != null)
            {
                txbNumPedido.Text = oPedido.codigo_pedido;
                dtpFecha.Enabled = true;
            }
        }

        private void btnBuscarTarimas_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarTarimas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscarTarimas()
        {
            DateTime dtFechaInicial = dtpFecha.Value.Date;
            DateTime dtFechaFinal = dtFechaInicial.AddDays(1);

            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<paquetes> LstTarimas =
                SegContext.paquetes.Where(o => o.id_pedido == oPedido.id_pedido
                                            && o.fecha_creacion >= dtFechaInicial 
                                            && o.fecha_creacion  < dtFechaFinal
                                            && o.estatus == "A").ToList();

            TarimasGrid RenglonGrid;
            List<TarimasGrid> SourceGrid = new List<TarimasGrid>();
            
            foreach (paquetes oPaquete in LstTarimas)
            {
                List<paquetes_det> lstDetalles = 
                    SegContext.paquetes_det.Where(o=>o.id_paquete == oPaquete.id_paquete).ToList();
                      
                RenglonGrid = new TarimasGrid();
                RenglonGrid.Tarima = oPaquete;
                RenglonGrid.Articulo = getArticulo(lstDetalles);
                SourceGrid.Add(RenglonGrid);
            }

            gridEtiquetas.DataSource = SourceGrid;
            gvEtiquetas.BestFitColumns();
        }

        private string getArticulo(List<paquetes_det> lstDetalles)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();

            string sArticulo = string.Empty;

            List<etiquetas> lstEtiquetas = new List<etiquetas>();
            foreach (paquetes_det Detalle in lstDetalles)
            {
                etiquetas oEtiqueta = segContext.etiquetas.FirstOrDefault(o => o.id_etiqueta == Detalle.id_etiqueta);
                sArticulo = oEtiqueta.articulos.articulo;
                lstEtiquetas.Add(oEtiqueta);
            }

            var query = from etiqueta in lstEtiquetas
                        select etiqueta.clave_articulo;

            int iArticulos = query.Distinct().ToList().Count;


            if (iArticulos > 1)
                sArticulo = "VARIOS";

            return sArticulo;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Imprimir()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<TarimasGrid> SourceGrid = (List<TarimasGrid>)gridEtiquetas.DataSource;

            ReporteTarima RenglonReporteTarima;
            List<ReporteTarima> SourceReporteTarima = new List<ReporteTarima>();

            TarimasGrid Renglon = getRenglonGrid();
            
            List<paquetes_det> LstDetalles = 
                SegContext.paquetes_det.Where(o=>o.id_paquete==Renglon.Tarima.id_paquete).ToList();
            foreach (paquetes_det PaqDetalle in LstDetalles)
            {
                if (PaqDetalle.etiquetas.estatus != "B")
                {
                    RenglonReporteTarima = new ReporteTarima();
                    RenglonReporteTarima.ID_Tarima = PaqDetalle.id_paquete;
                    RenglonReporteTarima.Responsable = Config.user.nombre;
                    RenglonReporteTarima.FechaHoraCreacion = getFechaServer();

                    RenglonReporteTarima.NumeroEtiqueta = PaqDetalle.etiquetas.numero_etiqueta;
                    RenglonReporteTarima.Articulo = PaqDetalle.etiquetas.articulos.articulo;
                    RenglonReporteTarima.Clave = PaqDetalle.etiquetas.articulos.clave;
                    RenglonReporteTarima.Cantidad = PaqDetalle.etiquetas.cantidad;
                    RenglonReporteTarima.Unidad = PaqDetalle.etiquetas.unidad;
                    RenglonReporteTarima.FechaProduccion = PaqDetalle.etiquetas.fecha_empaque;
                    SourceReporteTarima.Add(RenglonReporteTarima);
                }
            }

            ImagenReportes ImgRep = new ImagenReportes();
            ImgRep.ImgReporte = new Bitmap("LogoReportes.jpg");

            xrpImprimirTarima ReporteTarima = new xrpImprimirTarima();
            ReporteTarima.DataSource = SourceReporteTarima;
            ReporteTarima.ImagenReportes.Add(ImgRep);
            ReporteTarima.ShowPreviewDialog();
        }

        private TarimasGrid getRenglonGrid()
        {
            int iSelected = gvEtiquetas.GetSelectedRows()[0];
            TarimasGrid RenglonSeleccionado = (TarimasGrid)gvEtiquetas.GetRow(iSelected);
            return RenglonSeleccionado;
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }
    }
}

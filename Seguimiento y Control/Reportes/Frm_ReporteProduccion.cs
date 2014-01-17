using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Produccion;
using Seguimiento_y_Control.Utilidades;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Reportes
{
    public partial class Frm_ReporteProduccion : Form
    {
        private pedidos_internos oPedido;
        private articulos oArticulo;

        public Frm_ReporteProduccion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEtiquetas();
        }
        private void BuscarEtiquetas()
        {            
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            try
            {
                string sNumeroDePedido = txbNumPedido.Text.ToUpper();
                oPedido = SegContext.pedidos_internos.FirstOrDefault(o => o.codigo_pedido == sNumeroDePedido);
                if (oPedido == null & sNumeroDePedido.Trim().Length != 0)
                {
                    MessageBox.Show("No se encontro el pedido " + sNumeroDePedido);
                    return;
                }
                //***** Obtener las etiquetas de produccion
                List<etiquetas> lstEtiquetas = ObtenerEtiquetas();

                //***** Obtener las etiquetas que tienen contenedor
                List<paquetes_det> lstPaqueteDetalles = ObtenerPaqueteDetalles(lstEtiquetas);

                //***** Eliminar las etiquetas que esten en un paquete
                etiquetas EtiquetaAQuitar;
                foreach (paquetes_det oPaqueteDet in lstPaqueteDetalles)
                {
                    EtiquetaAQuitar = lstEtiquetas.Find(o => o.id_etiqueta == oPaqueteDet.id_etiqueta);
                    lstEtiquetas.Remove(EtiquetaAQuitar);
                }

                //***** Obtener las etiquetas de los contenedores
                List<paquetes> lstEtiquetasContenedores = ObtenerEtiquetasContenedores(lstPaqueteDetalles);

                List<ReporteProduccion> SourceGrid = CargarGrid(lstEtiquetas, lstEtiquetasContenedores);                

                gridEtiquetas.DataSource = SourceGrid;
                gvEtiquetas.BestFitColumns();

                if (SourceGrid.Count != 0)
                {
                    btnImprimir.Enabled = true;
                    btnImprimirTarima.Enabled = true;
                    lblSumaCantidades.Text = "Total: " + 
                        SourceGrid.Sum(o => o.Cantidad).ToString("0,0.###") + " " + 
                        SourceGrid[0].Unidad;
                    lblSumaEtiquetas.Text = "Total: " + SourceGrid.Count + " Etiquetas";
                }
                else
                {
                    btnImprimir.Enabled = false;
                    btnImprimirTarima.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<etiquetas> ObtenerEtiquetas()
        {
            DateTime dtFechaInicial = dtpFecha.Value.Date;
            DateTime dtFechaFinal = dtpFecha.Value.Date.AddDays(1);
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            string sNumeroDePedido = txbNumPedido.Text.ToUpper();
            oPedido = SegContext.pedidos_internos.FirstOrDefault(o => o.codigo_pedido == sNumeroDePedido);

            List<etiquetas> lstEtiquetas = new List<etiquetas>();
            if (oPedido != null)
            {
                /* Encontrar todas las etiquetas creadas en la fecha seleccionada,
                 * del pedido seleccionado, el articulo seleccionado y con estatus diferente de "B" Borrada. */
                var query = from etiqueta in SegContext.etiquetas
                            where etiqueta.fecha_empaque >= dtFechaInicial &&
                                  etiqueta.fecha_empaque <= dtFechaFinal &&
                                  etiqueta.id_pedido == oPedido.id_pedido &&
                                  etiqueta.clave_articulo == oArticulo.clave &&
                                  etiqueta.estatus != "B" &&
                                  etiqueta.tipo_etiqueta == "P"
                            select etiqueta;
                lstEtiquetas = query.ToList();
            }
            else
            {
                /* Encontrar todas las etiquetas creadas en la fecha seleccionada,
                 * el articulo seleccionado y con estatus diferente de "B" Borrada. */
                var query = from etiqueta in SegContext.etiquetas
                            where etiqueta.fecha_empaque >= dtFechaInicial &&
                                  etiqueta.fecha_empaque <= dtFechaFinal &&
                                  etiqueta.clave_articulo == oArticulo.clave &&
                                  etiqueta.estatus != "B" &&
                                  etiqueta.tipo_etiqueta == "P"

                            select etiqueta;

                lstEtiquetas = query.ToList();
            }

            return lstEtiquetas;
        }
        private List<paquetes_det> ObtenerPaqueteDetalles(List<etiquetas> lstEtiquetas)
        {
            List<paquetes_det> lst = new List<paquetes_det>();
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            foreach (etiquetas oEtiqueta in lstEtiquetas)
            {
                paquetes_det Detalle = SegContext.paquetes_det.SingleOrDefault(o => o.id_etiqueta == oEtiqueta.id_etiqueta);
                if (Detalle != null)
                    lst.Add(Detalle);
            }

            return lst;
        }
        private List<paquetes> ObtenerEtiquetasContenedores(List<paquetes_det> lstPaqueteDet)
        {
            List<paquetes> lst = new List<paquetes>();
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            foreach (paquetes_det oDetalle in lstPaqueteDet)
            {
                paquetes Paquete = SegContext.paquetes.SingleOrDefault(o => o.id_paquete == oDetalle.id_paquete);
                if (Paquete != null)
                    lst.Add(Paquete);
            }

            lst = lst.Distinct().ToList();

            return lst;
        }
        private List<ReporteProduccion> CargarGrid(List<etiquetas> lstEtiquetas, List<paquetes> lstContenedores)
        {
            int iContador = 1;
            ReporteProduccion RenglonGrid;
            List<ReporteProduccion> SourceGrid = new List<ReporteProduccion>();
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            foreach (paquetes oContenedor in lstContenedores)
            {
                RenglonGrid = new ReporteProduccion();
                RenglonGrid.Contador = iContador;
                RenglonGrid.NumeroEtiqueta = oContenedor.numero_etiqueta;
                RenglonGrid.Cantidad = oContenedor.cantidad;
                RenglonGrid.Unidad = oContenedor.unidad;
                RenglonGrid.Bodega =
                    SegContext
                        .bodegas
                        .SingleOrDefault(o => o.id_bodega == oArticulo.id_bodega).bodega;
                RenglonGrid.NumeroPedido =
                    SegContext
                        .pedidos_internos
                        .SingleOrDefault(o => o.id_pedido == oContenedor.id_pedido).codigo_pedido;

                RenglonGrid.Clave = oArticulo.clave;
                RenglonGrid.Articulo = oArticulo.articulo;
                RenglonGrid.FechaReporte = dtpFecha.Value;

                //*** Si algunas de las cajas se entregaron cambiar estatus a "Parcialmente Entregada"
                int iEtiquetasPaquete = SegContext.paquetes_det.Count(o => o.id_paquete == oContenedor.id_paquete);
                int iEtiquetasActivas = SegContext.paquetes_det.Count(o => o.id_paquete == oContenedor.id_paquete && o.etiquetas.estatus == "A");
                if (iEtiquetasPaquete == iEtiquetasActivas)
                    RenglonGrid.Estado = "A";
                else if (iEtiquetasActivas == 0)
                    RenglonGrid.Estado = "E";
                else if (iEtiquetasActivas > 0)
                    RenglonGrid.Estado = "P";

                    SourceGrid.Add(RenglonGrid);
                iContador++;
            }

            foreach (etiquetas Etiqueta in lstEtiquetas)
            {
                RenglonGrid = new ReporteProduccion();
                RenglonGrid.Contador = iContador;
                RenglonGrid.NumeroEtiqueta = Etiqueta.numero_etiqueta;
                RenglonGrid.Cantidad = Etiqueta.cantidad;
                RenglonGrid.Unidad = Etiqueta.unidad;
                RenglonGrid.Bodega =
                    SegContext
                        .bodegas
                        .SingleOrDefault(o => o.id_bodega == oArticulo.id_bodega).bodega;
                RenglonGrid.NumeroPedido =
                    SegContext
                        .pedidos_internos
                        .SingleOrDefault(o => o.id_pedido == Etiqueta.id_pedido).codigo_pedido;

                RenglonGrid.Clave = oArticulo.clave;
                RenglonGrid.Articulo = oArticulo.articulo;
                RenglonGrid.FechaReporte = dtpFecha.Value;
                RenglonGrid.Estado = Etiqueta.estatus;

                SourceGrid.Add(RenglonGrid);
                iContador++;
            }

            return SourceGrid;
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            Frm_BuscarArticulo frmBuscarArticulos = new Frm_BuscarArticulo();
            frmBuscarArticulos.ShowDialog();
            oArticulo = frmBuscarArticulos.Articulo;
            if (oArticulo != null)
            {
                txbArticulo.Text = oArticulo.clave + "-" + oArticulo.articulo;
                btnBuscar.Enabled = true;

                gridEtiquetas.DataSource = null;
                btnImprimir.Enabled = false;
            }
        }

        private void txbNumPedido_TextChanged(object sender, EventArgs e)
        {
            if (txbNumPedido.Text == string.Empty)
            {
                oPedido = null;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirReporte();
        }
        private void ImprimirReporte()
        {
            Bitmap Imagen = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");
            ImagenReportes ImagenReporte = new ImagenReportes();
            ImagenReporte.ImgReporte = Imagen;

            xrpReporteProduccion Reporte = new xrpReporteProduccion();
            Reporte.ImagenReporte.Add(ImagenReporte);
            Reporte.DataSource = gridEtiquetas.DataSource;

            Reporte.ShowPreviewDialog();
        }

        private void Frm_ReporteProduccion_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
        }

        private void btnImprimirTarima_Click(object sender, EventArgs e)
        {
            gridEtiquetas.ShowPrintPreview();
        }
    }
}

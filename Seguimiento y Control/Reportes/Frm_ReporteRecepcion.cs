using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Utilidades;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Reportes
{
    public partial class Frm_ReporteRecepcion : Form
    {
        private articulos oArticulo;

        public Frm_ReporteRecepcion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                string ExType = ex.GetType().ToString();
                StringBuilder sbMensaje = new StringBuilder();

                sbMensaje.Append(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.Append(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), ExType, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void Buscar()
        {
            //Obtener todas las etiquetas con fecha de recepcion igual a la fecha asignada
            //Del articulo seleccionado
            DateTime dtFecha = dtpFecha.Value.Date;
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<etiquetas> lstEtiquetas =
                SegContext
                .etiquetas.Where(o => o.fecha_recepcion == dtFecha 
                                   && o.clave_articulo==oArticulo.clave 
                                   && o.estatus != "B")
                .OrderBy(o=>o.tipo_salida).ToList();

            int iContador = 1;
            ReporteRecepcion Renglon;
            List<ReporteRecepcion> SourceGrid = new List<ReporteRecepcion>();
            foreach (etiquetas oEtiqueta in lstEtiquetas)
            {
                Renglon = new ReporteRecepcion();
                Renglon.Contador = iContador;
                Renglon.NumeroEtiqueta = oEtiqueta.numero_etiqueta;
                Renglon.Cantidad = oEtiqueta.cantidad;
                Renglon.Unidad = oEtiqueta.unidad;
                Renglon.Estado = oEtiqueta.catalog_estatus_etiquetas.descripcion;
                Renglon.Salida = getSalida(oEtiqueta.tipo_salida);
                if (Renglon.Salida == string.Empty)
                    Renglon.Bodega = getNombreBodega(oEtiqueta.id_bodega);
                else 
                    Renglon.Bodega = string.Empty;

                Renglon.Clave = oArticulo.clave;
                Renglon.Articulo = oArticulo.articulo;
                Renglon.FechaReporte = dtpFecha.Value;
                SourceGrid.Add(Renglon);
                iContador++;
            }

            List<etiquetas_traspasadas> lstEtiquetasTraspasadas =
                SegContext
                    .etiquetas_traspasadas
                    .Where(o => o.fecha_recepcion == dtFecha
                                   && o.clave_articulo == oArticulo.clave
                                   && o.estado != "B")
                    .OrderBy(o=>o.tipo_salida).ToList();
            foreach (etiquetas_traspasadas oEtiqueta in lstEtiquetasTraspasadas)
            {
                Renglon = new ReporteRecepcion();
                Renglon.Contador = iContador;
                Renglon.NumeroEtiqueta = oEtiqueta.numero_etiqueta;
                Renglon.Cantidad = oEtiqueta.cantidad;
                Renglon.Unidad = oEtiqueta.unidad;
                Renglon.Estado = oEtiqueta.catalog_estatus_etiquetas.descripcion;
                Renglon.Salida = getSalida(oEtiqueta.tipo_salida);
                if (Renglon.Salida == string.Empty)
                    Renglon.Bodega = getNombreBodega(oEtiqueta.id_bodega);
                else
                    Renglon.Bodega = string.Empty;

                Renglon.Clave = oArticulo.clave;
                Renglon.Articulo = oArticulo.articulo;
                Renglon.FechaReporte = dtpFecha.Value;
                SourceGrid.Add(Renglon);
                iContador++;
            }

            if (SourceGrid.Count != 0)
            {
                gridEtiquetas.DataSource = SourceGrid;
                gvEtiquetas.BestFitColumns();
                btnImprimir.Enabled = true;
                lblTotalCantidad.Text = "Total: " + SourceGrid.Sum(o => o.Cantidad).ToString("0,0.###") + " " + oArticulo.unidad;
                lblTotalEtiquetas.Text = "Total: " + SourceGrid.Count + " Etiquetas";
            }
            else
            {
                gridEtiquetas.DataSource = null;
                gvEtiquetas.BestFitColumns();
                btnImprimir.Enabled = false;
                lblTotalCantidad.Text = string.Empty;
                lblTotalEtiquetas.Text = string.Empty;
            }
        }
        private string getNombreBodega(long id_bodega)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            bodegas oBodega = SegContext.bodegas.SingleOrDefault(o => o.id_bodega == id_bodega);
            return oBodega.bodega;
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

        private string getSalida(string id_salida)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            catalog_tipo_salida oTipoSalida = SegContext.catalog_tipo_salida.SingleOrDefault(o => o.id_tipo_salida == id_salida);
            if (oTipoSalida == null)
                return string.Empty;
            else
                return oTipoSalida.descripcion;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                string ExType = ex.GetType().ToString();
                StringBuilder sbMensaje = new StringBuilder();

                sbMensaje.Append(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.Append(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), ExType, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            ImagenReportes ImagenReporte = new ImagenReportes();
            ImagenReporte.ImgReporte = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");

            xrpReporteRecepcion Reporte = new xrpReporteRecepcion();
            Reporte.ImagenSource.Add(ImagenReporte);
            Reporte.DataSource = gridEtiquetas.DataSource;

            Reporte.ShowPreviewDialog();
        }
    }
}

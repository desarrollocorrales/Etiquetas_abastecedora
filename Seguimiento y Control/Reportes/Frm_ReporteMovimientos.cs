using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Reportes;
using Seguimiento_y_Control.Utilidades;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Reportes
{
    public partial class Frm_ReporteMovimientos : Form
    {
        private articulos oArticulo;

        public Frm_ReporteMovimientos()
        {
            InitializeComponent();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            oArticulo = BuscarArticulo();
            if (oArticulo != null)
            {
                ActivarDatos();
            }
        }
        private articulos BuscarArticulo()
        {
            Frm_BuscarArticulo frmBuscaArticulo = new Frm_BuscarArticulo();
            frmBuscaArticulo.ShowDialog();
            return frmBuscaArticulo.Articulo;
        }
        private void ActivarDatos()
        {
            txbArticulo.Text = oArticulo.clave + " - " + oArticulo.articulo;
            btnReporte.Enabled = true;
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFinal.Value < dtpInicial.Value)
                dtpInicial.Value = dtpFinal.Value;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            CrearReporte();
        }
        private void CrearReporte()
        {
            DateTime fechainicial = dtpInicial.Value.Date;
            DateTime fechafinal = dtpFinal.Value.Date;

            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            DateTime fecha = fechainicial;
            DateTime fechaMasUno;
            List<ReporteMovimientos> lstSourceGrid = new List<ReporteMovimientos>();
            List<catalog_unidades> lstUnidades = SegContext.catalog_unidades.ToList();
            while (fecha <= fechafinal)
            {
                foreach (catalog_unidades unidad in lstUnidades)
                {
                    fechaMasUno = fecha.AddDays(1);
                    //Obtener todas las entradas
                    List<etiquetas> lstEtiqRecibidas = 
                        getEtiquetasRecepcion(SegContext, fecha, unidad.unidad);
                    List<etiquetas_traspasadas> lstEtiqTraspRecib = 
                        getEtiquetasTraspasadasRecepcion(SegContext, fecha, unidad.unidad);

                    //Obtener todas las etiquetas de produccion
                    List<etiquetas> lstEtiqProd = getEtiquetasProduccion(SegContext, fecha, unidad.unidad);

                    //Obtener todas las etiquetas con salida interna
                    List<etiquetas> lstEtiqSalidasInternas = 
                        getEtiquetasSalidas(SegContext, fecha, unidad.unidad, "P");
                    //Obtener todas las etiquetas con salida a sucursales
                    List<etiquetas> lstEtiqSalidasSucursales =
                        getEtiquetasSalidas(SegContext, fecha, unidad.unidad, "S");
                    //Obtener todas las etiquetas con salida a vendedores
                    List<etiquetas> lstEtiqSalidasVendedores =
                        getEtiquetasSalidas(SegContext, fecha, unidad.unidad, "C");

                    //Obtener todas las etiquetas traspasadas entregadas a produccion.
                    List<etiquetas_traspasadas> lstEtiqTraspInternas =
                        getEtiquetasTraspasadasSalidas(SegContext, fecha, unidad.unidad, "P");
                    //Obtener todas las etiquetas traspasadas entregadas a Sucursales.
                    List<etiquetas_traspasadas> lstEtiqTraspSucursales =
                        getEtiquetasTraspasadasSalidas(SegContext, fecha, unidad.unidad, "S");
                    //Obtener todas las etiquetas traspasadas entregadas a Vendedores.
                    List<etiquetas_traspasadas> lstEtiqTraspVendedores =
                        getEtiquetasTraspasadasSalidas(SegContext, fecha, unidad.unidad, "C");

                    ReporteMovimientos SourceRow = new ReporteMovimientos();
                    SourceRow.fechaInicial = dtpInicial.Value;
                    SourceRow.fechaFinal = dtpFinal.Value;
                    SourceRow.fecha = fecha;
                    SourceRow.Clave = oArticulo.clave;
                    SourceRow.Articulo = oArticulo.articulo;
                    SourceRow.Unidad = unidad.unidad;
                    SourceRow.TotalEntradas = lstEtiqRecibidas.Sum(o => o.cantidad) + lstEtiqTraspRecib.Sum(o => o.cantidad);
                    SourceRow.TotalProduccion = lstEtiqProd.Sum(o => o.cantidad);
                    SourceRow.TotalSalidasInternas = lstEtiqSalidasInternas.Sum(o => o.cantidad) + lstEtiqTraspInternas.Sum(o => o.cantidad);
                    SourceRow.TotalSalidasSucursales = lstEtiqSalidasSucursales.Sum(o => o.cantidad) + lstEtiqTraspSucursales.Sum(o => o.cantidad);
                    SourceRow.TotalSalidasVendedores = lstEtiqSalidasVendedores.Sum(o => o.cantidad) + lstEtiqTraspVendedores.Sum(o => o.cantidad);
                    decimal sumaTotal = SourceRow.TotalEntradas +
                                        SourceRow.TotalProduccion +
                                        SourceRow.TotalSalidas;
                    if (sumaTotal != 0)
                        lstSourceGrid.Add(SourceRow);
                }
                fecha = fecha.AddDays(1);
            }
            gridReporte.DataSource = lstSourceGrid;
            gvReporte.BestFitColumns();

            if (lstSourceGrid.Count != 0)
                btnImprimir.Enabled = true;
            else
                btnImprimir.Enabled = false;
        }
        private List<etiquetas> 
            getEtiquetasRecepcion(Seguimiento_ACC_Entities Context, DateTime fecha, string unidad)
        {
            List<etiquetas> lstEtiqRecibidas =
                        Context
                        .etiquetas
                        .Where(o => o.fecha_recepcion == fecha &&
                                    o.clave_articulo == oArticulo.clave &&
                                    o.estatus != "B" &&
                                    o.unidad == unidad)
                        .ToList();
            return lstEtiqRecibidas;
        }
        private List<etiquetas_traspasadas> 
            getEtiquetasTraspasadasRecepcion(Seguimiento_ACC_Entities Context, DateTime fecha, string unidad)
        {
            List<etiquetas_traspasadas> lstEtiqTraspRecib =
                    Context
                    .etiquetas_traspasadas
                    .Where(o => o.fecha_recepcion == fecha &&
                                o.clave_articulo == oArticulo.clave &&
                                o.unidad == unidad)
                    .ToList();
            return lstEtiqTraspRecib;
        }
        private List<etiquetas>
            getEtiquetasProduccion(Seguimiento_ACC_Entities Context, DateTime fecha, string unidad)
        {
            DateTime fechaMasUno = fecha.AddDays(1);
            List<etiquetas> lstEtiqProd =
                        Context
                        .etiquetas
                        .Where(o => o.fecha_empaque >= fecha && o.fecha_empaque <= fechaMasUno &&
                               o.tipo_etiqueta == "P" &&
                               o.clave_articulo == oArticulo.clave &&
                               o.estatus != "B" &&
                               o.unidad == unidad)
                        .ToList();
            return lstEtiqProd;
        }
        private List<etiquetas>
            getEtiquetasSalidas(Seguimiento_ACC_Entities Context, DateTime fecha, string unidad, string tipo_salida)
        {
            List<etiquetas> lstEtiqProd =
                        Context
                        .etiquetas
                        .Where(o => o.fecha_entrega == fecha &&
                                    o.tipo_salida == tipo_salida &&
                                    o.clave_articulo == oArticulo.clave &&
                                    o.estatus == "E" &&
                                    o.unidad == unidad)
                        .ToList();
            return lstEtiqProd;
        }
        private List<etiquetas_traspasadas>
            getEtiquetasTraspasadasSalidas(Seguimiento_ACC_Entities Context, DateTime fecha, string unidad, string tipo_salida)
        {
            List<etiquetas_traspasadas> lstEtiqTrasp =
                        Context
                        .etiquetas_traspasadas
                        .Where(o => o.fecha_entrega == fecha &&
                                    o.tipo_salida == tipo_salida &&
                                    o.clave_articulo == oArticulo.clave &&
                                    o.estado == "E" &&
                                    o.unidad == unidad)
                        .ToList();
            return lstEtiqTrasp;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImagenReportes ImagenReporte = new ImagenReportes();
            ImagenReporte.ImgReporte = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");

            xrpReporteDeMovimientos ReporteDeMovimientos = new xrpReporteDeMovimientos();
            ReporteDeMovimientos.ImagenReporte.Add(ImagenReporte);
            ReporteDeMovimientos.DataSource = gridReporte.DataSource;
            ReporteDeMovimientos.ShowPreviewDialog();
        }
    }
}

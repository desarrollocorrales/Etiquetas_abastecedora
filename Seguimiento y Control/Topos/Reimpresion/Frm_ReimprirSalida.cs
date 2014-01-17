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
using Seguimiento_y_Control.Reportes;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Topos.Reimpresion
{
    public partial class Frm_ReimprirSalida : Form
    {
        public Frm_ReimprirSalida()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirSalidaInterna();
            }
            catch(Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);
                MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirSalidaInterna()
        {
            string codigoSalida = txbCodigoSalida.Text.ToUpper().Trim();

            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            salidas oSalida = SegContext.salidas.FirstOrDefault(o => o.codigo_salida == codigoSalida);

            if (oSalida != null)
            {
                List<salidas_det> lstDetallesSalida = new List<salidas_det>();
                lstDetallesSalida = SegContext.salidas_det.Where(o => o.id_salida == oSalida.id_salida).ToList();

                RepEntregaInterna RowReporte;
                List<RepEntregaInterna> SourceReporte = new List<RepEntregaInterna>();

                foreach (salidas_det SalidaDet in lstDetallesSalida)
                {

                    pedidos_internos oPedido = getPedido(oSalida.id_pedido);
                    usuarios oUsuarioSol = getUsuario(oSalida.id_usuario_solicitante);
                    usuarios oUsuarioResp = getUsuario(oSalida.id_usuario_responsable);
                    areas oArea = getArea(oUsuarioSol.id_area);

                    RowReporte = new RepEntregaInterna();
                    RowReporte.Fecha = oSalida.fecha;
                    RowReporte.NumSalida = oSalida.codigo_salida;
                    RowReporte.NumPedido = oPedido.codigo_pedido;
                    RowReporte.Responsable = oUsuarioResp;
                    RowReporte.Solicitante = oUsuarioSol;
                    RowReporte.Destino = oArea.nombre;

                    string ID_SUCUSRAL = SalidaDet.numero_etiqueta.Substring(1, 2);
                    string TIPO_ETIQUETA = SalidaDet.numero_etiqueta.Substring(0, 1);

                    if (ID_SUCUSRAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                    {
                        //Son Locales
                        switch (TIPO_ETIQUETA)
                        {
                            case "1":
                            case "2":
                                etiquetas oEtiqueta = getEtiqueta(SalidaDet.numero_etiqueta);
                                RowReporte.RowEtiquetas = new GridEntrega();
                                RowReporte.RowEtiquetas.Articulo = oEtiqueta.articulos.articulo;
                                RowReporte.RowEtiquetas.Cantidad = oEtiqueta.cantidad;
                                RowReporte.RowEtiquetas.Clave_Articulo = oEtiqueta.clave_articulo;
                                RowReporte.RowEtiquetas.Estado = "A";
                                RowReporte.RowEtiquetas.Fecha_Empaque = oEtiqueta.fecha_empaque;
                                RowReporte.RowEtiquetas.NumeroEtiqueta = oEtiqueta.numero_etiqueta;
                                RowReporte.RowEtiquetas.Unidad = oEtiqueta.unidad;
                                RowReporte.RowEtiquetas.ID_Etiqueta = oEtiqueta.id_etiqueta;
                                RowReporte.Bodega = getBodega(oEtiqueta.id_bodega);
                                break;
                            case "3":
                            case "4":
                                paquetes oPaquete = getPaquete(SalidaDet.numero_etiqueta);
                                articulos oArticulo = getArticulo(oPaquete.clave_articulo);
                                RowReporte.RowEtiquetas = new GridEntrega();
                                RowReporte.RowEtiquetas.Articulo = oArticulo.articulo;
                                RowReporte.RowEtiquetas.Cantidad = Convert.ToDecimal(SalidaDet.cantidad);
                                RowReporte.RowEtiquetas.Clave_Articulo = oPaquete.clave_articulo;
                                RowReporte.RowEtiquetas.Estado = "A";
                                RowReporte.RowEtiquetas.Fecha_Empaque = oPaquete.fecha_creacion;
                                RowReporte.RowEtiquetas.NumeroEtiqueta = oPaquete.numero_etiqueta;
                                RowReporte.RowEtiquetas.Unidad = SalidaDet.unidad;
                                RowReporte.RowEtiquetas.ID_Etiqueta = oPaquete.id_paquete;
                                RowReporte.Bodega = getBodega(oArticulo.id_bodega);
                                break;
                        }
                    }
                    else
                    {
                        //Son traspasadas
                    }

                    SourceReporte.Add(RowReporte);
                }
                
                ImagenReportes IMAGEN = new ImagenReportes();
                IMAGEN.ImgReporte = new Bitmap("LogoReportes.jpg");
                
                xrpEntregaInterna Reimpresion = new xrpEntregaInterna();
                Reimpresion.DataSource = SourceReporte;
                Reimpresion.ImagenReporte.Add(IMAGEN);
                Reimpresion.Watermark.Text = "REIMPRESION";
                Reimpresion.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.ForwardDiagonal;
                Reimpresion.Watermark.TextTransparency = 150;
                Reimpresion.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("No se encontró la salida con el codigo: " + codigoSalida,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private etiquetas getEtiqueta(string pNumEtiqueta)
        {
            etiquetas oEtiqueta;
            //Obtener ID_SUCURSAL_CODIGO_DE_BARRAS
            string ID_SUCURSAL = pNumEtiqueta.Substring(1, 2);

            if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                oEtiqueta = BuscarEnEtiquetasInternas(pNumEtiqueta);
            else
                oEtiqueta = BuscarEnEtiquetasTraspasadas(pNumEtiqueta);

            return oEtiqueta;
        }
        private etiquetas BuscarEnEtiquetasInternas(string pNumEtiqueta)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            etiquetas oEtiqueta = SegContext.etiquetas.FirstOrDefault(o => o.numero_etiqueta == pNumEtiqueta);
            return oEtiqueta;
        }

        private etiquetas BuscarEnEtiquetasTraspasadas(string pNumEtiqueta)
        {
            return new etiquetas();
        }

        private pedidos_internos getPedido(int id_pedido)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            pedidos_internos oPedido = segContext.pedidos_internos.FirstOrDefault(o => o.id_pedido == id_pedido);
            return oPedido;
        }

        private usuarios getUsuario(int id_usuario)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            usuarios oUsuario = segContext.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario);
            return oUsuario;
        }

        private areas getArea(long id_area)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            areas oArea = segContext.areas.FirstOrDefault(o => o.id_area == id_area);
            return oArea;
        }

        private bodegas getBodega(long id_bodega)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            bodegas oBodega = segContext.bodegas.FirstOrDefault(o => o.id_bodega == id_bodega);
            return oBodega;
        }

        private paquetes getPaquete(string pNumeroEtiqueta)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            paquetes oPaquete = segContext.paquetes.FirstOrDefault(o => o.numero_etiqueta == pNumeroEtiqueta);
            return oPaquete;
        }

        private articulos getArticulo(string clave)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            articulos oArticulo = segContext.articulos.FirstOrDefault(o => o.clave == clave);
            return oArticulo;
        }

        private void rbInternas_CheckedChanged(object sender, EventArgs e)
        {
            txbCodigoSalida.Enabled = rbInternas.Checked;
            btnImprimirInterna.Enabled = rbInternas.Checked;
        }

        private void rbSucursales_CheckedChanged(object sender, EventArgs e)
        {
            txbSalidaSucursal.Enabled = rbSucursales.Checked;
            btnImprimirSucursal.Enabled = rbSucursales.Checked;
        }

        private void rbVendedores_CheckedChanged(object sender, EventArgs e)
        {
            txbSalidaVendedor.Enabled = rbVendedores.Checked;
            btnImprimirVendedor.Enabled = rbVendedores.Checked;
        }
    }
}

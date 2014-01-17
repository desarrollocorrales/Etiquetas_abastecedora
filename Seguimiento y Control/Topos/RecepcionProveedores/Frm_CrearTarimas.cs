using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Utilidades;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Produccion;
using Sofbr.Utils.Impresoras;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    public partial class Frm_CrearTarimas : Form
    {
        private articulos oArticulo;

        public Frm_CrearTarimas()
        {
            InitializeComponent();
        }

        private void btnBuscaArticulo_Click(object sender, EventArgs e)
        {
            Frm_BuscarArticulo frmBuscarArticulos = new Frm_BuscarArticulo();
            frmBuscarArticulos.ShowDialog();
            oArticulo = frmBuscarArticulos.Articulo;
            if (oArticulo != null)
            {
                txbArticulo.Text = oArticulo.clave + "-" + oArticulo.articulo;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEtiqueas();
        }
        private void BuscarEtiqueas()
        {
            DateTime dtFechaInicial = dtpFecha.Value.Date;
            DateTime dtFechaFinal = dtFechaInicial.AddDays(1);
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();

            List<etiquetas> lstEtiquetasRecepcion = new List<etiquetas>();
            List<EtiquetasTarimas> SourceGrid = new List<EtiquetasTarimas>();

            if (oArticulo == null)
            {
                // Buscar todas las etiquetas de la fecha seleccionada                
                var busqueda = from etiqueta in segContext.etiquetas
                               where etiqueta.fecha_recepcion >= dtFechaInicial &&
                                     etiqueta.fecha_recepcion < dtFechaFinal &&
                                     etiqueta.tipo_etiqueta == "R" &&
                                     etiqueta.estatus == "A"
                               select etiqueta;

                lstEtiquetasRecepcion.AddRange(busqueda.OrderBy(o => o.clave_articulo).ToList());
            }
            else
            {
                // Buscar todas las etiquetas del articulo seleccionado en la fecha seleccionada
                var busqueda = from etiqueta in segContext.etiquetas
                               where etiqueta.fecha_recepcion >= dtFechaInicial &&
                                     etiqueta.fecha_recepcion < dtFechaFinal &&
                                     etiqueta.tipo_etiqueta == "R" &&
                                     etiqueta.clave_articulo == oArticulo.clave &&
                                     etiqueta.estatus == "A"
                               select etiqueta;

                lstEtiquetasRecepcion.AddRange(busqueda.OrderBy(o => o.clave_articulo).ToList());
            }

            foreach (etiquetas oEtiqueta in lstEtiquetasRecepcion)
            {
                //Preguntar si ya tiene contenedor
                paquetes_det oPaqDetalle =
                    segContext.paquetes_det.FirstOrDefault(o => o.id_etiqueta == oEtiqueta.id_etiqueta);
                if (oPaqDetalle == null)
                {
                    //No tiene contenedor
                    EtiquetasTarimas oEtiquetaTarima = new EtiquetasTarimas();
                    oEtiquetaTarima.Checked = false;
                    oEtiquetaTarima.Etiqueta = oEtiqueta;
                    SourceGrid.Add(oEtiquetaTarima);
                }
            }

            gridEtiquetas.DataSource = SourceGrid;
            gvEtiquetas.BestFitColumns();
        }

        private void txbArticulo_TextChanged(object sender, EventArgs e)
        {
            if (txbArticulo.Text == string.Empty)
                oArticulo = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearTarima();
        }
        private void CrearTarima()
        {
            List<EtiquetasTarimas> lstEtiquetasSeleccionadas = (List<EtiquetasTarimas>)gridEtiquetas.DataSource;
            lstEtiquetasSeleccionadas = lstEtiquetasSeleccionadas.FindAll(o => o.Checked == true);

            if (lstEtiquetasSeleccionadas.Count == 0)
            {
                MessageBox.Show("No ha seleccionado ninguna etiqueta para crear la tarima...", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Son datos correctos?", "Validar",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int numProductos = getProductosDiferentes(lstEtiquetasSeleccionadas);
                if (numProductos == 1)
                {
                    //Crear la tarima
                    CrearTarimaRecepcion(lstEtiquetasSeleccionadas);
                }
                else
                {
                    //Error
                    MessageBox.Show("No se puede crear una tarima de diferentes productos", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void CrearTarimaRecepcion(List<EtiquetasTarimas> lstEtiquetasSeleccionadas)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            SegContext.Connection.Open();
            IDbTransaction Transaccion = SegContext.Connection.BeginTransaction();

            try
            {
                string sClave = lstEtiquetasSeleccionadas[0].Etiqueta.clave_articulo;
                string sArticulo = lstEtiquetasSeleccionadas[0].Etiqueta.articulos.articulo;
                string sUnidad = lstEtiquetasSeleccionadas[0].Etiqueta.unidad;

                paquetes NuevoPaquete = new paquetes();
                NuevoPaquete.numero_etiqueta = "";
                NuevoPaquete.estatus = "A";
                NuevoPaquete.cantidad = lstEtiquetasSeleccionadas.Sum(o => o.Etiqueta.cantidad);
                NuevoPaquete.unidad = lstEtiquetasSeleccionadas[0].Etiqueta.unidad;
                NuevoPaquete.id_pedido = -1;
                NuevoPaquete.fecha_creacion = getFechaServer();
                NuevoPaquete.fecha_caducidad = getFechaServer();
                NuevoPaquete.clave_articulo = sClave;

                SegContext.paquetes.AddObject(NuevoPaquete);
                SegContext.SaveChanges();

                string sNumeroEtiqueta = getNumeroEtiqueta(NuevoPaquete.id_paquete);
                NuevoPaquete.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
                SegContext.SaveChanges();

                paquetes_det PaqDetalle;
                foreach (EtiquetasTarimas Etiqueta in lstEtiquetasSeleccionadas)
                {
                    PaqDetalle = new paquetes_det();
                    PaqDetalle.id_paquete = NuevoPaquete.id_paquete;
                    PaqDetalle.id_etiqueta = Etiqueta.Etiqueta.id_etiqueta;
                    SegContext.paquetes_det.AddObject(PaqDetalle);
                    SegContext.SaveChanges();
                }

                catalog_comandos_etiquetas oComando =
                    SegContext.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "tarima");

                string sEtiquetaComando =
                    ObtenerComandoContenedorUnProducto(NuevoPaquete, oComando, NuevoPaquete.cantidad,
                                                       sClave, sArticulo, sUnidad);

                Imprimir(sEtiquetaComando);

                Transaccion.Commit();

                MessageBox.Show("Tarima creada con exito");

                BuscarEtiqueas();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();

                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SegContext.Connection.State != ConnectionState.Closed)
                    SegContext.Connection.Close();
            }   
        }

        private int getProductosDiferentes(List<EtiquetasTarimas> lstEtiquetasSeleccionadas)
        {
            int iNumProductos = 0;

            var query = from etiqueta in lstEtiquetasSeleccionadas
                        select etiqueta.Etiqueta.clave_articulo;

            iNumProductos = query.Distinct().Count();

            return iNumProductos;
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }

        public string getNumeroEtiqueta(long pId_etiqueta)
        {
            string ID_SUCURSAL = Config.ID_SUCURSAL_CODIGO_DE_BARRAS;

            //***** El numero <4> Al inicio de la etiqueta, representa que es una Tarima de Recepción
            string numero = "4" + ID_SUCURSAL + pId_etiqueta.ToString().PadLeft(9, '0');
            return numero;
        }

        private string ObtenerComandoContenedorUnProducto
            (paquetes oEtiquetaContenedor, catalog_comandos_etiquetas oCommand, decimal dCantidad,
            string sClave, string sArticulo, string sUnidad)
        {
            string Comando = oCommand.comando;

            Comando = Comando.Replace("|empaque|", oEtiquetaContenedor.fecha_creacion.ToString("dd/MM/yyyy HH:mm"));
            Comando = Comando.Replace("|caducidad|", string.Empty);
            Comando = Comando.Replace("|leyenda|", string.Empty);
            Comando = Comando.Replace("|clave|", sClave);
            Comando = Comando.Replace("|de|", string.Empty);
            Comando = Comando.Replace("|lote|", string.Empty);
            Comando = Comando.Replace("|articulo|", sArticulo);
            Comando = Comando.Replace("|lblCantidadPeso|", "Cantidad");
            Comando = Comando.Replace("|pesoneto|", dCantidad.ToString());
            Comando = Comando.Replace("|unidad|", sUnidad);
            Comando = Comando.Replace("0000000000000", oEtiquetaContenedor.numero_etiqueta);
            Comando = Comando.Replace("|piezas|", string.Empty);

            return Comando;
        }

        private void Imprimir(string Comando)
        {
            string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
            RawPrinter.SendToPrinter("Etiqueta Produccion", Comando, sImpresoraEtiquetas);
        }
    }
}

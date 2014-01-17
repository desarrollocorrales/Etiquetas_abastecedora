using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Entity.Internet;
using Seguimiento_y_Control.Clases.Distribucion;
using Seguimiento_y_Control.Distribucion.Reportes;
using Seguimiento_y_Control.Clases.Utilitarias;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control.Distribucion
{
    public partial class Frm_PedidosVendedores : Form
    {
        private DateTime _FechaServer;
        List<Entity.Internet.usuarios> lstTodosLosUsuarios;
        List<bodegas> LstTodasLasBodegas;
        List<Entity.articulos> LstTodosLosArticulos;

        public Frm_PedidosVendedores()
        {
            InitializeComponent();
        }

        private void Frm_PedidosVendedores_Load(object sender, EventArgs e)
        {
            _FechaServer = getFechaServer();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimirPedidos_Click(object sender, EventArgs e)
        {
            List<GridPedidoVendedor> ListaPedidos = obtenerPedidosSeleccionados();
            if (ListaPedidos.Count == 0)
            {
                //***** No hay pedidos seleccionados
                MessageBox.Show("Por favor seleccione los pedidos que desea imprimir.",
                                "Imprimir Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //**** Imprimir pedidos
                foreach (GridPedidoVendedor pedido in ListaPedidos)
                {
                    ImprimirPedidoPreview(pedido);
                }
            }
        }
        private ReportePedidoVendedor ImprimirPedido(GridPedidoVendedor pedido)
        {
            //***** Contexto para base de datos logis
            Logisn_Entities logisContext = new Logisn_Entities();

            //***** Obtener detalles del pedido
            List<pedidos_detalle> listaDetalles = 
                logisContext.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

            RepPedidoVendedor DetalleReporte;
            List<RepPedidoVendedor> ListaReporte = new List<RepPedidoVendedor>();

            foreach (pedidos_detalle detalle in listaDetalles)
            {
                DetalleReporte = new RepPedidoVendedor();
                DetalleReporte.NumeroPedido = pedido.ID_Pedido;
                DetalleReporte.Usuario = pedido.Usuario;
                DetalleReporte.Cliente = pedido.Cliente;
                DetalleReporte.Ruta = pedido.Ruta;
                DetalleReporte.FechaPedido = pedido.FechaPedido;
                DetalleReporte.FechaSurtir = pedido.FechaSurtir;
                DetalleReporte.Observaciones = pedido.Observaciones;

                DetalleReporte.Codigo = detalle.articulos.clave;
                DetalleReporte.Descripcion = detalle.articulos.nombre;
                DetalleReporte.Cantidad = detalle.cantidad;
                DetalleReporte.Unidad = detalle.unidad;

                ListaReporte.Add(DetalleReporte);
            }

            ImagenReportes Imagen = new ImagenReportes();
            Imagen.ImgReporte = new Bitmap("LogoReportes.jpg");

            ReportePedidoVendedor Reporte = new ReportePedidoVendedor();
            Reporte.ImagenReporte.Add(Imagen);
            Reporte.DataSource = ListaReporte.OrderBy(o=>o.Descripcion).ToList();
            //Reporte.PrintDialog();
            return Reporte;
        }
        private void ImprimirPedidoPreview(GridPedidoVendedor pedido)
        {
            //***** Contexto para base de datos logis
            Logisn_Entities logisContext = new Logisn_Entities();

            //***** Obtener detalles del pedido
            List<pedidos_detalle> listaDetalles =
                logisContext.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

            RepPedidoVendedor DetalleReporte;
            List<RepPedidoVendedor> ListaReporte = new List<RepPedidoVendedor>();

            foreach (pedidos_detalle detalle in listaDetalles)
            {
                DetalleReporte = new RepPedidoVendedor();
                DetalleReporte.NumeroPedido = pedido.ID_Pedido;
                DetalleReporte.Usuario = pedido.Usuario;
                DetalleReporte.Cliente = pedido.Cliente;
                DetalleReporte.Ruta = pedido.Ruta;
                DetalleReporte.FechaPedido = pedido.FechaPedido;
                DetalleReporte.FechaSurtir = pedido.FechaSurtir;
                DetalleReporte.Observaciones = pedido.Observaciones;

                DetalleReporte.Codigo = detalle.articulos.clave;
                DetalleReporte.Descripcion = detalle.articulos.nombre;
                DetalleReporte.Cantidad = detalle.cantidad;
                DetalleReporte.Unidad = detalle.unidad;

                ListaReporte.Add(DetalleReporte);
            }

            ImagenReportes Imagen = new ImagenReportes();
            Imagen.ImgReporte = new Bitmap("LogoReportes.jpg");

            ReportePedidoVendedor Reporte = new ReportePedidoVendedor();
            Reporte.ImagenReporte.Add(Imagen);
            Reporte.DataSource = ListaReporte.OrderBy(o => o.Descripcion).ToList();
            Reporte.ShowPreview();
        }

        private DialogResult Validar(List<GridPedidoVendedor> lstPedidos)
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("Se han seleccionado " + lstPedidos.Count + " pedidos.");
            sb.AppendLine("Se ha seleccioado la ruta: " + cbRutas.Text);
            sb.AppendLine("¿Son datos correctos?");

            DialogResult dr =
            MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr;
        }

        private void btnRequerir_Click(object sender, EventArgs e)
        {
            Requerir();
        }
        private void Requerir()
        {
            //***** Obtener todos los pedidos seleccionados
            List<GridPedidoVendedor> LstPedidos = obtenerPedidosSeleccionados();

            if (LstPedidos.Count == 0)
            {
                MessageBox.Show("Por favor seleccione los pedidos que desea requerir.",
                                "Imprimir Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Validar(LstPedidos) != DialogResult.Yes)
            {
                return;
            }

            pbLoading.Visible = true;

            //Crear entidad a la base de datos de logistica
            Logisn_Entities LogisContexto = new Logisn_Entities();

            //***** Crear el contexto y abrir la conexion
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            SeguimientoContexto.Connection.Open();
            //Crear una transacción                
            IDbTransaction transaccion = SeguimientoContexto.Connection.BeginTransaction();

            //***** Obtener prefijo
            string prefijo = obtenerPrefijoReporte();

            //**** Crear una Lista para TODOS los Encabezados
            List<pedidos_vendedores> LstTodosLosEncabezados = new List<pedidos_vendedores>();
            //**** Crear una Lista para TODOS los detalles
            List<pedidos_vendedores_det> LstTodosLosDetalles = new List<pedidos_vendedores_det>();

            //Crear un Reporte con todos los pedidos;
            ReportePedidoVendedor TodosLosPedidos = new ReportePedidoVendedor();

            //Crear un Reporte para todas las Requisiciones
            RequisicionVendedor TodasLasRequisiciones = new RequisicionVendedor();

            try
            {
                //**** Por cada pedido seleccionado
                foreach (GridPedidoVendedor pedido in LstPedidos)
                {

                    List<pedidos_detalle> ListaDetalles = new List<pedidos_detalle>();

                    //***** Obtener los detalles del pedido
                    ListaDetalles = LogisContexto.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

                    //***** Crear el encabezado del pedido
                    pedidos_vendedores PedidoVendedor = new pedidos_vendedores();
                    PedidoVendedor.id_pedido_portal = pedido.ID_Pedido;
                    PedidoVendedor.fecha = pedido.FechaPedido;
                    PedidoVendedor.id_usuario_portal = pedido.ID_Usuario;
                    PedidoVendedor.id_cliente_portal = pedido.ID_Cliente;
                    PedidoVendedor.fecha_a_surtir = pedido.FechaSurtir;
                    PedidoVendedor.tipo_pedido = "V";
                    PedidoVendedor.estatus = "A";
                    PedidoVendedor.observaciones = pedido.Observaciones;
                    SeguimientoContexto.pedidos_vendedores.AddObject(PedidoVendedor);
                    SeguimientoContexto.SaveChanges();
                    LstTodosLosEncabezados.Add(PedidoVendedor);

                    PedidoVendedor.codigo_pedido = prefijo + "-PV-" + PedidoVendedor.id_pedido_vendedor.ToString().PadLeft(7, '0');
                    SeguimientoContexto.SaveChanges();

                    //***** Crear los detalles del pedido
                    pedidos_vendedores_det DetalleSeguimiento;
                    foreach (pedidos_detalle detalle in ListaDetalles)
                    {
                        DetalleSeguimiento = new pedidos_vendedores_det();
                        DetalleSeguimiento.id_pedido_vendedor = PedidoVendedor.id_pedido_vendedor;
                        DetalleSeguimiento.clave_articulo = detalle.articulos.clave;
                        DetalleSeguimiento.id_bodega = getIdBodega(detalle.articulos.clave);
                        DetalleSeguimiento.cantidad = Convert.ToDecimal(detalle.cantidad.ToString());
                        DetalleSeguimiento.unidad = detalle.unidad;
                        DetalleSeguimiento.id_pedido_maestro_vendedores_det = 0;
                        LstTodosLosDetalles.Add(DetalleSeguimiento);

                        SeguimientoContexto.pedidos_vendedores_det.AddObject(DetalleSeguimiento);
                        SeguimientoContexto.SaveChanges();
                    }
                    SeguimientoContexto.SaveChanges();

                    ReportePedidoVendedor PedidoReporte = ImprimirPedido(pedido);
                    PedidoReporte.CreateDocument();
                    TodosLosPedidos.Pages.AddRange(PedidoReporte.Pages);
                }

                TodosLosPedidos.ShowPreviewDialog();

                //**********************************************************************************************
                //************************************* Pedido Global ******************************************
                //**********************************************************************************************
                pedidos_maestros_vendedores PedidoMaestro = new pedidos_maestros_vendedores();
                PedidoMaestro.id_usuario_creador = Config.user.id_usuario;
                PedidoMaestro.fecha_creacion = Servidor.getFechaServer();
                PedidoMaestro.ruta = cbRutas.Text;
                SeguimientoContexto.pedidos_maestros_vendedores.AddObject(PedidoMaestro);
                SeguimientoContexto.SaveChanges();

                var query = from detalles in LstTodosLosDetalles select detalles.id_bodega;
                List<int> IdsBodegas = query.ToList().Distinct().ToList();

                foreach (int IdBodega in IdsBodegas)
                {
                    pedidos_maestros_vendedores_det PedidoMaestroDet = new pedidos_maestros_vendedores_det();
                    PedidoMaestroDet.id_pedido_maestro_vendedor = PedidoMaestro.id_pedido_maestro_vendedores;
                    PedidoMaestroDet.id_bodega = IdBodega;
                    PedidoMaestroDet.codigo_requisicion = prefijo +
                                                          "-PV-B" +
                                                          IdBodega + "-" +
                                                          PedidoMaestro.id_pedido_maestro_vendedores
                                                          .ToString().PadLeft(7, '0');
                    SeguimientoContexto.pedidos_maestros_vendedores_det.AddObject(PedidoMaestroDet);
                    SeguimientoContexto.SaveChanges();

                    // Obtener todos los articulos de esta bodega
                    List<pedidos_vendedores_det> LstArticulosBodega =
                        LstTodosLosDetalles.FindAll(o => o.id_bodega == IdBodega);

                    RepRequisicionVendedor RowReporte;
                    List<RepRequisicionVendedor> SourceReporte = new List<RepRequisicionVendedor>();
                    foreach (pedidos_vendedores_det ArticuloBodega in LstArticulosBodega)
                    {
                        ArticuloBodega.id_pedido_maestro_vendedores_det = PedidoMaestroDet.id_pedido_maestro_vendedores_det;
                        SeguimientoContexto.SaveChanges();

                        // Encontrar el encabezado
                        pedidos_vendedores Encabezado =
                            LstTodosLosEncabezados.Find(o => o.id_pedido_vendedor == ArticuloBodega.id_pedido_vendedor);

                        RowReporte = new RepRequisicionVendedor();
                        RowReporte.dtFechaSolicitud = Encabezado.fecha;
                        RowReporte.dtFechaSurtir = Encabezado.fecha_a_surtir;
                        RowReporte.sSolicitante = Config.user.nombre;
                        RowReporte.sRuta = cbRutas.Text;
                        RowReporte.sNumeroRequisicion = PedidoMaestroDet.codigo_requisicion;

                        RowReporte.sCodigo = ArticuloBodega.clave_articulo;
                        RowReporte.sDescripcion = LstTodosLosArticulos.Find(o => o.clave == ArticuloBodega.clave_articulo).articulo;
                        RowReporte.fCantidad = ArticuloBodega.cantidad;
                        RowReporte.sUnidad = ArticuloBodega.unidad;
                        RowReporte.sAlmacen = LstTodasLasBodegas.Find(o => o.id_bodega == ArticuloBodega.id_bodega).bodega;
                        SourceReporte.Add(RowReporte);
                    }

                    ImagenReportes Imagen = new ImagenReportes();
                    Imagen.ImgReporte = new Bitmap("LogoReportes.jpg");

                    RequisicionVendedor ReporteRequisicion = new RequisicionVendedor();
                    ReporteRequisicion.ImagenReporte.Add(Imagen);
                    ReporteRequisicion.DataSource = SourceReporte;
                    ReporteRequisicion.CreateDocument();
                    TodasLasRequisiciones.Pages.AddRange(ReporteRequisicion.Pages);
                }

                //************************* Respaldo *********************************************
                string BackUp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RequisicionesVendedores";
                if (System.IO.Directory.Exists(BackUp) == false)
                    System.IO.Directory.CreateDirectory(BackUp);

                TodasLasRequisiciones.ExportToPdf(BackUp +
                                                  "\\RGV_" +
                                                  Servidor.getFechaServer().ToString("ddMMyyyy HHmm") + ".pdf");
                //*********************************************************************************

                TodasLasRequisiciones.ShowPreviewDialog();

                //**********************************************************************************************
                //**********************************************************************************************
                //**********************************************************************************************

                //Marcar los pedidos como Requeridos
                LogisContexto.Connection.Open();
                IDbTransaction TransaccionLogis = LogisContexto.Connection.BeginTransaction();
                try
                {
                    foreach (GridPedidoVendedor pedido in LstPedidos)
                        LogisContexto.pedidos.FirstOrDefault(o => o.id_pedido == pedido.ID_Pedido).requerido = 1;
                    LogisContexto.SaveChanges();

                    TransaccionLogis.Commit();
                    LogisContexto.Connection.Close();
                }
                catch (Exception ex)
                {
                    TransaccionLogis.Rollback();
                    LogisContexto.Connection.Close();
                    throw ex;
                }

                transaccion.Commit();
                SeguimientoContexto.Connection.Close();

                CargarPedidosVendedores();
                pbLoading.Visible = false;

                MessageBox.Show("¡Los pedidos se han procesado con exito!", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                //***** Cerrar la conexion
                SeguimientoContexto.Connection.Close();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sb.AppendLine(ex.InnerException.Message);

                MessageBox.Show(sb.ToString(), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                pbLoading.Visible = false;
                return;
            }
        }

        private void ImprimirRequisicion(List<RepRequisicionVendedor> lstSource)
        {
            ImagenReportes Imagen = new ImagenReportes();
            Imagen.ImgReporte = new Bitmap("LogoReportes.jpg");

            RequisicionVendedor requisicion = new RequisicionVendedor();
            requisicion.ImagenReporte.Add(Imagen);
            requisicion.DataSource = lstSource.OrderBy(o => o.sCodigo).ToList();
            requisicion.PrintDialog();
        }

        #region ***** Funciones *****
        /***********************************************************************************/
        private void CargarPedidosVendedores()
        {
            pbLoading.Visible = true;
            Application.DoEvents();

            //***** Obtener registros para llenar el grid
            List<GridPedidoVendedor> ListaGridPedidosVendedores = getTodosLosPedidos();

            foreach (GridPedidoVendedor RenglonGrid in ListaGridPedidosVendedores)
            {
                RenglonGrid.Usuario = getUsuario(RenglonGrid.ID_Usuario);
            }

            gridPedidos.DataSource = ListaGridPedidosVendedores.OrderBy(o => o.Usuario).ThenBy(o => o.ID_Pedido).ToList();
            gvPedidos.BestFitColumns();

            pbLoading.Visible = false;
        }

        private DateTime getFechaServer()
        {
            Logisn_Entities dataContext = new Logisn_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer.Date;
        }

        
        private string getUsuario(int id_usuario)
        {
            string sUsuario = string.Empty;

            Entity.Internet.usuarios user = lstTodosLosUsuarios.FirstOrDefault(o => o.idusuario == id_usuario);
            if (user != null)
                sUsuario = user.nombre;
            
            return sUsuario;
        }

        private List<GridPedidoVendedor> obtenerPedidosSeleccionados()
        {
            List<GridPedidoVendedor> lstPedidosSeleccionados = (List<GridPedidoVendedor>)gridPedidos.DataSource;
            lstPedidosSeleccionados = lstPedidosSeleccionados.FindAll(o => o.Seleccion == true);
            return lstPedidosSeleccionados;
        }

        private string obtenerPrefijoReporte()
        {
            string prefijo = string.Empty;
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();

            try
            {
                prefijo = SeguimientoContexto.configuracion.FirstOrDefault(o => o.config == "sucursal").valor;
                return prefijo;
            }
            catch
            {
                throw;
            }
        }

        private void CambiarStatusRequerido(int id_pedido)
        {
            Logisn_Entities LogisContexto = new Logisn_Entities();
            pedidos oPedido = LogisContexto.pedidos.FirstOrDefault(o => o.id_pedido == id_pedido);
            oPedido.requerido = 1;
            LogisContexto.SaveChanges();
            LogisContexto.Dispose();
        }
        /************************************************************************************/
        #endregion

        private List<Entity.Internet.usuarios> getTodosLosUsuarios()
        {
            Portal_Entities PortalContext = new Portal_Entities();
            List<Entity.Internet.usuarios> lstUsuarios = PortalContext.usuarios.ToList();
            return lstUsuarios;
        }

        private List<GridPedidoVendedor> getTodosLosPedidos()
        {
            List<GridPedidoVendedor> listaGrid = new List<GridPedidoVendedor>();
            string query = @"Select
  	                              pedidos.id_pedido As ID_Pedido,
  	                              pedidos.id_usuario As ID_Usuario,
	                              pedidos.fecha_hora_creacion As FechaPedido,	
	                              pedidos.fecha_surtir As FechaSurtir,
	                              clientes.id_cliente As ID_Cliente,
	                              clientes.nombre As Cliente,
	                              rutas.ruta As Ruta,
	                              pedidos.observaciones As Observaciones
                              From 
	                              pedidos 
	                              Inner Join ventas on pedidos.id_pedido = ventas.id_pedido
	                              Inner Join clientes on ventas.id_cliente = clientes.id_cliente
	                              Inner Join rutas on rutas.id_ruta = clientes.id_ruta
                              Where
	                              pedidos.requerido=0 and
	                              pedidos.fecha_surtir >= DATE(now());";
            Logisn_Entities dataContext = new Logisn_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<GridPedidoVendedor>(query);
            listaGrid = queryResults.ToList();
            return listaGrid;
        }

        private void Frm_PedidosVendedores_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            lstTodosLosUsuarios = getTodosLosUsuarios();
            CargarPedidosVendedores();
            CargarRutas();
            CargarTodasLasBodegasYTodosArticulos();
        }

        private void CargarRutas()
        {
            Logisn_Entities LogisContext = new Logisn_Entities();
            List<rutas> LstRutas = LogisContext.rutas.ToList();
            cbRutas.DataSource = LstRutas;
        }

        private void CargarTodasLasBodegasYTodosArticulos()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            LstTodasLasBodegas = SegContext.bodegas.ToList();
            LstTodosLosArticulos = SegContext.articulos.ToList();
        }

        private int getIdBodega(string clave_articulo)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            Entity.articulos Articulo
                = SegContext.articulos.FirstOrDefault(o => o.clave == clave_articulo);
            return Articulo.id_bodega;
        }
    }
}

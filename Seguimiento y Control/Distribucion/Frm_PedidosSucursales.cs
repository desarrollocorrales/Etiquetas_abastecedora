using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity.Internet;
using Seguimiento_y_Control.Clases.Distribucion;
using Seguimiento_y_Control.Distribucion.Reportes;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Utilitarias;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control.Distribucion
{
    public partial class Frm_PedidosSucursales : Form
    {
        private DateTime _FechaServer;
        private List<EncargadoSucursal> lstEncargados;
        List<Entity.Internet.usuarios> lstTodosLosUsuarios;
        List<bodegas> LstTodasLasBodegas;
        List<Entity.articulos> LstTodosLosArticulos;

        public Frm_PedidosSucursales()
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
            List<GridPedidoSucursal> ListaPedidos = obtenerPedidosSeleccionados();
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
                foreach (GridPedidoSucursal pedido in ListaPedidos)
                {
                    ImprimirPedidoPreview(pedido);
                }
            }
        }
        private ReportePedido ImprimirPedido(GridPedidoSucursal pedido)
        {
            //***** Contexto para base de datos logis
            Logisn_Entities logisContext = new Logisn_Entities();

            //***** Obtener detalles del pedido
            List<pedidos_detalle> listaDetalles = 
                logisContext.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

            RepPedidoSucursal DetalleReporte;
            List<RepPedidoSucursal> ListaReporte = new List<RepPedidoSucursal>();

            foreach (pedidos_detalle detalle in listaDetalles)
            {
                DetalleReporte = new RepPedidoSucursal();
                DetalleReporte.NumeroPedido = pedido.ID_Pedido;
                DetalleReporte.Responsable = pedido.Responsable;
                DetalleReporte.Sucursal = pedido.Sucursal;
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

            ReportePedido Reporte = new ReportePedido();
            Reporte.ImagenLogo.Add(Imagen);
            Reporte.DataSource = ListaReporte.OrderBy(o=>o.Descripcion).ToList();

            return Reporte;
        }
        private void ImprimirPedidoPreview(GridPedidoSucursal pedido)
        {
            //***** Contexto para base de datos logis
            Logisn_Entities logisContext = new Logisn_Entities();

            //***** Obtener detalles del pedido
            List<pedidos_detalle> listaDetalles =
                logisContext.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

            RepPedidoSucursal DetalleReporte;
            List<RepPedidoSucursal> ListaReporte = new List<RepPedidoSucursal>();

            foreach (pedidos_detalle detalle in listaDetalles)
            {
                DetalleReporte = new RepPedidoSucursal();
                DetalleReporte.NumeroPedido = pedido.ID_Pedido;
                DetalleReporte.Responsable = pedido.Responsable;
                DetalleReporte.Sucursal = pedido.Sucursal;
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

            ReportePedido Reporte = new ReportePedido();
            Reporte.ImagenLogo.Add(Imagen);
            Reporte.DataSource = ListaReporte.OrderBy(o => o.Descripcion).ToList();
            Reporte.ShowPreview();
        }

        private DialogResult Validar(List<GridPedidoSucursal> lstPedidos)
        {
            var query = from pedido in lstPedidos select pedido.Sucursal;
            List<string> lstSucursales = query.ToList().Distinct().ToList();
            
            if (lstSucursales.Count != 1)
            {
                MessageBox.Show("No puede agrupar pedidos de diferentes sucursales", 
                                "Validar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return DialogResult.No;
            }

            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("Se han seleccionado " + lstPedidos.Count + " pedidos.");
            sb.AppendLine("Para la sucursal: " + lstSucursales[0].ToUpper());
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
            List<GridPedidoSucursal> LstPedidos = obtenerPedidosSeleccionados();

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

            string sSucursal = LstPedidos[0].Sucursal;

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
            List<pedidos_sucursales> LstTodosLosEncabezados = new List<pedidos_sucursales>();
            //**** Crear una Lista para TODOS los detalles
            List<pedidos_sucursales_det> LstTodosLosDetalles = new List<pedidos_sucursales_det>();

            //Crear un Reporte con todos los pedidos;
            ReportePedido TodosLosPedidos = new ReportePedido();

            //Crear un Reporte para todas las Requisiciones
            RequisicionSucursal TodasLasRequisiciones = new RequisicionSucursal();

            try
            {
                //**** Por cada pedido seleccionado
                foreach (GridPedidoSucursal pedido in LstPedidos)
                {
                    List<pedidos_detalle> ListaDetalles = new List<pedidos_detalle>();

                    //***** Obtener los detalles del pedido
                    ListaDetalles = LogisContexto.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

                    //***** Crear el encabezado del pedido
                    pedidos_sucursales PedidoSucursal = new pedidos_sucursales();
                    PedidoSucursal.id_pedido_portal = pedido.ID_Pedido;
                    PedidoSucursal.fecha = pedido.FechaPedido;
                    PedidoSucursal.fecha_a_surtir = pedido.FechaSurtir;
                    PedidoSucursal.id_usuario_portal = pedido.ID_Usuario;
                    PedidoSucursal.tipo_pedido = "S";
                    PedidoSucursal.estatus = "A";
                    PedidoSucursal.observaciones = pedido.Observaciones;
                    SeguimientoContexto.pedidos_sucursales.AddObject(PedidoSucursal);
                    SeguimientoContexto.SaveChanges();

                    LstTodosLosEncabezados.Add(PedidoSucursal);

                    PedidoSucursal.codigo_pedido = 
                        prefijo + "-PS-" + PedidoSucursal.id_pedido_sucursal.ToString().PadLeft(7, '0');

                    SeguimientoContexto.SaveChanges();

                    //***** Crear los detalles del pedido
                    pedidos_sucursales_det DetalleSeguimiento;
                    foreach (pedidos_detalle detalle in ListaDetalles)
                    {
                        DetalleSeguimiento = new pedidos_sucursales_det();
                        DetalleSeguimiento.id_pedido_sucursal = PedidoSucursal.id_pedido_sucursal;
                        DetalleSeguimiento.clave_articulo = detalle.articulos.clave;
                        DetalleSeguimiento.id_bodega = getIdBodega(detalle.articulos.clave);
                        DetalleSeguimiento.cantidad = Convert.ToDecimal(detalle.cantidad.ToString());
                        DetalleSeguimiento.unidad = detalle.unidad;
                        DetalleSeguimiento.id_pedido_maestro_sucursales_det = 0;
                        LstTodosLosDetalles.Add(DetalleSeguimiento);

                        SeguimientoContexto.pedidos_sucursales_det.AddObject(DetalleSeguimiento);
                        SeguimientoContexto.SaveChanges();
                    }
                    SeguimientoContexto.SaveChanges();

                    ReportePedido PedidoReporte = ImprimirPedido(pedido);
                    PedidoReporte.CreateDocument();
                    TodosLosPedidos.Pages.AddRange(PedidoReporte.Pages);
                }

                TodosLosPedidos.ShowPreviewDialog();

                //**********************************************************************************************
                //************************************* Pedido Global ******************************************
                //**********************************************************************************************
                pedidos_maestros_sucursales PedidoMaestro = new pedidos_maestros_sucursales();
                PedidoMaestro.id_usuario_creador = Config.user.id_usuario;
                PedidoMaestro.fecha_creacion = Servidor.getFechaServer();
                PedidoMaestro.ruta = sSucursal;
                SeguimientoContexto.pedidos_maestros_sucursales.AddObject(PedidoMaestro);
                SeguimientoContexto.SaveChanges();

                var query = from detalles in LstTodosLosDetalles select detalles.id_bodega;
                List<int> IdsBodegas = query.ToList().Distinct().ToList();

                foreach (int IdBodega in IdsBodegas)
                {
                    pedidos_maestros_sucursales_det PedidoMaestroDet = new pedidos_maestros_sucursales_det();
                    PedidoMaestroDet.id_pedido_maestro_sucursal = PedidoMaestro.id_pedido_maestro_sucursal;
                    PedidoMaestroDet.id_bodega = IdBodega;
                    PedidoMaestroDet.codigo_requisicion = prefijo +
                                                          "-PS-B" +
                                                          IdBodega + "-" +
                                                          PedidoMaestro.id_pedido_maestro_sucursal
                                                          .ToString().PadLeft(7, '0');
                    SeguimientoContexto.pedidos_maestros_sucursales_det.AddObject(PedidoMaestroDet);
                    SeguimientoContexto.SaveChanges();

                    // Obtener todos los articulos de esta bodega
                    List<pedidos_sucursales_det> LstArticulosBodega =
                        LstTodosLosDetalles.FindAll(o => o.id_bodega == IdBodega);

                    RepRequisicionSucursal RowReporte;
                    List<RepRequisicionSucursal> SourceReporte = new List<RepRequisicionSucursal>();
                    foreach (pedidos_sucursales_det ArticuloBodega in LstArticulosBodega)
                    {
                        ArticuloBodega.id_pedido_maestro_sucursales_det = 
                            PedidoMaestroDet.id_pedido_maestro_sucursal_det;

                        SeguimientoContexto.SaveChanges();

                        // Encontrar el encabezado
                        pedidos_sucursales Encabezado =
                            LstTodosLosEncabezados.Find(o => o.id_pedido_sucursal == ArticuloBodega.id_pedido_sucursal);

                        RowReporte = new RepRequisicionSucursal();
                        RowReporte.dtFechaSolicitud = Encabezado.fecha;
                        RowReporte.dtFechaSurtir = Encabezado.fecha_a_surtir;
                        RowReporte.sSolicitante = Config.user.nombre;
                        RowReporte.sDestino = sSucursal;
                        RowReporte.sNumeroRequisicion = PedidoMaestroDet.codigo_requisicion;

                        RowReporte.sCodigo = ArticuloBodega.clave_articulo;
                        RowReporte.sDescripcion = 
                            LstTodosLosArticulos.Find(o => o.clave == ArticuloBodega.clave_articulo).articulo;
                        RowReporte.fCantidad = ArticuloBodega.cantidad;
                        RowReporte.sUnidad = ArticuloBodega.unidad;
                        RowReporte.sAlmacen = LstTodasLasBodegas.Find(o => o.id_bodega == ArticuloBodega.id_bodega).bodega;
                        SourceReporte.Add(RowReporte);
                    }

                    ImagenReportes Imagen = new ImagenReportes();
                    Imagen.ImgReporte = new Bitmap("LogoReportes.jpg");

                    RequisicionSucursal ReporteRequisicion = new RequisicionSucursal();
                    ReporteRequisicion.ImagenReporte.Add(Imagen);
                    ReporteRequisicion.DataSource = SourceReporte;
                    ReporteRequisicion.CreateDocument();

                    TodasLasRequisiciones.Pages.AddRange(ReporteRequisicion.Pages);
                }

                //************************* Respaldo *********************************************
                string BackUp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RequisicionesSucursales";
                if (System.IO.Directory.Exists(BackUp) == false)
                    System.IO.Directory.CreateDirectory(BackUp);

                TodasLasRequisiciones.ExportToPdf(BackUp + 
                                                  "\\RGS_" + 
                                                  Servidor.getFechaServer().ToString("ddMMyyyy HHmm")+ ".pdf");
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
                    foreach (GridPedidoSucursal pedido in LstPedidos)
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

                CargarPedidosSucursales();
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

        private List<GridPedidoSucursal> obtenerPedidosSeleccionados()
        {
            List<GridPedidoSucursal> lstPedidosSeleccionados = (List<GridPedidoSucursal>)gridPedidos.DataSource;
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

        private void Frm_PedidosVendedores_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            lstTodosLosUsuarios = getTodosLosUsuarios();
            CargarPedidosSucursales();
            CargarTodasLasBodegasYTodosArticulos();
        }

        private void CargarRutas()
        {
            Logisn_Entities LogisContext = new Logisn_Entities();
            List<rutas> LstRutas = LogisContext.rutas.ToList();
            //cbRutas.DataSource = LstRutas;
        }

        private void CargarTodasLasBodegasYTodosArticulos()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            LstTodasLasBodegas = SegContext.bodegas.ToList();
            LstTodosLosArticulos = SegContext.articulos.ToList();
        }

        private List<EncargadoSucursal> getTodosEncargadosSucursales()
        {
            List<EncargadoSucursal> listaEncargados = new List<EncargadoSucursal>();
            string query = @"Select 
                                  idusuario As ID_Usuario,
                                  usuarios.nombre As NombreUsuario,
                                  empresas.id_empresa As ID_Empresa,
                                  empresas.nombre_corto As NombreEmpresa
                              From
                                  usuarios
                                  Inner Join
                                      empresas ON empresas.id_empresa = usuarios.id_empresa";
            Portal_Entities dataContext = new Portal_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<EncargadoSucursal>(query);
            listaEncargados = queryResults.ToList();
            return listaEncargados;
        }

        private string getSucursal(int id_usuario)
        {
            EncargadoSucursal Encargado = lstEncargados.FirstOrDefault(o => o.ID_Usuario == id_usuario);
            return Encargado.NombreEmpresa;
        }

        private string getResponsable(int id_usuario)
        {
            EncargadoSucursal Encargado = lstEncargados.FirstOrDefault(o => o.ID_Usuario == id_usuario);
            return Encargado.NombreUsuario;
        }

        private void CargarPedidosSucursales()
        {
            pbLoading.Visible = true;
            Application.DoEvents();

            //***** Obtener registros para llenar el grid
            List<GridPedidoSucursal> ListaPedidosSucursal = getTodosLosPedidos();

            foreach (GridPedidoSucursal RowGrid in ListaPedidosSucursal)
            {
                RowGrid.Responsable = getResponsable(RowGrid.ID_Usuario);
                RowGrid.Sucursal = getSucursal(RowGrid.ID_Usuario);
            }

            gridPedidos.DataSource = ListaPedidosSucursal.OrderBy(o => o.Sucursal).ThenBy(o => o.FechaSurtir).ToList();
            gvPedidos.BestFitColumns();

            pbLoading.Visible = false;
        }

        private List<GridPedidoSucursal> getTodosLosPedidos()
        {
            List<GridPedidoSucursal> listaGrid = new List<GridPedidoSucursal>();
            string query = @"Select
	                              pedidos.id_pedido As ID_Pedido,
	                              pedidos.id_usuario As ID_Usuario,
	                              pedidos.fecha_hora_creacion As FechaPedido,	
	                              pedidos.fecha_surtir As FechaSurtir,
	                              pedidos.observaciones As Observaciones
                               From 
	                              pedidos 
	                              Left Join ventas on pedidos.id_pedido = ventas.id_pedido
	                              Left Join clientes on ventas.id_cliente = clientes.id_cliente
	                              left Join rutas on rutas.id_ruta = clientes.id_ruta
                              Where
	                              pedidos.requerido=0 and
	                              pedidos.fecha_surtir >= DATE(now()) and
	                              clientes.id_cliente is null;";
            Logisn_Entities dataContext = new Logisn_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<GridPedidoSucursal>(query);
            listaGrid = queryResults.ToList();
            return listaGrid;
        }

        private void Frm_PedidosSucursales_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            lstEncargados = getTodosEncargadosSucursales();
            CargarPedidosSucursales();
            CargarTodasLasBodegasYTodosArticulos();
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

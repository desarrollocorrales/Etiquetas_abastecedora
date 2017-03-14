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

namespace Seguimiento_y_Control.Distribucion
{
    public partial class Frm_DistibucionVendedores : Form
    {
        private List<Entity.Internet.usuarios> lstTodosLosUsuarios;
        private List<pedidos> lstPedidosPoral;
        private List<pedidos_detalle> lstPedidosDetallesPortal;
        private List<GridPedidoVendedor> lstPedidosMarcados;

        public Frm_DistibucionVendedores()
        {
            InitializeComponent();
        }

        private void CargarRutas()
        {
            Logisn_Entities LogisContext = new Logisn_Entities();
            List<rutas> LstRutas = LogisContext.rutas.ToList();
            cbRutas.DataSource = LstRutas;
        }
        
        private void CargarUsuariosPortal()
        {
            Portal_Entities PortalContext = new Portal_Entities();
            lstTodosLosUsuarios = PortalContext.usuarios.Where(o => o.status == 1).ToList();
        }

        private void CargarPedidosVendedores()
        {
            //***** Obtener registros para llenar el grid
            List<GridPedidoVendedor> ListaGridPedidosVendedores = ObtenerPedidosSinRequerir();

            foreach (GridPedidoVendedor RenglonGrid in ListaGridPedidosVendedores)
            {
                Entity.Internet.usuarios user = lstTodosLosUsuarios.FirstOrDefault(o => o.idusuario == RenglonGrid.ID_Usuario);
                if (user != null)
                {
                    RenglonGrid.Usuario = lstTodosLosUsuarios.FirstOrDefault(o => o.idusuario == RenglonGrid.ID_Usuario).nombre;
                }
                else
                {
                    RenglonGrid.Usuario = string.Empty;
                }
            }

            gridPedidos.DataSource = ListaGridPedidosVendedores.OrderBy(o => o.Usuario).ThenBy(o => o.ID_Pedido).ToList();
            gvPedidos.BestFitColumns();
        }

        private List<GridPedidoVendedor> ObtenerPedidosSinRequerir()
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

        private DateTime getFechaServer()
        {
            Logisn_Entities dataContext = new Logisn_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer.Date;
        }

        private List<GridPedidoVendedor> ObtenerPedidosMarcados()
        {
            List<GridPedidoVendedor> lstPedidosSeleccionados = (List<GridPedidoVendedor>)gridPedidos.DataSource;
            lstPedidosSeleccionados = lstPedidosSeleccionados.FindAll(o => o.Seleccion == true);
            return lstPedidosSeleccionados;
        }

        private void ObtenerPedidosPortal(List<GridPedidoVendedor> lstPedidosMarcados)
        {
            int i = 0;
            lstPedidosPoral = new List<pedidos>();
            lstPedidosDetallesPortal = new List<pedidos_detalle>();
      
            using (var ContextoLogistica = new Logisn_Entities())
            {
                foreach (GridPedidoVendedor pedido in lstPedidosMarcados)
                {
                    var lstPedDet = ContextoLogistica.pedidos_detalle.Where(o => o.id_pedido == pedido.ID_Pedido).ToList();

                    pedidos_detalle pedido_detalle_portal;
                    foreach (pedidos_detalle pedet in lstPedDet)
                    {
                        pedido_detalle_portal = new pedidos_detalle();
                        pedido_detalle_portal.id_pedido = pedet.id_pedido;
                        pedido_detalle_portal.id_articulo = pedet.id_articulo;
                        pedido_detalle_portal.cantidad = pedet.cantidad;
                        pedido_detalle_portal.unidad = pedet.unidad;
                        pedido_detalle_portal.resto = pedet.resto;

                        lstPedidosDetallesPortal.Add(pedido_detalle_portal);
                    }
                    
                    i++;
                    bgwProceso.ReportProgress(i);
                }
            }
        }

        private void CrearRegistroDePedidos()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();

            try
            {
                pedidos_vendedores pedvend;
                foreach (GridPedidoVendedor pedido in lstPedidosMarcados)
                {
                    pedvend = new pedidos_vendedores();
                    pedvend.id_pedido_portal = pedido.ID_Pedido;
                    pedvend.fecha = pedido.FechaPedido;
                    pedvend.id_usuario_portal = pedido.ID_Usuario;
                    pedvend.id_cliente_portal = pedido.ID_Cliente;
                    pedvend.fecha_a_surtir = pedido.FechaSurtir;
                    pedvend.tipo_pedido = "V";
                    pedvend.estatus = "A";
                    pedvend.observaciones = pedido.Observaciones;

                    pedidos_vendedores_det pedvendet;
                    var lstDetallesPed = lstPedidosDetallesPortal.Where(o => o.id_pedido == pedido.ID_Pedido);
                    foreach (pedidos_detalle pedido_detalle in lstPedidosDetallesPortal)
                    {
                        pedvendet = new pedidos_vendedores_det();
                        pedvendet.id_pedido_vendedor = pedvend.id_pedido_vendedor;
                        pedvendet.clave_articulo = pedido_detalle.articulos.clave;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Requerir()
        {
            
            // Obtener los Pedidos Marcados
            lstPedidosMarcados = ObtenerPedidosMarcados();

            // Obtener los detalles de los pedidos
            pbLoading.Visible = true;
            bgwProceso.WorkerReportsProgress = true;
            bgwProceso.RunWorkerAsync();

            // Crear una transacción

            //   Crear encabezado

            //   Crear detalle

            // Cerrar Transaccion con un commit
        }

        private void Frm_DistibucionVendedores_Load(object sender, EventArgs e)
        {
            CargarRutas();
        }
        private void Frm_DistibucionVendedores_Shown(object sender, EventArgs e)
        {
            try
            {
                pbLoading.Visible = true;
                Application.DoEvents();

                CargarUsuariosPortal();
                CargarPedidosVendedores();

                pbLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRequerir_Click(object sender, EventArgs e)
        {
            try
            {
                Requerir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bgwProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            ObtenerPedidosPortal(lstPedidosMarcados);
        }

        private void bgwProceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwInserts.WorkerReportsProgress = true;
            bgwInserts.RunWorkerAsync();
        }

        private void bgwProceso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblAccion.Text = "Registros procesados: " + e.ProgressPercentage;
        }

        private void bgwInserts_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwInserts_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwInserts_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbLoading.Visible = false;
            MessageBox.Show("Termino el proceso");
        }
    }
}

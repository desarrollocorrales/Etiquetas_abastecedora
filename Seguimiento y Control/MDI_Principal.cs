using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Topos.RecepcionProveedores;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Produccion;
using Seguimiento_y_Control.Topos.EntregaMateraPrima;
using Seguimiento_y_Control.Distribucion;
using Seguimiento_y_Control.Administracion;
using Seguimiento_y_Control.Administracion.Articulos;
using Seguimiento_y_Control.Topos.EntregaExterna;
using Seguimiento_y_Control.Administracion.Bodegas;
using Seguimiento_y_Control.Administracion.Usuarios;
using Seguimiento_y_Control.Administracion.Areas;
using Seguimiento_y_Control.Reportes;
using Seguimiento_y_Control.Administracion.Devoluciones;
using Seguimiento_y_Control.Topos.Reimpresion;
using Seguimiento_y_Control.Administracion.Reimpresiones;

namespace Seguimiento_y_Control
{
    public partial class MDI_Principal : Form
    {
        private Frm_RecepcionProveedores frm_RecepcionProveedores;
        private Frm_RecepcionInterna frm_RecepcionInterna;
        private Frm_RequisicionesInternas frm_RequisicionesInternas;
        private Frm_EntregaMateriaPrima frm_EntrgaMateriaPrima;
        private Frm_Procesados frm_Procesados;
        private Frm_Procesados frm_ProcesadosCortes;
        private Frm_Procesados frm_Mantequera;
        private Frm_PedidosSucursales frm_PedidosSucursales;
        private Frm_PedidosVendedores frm_PedidosVendedores;
        private Frm_AdmImpresoras frmAdmImpresoras;
        private Frm_Articulos frmArticulos;
        private Frm_EntregaExternaVendedor frmEntregasVendedor;
        private Frm_EntregaExternaSucursales frmEntregaSucursal;
        private Frm_Bodegas frmBodegas;
        private Frm_Usuarios frmUsuarios;
        private Frm_Areas frmAreas;
        private Frm_EnvioEtiquetas frmEnvioEtiquetas;
        private Frm_Tarimas frmTarimasProduccion;
        private Frm_CrearTarimas frmTarimasRecepcion;
        private Frm_ReporteProduccion frmReporteProduccion;
        private Frm_ReporteRecepcion frmReporteRecepcion;
        private Frm_CerrarPedidos frmCerrarPedidos;
        private Frm_Devoluciones frmDevoluciones;
        private Frm_ImprimirTarima frmImprimirTarima;
        private Frm_ReimprirSalida frmReimprimirSalida;
        private Frm_ReimprimirEtiqueta frmReimprimirEtiqueta;
        private Frm_Eliminar_Etiquetas frmEliminarEtiquetas;
        private Frm_ReporteMovimientos frmReporteMovimientos;

        public MDI_Principal()
        {
            InitializeComponent();        
        }

        private void barRecepcion_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_RecepcionProveedores.IsDisposed)
            {
                frm_RecepcionProveedores = new Frm_RecepcionProveedores();
                frm_RecepcionProveedores.MdiParent = this;
                frm_RecepcionProveedores.WindowState = FormWindowState.Maximized;
                frm_RecepcionProveedores.Show();
            }
            else
            {
                frm_RecepcionProveedores.WindowState = FormWindowState.Maximized;
            }
        }

        private void MDI_Principal_Load(object sender, EventArgs e)
        {
            navMenuPrincipal.Groups["gBlank"].Expanded = true;
            InicializarFormularios();
            CargarPermisos();

            if (Properties.Settings.Default.Impresora.Equals(string.Empty))
            {
                MessageBox.Show("Seleccione la impresora de etiquetas por favor.");
                frmAdmImpresoras = new Frm_AdmImpresoras();
                frmAdmImpresoras.MdiParent = this;
                frmAdmImpresoras.WindowState = FormWindowState.Maximized;
                frmAdmImpresoras.Show();
            }

            this.WindowState = FormWindowState.Maximized;
            this.Text = this.Text + " -=[" + Seguimiento_y_Control.Clases.Configuracion.Config.user.nombre + "]=-";
            this.Text = this.Text.ToUpper();
        }
        private void CargarPermisos()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            int id_usuario = Seguimiento_y_Control.Clases.Configuracion.Config.user.id_usuario;
            permisos oPermisos = SeguimientoContexto.permisos.SingleOrDefault(o => o.id_usuario == id_usuario);
            if (oPermisos != null)
            {
                //***************************** Menu Principal *****************************************
                foreach (DevExpress.XtraNavBar.NavBarGroup NavBar in navMenuPrincipal.Groups)
                {                    
                    if (NavBar.Tag != null)
                    {
                        NavBar.Visible = false;
                        string sPermiso = oPermisos.cadena_permisos.ToUpper();
                        string sTag = NavBar.Tag.ToString().ToUpper();

                        if (sPermiso.Contains(sTag))
                        {
                            //***** Activar Permiso *****
                            NavBar.Visible = true;

                            //********************** Activar Items *************************************
                            foreach (DevExpress.XtraNavBar.NavBarItemLink Item in NavBar.ItemLinks)
                            {
                                if (Item.Item.Tag != null)
                                {
                                    Item.Item.Enabled = false;

                                    sTag = Item.Item.Tag.ToString().ToUpper();

                                    if (sPermiso.Contains(sTag))
                                    {
                                        //***** Activar Permiso *****
                                        Item.Item.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
                //**************************************************************************************
            }
        }

        private void InicializarFormularios()
        {
            frm_RecepcionProveedores = new Frm_RecepcionProveedores();
            frm_RecepcionProveedores.Dispose();

            frm_RecepcionInterna = new Frm_RecepcionInterna();
            frm_RecepcionInterna.Dispose();

            frm_RequisicionesInternas = new Frm_RequisicionesInternas();
            frm_RequisicionesInternas.Dispose();

            frm_EntrgaMateriaPrima = new Frm_EntregaMateriaPrima();
            frm_EntrgaMateriaPrima.Dispose();

            frm_Procesados = new Frm_Procesados();
            frm_Procesados.Dispose();

            frm_ProcesadosCortes = new Frm_Procesados();
            frm_ProcesadosCortes.Dispose();

            frm_Mantequera = new Frm_Procesados();
            frm_Mantequera.Dispose();

            frm_PedidosSucursales = new Frm_PedidosSucursales();
            frm_PedidosSucursales.Dispose();

            frm_PedidosVendedores = new Frm_PedidosVendedores();
            frm_PedidosVendedores.Dispose();

            frmAdmImpresoras = new Frm_AdmImpresoras();
            frmAdmImpresoras.Dispose();

            frmArticulos = new Frm_Articulos();
            frmArticulos.Dispose();

            frmEntregasVendedor = new Frm_EntregaExternaVendedor();
            frmEntregasVendedor.Dispose();

            frmEntregaSucursal = new Frm_EntregaExternaSucursales();
            frmEntregaSucursal.Dispose();

            frmBodegas = new Frm_Bodegas();
            frmBodegas.Dispose();

            frmUsuarios = new Frm_Usuarios();
            frmUsuarios.Dispose();

            frmAreas = new Frm_Areas();
            frmAreas.Dispose();

            frmEnvioEtiquetas = new Frm_EnvioEtiquetas();
            frmEnvioEtiquetas.Dispose();

            frmTarimasProduccion = new Frm_Tarimas();
            frmTarimasProduccion.Dispose();

            frmTarimasRecepcion = new Frm_CrearTarimas();
            frmTarimasRecepcion.Dispose();

            frmReporteProduccion = new Frm_ReporteProduccion();
            frmReporteProduccion.Dispose();

            frmReporteRecepcion = new Frm_ReporteRecepcion();
            frmReporteRecepcion.Dispose();

            frmCerrarPedidos = new Frm_CerrarPedidos();
            frmCerrarPedidos.Dispose();

            frmDevoluciones = new Frm_Devoluciones();
            frmDevoluciones.Dispose();

            frmImprimirTarima = new Frm_ImprimirTarima();
            frmImprimirTarima.Dispose();

            frmReimprimirSalida = new Frm_ReimprirSalida();
            frmReimprimirSalida.Dispose();

            frmReimprimirEtiqueta = new Frm_ReimprimirEtiqueta();
            frmReimprimirEtiqueta.Dispose();

            frmEliminarEtiquetas = new Frm_Eliminar_Etiquetas();
            frmEliminarEtiquetas.Dispose();

            frmReporteMovimientos = new Frm_ReporteMovimientos();
            frmReporteMovimientos.Dispose();
        }

        private void navRequerir_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_RequisicionesInternas.IsDisposed)
            {
                frm_RequisicionesInternas = new Frm_RequisicionesInternas();
                frm_RequisicionesInternas.MdiParent = this;
                frm_RequisicionesInternas.WindowState = FormWindowState.Maximized;
                frm_RequisicionesInternas.Show();
            }
            else
            {
                frm_RequisicionesInternas.WindowState = FormWindowState.Maximized;
            }
        }

        private void barRecepcionInterna_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_RecepcionInterna.IsDisposed)
            {
                frm_RecepcionInterna = new Frm_RecepcionInterna();
                frm_RecepcionInterna.MdiParent = this;
                frm_RecepcionInterna.WindowState = FormWindowState.Maximized;
                frm_RecepcionInterna.Show();
            }
            else
            {
                frm_RecepcionInterna.WindowState = FormWindowState.Maximized;
            }
        }

        private void navEntregarMateria_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_EntrgaMateriaPrima.IsDisposed)
            {
                frm_EntrgaMateriaPrima = new Frm_EntregaMateriaPrima();
                frm_EntrgaMateriaPrima.MdiParent = this;
                frm_EntrgaMateriaPrima.WindowState = FormWindowState.Maximized;
                frm_EntrgaMateriaPrima.Show();
            }
            else
            {
                frm_EntrgaMateriaPrima.WindowState = FormWindowState.Maximized;
            }
        }

        private void barProcesados_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_Procesados.IsDisposed)
            {
                frm_Procesados = new Frm_Procesados();
                frm_Procesados.MdiParent = this;
                frm_Procesados.WindowState = FormWindowState.Maximized;
                frm_Procesados.lblTitulo.Text = "Procesados";
                frm_Procesados.Show();
            }
            else
            {
                frm_Procesados.WindowState = FormWindowState.Maximized;
            }
        }

        private void barCortes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_ProcesadosCortes.IsDisposed)
            {
                frm_ProcesadosCortes = new Frm_Procesados();
                frm_ProcesadosCortes.MdiParent = this;
                frm_ProcesadosCortes.WindowState = FormWindowState.Maximized;
                frm_ProcesadosCortes.lblTitulo.Text = "Cortes";
                frm_ProcesadosCortes.Show();
            }
            else
            {
                frm_ProcesadosCortes.WindowState = FormWindowState.Maximized;
            }
        }

        private void itmPedidoSucursales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_PedidosSucursales.IsDisposed)
            {
                frm_PedidosSucursales = new Frm_PedidosSucursales();
                frm_PedidosSucursales.MdiParent = this;
                frm_PedidosSucursales.WindowState = FormWindowState.Maximized;
                frm_PedidosSucursales.Show();
            }
            else
            {
                frm_PedidosSucursales.WindowState = FormWindowState.Maximized;
            }
        }

        private void itmPedidosVendedores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            if (frm_PedidosVendedores.IsDisposed)
            {
                frm_PedidosVendedores = new Frm_PedidosVendedores();
                frm_PedidosVendedores.MdiParent = this;
                frm_PedidosVendedores.WindowState = FormWindowState.Maximized;
                frm_PedidosVendedores.Show();
            }
            else
            {
                frm_PedidosVendedores.WindowState = FormWindowState.Maximized;
            }
        }

        private void barImpresora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmAdmImpresoras.IsDisposed)
            {
                frmAdmImpresoras = new Frm_AdmImpresoras();
                frmAdmImpresoras.MdiParent = this;
                frmAdmImpresoras.WindowState = FormWindowState.Maximized;
                frmAdmImpresoras.Show();
            }
            else
            {
                frmAdmImpresoras.WindowState = FormWindowState.Maximized;
            }
        }

        private void barAltasArticulos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmArticulos.IsDisposed)
            {
                frmArticulos = new Frm_Articulos();
                frmArticulos.MdiParent = this;
                frmArticulos.WindowState = FormWindowState.Maximized;
                frmArticulos.Show();
            }
            else
            {
                frmArticulos.WindowState = FormWindowState.Maximized;
            }
        }

        private void barMantequera_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frm_Mantequera.IsDisposed)
            {
                frm_Mantequera = new Frm_Procesados();
                frm_Mantequera.MdiParent = this;
                frm_Mantequera.WindowState = FormWindowState.Maximized;
                frm_Mantequera.lblTitulo.Text = "Mantequera";
                frm_Mantequera.Show();
            }
            else
            {
                frm_Mantequera.WindowState = FormWindowState.Maximized;
            }
        }

        private void barEntregaSucursales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmEntregaSucursal.IsDisposed)
            {
                frmEntregaSucursal = new Frm_EntregaExternaSucursales();
                frmEntregaSucursal.MdiParent = this;
                frmEntregaSucursal.WindowState = FormWindowState.Maximized;
                frmEntregaSucursal.Show();
            }
            else
            {
                frmEntregaSucursal.WindowState = FormWindowState.Maximized;
            }
        }

        private void barEntregaVendedores_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmEntregasVendedor.IsDisposed)
            {
                frmEntregasVendedor = new Frm_EntregaExternaVendedor();
                frmEntregasVendedor.MdiParent = this;
                frmEntregasVendedor.WindowState = FormWindowState.Maximized;
                frmEntregasVendedor.Show();
            }
            else
            {
                frmEntregasVendedor.WindowState = FormWindowState.Maximized;
            }
        }

        private void barBodegas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmBodegas.IsDisposed)
            {
                frmBodegas = new Frm_Bodegas();
                frmBodegas.MdiParent = this;
                frmBodegas.WindowState = FormWindowState.Maximized;
                frmBodegas.Show();
            }
            else
            {
                frmBodegas.WindowState = FormWindowState.Maximized;
            }
        }

        private void barUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmUsuarios.IsDisposed)
            {
                frmUsuarios = new Frm_Usuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.WindowState = FormWindowState.Maximized;
                frmUsuarios.Show();
            }
            else
            {
                frmUsuarios.WindowState = FormWindowState.Maximized;
            }
        }

        private void barAreas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmAreas.IsDisposed)
            {
                frmAreas = new Frm_Areas();
                frmAreas.MdiParent = this;
                frmAreas.WindowState = FormWindowState.Maximized;
                frmAreas.Show();
            }
            else
            {
                frmAreas.WindowState = FormWindowState.Maximized;
            }
        }

        private void barEnvios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmEnvioEtiquetas.IsDisposed)
            {
                frmEnvioEtiquetas = new Frm_EnvioEtiquetas();
                frmEnvioEtiquetas.MdiParent = this;
                frmEnvioEtiquetas.WindowState = FormWindowState.Maximized;
                frmEnvioEtiquetas.Show();
            }
            else
            {
                frmEnvioEtiquetas.WindowState = FormWindowState.Maximized;
            }
        }

        private void barTarimasProd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmTarimasProduccion.IsDisposed)
            {
                frmTarimasProduccion = new Frm_Tarimas();
                frmTarimasProduccion.MdiParent = this;
                frmTarimasProduccion.WindowState = FormWindowState.Maximized;
                frmTarimasProduccion.Show();
            }
            else
            {
                frmTarimasProduccion.WindowState = FormWindowState.Maximized;
            }
        }

        private void barTarimaRecep_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmTarimasRecepcion.IsDisposed)
            {
                frmTarimasRecepcion = new Frm_CrearTarimas();
                frmTarimasRecepcion.MdiParent = this;
                frmTarimasRecepcion.WindowState = FormWindowState.Maximized;
                frmTarimasRecepcion.Show();
            }
            else
            {
                frmTarimasRecepcion.WindowState = FormWindowState.Maximized;
            }
        }

        private void barRepProduccion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmReporteProduccion.IsDisposed)
            {
                frmReporteProduccion = new Frm_ReporteProduccion();
                frmReporteProduccion.MdiParent = this;
                frmReporteProduccion.WindowState = FormWindowState.Maximized;
                frmReporteProduccion.Show();
            }
            else
            {
                frmReporteProduccion.WindowState = FormWindowState.Maximized;
            }
        }

        private void barRepRecepcion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmReporteRecepcion.IsDisposed)
            {
                frmReporteRecepcion = new Frm_ReporteRecepcion();
                frmReporteRecepcion.MdiParent = this;
                frmReporteRecepcion.WindowState = FormWindowState.Maximized;
                frmReporteRecepcion.Show();
            }
            else
            {
                frmReporteRecepcion.WindowState = FormWindowState.Maximized;
            }
        }

        private void barCerrarPedidos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmCerrarPedidos.IsDisposed)
            {
                frmCerrarPedidos = new Frm_CerrarPedidos();
                frmCerrarPedidos.MdiParent = this;
                frmCerrarPedidos.WindowState = FormWindowState.Maximized;
                frmCerrarPedidos.Show();
            }
            else
            {
                frmCerrarPedidos.WindowState = FormWindowState.Maximized;
            }
        }

        private void barDevoluciones_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmDevoluciones.IsDisposed)
            {
                frmDevoluciones = new Frm_Devoluciones();
                frmDevoluciones.MdiParent = this;
                frmDevoluciones.WindowState = FormWindowState.Maximized;
                frmDevoluciones.Show();
            }
            else
            {
                frmDevoluciones.WindowState = FormWindowState.Maximized;
            }
        }

        private void barImprTarima_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmImprimirTarima.IsDisposed)
            {
                frmImprimirTarima = new Frm_ImprimirTarima();
                frmImprimirTarima.MdiParent = this;
                frmImprimirTarima.WindowState = FormWindowState.Maximized;
                frmImprimirTarima.Show();
            }
            else
            {
                frmImprimirTarima.WindowState = FormWindowState.Maximized;
            }
        }

        private void barReimprimirSalidas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmReimprimirSalida.IsDisposed)
            {
                frmReimprimirSalida = new Frm_ReimprirSalida();
                frmReimprimirSalida.MdiParent = this;
                frmReimprimirSalida.WindowState = FormWindowState.Maximized;
                frmReimprimirSalida.Show();
            }
            else
            {
                frmReimprimirSalida.WindowState = FormWindowState.Maximized;
            }
        }

        private void barReimprirEtiquetas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmReimprimirEtiqueta.IsDisposed)
            {
                frmReimprimirEtiqueta = new  Frm_ReimprimirEtiqueta();
                frmReimprimirEtiqueta.MdiParent = this;
                frmReimprimirEtiqueta.WindowState = FormWindowState.Maximized;
                frmReimprimirEtiqueta.Show();
            }
            else
            {
                frmReimprimirEtiqueta.WindowState = FormWindowState.Maximized;
            }
        }

        private void barEliminarEtiquetas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmEliminarEtiquetas.IsDisposed)
            {
                frmEliminarEtiquetas = new Frm_Eliminar_Etiquetas();
                frmEliminarEtiquetas.MdiParent = this;
                frmEliminarEtiquetas.WindowState = FormWindowState.Maximized;
                frmEliminarEtiquetas.Show();
            }
            else
            {
                frmEliminarEtiquetas.WindowState = FormWindowState.Maximized;
            }
        }

        private void navRepMovimientos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmReporteMovimientos.IsDisposed)
            {
                frmReporteMovimientos = new  Frm_ReporteMovimientos();
                frmReporteMovimientos.MdiParent = this;
                frmReporteMovimientos.WindowState = FormWindowState.Maximized;
                frmReporteMovimientos.Show();
            }
            else
            {
                frmReporteMovimientos.WindowState = FormWindowState.Maximized;
            }
        }

        private void barArticulosUnidades_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new Frm_ArticulosUnidades().ShowDialog();
        }
    }
}

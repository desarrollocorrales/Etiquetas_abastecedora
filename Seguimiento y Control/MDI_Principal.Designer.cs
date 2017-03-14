namespace Seguimiento_y_Control
{
    partial class MDI_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Principal));
            this.navMenuPrincipal = new DevExpress.XtraNavBar.NavBarControl();
            this.gAdministracion = new DevExpress.XtraNavBar.NavBarGroup();
            this.barImpresora = new DevExpress.XtraNavBar.NavBarItem();
            this.barAltasArticulos = new DevExpress.XtraNavBar.NavBarItem();
            this.barBodegas = new DevExpress.XtraNavBar.NavBarItem();
            this.barAreas = new DevExpress.XtraNavBar.NavBarItem();
            this.barUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.barDevoluciones = new DevExpress.XtraNavBar.NavBarItem();
            this.barReimprirEtiquetas = new DevExpress.XtraNavBar.NavBarItem();
            this.barEliminarEtiquetas = new DevExpress.XtraNavBar.NavBarItem();
            this.barArticulosUnidades = new DevExpress.XtraNavBar.NavBarItem();
            this.gBlank = new DevExpress.XtraNavBar.NavBarGroup();
            this.gAlmacen = new DevExpress.XtraNavBar.NavBarGroup();
            this.barRecepcion = new DevExpress.XtraNavBar.NavBarItem();
            this.barRecepcionInterna = new DevExpress.XtraNavBar.NavBarItem();
            this.navEntregarMateria = new DevExpress.XtraNavBar.NavBarItem();
            this.barEntregaVendedores = new DevExpress.XtraNavBar.NavBarItem();
            this.barEntregaSucursales = new DevExpress.XtraNavBar.NavBarItem();
            this.barEnvios = new DevExpress.XtraNavBar.NavBarItem();
            this.barTarimaRecep = new DevExpress.XtraNavBar.NavBarItem();
            this.barReimprimirSalidas = new DevExpress.XtraNavBar.NavBarItem();
            this.gProduccion = new DevExpress.XtraNavBar.NavBarGroup();
            this.navRequerir = new DevExpress.XtraNavBar.NavBarItem();
            this.barCerrarPedidos = new DevExpress.XtraNavBar.NavBarItem();
            this.barCortes = new DevExpress.XtraNavBar.NavBarItem();
            this.barProcesados = new DevExpress.XtraNavBar.NavBarItem();
            this.barMantequera = new DevExpress.XtraNavBar.NavBarItem();
            this.barTarimasProd = new DevExpress.XtraNavBar.NavBarItem();
            this.barImprTarima = new DevExpress.XtraNavBar.NavBarItem();
            this.gDistribucion = new DevExpress.XtraNavBar.NavBarGroup();
            this.itmPedidoSucursales = new DevExpress.XtraNavBar.NavBarItem();
            this.itmPedidosVendedores = new DevExpress.XtraNavBar.NavBarItem();
            this.gReportes = new DevExpress.XtraNavBar.NavBarGroup();
            this.barRepProduccion = new DevExpress.XtraNavBar.NavBarItem();
            this.barRepRecepcion = new DevExpress.XtraNavBar.NavBarItem();
            this.navRepMovimientos = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // navMenuPrincipal
            // 
            this.navMenuPrincipal.ActiveGroup = this.gDistribucion;
            this.navMenuPrincipal.Appearance.GroupHeader.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navMenuPrincipal.Appearance.GroupHeader.Options.UseFont = true;
            this.navMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenuPrincipal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navMenuPrincipal.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.gBlank,
            this.gAlmacen,
            this.gProduccion,
            this.gDistribucion,
            this.gAdministracion,
            this.gReportes});
            this.navMenuPrincipal.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.barRecepcion,
            this.barRecepcionInterna,
            this.navEntregarMateria,
            this.barEntregaVendedores,
            this.navRequerir,
            this.barCerrarPedidos,
            this.barCortes,
            this.barProcesados,
            this.itmPedidoSucursales,
            this.itmPedidosVendedores,
            this.barImpresora,
            this.barAltasArticulos,
            this.barBodegas,
            this.barAreas,
            this.barUsuarios,
            this.barMantequera,
            this.barEntregaSucursales,
            this.barEnvios,
            this.barRepProduccion,
            this.barRepRecepcion,
            this.barTarimasProd,
            this.barTarimaRecep,
            this.barDevoluciones,
            this.barImprTarima,
            this.barReimprimirSalidas,
            this.barReimprirEtiquetas,
            this.barEliminarEtiquetas,
            this.navRepMovimientos,
            this.barArticulosUnidades});
            this.navMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.navMenuPrincipal.Name = "navMenuPrincipal";
            this.navMenuPrincipal.OptionsNavPane.ExpandedWidth = 219;
            this.navMenuPrincipal.Size = new System.Drawing.Size(219, 612);
            this.navMenuPrincipal.TabIndex = 1;
            this.navMenuPrincipal.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("iMaginary");
            // 
            // gAdministracion
            // 
            this.gAdministracion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.gAdministracion.Appearance.Options.UseFont = true;
            this.gAdministracion.Caption = "Administración";
            this.gAdministracion.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.barImpresora),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barAltasArticulos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barBodegas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barAreas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barUsuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barDevoluciones),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barReimprirEtiquetas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barEliminarEtiquetas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barArticulosUnidades)});
            this.gAdministracion.Name = "gAdministracion";
            this.gAdministracion.Tag = "ADMINISTRACION";
            // 
            // barImpresora
            // 
            this.barImpresora.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barImpresora.Appearance.Options.UseFont = true;
            this.barImpresora.Caption = "Impresora de Etiquetas";
            this.barImpresora.Name = "barImpresora";
            this.barImpresora.Tag = "IMPRESORA";
            this.barImpresora.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barImpresora_LinkClicked);
            // 
            // barAltasArticulos
            // 
            this.barAltasArticulos.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAltasArticulos.Appearance.Options.UseFont = true;
            this.barAltasArticulos.Caption = "Artículos";
            this.barAltasArticulos.Name = "barAltasArticulos";
            this.barAltasArticulos.Tag = "ARTICULOS";
            this.barAltasArticulos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barAltasArticulos_LinkClicked);
            // 
            // barBodegas
            // 
            this.barBodegas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barBodegas.Appearance.Options.UseFont = true;
            this.barBodegas.Caption = "Bodegas";
            this.barBodegas.Name = "barBodegas";
            this.barBodegas.Tag = "BODEGAS";
            this.barBodegas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barBodegas_LinkClicked);
            // 
            // barAreas
            // 
            this.barAreas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAreas.Appearance.Options.UseFont = true;
            this.barAreas.Caption = "Areas";
            this.barAreas.Name = "barAreas";
            this.barAreas.Tag = "AREAS";
            this.barAreas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barAreas_LinkClicked);
            // 
            // barUsuarios
            // 
            this.barUsuarios.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barUsuarios.Appearance.Options.UseFont = true;
            this.barUsuarios.Caption = "Usuarios";
            this.barUsuarios.Name = "barUsuarios";
            this.barUsuarios.Tag = "USUARIOS";
            this.barUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barUsuarios_LinkClicked);
            // 
            // barDevoluciones
            // 
            this.barDevoluciones.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDevoluciones.Appearance.Options.UseFont = true;
            this.barDevoluciones.Caption = "Devoluciones";
            this.barDevoluciones.Name = "barDevoluciones";
            this.barDevoluciones.Tag = "DEVOLUCIONES";
            this.barDevoluciones.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barDevoluciones_LinkClicked);
            // 
            // barReimprirEtiquetas
            // 
            this.barReimprirEtiquetas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.barReimprirEtiquetas.Appearance.Options.UseFont = true;
            this.barReimprirEtiquetas.Caption = "Reimprimir Etiquetas";
            this.barReimprirEtiquetas.Name = "barReimprirEtiquetas";
            this.barReimprirEtiquetas.Tag = "REIMPRIMIR_ETIQUETA";
            this.barReimprirEtiquetas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barReimprirEtiquetas_LinkClicked);
            // 
            // barEliminarEtiquetas
            // 
            this.barEliminarEtiquetas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.barEliminarEtiquetas.Appearance.Options.UseFont = true;
            this.barEliminarEtiquetas.Caption = "Eliminar Etiqueta";
            this.barEliminarEtiquetas.Name = "barEliminarEtiquetas";
            this.barEliminarEtiquetas.Tag = "ELIMINAR_ETIQUETA";
            this.barEliminarEtiquetas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barEliminarEtiquetas_LinkClicked);
            // 
            // barArticulosUnidades
            // 
            this.barArticulosUnidades.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.barArticulosUnidades.Appearance.Options.UseFont = true;
            this.barArticulosUnidades.Caption = "Unidades de articulos";
            this.barArticulosUnidades.Name = "barArticulosUnidades";
            this.barArticulosUnidades.Tag = "ARTICULO_UNIDAD";
            this.barArticulosUnidades.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barArticulosUnidades_LinkClicked);
            // 
            // gBlank
            // 
            this.gBlank.Caption = "";
            this.gBlank.Name = "gBlank";
            // 
            // gAlmacen
            // 
            this.gAlmacen.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAlmacen.Appearance.Options.UseFont = true;
            this.gAlmacen.Caption = "Almacén";
            this.gAlmacen.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.barRecepcion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barRecepcionInterna),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navEntregarMateria),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barEntregaVendedores),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barEntregaSucursales),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barEnvios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barTarimaRecep),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barReimprimirSalidas)});
            this.gAlmacen.Name = "gAlmacen";
            this.gAlmacen.Tag = "ALMACEN";
            // 
            // barRecepcion
            // 
            this.barRecepcion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barRecepcion.Appearance.Options.UseFont = true;
            this.barRecepcion.Caption = "Recepción de proveedores";
            this.barRecepcion.Name = "barRecepcion";
            this.barRecepcion.Tag = "RECEP_PROVEEDORES";
            this.barRecepcion.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barRecepcion_LinkPressed);
            // 
            // barRecepcionInterna
            // 
            this.barRecepcionInterna.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barRecepcionInterna.Appearance.Options.UseFont = true;
            this.barRecepcionInterna.Caption = "Recepción de interna";
            this.barRecepcionInterna.Name = "barRecepcionInterna";
            this.barRecepcionInterna.Tag = "RECEP_INTERNA";
            this.barRecepcionInterna.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barRecepcionInterna_LinkPressed);
            // 
            // navEntregarMateria
            // 
            this.navEntregarMateria.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navEntregarMateria.Appearance.Options.UseFont = true;
            this.navEntregarMateria.Caption = "Entrega interna";
            this.navEntregarMateria.Name = "navEntregarMateria";
            this.navEntregarMateria.Tag = "ENTREGA_INTERNA";
            this.navEntregarMateria.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navEntregarMateria_LinkPressed);
            // 
            // barEntregaVendedores
            // 
            this.barEntregaVendedores.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barEntregaVendedores.Appearance.Options.UseFont = true;
            this.barEntregaVendedores.Caption = "Entrega a vendedores";
            this.barEntregaVendedores.Name = "barEntregaVendedores";
            this.barEntregaVendedores.Tag = "ENTREGA_VENDEDORES";
            this.barEntregaVendedores.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barEntregaVendedores_LinkClicked);
            // 
            // barEntregaSucursales
            // 
            this.barEntregaSucursales.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barEntregaSucursales.Appearance.Options.UseFont = true;
            this.barEntregaSucursales.Caption = "Entrega a sucursales";
            this.barEntregaSucursales.Name = "barEntregaSucursales";
            this.barEntregaSucursales.Tag = "ENTREGA_SUCURSALES";
            this.barEntregaSucursales.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barEntregaSucursales_LinkClicked);
            // 
            // barEnvios
            // 
            this.barEnvios.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barEnvios.Appearance.Options.UseFont = true;
            this.barEnvios.Caption = "Envio de etiquetas";
            this.barEnvios.Name = "barEnvios";
            this.barEnvios.Tag = "ENVIO_ETIQUETAS";
            this.barEnvios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barEnvios_LinkClicked);
            // 
            // barTarimaRecep
            // 
            this.barTarimaRecep.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barTarimaRecep.Appearance.Options.UseFont = true;
            this.barTarimaRecep.Caption = "Crear Tarima";
            this.barTarimaRecep.Name = "barTarimaRecep";
            this.barTarimaRecep.Tag = "TARIMA_RECEP";
            this.barTarimaRecep.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barTarimaRecep_LinkClicked);
            // 
            // barReimprimirSalidas
            // 
            this.barReimprimirSalidas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barReimprimirSalidas.Appearance.Options.UseFont = true;
            this.barReimprimirSalidas.Caption = "Reimprimir Salida";
            this.barReimprimirSalidas.Name = "barReimprimirSalidas";
            this.barReimprimirSalidas.Tag = "REIMPRIMIR_SALIDAS";
            this.barReimprimirSalidas.Visible = false;
            this.barReimprimirSalidas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barReimprimirSalidas_LinkClicked);
            // 
            // gProduccion
            // 
            this.gProduccion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gProduccion.Appearance.Options.UseFont = true;
            this.gProduccion.Caption = "Producción";
            this.gProduccion.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRequerir),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barCerrarPedidos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barCortes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barProcesados),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barMantequera),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barTarimasProd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barImprTarima)});
            this.gProduccion.Name = "gProduccion";
            this.gProduccion.Tag = "PRODUCCION";
            // 
            // navRequerir
            // 
            this.navRequerir.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navRequerir.Appearance.Options.UseFont = true;
            this.navRequerir.Caption = "Requerir";
            this.navRequerir.Name = "navRequerir";
            this.navRequerir.Tag = "REQUERIR";
            this.navRequerir.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navRequerir_LinkPressed);
            // 
            // barCerrarPedidos
            // 
            this.barCerrarPedidos.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCerrarPedidos.Appearance.Options.UseFont = true;
            this.barCerrarPedidos.Caption = "Cerrar Pedidos";
            this.barCerrarPedidos.Name = "barCerrarPedidos";
            this.barCerrarPedidos.Tag = "CERRAR_PEDIDOS";
            this.barCerrarPedidos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barCerrarPedidos_LinkClicked);
            // 
            // barCortes
            // 
            this.barCortes.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCortes.Appearance.Options.UseFont = true;
            this.barCortes.Caption = "Cortes";
            this.barCortes.Name = "barCortes";
            this.barCortes.Tag = "CORTES";
            this.barCortes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barCortes_LinkClicked);
            // 
            // barProcesados
            // 
            this.barProcesados.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barProcesados.Appearance.Options.UseFont = true;
            this.barProcesados.Caption = "Procesados";
            this.barProcesados.Name = "barProcesados";
            this.barProcesados.Tag = "PROCESADOS";
            this.barProcesados.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barProcesados_LinkPressed);
            // 
            // barMantequera
            // 
            this.barMantequera.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMantequera.Appearance.Options.UseFont = true;
            this.barMantequera.Caption = "Mantequera";
            this.barMantequera.Name = "barMantequera";
            this.barMantequera.Tag = "MANTEQUERA";
            this.barMantequera.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barMantequera_LinkPressed);
            // 
            // barTarimasProd
            // 
            this.barTarimasProd.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barTarimasProd.Appearance.Options.UseFont = true;
            this.barTarimasProd.Caption = "Crear Tarima";
            this.barTarimasProd.Name = "barTarimasProd";
            this.barTarimasProd.Tag = "TARIMA_PROD";
            this.barTarimasProd.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barTarimasProd_LinkClicked);
            // 
            // barImprTarima
            // 
            this.barImprTarima.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.barImprTarima.Appearance.Options.UseFont = true;
            this.barImprTarima.Caption = "Imprimir Tarima";
            this.barImprTarima.Name = "barImprTarima";
            this.barImprTarima.Tag = "IMPRIMIR_TARIMAS";
            this.barImprTarima.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barImprTarima_LinkClicked);
            // 
            // gDistribucion
            // 
            this.gDistribucion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.gDistribucion.Appearance.Options.UseFont = true;
            this.gDistribucion.Caption = "Distribución";
            this.gDistribucion.Expanded = true;
            this.gDistribucion.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmPedidoSucursales),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmPedidosVendedores)});
            this.gDistribucion.Name = "gDistribucion";
            this.gDistribucion.Tag = "DISTRIBUCION";
            // 
            // itmPedidoSucursales
            // 
            this.itmPedidoSucursales.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmPedidoSucursales.Appearance.Options.UseFont = true;
            this.itmPedidoSucursales.Caption = "Pedidos de Sucursales";
            this.itmPedidoSucursales.Name = "itmPedidoSucursales";
            this.itmPedidoSucursales.Tag = "PEDIDOS_SUCURSALES";
            this.itmPedidoSucursales.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmPedidoSucursales_LinkClicked);
            // 
            // itmPedidosVendedores
            // 
            this.itmPedidosVendedores.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmPedidosVendedores.Appearance.Options.UseFont = true;
            this.itmPedidosVendedores.Caption = "Pedidos de Vendedores";
            this.itmPedidosVendedores.Name = "itmPedidosVendedores";
            this.itmPedidosVendedores.Tag = "PEDIDOS_VENDEDORES";
            this.itmPedidosVendedores.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmPedidosVendedores_LinkClicked);
            // 
            // gReportes
            // 
            this.gReportes.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.gReportes.Appearance.Options.UseFont = true;
            this.gReportes.Caption = "Reportes";
            this.gReportes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.barRepProduccion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barRepRecepcion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navRepMovimientos)});
            this.gReportes.Name = "gReportes";
            this.gReportes.Tag = "REPORTES";
            // 
            // barRepProduccion
            // 
            this.barRepProduccion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barRepProduccion.Appearance.Options.UseFont = true;
            this.barRepProduccion.Caption = "Reporte de Producción";
            this.barRepProduccion.Name = "barRepProduccion";
            this.barRepProduccion.Tag = "REPORTE_PROD";
            this.barRepProduccion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barRepProduccion_LinkClicked);
            // 
            // barRepRecepcion
            // 
            this.barRepRecepcion.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barRepRecepcion.Appearance.Options.UseFont = true;
            this.barRepRecepcion.Caption = "Reporte de Recepción";
            this.barRepRecepcion.Name = "barRepRecepcion";
            this.barRepRecepcion.Tag = "REPORTE_RECEP";
            this.barRepRecepcion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barRepRecepcion_LinkClicked);
            // 
            // navRepMovimientos
            // 
            this.navRepMovimientos.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.navRepMovimientos.Appearance.Options.UseFont = true;
            this.navRepMovimientos.Caption = "Reporte de Movimientos";
            this.navRepMovimientos.Name = "navRepMovimientos";
            this.navRepMovimientos.Tag = "REPORTE_MOVIMIENTOS";
            this.navRepMovimientos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navRepMovimientos_LinkClicked);
            // 
            // MDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.navMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguimiento y control";
            this.Load += new System.EventHandler(this.MDI_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navMenuPrincipal)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraNavBar.NavBarControl navMenuPrincipal;
        private DevExpress.XtraNavBar.NavBarGroup gAlmacen;
        private DevExpress.XtraNavBar.NavBarItem barRecepcion;
        private DevExpress.XtraNavBar.NavBarItem barRecepcionInterna;
        private DevExpress.XtraNavBar.NavBarItem navEntregarMateria;
        private DevExpress.XtraNavBar.NavBarItem barEntregaVendedores;
        private DevExpress.XtraNavBar.NavBarGroup gProduccion;
        private DevExpress.XtraNavBar.NavBarItem navRequerir;
        private DevExpress.XtraNavBar.NavBarItem barCerrarPedidos;
        private DevExpress.XtraNavBar.NavBarItem barCortes;
        private DevExpress.XtraNavBar.NavBarItem barProcesados;
        private DevExpress.XtraNavBar.NavBarGroup gDistribucion;
        private DevExpress.XtraNavBar.NavBarItem itmPedidoSucursales;
        private DevExpress.XtraNavBar.NavBarItem itmPedidosVendedores;
        private DevExpress.XtraNavBar.NavBarGroup gBlank;
        private DevExpress.XtraNavBar.NavBarGroup gAdministracion;
        private DevExpress.XtraNavBar.NavBarItem barImpresora;
        private DevExpress.XtraNavBar.NavBarItem barAltasArticulos;
        private DevExpress.XtraNavBar.NavBarItem barBodegas;
        private DevExpress.XtraNavBar.NavBarItem barAreas;
        private DevExpress.XtraNavBar.NavBarItem barUsuarios;
        private DevExpress.XtraNavBar.NavBarItem barMantequera;
        private DevExpress.XtraNavBar.NavBarItem barEntregaSucursales;
        private DevExpress.XtraNavBar.NavBarItem barEnvios;
        private DevExpress.XtraNavBar.NavBarItem barTarimasProd;
        private DevExpress.XtraNavBar.NavBarGroup gReportes;
        private DevExpress.XtraNavBar.NavBarItem barRepProduccion;
        private DevExpress.XtraNavBar.NavBarItem barRepRecepcion;
        private DevExpress.XtraNavBar.NavBarItem barTarimaRecep;
        private DevExpress.XtraNavBar.NavBarItem barDevoluciones;
        private DevExpress.XtraNavBar.NavBarItem barImprTarima;
        private DevExpress.XtraNavBar.NavBarItem barReimprimirSalidas;
        private DevExpress.XtraNavBar.NavBarItem barReimprirEtiquetas;
        private DevExpress.XtraNavBar.NavBarItem barEliminarEtiquetas;
        private DevExpress.XtraNavBar.NavBarItem navRepMovimientos;
        private DevExpress.XtraNavBar.NavBarItem barArticulosUnidades;

    }
}




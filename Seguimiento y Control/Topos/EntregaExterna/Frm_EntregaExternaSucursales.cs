using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Produccion;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Entity.Internet;
using Seguimiento_y_Control.Reportes;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Utilitarias;
using System.Drawing;

namespace Seguimiento_y_Control.Topos.EntregaExterna
{
    public partial class Frm_EntregaExternaSucursales : Form
    {
        private string sFileName;
        private string sCodigoPedido;
        private string sSucursal;
        private List<string> lstEtiquetas;
        private pedidos_maestros_sucursales oPedidoMaestro;
        private pedidos_maestros_sucursales_det oPedido;
        private List<pedidos_sucursales_det> lstDetallesPedido;
        List<GridEntrega> lstEtiquetasAEntregar;

        public Frm_EntregaExternaSucursales()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            BuscarArchivo();
        }
        private void BuscarArchivo()
        {
            DialogResult dr = ofdBuscaArchivo.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                sFileName = ofdBuscaArchivo.FileName;

                if (ValidarArchivo() == true)
                {
                    txbIdRequisicion.Text = sCodigoPedido;
                    gridRequisicion.DataSource = cargarGridRequisiciones(lstDetallesPedido);
                    gvRequisicion.BestFitColumns();

                    if (ValidarEtiquetas() == true)
                    {
                        gridMateriaPrima.DataSource = lstEtiquetasAEntregar;
                        gvMateriaPrima.BestFitColumns();

                        btnAceptar.Enabled = true;
                    }
                }
            }
        }

        private bool ValidarArchivo()
        {
            lstEtiquetas = AbrirArchivo(sFileName);

            if (lstEtiquetas.Count == 0)
            {
                MessageBox.Show("El archivo esta en blanco...");
                return false;
            }

            sCodigoPedido = lstEtiquetas[0];

            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            //Obtener la requisicion de la bodega.
            oPedido = 
                Contexto.pedidos_maestros_sucursales_det.FirstOrDefault(o => o.codigo_requisicion == sCodigoPedido);
            if (oPedido == null)
            {
                MessageBox.Show("Error: No se encontro el pedido: " + sCodigoPedido);
                return false;
            }

            //Obtener los Articulos Requeridos.
            lstDetallesPedido =
                Contexto
                .pedidos_sucursales_det
                .Where(o => o.id_pedido_maestro_sucursales_det == oPedido.id_pedido_maestro_sucursal_det)
                .ToList();

            //Obtener el Pedido Maestro
            oPedidoMaestro =
                Contexto
                .pedidos_maestros_sucursales
                .FirstOrDefault(o => o.id_pedido_maestro_sucursal == oPedido.id_pedido_maestro_sucursal);

            sSucursal = oPedidoMaestro.ruta;

            return true;
        }

        private List<string> AbrirArchivo(string sFile)
        {
            StreamReader sr = new StreamReader(sFile);

            string line;
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
                lines.Add(line);

            sr.Close();

            return lines.Distinct().ToList();
        }

        private List<ArticuloRequerir> cargarGridRequisiciones(List<pedidos_sucursales_det> lsPedidosDet)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            List<ArticuloRequerir> lsArticulosRequerir = new List<ArticuloRequerir>();

            try
            {
                ArticuloRequerir oArticuloRequerir;
                foreach (pedidos_sucursales_det oDetalle in lsPedidosDet)
                {
                    oArticuloRequerir = new ArticuloRequerir();
                    oArticuloRequerir.articulo_a_requerir = Contexto.articulos.FirstOrDefault(o => o.clave == oDetalle.clave_articulo);
                    oArticuloRequerir.cantidad_a_requrir = oDetalle.cantidad;
                    oArticuloRequerir.unidad = oDetalle.unidad;
                    lsArticulosRequerir.Add(oArticuloRequerir);
                }

                gridRequisicion.DataSource = lsArticulosRequerir;
                gvRequisicion.BestFitColumns();
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

            return lsArticulosRequerir;
        }

        private bool ValidarEtiquetas()
        {
            bool bValida = true;

            List<string> lstEtiquetasAux = new List<string>();

            //**** Cargar la lista de etiquetas a entregar.
            lstEtiquetasAux.AddRange(this.lstEtiquetas);

            //**** Remover el codigo del Pedido.
            lstEtiquetasAux.Remove(sCodigoPedido);

            GridEntrega RenglonGridEntregas;
            lstEtiquetasAEntregar = new List<GridEntrega>();
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            string ID_SUCURSAL;
            string TIPO_ETIQUETA;

            //***** Por cada etiqueta del archivo escaneado
            foreach (string sEtiqueta in lstEtiquetasAux)
            {
                TIPO_ETIQUETA = sEtiqueta.Substring(0, 1);
                ID_SUCURSAL = sEtiqueta.Substring(1, 2);

                if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                {
                    //Son Etiquetas Locales
                    switch (TIPO_ETIQUETA)
                    {
                        case "1":
                        case "2":
                            //Son Etiquetas Normales
                            etiquetas oEtiquetaLocal =
                                Contexto.etiquetas.FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                            if (oEtiquetaLocal != null)
                            {
                                RenglonGridEntregas = new GridEntrega();
                                RenglonGridEntregas.ID_Etiqueta = oEtiquetaLocal.id_etiqueta;
                                RenglonGridEntregas.NumeroEtiqueta = sEtiqueta;
                                RenglonGridEntregas.Clave_Articulo = oEtiquetaLocal.clave_articulo;
                                RenglonGridEntregas.Articulo = oEtiquetaLocal.articulos.articulo;
                                RenglonGridEntregas.Cantidad = oEtiquetaLocal.cantidad;
                                RenglonGridEntregas.Unidad = oEtiquetaLocal.unidad;
                                RenglonGridEntregas.ID_Bodega = oEtiquetaLocal.id_bodega;
                                RenglonGridEntregas.Estado = oEtiquetaLocal.estatus;
                                RenglonGridEntregas.Fecha_Empaque = oEtiquetaLocal.fecha_empaque;
                                RenglonGridEntregas.Tipo = 'L';
                                lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                            }
                            else
                            {
                                MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bValida = false;
                                break;
                            }
                            break;
                        case "3":
                        case "4":
                            //Son Etiquetas de Tarimas
                            paquetes oPaqueteLocal = 
                                Contexto.paquetes.FirstOrDefault(o=>o.numero_etiqueta==sEtiqueta);
                            if (oPaqueteLocal != null)
                            {
                                Entity.articulos oArticulo = ObtenerArticulo(oPaqueteLocal.clave_articulo);
                                RenglonGridEntregas = new GridEntrega();
                                RenglonGridEntregas.ID_Etiqueta = oPaqueteLocal.id_paquete;
                                RenglonGridEntregas.NumeroEtiqueta = sEtiqueta;
                                RenglonGridEntregas.Clave_Articulo = oPaqueteLocal.clave_articulo;
                                RenglonGridEntregas.Articulo = oArticulo.articulo;
                                RenglonGridEntregas.Cantidad = getCantidadPaquete(oPaqueteLocal);
                                RenglonGridEntregas.Unidad = oPaqueteLocal.unidad;
                                RenglonGridEntregas.ID_Bodega = oArticulo.id_bodega;
                                RenglonGridEntregas.Estado = oPaqueteLocal.estatus;
                                RenglonGridEntregas.Fecha_Empaque = oPaqueteLocal.fecha_creacion;
                                RenglonGridEntregas.Tipo = 'P';
                                lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                            }
                            else
                            {
                                MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bValida = false;
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    //Son Etiquetas Traspasadas
                    switch (TIPO_ETIQUETA)
                    {
                        case "1":
                        case "2":
                            //Son Etiquetas Normales
                            etiquetas_traspasadas oEtiquetaTraspasada =
                                Contexto.etiquetas_traspasadas.FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                            if (oEtiquetaTraspasada != null)
                            {
                                RenglonGridEntregas = new GridEntrega();
                                RenglonGridEntregas.ID_Etiqueta = oEtiquetaTraspasada.id_etiqueta_traspasada;
                                RenglonGridEntregas.NumeroEtiqueta = sEtiqueta;
                                RenglonGridEntregas.Clave_Articulo = oEtiquetaTraspasada.clave_articulo;
                                RenglonGridEntregas.Articulo = oEtiquetaTraspasada.articulos.articulo;
                                RenglonGridEntregas.Cantidad = oEtiquetaTraspasada.cantidad;
                                RenglonGridEntregas.Unidad = oEtiquetaTraspasada.unidad;
                                RenglonGridEntregas.ID_Bodega = oEtiquetaTraspasada.id_bodega;
                                RenglonGridEntregas.Estado = oEtiquetaTraspasada.estado;
                                RenglonGridEntregas.Fecha_Empaque = oEtiquetaTraspasada.fecha_empaque;
                                RenglonGridEntregas.Tipo = 'T';
                                lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                            }
                            else
                            {
                                MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bValida = false;
                                return bValida;
                            }
                            break;
                        case "3":
                        case "4":
                            //Son Etiquetas de Tarimas
                            paquetes_traspasados oPaqTrasp = 
                                Contexto
                                .paquetes_traspasados
                                .FirstOrDefault(o=>o.numero_etiqueta==sEtiqueta);
                            if (oPaqTrasp != null)
                            {
                                Entity.articulos oArticulo = ObtenerArticulo(oPaqTrasp.clave_articulo);
                                RenglonGridEntregas = new GridEntrega();
                                RenglonGridEntregas.ID_Etiqueta = oPaqTrasp.id_paquete_traspasado;
                                RenglonGridEntregas.NumeroEtiqueta = sEtiqueta;
                                RenglonGridEntregas.Clave_Articulo = oPaqTrasp.clave_articulo;
                                RenglonGridEntregas.Articulo = oArticulo.articulo;
                                RenglonGridEntregas.Cantidad = getCantidadPaquete(oPaqTrasp);
                                RenglonGridEntregas.Unidad = oPaqTrasp.unidad;
                                RenglonGridEntregas.ID_Bodega = oArticulo.id_bodega;
                                RenglonGridEntregas.Estado = oPaqTrasp.estado;
                                RenglonGridEntregas.Fecha_Empaque = oPaqTrasp.fecha_creacion;
                                RenglonGridEntregas.Tipo = 'P';
                                lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                            }
                            else
                            {
                                MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bValida = false;
                                break;
                            }
                            break;
                    }
                }                                                                 
            }

            gridMateriaPrima.DataSource = lstEtiquetasAEntregar;
            gvMateriaPrima.BestFitColumns();

            int iRenglonesAEntregar = lstEtiquetasAEntregar.Count;
            int iRenglonesActivados = lstEtiquetasAEntregar.FindAll(o => o.Estado == "A").Count;

            if (iRenglonesActivados != iRenglonesAEntregar)
            {
                MessageBox.Show("Error: Existen etiquetas que no estan activadas ", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                bValida = false;
            }

            return bValida;
        }

        private string ObtenerSalida(long id_pedido)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            salidas_sucursales oSalida = 
                Contexto.salidas_sucursales.FirstOrDefault(o => o.id_pedido_maestro_sucursales_det == id_pedido);
            if (oSalida == null)
                return string.Empty;
            else
                return oSalida.codigo_salida;
        }

        private string ObtenerUsuario(int id_usuario)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            Entity.usuarios user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario);
            return user.nombre.ToUpper();
        }

        private string ObtenerSucursal(int id_empresa)
        {
            Portal_Entities Contexto = new Portal_Entities();
            empresas oSucursal = Contexto.empresas.FirstOrDefault(o => o.id_empresa == id_empresa);
            if (oSucursal == null)
                return string.Empty;
            else
                return oSucursal.nombre.ToUpper();
        }

        private bodegas ObtenerBodega(long id_bodega)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            bodegas bodega = Contexto.bodegas.FirstOrDefault(o => o.id_bodega == id_bodega);
            return bodega;
        }

        private string ObtenerNombreArticulo(string clave_articulo)
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            Entity.articulos Articulo =
                SeguimientoContexto.articulos.SingleOrDefault(o => o.clave == clave_articulo);
            if (Articulo != null)
                return Articulo.articulo;
            else
                throw new EntityException("No se encontro el articulo: " + clave_articulo);
        }

        private bool ValidarEntrega()
        {
            bool bValidado = false;
            bool bNoHay = false;

            if (RequisicionVSEntrega() == true)
            {
                bValidado = true;
                StringBuilder sbMensaje = new StringBuilder();
                List<ArticuloRequerir> lstArticulosRequeridos = (List<ArticuloRequerir>)gridRequisicion.DataSource;

                //Por cada artículo en la lista
                foreach (ArticuloRequerir oRequerido in lstArticulosRequeridos)
                {
                    //Obtener todas las etiquetas que contienen el articulo y la unidad del articulo requerido.
                    List<GridEntrega> listaAuxiliar = new List<GridEntrega>();
                    listaAuxiliar = 
                        lstEtiquetasAEntregar.FindAll(o => o.Clave_Articulo == oRequerido.articulo_a_requerir.clave);
                    //listaAuxiliar = listaAuxiliar.FindAll(o => o.Unidad == oRequerido.unidad);

                    if (listaAuxiliar.Count != 0)
                    {
                        ////Si hay etiquetas que corresponden al articulo y unidad requeridos
                        ////Obtener la cantidad requerida == cantidad de la requisicion + 10%
                        //decimal fCantidadRequerida = oRequerido.cantidad_a_requrir * 1.10M;
                        ////Obtener la cantidad de la entrega sumando todas las etiquetas
                        //decimal fSumaEntrega = listaAuxiliar.Sum(o => o.Cantidad);

                        //if (fCantidadRequerida < fSumaEntrega)
                        //{
                        //    //Si la cantidad a entregar es Mayor a la cantidad requerida ERROR
                        //    sbMensaje.AppendLine("Error: La cantidad requerida es menor a la cantidad de la entrega...");
                        //    sbMensaje.Append("Clave: " + oRequerido.articulo_a_requerir.clave);
                        //    sbMensaje.AppendLine(" Articulo: " + oRequerido.articulo_a_requerir.articulo);
                        //    bValidado = false;
                        //    break;
                        //}
                    }
                    else
                    {
                        //Si no hay etiquetas del articulo requerido: ERROR
                        sbMensaje.Append(oRequerido.articulo_a_requerir.clave);
                        sbMensaje.AppendLine(" - " + oRequerido.articulo_a_requerir.articulo);
                        //sbMensaje.AppendLine(" Unidad: " + oRequerido.unidad);
                        bValidado = false;
                        bNoHay = true;
                    }
                }

                if (ExisteSalida() == true)
                {
                    sbMensaje.AppendLine("Error: La salida ya existe en el sistema...");
                    sbMensaje.Append("ID Salida: " + ObtenerSalida(oPedido.id_pedido_maestro_sucursal_det));
                    bValidado = false;
                }

                if (bValidado == false)
                {
                    if (bNoHay == true)
                    {
                        sbMensaje.AppendLine("Los articulos anteriores no se encuentran en la lista de entrega");
                        sbMensaje.AppendLine();
                        sbMensaje.AppendLine("¿Desea hacer la entrega de todas formas?");
                        DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            bValidado = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(sbMensaje.ToString(), string.Empty,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return bValidado;
        }

        private bool ExisteSalida()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            salidas_sucursales ValidaSalida =
                Contexto
                .salidas_sucursales
                .FirstOrDefault(o => o.id_pedido_maestro_sucursales_det == oPedido.id_pedido_maestro_sucursal_det);
            if (ValidaSalida != null)
                return true;
            else
                return false;
        }

        private void GuardarEntrega()
        {
            string Soliciante = ObtenerUsuario(oPedidoMaestro.id_usuario_creador);
            List<RepEntregaExterna> dsReporte = new List<RepEntregaExterna>();
            List<GridEntrega> lstEtiquetasEntrega = (List<GridEntrega>)gridMateriaPrima.DataSource;
            RepEntregaExterna RowReporte;

            try
            {
                salidas_sucursales oSalida = GenerarSalida();

                foreach (GridEntrega EtiquetaEntrega in lstEtiquetasEntrega)
                {
                    RowReporte = new RepEntregaExterna();
                    RowReporte.Fecha = oSalida.fecha;
                    RowReporte.NumSalida = oSalida.codigo_salida;
                    RowReporte.NumPedido = oPedido.codigo_requisicion;
                    RowReporte.Responsable = Config.user.nombre.ToUpper();
                    RowReporte.Solicitante = Soliciante;
                    RowReporte.Destino = oSalida.destino;
                    RowReporte.RowEtiquetas = EtiquetaEntrega;
                    RowReporte.Bodega = ObtenerBodega(EtiquetaEntrega.ID_Bodega);

                    dsReporte.Add(RowReporte);
                }

                ImagenReportes ImagenReporte = new ImagenReportes();
                ImagenReporte.ImgReporte = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");

                xrpEntregaVendedores ReporteEntregaInterna = new xrpEntregaVendedores();
                ReporteEntregaInterna.ImagenReporte.Add(ImagenReporte);
                ReporteEntregaInterna.DataSource = dsReporte;

                //************************* Respaldo *********************************************
                string BackUp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SalidasSucursales";
                if (Directory.Exists(BackUp) == false)
                    Directory.CreateDirectory(BackUp);

                ReporteEntregaInterna.ExportToPdf(BackUp + "\\" + oSalida.codigo_salida + ".pdf");
                //*********************************************************************************

                ReporteEntregaInterna.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Ocurrio un error al hacer el registro de la salida");
                sb.Append(ex.Message);
                MessageBox.Show(sb.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Revisa que los articulos escaneados existan en la requisicion
        /// </summary>
        /// <returns></returns>
        private bool RequisicionVSEntrega()
        {
            bool bValido = true;

            List<ArticuloRequerir> ListaValidación = new List<ArticuloRequerir>();
            List<ArticuloRequerir> ListaRequisicion = (List<ArticuloRequerir>)gridRequisicion.DataSource;
            List<GridEntrega> ListaEntrega = (List<GridEntrega>)gridMateriaPrima.DataSource;

            foreach (GridEntrega objEntrega in ListaEntrega)
            {
                ListaValidación = ListaRequisicion.FindAll(o => o.articulo_a_requerir.clave == objEntrega.Clave_Articulo);
                //ListaValidación = ListaValidación.FindAll(o => o.unidad == objEntrega.Unidad);
                if (ListaValidación.Count == 0)
                {
                    MessageBox.Show("Articulo No Requerido: " +
                                     objEntrega.NumeroEtiqueta + " - " +
                                     objEntrega.Articulo);
                    bValido = false;
                    break;
                }
            }

            return bValido;
        }

        private salidas_sucursales GenerarSalida()
        {
            salidas_sucursales objSalida = new salidas_sucursales();
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();

            SeguimientoContexto.Connection.Open();
            IDbTransaction Transaccion = SeguimientoContexto.Connection.BeginTransaction();
            try
            {
                // Requisicion Global por Camara = RGPC
                pedidos_maestros_sucursales_det RGPC =
                    SeguimientoContexto
                    .pedidos_maestros_sucursales_det
                    .FirstOrDefault(o => o.codigo_requisicion == sCodigoPedido);
                // Requisicion Global = RG
                pedidos_maestros_sucursales RG =
                    SeguimientoContexto
                    .pedidos_maestros_sucursales
                    .FirstOrDefault(o => o.id_pedido_maestro_sucursal == RGPC.id_pedido_maestro_sucursal);

                objSalida.fecha = Servidor.getFechaServer();
                objSalida.destino = RG.ruta;
                objSalida.id_pedido_maestro_sucursales_det = RGPC.id_pedido_maestro_sucursal_det;
                objSalida.id_usuario_responsable = Config.user.id_usuario;
                objSalida.id_usuario_solicitante = RG.id_usuario_creador;
                objSalida.tipo_salida = "S";
                SeguimientoContexto.salidas_sucursales.AddObject(objSalida);
                SeguimientoContexto.SaveChanges();

                configuracion Prefijo = SeguimientoContexto.configuracion.FirstOrDefault(o => o.config == "sucursal");
                objSalida.codigo_salida =
                    Prefijo.valor + "-SS-B" + RGPC.id_bodega + "-" + objSalida.id_salida.ToString().PadLeft(7, '0');
                SeguimientoContexto.SaveChanges();

                salidas_sucursales_det oSalidasDet;
                List<GridEntrega> lstEtiquetasEntrega = (List<GridEntrega>)gridMateriaPrima.DataSource;
                foreach (GridEntrega RowEtiqueta in lstEtiquetasEntrega)
                {
                    string ID_SUCURSAL = RowEtiqueta.NumeroEtiqueta.Substring(1, 2);
                    string TIPO_ETIQUETA = RowEtiqueta.NumeroEtiqueta.Substring(0, 1);

                    if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                    {
                        //Es Etiqueta local
                        switch (TIPO_ETIQUETA)
                        {
                            case "1":
                            case "2":
                                // Es etiqueta de caja o pieza.
                                // Crear el detalle de salida.
                                oSalidasDet = new salidas_sucursales_det();
                                oSalidasDet.id_salida = objSalida.id_salida;
                                oSalidasDet.numero_etiqueta = RowEtiqueta.NumeroEtiqueta;
                                SeguimientoContexto.salidas_sucursales_det.AddObject(oSalidasDet);

                                //Marcar las etiquetas como entregadas.
                                SeguimientoContexto
                                    .etiquetas
                                    .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta)
                                    .estatus = "E";
                                SeguimientoContexto
                                    .etiquetas
                                    .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta)
                                    .tipo_salida = "S";
                                SeguimientoContexto
                                    .etiquetas
                                    .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta)
                                    .fecha_entrega = Servidor.getFechaServer().Date;

                                //Guardar los cambios.
                                SeguimientoContexto.SaveChanges();

                                break;

                            case "3":
                            case "4":
                                // Es Etiqueta de Tarima.
                                oSalidasDet = new salidas_sucursales_det();
                                oSalidasDet.id_salida = objSalida.id_salida;
                                oSalidasDet.numero_etiqueta = RowEtiqueta.NumeroEtiqueta;
                                oSalidasDet.cantidad = RowEtiqueta.Cantidad;
                                oSalidasDet.unidad = RowEtiqueta.Unidad;
                                SeguimientoContexto.salidas_sucursales_det.AddObject(oSalidasDet);

                                //Marcar las etiquetas como entregadas.
                                paquetes oPaquete =
                                    SeguimientoContexto
                                    .paquetes.FirstOrDefault(o => o.id_paquete == RowEtiqueta.ID_Etiqueta);

                                List<paquetes_det> listDetallesPaquete =
                                    SeguimientoContexto
                                    .paquetes_det
                                    .Where(o => o.id_paquete == RowEtiqueta.ID_Etiqueta
                                             && o.etiquetas.estatus == "A")
                                    .ToList();
                                foreach (paquetes_det Detalle in listDetallesPaquete)
                                {
                                    Detalle.etiquetas.estatus = "E";
                                    Detalle.etiquetas.tipo_salida = "S";
                                    Detalle.etiquetas.fecha_entrega = Servidor.getFechaServer().Date;
                                    SeguimientoContexto.SaveChanges();
                                }
                                oPaquete.estatus = "E";
                                SeguimientoContexto.SaveChanges();

                                break;
                        }
                    }
                    else
                    {
                        //Es etiqueta traspasada
                        switch (TIPO_ETIQUETA)
                        {
                            case "1":
                            case "2":
                                // Es etiqueta de caja o pieza.
                                // Crear el detalle de salida.
                                oSalidasDet = new salidas_sucursales_det();
                                oSalidasDet.id_salida = objSalida.id_salida;
                                oSalidasDet.numero_etiqueta = RowEtiqueta.NumeroEtiqueta;
                                SeguimientoContexto.salidas_sucursales_det.AddObject(oSalidasDet);

                                //Marcar las etiquetas como entregadas.
                                SeguimientoContexto
                                    .etiquetas_traspasadas
                                    .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta)
                                    .estado = "E";
                                SeguimientoContexto
                                    .etiquetas_traspasadas
                                    .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta)
                                    .tipo_salida = "S";
                                SeguimientoContexto
                                    .etiquetas_traspasadas
                                    .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta)
                                    .fecha_entrega = Servidor.getFechaServer().Date;

                                //Guardar los cambios.
                                SeguimientoContexto.SaveChanges();

                                break;

                            case "3":
                            case "4":
                                // Es Etiqueta de Tarima.
                                oSalidasDet = new salidas_sucursales_det();
                                oSalidasDet.id_salida = objSalida.id_salida;
                                oSalidasDet.numero_etiqueta = RowEtiqueta.NumeroEtiqueta;
                                oSalidasDet.cantidad = RowEtiqueta.Cantidad;
                                oSalidasDet.unidad = RowEtiqueta.Unidad;
                                SeguimientoContexto.salidas_sucursales_det.AddObject(oSalidasDet);

                                //Marcar las etiquetas como entregadas.
                                paquetes_traspasados oPaqTrasp =
                                    SeguimientoContexto
                                    .paquetes_traspasados
                                    .FirstOrDefault(o => o.id_paquete_traspasado == RowEtiqueta.ID_Etiqueta);

                                List<etiquetas_traspasadas> listDetallesPaquete =
                                    SeguimientoContexto
                                    .etiquetas_traspasadas
                                    .Where(o => o.numero_etiqueta_contenedor == RowEtiqueta.NumeroEtiqueta
                                             && o.estado == "A")
                                    .ToList();

                                foreach (etiquetas_traspasadas Detalle in listDetallesPaquete)
                                {
                                    Detalle.estado = "E";
                                    Detalle.tipo_salida = "S";
                                    Detalle.fecha_entrega = Servidor.getFechaServer().Date;
                                    SeguimientoContexto.SaveChanges();
                                }

                                oPaqTrasp.estado = "E";

                                //Guardar los cambios.
                                SeguimientoContexto.SaveChanges();

                                break;
                        }
                    }
                }

                Transaccion.Commit();
                SeguimientoContexto.Connection.Close();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                SeguimientoContexto.Connection.Close();
                throw ex;
            }

            return objSalida;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (ValidarEntrega() == true)
            {
                DialogResult dr = MessageBox.Show("¿Son datos correctos?", string.Empty,
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GuardarEntrega();
                    btnAceptar.Enabled = false;
                }
            }
        }
                
        private void gvMateriaPrima_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private Entity.articulos ObtenerArticulo(string clave_articulo)
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            Entity.articulos Articulo =
                SeguimientoContexto.articulos.SingleOrDefault(o => o.clave == clave_articulo);
            if (Articulo != null)
                return Articulo;
            else
                throw new EntityException("No se encontro el articulo: " + clave_articulo);
        }

        private decimal getCantidadPaquete(paquetes oPaquete)
        {
            decimal dCantidad = 0;
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<paquetes_det> LstDetallesPaquete =
                SegContext.paquetes_det.Where(o => o.id_paquete == oPaquete.id_paquete).ToList();

            LstDetallesPaquete = LstDetallesPaquete.FindAll(o => o.etiquetas.estatus == "A");

            dCantidad = LstDetallesPaquete.Sum(o => o.etiquetas.cantidad);

            return dCantidad;
        }
        private decimal getCantidadPaquete(paquetes_traspasados oPaqTrasp)
        {
            decimal dCantidad = 0;
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            List<etiquetas_traspasadas> LstDetallesPaquete =
                SegContext
                .etiquetas_traspasadas
                .Where(o => o.numero_etiqueta_contenedor == oPaqTrasp.numero_etiqueta)
                .ToList();

            LstDetallesPaquete = LstDetallesPaquete.FindAll(o => o.estado == "A");

            dCantidad = LstDetallesPaquete.Sum(o => o.cantidad);

            return dCantidad;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //Obtener el producto seleccionado.
            int i = gvRequisicion.GetSelectedRows()[0];
            ArticuloRequerir X = (ArticuloRequerir)gvRequisicion.GetRow(i);

            CambiarArticulo(X.articulo_a_requerir);

        }

        private void CambiarArticulo(Entity.articulos pArticulo)
        {
            Utilidades.Frm_BuscarArticulo frmArticulo = new Utilidades.Frm_BuscarArticulo();
            frmArticulo.ShowDialog();
            Entity.articulos ArticuloSeleccionado = frmArticulo.Articulo;

            if (ArticuloSeleccionado != null)
            {
                string mensaje =
                    string.Format("¿Desea cambiar el artículo: '{0}' por el articulo: '{1}'?", 
                                   pArticulo.articulo, ArticuloSeleccionado.articulo);

                DialogResult dr = MessageBox.Show(mensaje, "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
                        pedidos_sucursales_det DetalleACambiar =
                            SegContext
                            .pedidos_sucursales_det
                            .FirstOrDefault(o => o.id_pedido_maestro_sucursales_det == oPedido.id_pedido_maestro_sucursal_det
                                              && o.clave_articulo == pArticulo.clave);
                        DetalleACambiar.clave_articulo = ArticuloSeleccionado.clave;

                        bitacora RecordBitacora = new bitacora();
                        RecordBitacora.acción = "Cambio de Articulo";
                        RecordBitacora.numero_etiqueta = "N/A";
                        RecordBitacora.observaciones = "Cambio del artículo '" + pArticulo.articulo + "' " +
                            "por el artículo: '" + ArticuloSeleccionado.articulo + "'" +
                            "Para la requisicion numero: '" + oPedido.codigo_requisicion + "'";
                        RecordBitacora.id_usuario_creador = Config.user.id_usuario;
                        RecordBitacora.fecha_hora = Servidor.getFechaServer();
                        SegContext.bitacora.AddObject(RecordBitacora);

                        SegContext.SaveChanges();

                        MessageBox.Show("¡El cambio se ha realizado extosamente!", "OK",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ValidarArchivo();
                        gridRequisicion.DataSource = cargarGridRequisiciones(lstDetallesPedido);
                        gvRequisicion.BestFitColumns();
                    }
                    catch (Exception ex)
                    {
                        StringBuilder sb = new StringBuilder();

                        sb.AppendLine(ex.Message);
                        if (ex.InnerException != null)
                            sb.AppendLine(ex.InnerException.Message);

                        MessageBox.Show(sb.ToString(), ex.GetType().ToString(), 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

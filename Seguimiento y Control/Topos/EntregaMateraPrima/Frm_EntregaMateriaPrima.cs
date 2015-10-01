using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Produccion;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Clases.Utilitarias;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Reportes;

namespace Seguimiento_y_Control.Topos.EntregaMateraPrima
{
    public partial class Frm_EntregaMateriaPrima : Form
    {
        private string sFileName;
        private string sCodigoPedido;
        private pedidos_internos oPedido;
        private List<string> lstEtiquetas;
        private List<pedidos_internos_det> lstDetallesPedido;

        public Frm_EntregaMateriaPrima()
        {
            InitializeComponent();
            lstEtiquetas = new List<string>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarArchivo();
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
            oPedido = Contexto.pedidos_internos.FirstOrDefault(o => o.codigo_pedido == sCodigoPedido);
            if (oPedido == null)
            {
                MessageBox.Show("Error: No se encontro el pedido: " + sCodigoPedido);
                return false;
            }

            lstDetallesPedido = Contexto.pedidos_internos_det.Where(o => o.id_pedido == oPedido.id_pedido).ToList();

            return true;
        }

        private List<string> AbrirArchivo(string sFile)
        {
            StreamReader sr = new StreamReader(sFile);

            string line;
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lines.Remove(string.Empty);

            sr.Close();

            return lines.Distinct().ToList();
        }

        private List<ArticuloRequerir> cargarGridRequisiciones(List<pedidos_internos_det> lsPedidosDet)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            List<ArticuloRequerir> lsArticulosRequerir = new List<ArticuloRequerir>();

            try
            {
                ArticuloRequerir oArticuloRequerir;
                foreach (pedidos_internos_det oDetalle in lsPedidosDet)
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
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sb.AppendLine(ex.InnerException.Message);
                MessageBox.Show(sb.ToString(), ex.GetType().ToString(),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lsArticulosRequerir;
        }

        List<GridEntrega> lstEtiquetasAEntregar;
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

            foreach (string sEtiqueta in lstEtiquetasAux)
            {
                //***** Por cada etiqueta del archivo escaneado
                //***** Buscar el numero de etiqueta en las etiquetas locales
                TIPO_ETIQUETA = sEtiqueta.Substring(0, 1);
                ID_SUCURSAL = sEtiqueta.Substring(1, 2);

                if (TIPO_ETIQUETA == "1" || TIPO_ETIQUETA == "2")
                {
                    //No son Tarimas
                    if (1 == 1)
                    {
                        //Son Locales
                        etiquetas oEtiquetaLocal =
                            Contexto.etiquetas.FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                        if (oEtiquetaLocal != null)
                        {
                            //Si se encontró
                            RenglonGridEntregas = new GridEntrega();
                            RenglonGridEntregas = GenerearRenglonGrid(oEtiquetaLocal, sEtiqueta);
                            lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                        }
                        else
                        {
                            //No se encontró
                            MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bValida = false;
                            break;
                        }
                    }
                    else 
                    {
                        //Son Traspasadas
                        etiquetas_traspasadas oEtiquetaTraspasada =
                        Contexto.etiquetas_traspasadas.FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                        if (oEtiquetaTraspasada != null)
                        {
                            //*** Es una etiqueta Traspasada
                            RenglonGridEntregas = new GridEntrega();
                            RenglonGridEntregas = GenerearRenglonGrid(oEtiquetaTraspasada, sEtiqueta);
                            lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                        }
                        else
                        {
                            MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bValida = false;
                            break;
                        }
                    }
                }
                else
                {
                    //Son Tarminas
                    if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                    {
                        //Son Locales
                        paquetes oPaqueteLocal =
                            Contexto.paquetes.FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                        if (oPaqueteLocal != null)
                        {
                            //Si se encontró
                            RenglonGridEntregas = new GridEntrega();
                            RenglonGridEntregas = GenerearRenglonGrid(oPaqueteLocal);
                            lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                        }
                        else
                        {
                            //No se encontró
                            MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bValida = false;
                            break;
                        }
                    }
                    else
                    {
                        //Son Traspasadas
                        paquetes_traspasados oPaqTrasp =
                            Contexto
                            .paquetes_traspasados
                            .FirstOrDefault(o => o.numero_etiqueta == sEtiqueta);
                        if (oPaqTrasp != null)
                        {
                            //Si se encontró
                            RenglonGridEntregas = new GridEntrega();
                            RenglonGridEntregas = GenerearRenglonGrid(oPaqTrasp);
                            lstEtiquetasAEntregar.Add(RenglonGridEntregas);
                        }
                        else
                        {
                            //No se encontró
                            MessageBox.Show("Error: No se encontró la etiqueta numero: " + sEtiqueta, string.Empty,
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bValida = false;
                            break;
                        }
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrega() == true)
            {
                DialogResult dr = MessageBox.Show("¿Son datos correctos?", string.Empty,
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    GuardarEntrega();
                }
            }
        }

        private bool ValidarEntrega()
        {
            bool bValidado = false;

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
                    listaAuxiliar = lstEtiquetasAEntregar.FindAll(o => o.Clave_Articulo == oRequerido.articulo_a_requerir.clave);
                    //listaAuxiliar = listaAuxiliar.FindAll(o => o.Unidad == oRequerido.unidad);

                    if (listaAuxiliar.Count != 0)
                    {
                        //Si hay etiquetas que corresponden al articulo y unidad requeridos
                        //Obtener la cantidad requerida == cantidad de la requisicion + 10%
                        //decimal fCantidadRequerida = oRequerido.cantidad_a_requrir * 1.10M;
                        //Obtener la cantidad de la entrega sumando todas las etiquetas
                        //decimal fSumaEntrega = listaAuxiliar.Sum(o => o.Cantidad);

                        //if (fCantidadRequerida < fSumaEntrega)
                        //{
                            //Si la cantidad a entregar es Mayor a la cantidad requerida ERROR
                            //sbMensaje.AppendLine("Error: La cantidad requerida es menor a la cantidad de la entrega...");
                            //sbMensaje.Append("Clave: " + oRequerido.articulo_a_requerir.clave);
                            //sbMensaje.AppendLine(" Articulo: " + oRequerido.articulo_a_requerir.articulo);
                            //bValidado = false;
                          //  break;
                        //}
                    }
                    else
                    {
                        //No hay etiquetas del articulo requerido
                        sbMensaje.Append("La entrega no cuenta con el articulo: ");
                        sbMensaje.Append(oRequerido.articulo_a_requerir.clave);
                        sbMensaje.Append(" - " + oRequerido.articulo_a_requerir.articulo);
                        sbMensaje.AppendLine(" Unidad: " + oRequerido.unidad);
                        bValidado = false;
                    }
                }

                if (ExisteSalida() == true)
                {
                    sbMensaje.AppendLine("Error: La salida ya existe en el sistema...");
                    sbMensaje.Append("ID Salida: " + ObtenerSalida(oPedido.id_pedido));
                    bValidado = false;
                }

                if (bValidado == false)
                {
                    MessageBox.Show(sbMensaje.ToString(), string.Empty,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return bValidado;
        }

        private void GuardarEntrega()
        {
            DateTime fecha = DateTime.Now;
            usuarios Soliciante = ObtenerUsuario(oPedido.id_usuario);
            List<RepEntregaInterna> dsReporte = new List<RepEntregaInterna>();
            List<GridEntrega> lstEtiquetasEntrega = (List<GridEntrega>)gridMateriaPrima.DataSource;
            RepEntregaInterna RowReporte;

            try
            {
                salidas oSalida = GenerarSalida();

                foreach (GridEntrega EtiquetaEntrega in lstEtiquetasEntrega)
                {
                    RowReporte = new RepEntregaInterna();
                    RowReporte.Fecha = oSalida.fecha;
                    RowReporte.NumSalida = oSalida.codigo_salida;
                    RowReporte.NumPedido = oPedido.codigo_pedido;
                    RowReporte.Responsable = Config.user;
                    RowReporte.Solicitante = Soliciante;
                    RowReporte.Destino = ObtenerArea(Soliciante.id_area); 
                    RowReporte.RowEtiquetas = EtiquetaEntrega;
                    RowReporte.Bodega = ObtenerBodega(EtiquetaEntrega.ID_Bodega);

                    dsReporte.Add(RowReporte);
                }

                ImagenReportes Imagen = new ImagenReportes();
                Imagen.ImgReporte = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");
               
                xrpEntregaInterna ReporteEntregaInterna = new xrpEntregaInterna();
                ReporteEntregaInterna.ImagenReporte.Add(Imagen);
                ReporteEntregaInterna.DataSource = dsReporte;

                //************************* Respaldo *********************************************
                string BackUp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SalidasInternas";
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
                sb.AppendLine(ex.ToString());
                MessageBox.Show(ex.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private salidas GenerarSalida()
        {
            salidas objSalida = new salidas();
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
            try
            {
                objSalida.fecha = DateTime.Now;
                objSalida.destino = Contexto.areas.FirstOrDefault(o => o.id_area == Config.user.id_area).nombre;
                objSalida.id_pedido = oPedido.id_pedido;
                objSalida.id_usuario_responsable = Config.user.id_usuario;
                objSalida.id_usuario_solicitante = oPedido.id_usuario;
                objSalida.tipo_salida = "P";

                Contexto.salidas.AddObject(objSalida);
                Contexto.SaveChanges();

                configuracion oConfiguracion = Contexto.configuracion.FirstOrDefault(o => o.config == "sucursal");
                objSalida.codigo_salida = oConfiguracion.valor + "-S-" + objSalida.id_salida.ToString().PadLeft(7, '0');
                Contexto.SaveChanges();

                salidas_det oSalidasDet;
                List<GridEntrega> lstEtiquetasEntrega = (List<GridEntrega>)gridMateriaPrima.DataSource;
                foreach (GridEntrega RowEtiqueta in lstEtiquetasEntrega)
                {
                    oSalidasDet = new salidas_det();
                    oSalidasDet.id_salida = objSalida.id_salida;
                    oSalidasDet.numero_etiqueta = RowEtiqueta.NumeroEtiqueta;
                    Contexto.salidas_det.AddObject(oSalidasDet);

                    if (RowEtiqueta.Tipo == 'L')
                    {
                        Contexto
                            .etiquetas
                            .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta).estatus = "E";
                        Contexto
                            .etiquetas
                            .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta).tipo_salida = "P";
                        Contexto
                            .etiquetas
                            .FirstOrDefault(o => o.id_etiqueta == RowEtiqueta.ID_Etiqueta)
                            .fecha_entrega = Servidor.getFechaServer().Date;
                    }
                    else if (RowEtiqueta.Tipo == 'T')
                    {
                        Contexto
                            .etiquetas_traspasadas
                            .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta).estado = "E";
                        Contexto
                            .etiquetas_traspasadas
                            .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta).tipo_salida = "P";
                        Contexto
                            .etiquetas_traspasadas
                            .FirstOrDefault(o => o.id_etiqueta_traspasada == RowEtiqueta.ID_Etiqueta)
                            .fecha_entrega = Servidor.getFechaServer().Date;
                    }
                    else if (RowEtiqueta.Tipo == 'P')
                    {
                        string ID_SUCURSAL = RowEtiqueta.NumeroEtiqueta.Substring(1, 2);
                        oSalidasDet.cantidad = RowEtiqueta.Cantidad;
                        oSalidasDet.unidad = RowEtiqueta.Unidad;

                        if (Config.ID_SUCURSAL_CODIGO_DE_BARRAS == ID_SUCURSAL)
                        {
                            //paquete local
                            Contexto
                            .paquetes
                            .FirstOrDefault(o => o.id_paquete == RowEtiqueta.ID_Etiqueta).estatus = "E";
                            Contexto
                                .paquetes
                                .FirstOrDefault(o => o.id_paquete == RowEtiqueta.ID_Etiqueta).id_pedido = oPedido.id_pedido;

                            List<paquetes_det> ListaPaqDetalles =
                                Contexto.paquetes_det.Where(o => o.id_paquete == RowEtiqueta.ID_Etiqueta
                                                              && o.etiquetas.estatus=="A").ToList();
                            foreach (paquetes_det PaqDetalle in ListaPaqDetalles)
                            {
                                PaqDetalle.etiquetas.estatus = "E";
                                PaqDetalle.etiquetas.tipo_salida = "P";
                                PaqDetalle.etiquetas.fecha_entrega = Servidor.getFechaServer().Date;
                            }

                        }
                        else
                        {
                            //paquete traspasado
                            Contexto
                                .paquetes_traspasados
                                .FirstOrDefault(o => o.id_paquete_traspasado == RowEtiqueta.ID_Etiqueta).estado = "E";
                            Contexto
                                .paquetes_traspasados
                                .FirstOrDefault(o => o.id_paquete_traspasado == RowEtiqueta.ID_Etiqueta).id_pedido_salida = oPedido.id_pedido;

                            List<etiquetas_traspasadas> ListaEtiqTrasp =
                                Contexto
                                .etiquetas_traspasadas
                                .Where(o => o.numero_etiqueta_contenedor == RowEtiqueta.NumeroEtiqueta).ToList();

                            foreach (etiquetas_traspasadas EtiqTrasp in ListaEtiqTrasp)
                            {
                                EtiqTrasp.estado = "E";
                                EtiqTrasp.tipo_salida = "P";
                                EtiqTrasp.fecha_entrega = Servidor.getFechaServer().Date;
                            }
                        }
                    }
                }

                Contexto.SaveChanges();

                /********** Activar Pedido **********/
                pedidos_internos PedidoActivar = Contexto.pedidos_internos.FirstOrDefault(o => o.id_pedido == oPedido.id_pedido);
                PedidoActivar.estatus = "A";
                Contexto.SaveChanges();

                Transaccion.Commit();
                Contexto.Connection.Close();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                Contexto.Connection.Close();
                throw ex;
            }

            return objSalida;
        }

        private bool ExisteSalida()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            salidas ValidaSalida = Contexto.salidas.FirstOrDefault(o => o.id_pedido == oPedido.id_pedido);
            if (ValidaSalida != null)
                return true;
            else
                return false;
        }

        private string ObtenerSalida(int id_pedido)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            salidas oSalida = Contexto.salidas.FirstOrDefault(o => o.id_pedido == id_pedido);
            if (oSalida == null)
                return string.Empty;
            else
                return oSalida.codigo_salida;
        }

        private usuarios ObtenerUsuario(int id_usuario)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            usuarios user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario);
            return user;
        } 

        private string ObtenerArea(long id_area)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            areas oArea = Contexto.areas.FirstOrDefault(o => o.id_area == id_area);
            if (oArea == null)
                return string.Empty;
            else
                return oArea.nombre;
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
            articulos Articulo =
                SeguimientoContexto.articulos.SingleOrDefault(o => o.clave == clave_articulo);
            if (Articulo != null)
                return Articulo.articulo;
            else
                throw new EntityException("No se encontro el articulo: " + clave_articulo);
        }

        private void Frm_EntregaMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private GridEntrega GenerearRenglonGrid(etiquetas EtiqLocal, string sNumEtiq)
        {
            GridEntrega RenglonGridEntregas = new GridEntrega();
            RenglonGridEntregas.ID_Etiqueta = EtiqLocal.id_etiqueta;
            RenglonGridEntregas.NumeroEtiqueta = sNumEtiq;
            RenglonGridEntregas.Clave_Articulo = EtiqLocal.clave_articulo;
            RenglonGridEntregas.Articulo = ObtenerNombreArticulo(EtiqLocal.clave_articulo);
            RenglonGridEntregas.Cantidad = EtiqLocal.cantidad;
            RenglonGridEntregas.Unidad = EtiqLocal.unidad;
            RenglonGridEntregas.ID_Bodega = EtiqLocal.id_bodega;
            RenglonGridEntregas.Estado = EtiqLocal.estatus;
            RenglonGridEntregas.Fecha_Empaque = EtiqLocal.fecha_empaque;
            //***** RenglonGridEntregas.Tipo = 'L';
            RenglonGridEntregas.Tipo = 'L';
            return RenglonGridEntregas;
        }

        private GridEntrega GenerearRenglonGrid(etiquetas_traspasadas EtiqTrasp, string sNumEtiq)
        {
            GridEntrega RenglonGridEntregas = new GridEntrega();
            RenglonGridEntregas.ID_Etiqueta = EtiqTrasp.id_etiqueta_traspasada;
            RenglonGridEntregas.NumeroEtiqueta = sNumEtiq;
            RenglonGridEntregas.Clave_Articulo = EtiqTrasp.clave_articulo;
            RenglonGridEntregas.Articulo = ObtenerNombreArticulo(EtiqTrasp.clave_articulo);
            RenglonGridEntregas.Cantidad = EtiqTrasp.cantidad;
            RenglonGridEntregas.Unidad = EtiqTrasp.unidad;
            RenglonGridEntregas.ID_Bodega = EtiqTrasp.id_bodega;
            RenglonGridEntregas.Estado = EtiqTrasp.estado;
            RenglonGridEntregas.Fecha_Empaque = EtiqTrasp.fecha_empaque;
            //*** RenglonGridEntregas.Tipo = 'T';
            RenglonGridEntregas.Tipo = 'T';
            return RenglonGridEntregas;
        }

        private GridEntrega GenerearRenglonGrid(paquetes PaqLocal)
        {
            articulos oArticulo = getArticulo(PaqLocal);
            GridEntrega RenglonGridEntregas = new GridEntrega();
            RenglonGridEntregas.ID_Etiqueta = PaqLocal.id_paquete;
            RenglonGridEntregas.NumeroEtiqueta = PaqLocal.numero_etiqueta;
            RenglonGridEntregas.Clave_Articulo = oArticulo.clave;
            RenglonGridEntregas.Articulo = oArticulo.articulo;
            RenglonGridEntregas.Cantidad = getCantidadPaquete(PaqLocal);
            RenglonGridEntregas.Unidad = PaqLocal.unidad;
            RenglonGridEntregas.ID_Bodega = oArticulo.id_bodega;
            RenglonGridEntregas.Estado = PaqLocal.estatus;
            RenglonGridEntregas.Fecha_Empaque = PaqLocal.fecha_creacion;

            RenglonGridEntregas.Tipo = 'P';
            return RenglonGridEntregas;
        }

        private GridEntrega GenerearRenglonGrid(paquetes_traspasados PaqTrasp)
        {
            articulos oArticulo = getArticulo(PaqTrasp);
            GridEntrega RenglonGridEntregas = new GridEntrega();
            RenglonGridEntregas.ID_Etiqueta = PaqTrasp.id_paquete_traspasado;
            RenglonGridEntregas.NumeroEtiqueta = PaqTrasp.numero_etiqueta;
            RenglonGridEntregas.Clave_Articulo = oArticulo.clave;
            RenglonGridEntregas.Articulo = oArticulo.articulo;
            RenglonGridEntregas.Cantidad = getCantidadPaquete(PaqTrasp);
            RenglonGridEntregas.Unidad = PaqTrasp.unidad;
            RenglonGridEntregas.ID_Bodega = oArticulo.id_bodega;
            RenglonGridEntregas.Estado = PaqTrasp.estado;
            RenglonGridEntregas.Fecha_Empaque = PaqTrasp.fecha_creacion;

            RenglonGridEntregas.Tipo = 'P';
            return RenglonGridEntregas;
        }


        private void gvMateriaPrima_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private articulos getArticulo(paquetes pPaquete)
        {
            articulos Articulo = new articulos();
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            Articulo = segContext.articulos.FirstOrDefault(o => o.clave == pPaquete.clave_articulo);
            return Articulo;
        }
        private articulos getArticulo(paquetes_traspasados pPaqTrasp)
        {
            articulos Articulo = new articulos();
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            Articulo = segContext.articulos.FirstOrDefault(o => o.clave == pPaqTrasp.clave_articulo);
            return Articulo;
        }

        private decimal getCantidadPaquete(paquetes pPaquete)
        {
            decimal dCantidad = 0;

            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            List<paquetes_det> lstPaqDetalles =
                segContext
                .paquetes_det
                .Where(o => o.id_paquete == pPaquete.id_paquete)
                .ToList();
            lstPaqDetalles = lstPaqDetalles.FindAll(o => o.etiquetas.estatus == "A");
            dCantidad = lstPaqDetalles.Sum(o => o.etiquetas.cantidad);

            return dCantidad;
        }

        private decimal getCantidadPaquete(paquetes_traspasados pPaqTrasp)
        {
            decimal dCantidad = 0;

            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            List<etiquetas_traspasadas> lstPaqDetalles =
                segContext
                .etiquetas_traspasadas
                .Where(o => o.numero_etiqueta_contenedor == pPaqTrasp.numero_etiqueta)
                .ToList();
            lstPaqDetalles = lstPaqDetalles.FindAll(o => o.estado == "A");
            dCantidad = lstPaqDetalles.Sum(o => o.cantidad);

            return dCantidad;
        }
    }
}

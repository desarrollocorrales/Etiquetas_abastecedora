using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Utilidades;
using Sofbr.Utils.Impresoras;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_Procesados : Form
    {        
        private bodegas oBodega;
        private articulos oArticulo;
        private string sUnidadPaquete;
        private pedidos_internos oPedido;
        private List<bodegas> SourceBodegas;
        private List<pesos_fijos> ListaPesosFijos;
        private List<PesoFijo> PesosFijosGrid;
        private Seguimiento_ACC_Entities Contexto;

        public Frm_Procesados()
        {
            InitializeComponent();
        }

        private void Frm_Procesados_Load(object sender, EventArgs e)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            SourceBodegas = Contexto.bodegas.ToList();
            cbCamara.DataSource = SourceBodegas;
            cbCamara.DisplayMember = "bodega";

            ListaPesosFijos = new List<pesos_fijos>();

            string sRazon = Contexto.configuracion.FirstOrDefault(o => o.config == "razon").valor;
            string sNombreEmpresa = Contexto.configuracion.FirstOrDefault(o => o.config == "nombre_empresa").valor;
            string sDomicilio1 = Contexto.configuracion.FirstOrDefault(o => o.config == "domicilio1").valor;
            string sDomicilio2 = Contexto.configuracion.FirstOrDefault(o => o.config == "domicilio2").valor;
            string sDomicilio = sDomicilio1 + Environment.NewLine + sDomicilio2;
            string sLogoEtiqueta = Contexto.configuracion.FirstOrDefault(o => o.config == "logo_etiqueta").valor;
            pbLogoEtiqueta.ImageLocation = sLogoEtiqueta;
            lblRazon.Text = sRazon;
            lblNombreEmpresa.Text = sNombreEmpresa;
            lblDomicilio.Text = sDomicilio;
        }

        private void ActivarControles(bool Activar)
        {
            cbCamara.Enabled = Activar;
            dtpFechaEmpaque.Enabled = Activar;
            panelOpciones.Enabled = true;
            panelPreview.Enabled = true;
        }

        private void ActualizarDatosEtiqueta()
        {
            lblEmpaque.Text = dtpFechaEmpaque.Value.ToString("dd/MM/yyyy");
            lblCaducidad.Text = dtpFechaEmpaque.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MM/yyyy");
            lblClave.Text = oArticulo.clave;
            lblArticulo.Text = oArticulo.articulo;
            lblUnidad.Text = oArticulo.unidad;
            /*************************** Leyenda ***********************************/
            if (oArticulo.leyenda == false)
            {
                lblLeyenda.Text = string.Empty;
                lblLeyenda.Visible = false;
            }
            else
            {
                lblLeyenda.Visible = true;
                if (oArticulo.dias_caducidad >1 && oArticulo.dias_caducidad < 31)
                    lblLeyenda.Text = "MANTENGASE EN REFRIGERACION";
                else
                    lblLeyenda.Text = "MANTENGASE EN CONGELACION";
            }
            /***********************************************************************/
            /*************************** Piezas ************************************/
            if (oArticulo.piezas == null)
            {
                lblPiezas.Visible = false;
                numUpDnPiezas.Visible = false;
            }
            else
            {
                lblPiezas.Visible = true;
                numUpDnPiezas.Visible = true;
                numUpDnPiezas.Enabled = true;
                numUpDnPiezas.Value = Convert.ToDecimal(oArticulo.piezas);
            }
            /***********************************************************************/
        }

        private void ObtenerPesosFijos(string claveArticulo)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            ListaPesosFijos = Contexto.pesos_fijos.Where(o => o.clave_articulo == claveArticulo).ToList();

            PesosFijosGrid = new List<PesoFijo>();
            PesoFijo oPesoFijo;
            foreach (pesos_fijos peso in ListaPesosFijos)
            {
                oPesoFijo = new PesoFijo();
                oPesoFijo.Etiquetas = 0;
                oPesoFijo.Peso = peso.cantidad;
                oPesoFijo.Seleccion = false;
                PesosFijosGrid.Add(oPesoFijo);
            }
        }

        private void ActivarOpciones(articulos pArticulo)
        {
            rbPesoFijo.Checked = true;
            rbCantidadFija.Checked = true;            
            rbPesoVariado.Checked = true;

            if (pArticulo.cantidad_fija == null)
                rbCantidadFija.Enabled = false;
            else
            {
                rbCantidadFija.Enabled = true;
                rbCantidadFija.Checked = true;
                lblCantidadPeso.Text = "Cantidad:";
            }

            if (pArticulo.peso_variado == false)
                rbPesoVariado.Enabled = false;
            else
            {
                rbPesoVariado.Enabled = true;
                rbPesoVariado.Checked = true;
                lblCantidadPeso.Text = "Peso Neto:";
            }

            if (ListaPesosFijos.Count == 0)
            {
                rbPesoFijo.Enabled = false;
                gridPesosFijos.DataSource = null;
            }
            else
            {
                rbPesoFijo.Enabled = true;
                rbPesoFijo.Checked = true;
                gridPesosFijos.DataSource = PesosFijosGrid;
                lblCantidadPeso.Text = "Peso Neto:";
            }
        }

        private void rbPesoFijo_CheckedChanged(object sender, EventArgs e)
        {
            gridPesosFijos.Enabled = rbPesoFijo.Checked;
            if (rbPesoFijo.Checked == true)
            {
                txbCantidad.Text = "0000.0000";
                txbCantidad.Enabled = false;
            }
        }

        private void rbCantidadFija_CheckedChanged(object sender, EventArgs e)
        {
            txbCantidadFija.Enabled = rbCantidadFija.Checked;
            if (rbCantidadFija.Checked == true)
            {
                if (oArticulo != null)
                {
                    txbCantidad.Text = oArticulo.cantidad_fija.ToString();
                    txbCantidad.Enabled = false;
                }
            }
        }

        private void dtpFechaEmpaque_ValueChanged(object sender, EventArgs e)
        {
            lblEmpaque.Text = dtpFechaEmpaque.Value.ToString("dd/MM/yyyy HH:mm");
            lblCaducidad.Text = dtpFechaEmpaque.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MM/yyyy");
        }

        private void rbPesoVariado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPesoVariado.Checked == true)
            {
                txbCantidad.Text = "0000.0000";
                txbCantidad.Enabled = false;
                numUpDnPiezas.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarFechaEmpaque() == false)
            {
                MessageBox.Show("Error en la fecha de empaque...", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbPesoFijo.Checked == true)
                imprimirPesoFijo();
            else if (rbCantidadFija.Checked == true)
                imprimirCantidadFija();
            else if (rbPesoVariado.Checked == true)
                imprimirPesoVariado();
        }
        private bool ValidarFechaEmpaque()
        {
            if (dtpFechaEmpaque.Value.Date > Servidor.getFechaServer().Date)
                return false;
            else
                return true;
        }

        private void imprimirPesoFijo()
        {
            string Comando;
            StringBuilder sbComandos = new StringBuilder();
            Contexto = new Seguimiento_ACC_Entities();
            contenedores Contenedor = Contexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticulo.clave);
            catalog_comandos_etiquetas ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");
            catalog_comandos_etiquetas ComandoTarima= Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "tarima");

            int iNumeroEtiquetas = Convert.ToInt32(txbCantidadFija.Text); //Cantidad de etiquetas a imprimir

            if (Contenedor != null)
            {
                //Existe un contenedor
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    bool bImprimirContenedor = false;
                    List<etiquetas> listaEtiquetas = new List<etiquetas>();
                    List<PesoFijo> ListaPesosFijos = (List<PesoFijo>)gridPesosFijos.DataSource;
                    List<PesoFijo> ListaPesosFijosSeleccionados = ListaPesosFijos.FindAll(o => o.Seleccion == true);

                    foreach (PesoFijo oPesoFijo in ListaPesosFijosSeleccionados)
                    {
                        //Por cada Peso fijo Seleccionado
                        for (int i = 1; i <= oPesoFijo.Etiquetas; i++)
                        {
                            // Imprimir Etiquetas de peso fijo
                            // Generar la Etiqueta del Producto
                            txbCantidad.Text = oPesoFijo.Peso.ToString();
                            etiquetas NuevaEtiqueta = CrearEtiqueta(oPesoFijo.Peso);
                            listaEtiquetas.Add(NuevaEtiqueta);

                            if (Contenedor.impresion_paquete == false)
                            {
                                // Si es contenedor es solo impresion, no se agrega el comando de la etiqueta
                                Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                                sbComandos.AppendLine(Comando);
                            }

                            /******************************* Contenedor **********************************/
                            if ((i % Contenedor.cantidad) == 0)
                            {
                                //Imprimir Contenedor
                                //Solo Imprimir la etiqueta del Contenedor
                                if (Contenedor.tipo == 2)
                                {
                                    //Sumatoria Etiquetas
                                    sUnidadPaquete = "PZAS";
                                    paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Count, listaEtiquetas);
                                    Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Count);
                                    Comando = Comando.Replace("|unidad|", "Piezas");
                                    sbComandos.AppendLine(Comando);
                                    bImprimirContenedor = false;
                                }
                                else if (Contenedor.tipo == 1)
                                {
                                    //Sumatoria Pesos
                                    sUnidadPaquete = "KGS";
                                    paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Sum(o => o.cantidad), listaEtiquetas);
                                    Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Sum(o => o.cantidad));
                                    Comando = Comando.Replace("|unidad|", lblUnidad.Text);
                                    sbComandos.AppendLine(Comando);
                                    bImprimirContenedor = false;
                                }
                                listaEtiquetas = new List<etiquetas>();
                            }
                            else
                            {
                                bImprimirContenedor = true;
                            }
                            /*****************************************************************************/
                        }
                        Contexto.SaveChanges();

                        if (bImprimirContenedor == true)
                        {
                            //Imprimir Contenedor
                            //Solo Imprimir la etiqueta del Contenedor
                            if (Contenedor.tipo == 2)
                            {
                                //Sumatoria Etiquetas
                                sUnidadPaquete = "PZAS";
                                paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Count, listaEtiquetas);
                                Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Count);
                                Comando = Comando.Replace("|unidad|", "Piezas");
                                sbComandos.AppendLine(Comando);
                                bImprimirContenedor = false;
                            }
                            else if (Contenedor.tipo == 1)
                            {
                                //Sumatoria Pesos
                                sUnidadPaquete = "KGS";
                                paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Sum(o => o.cantidad), listaEtiquetas);
                                Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Sum(o => o.cantidad));
                                Comando = Comando.Replace("|unidad|", lblUnidad.Text);
                                sbComandos.AppendLine(Comando);
                                bImprimirContenedor = false;
                            }
                            listaEtiquetas = new List<etiquetas>();
                        }
                    }
                    Imprimir(sbComandos.ToString());

                    //La transacción termina con exito.
                    Transaccion.Commit();
                    Contexto.Connection.Close();
                    MessageBox.Show("La impresión a terminado correctamente", string.Empty,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    MessageBox.Show("Error: " + ex.Message, string.Empty);
                }
            }
            else
            {
                //Imprimir etiquetas sin contenedor
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    List<PesoFijo> ListaPesosFijos = (List<PesoFijo>)gridPesosFijos.DataSource;
                    List<PesoFijo> ListaPesosFijosSeleccionados = ListaPesosFijos.FindAll(o => o.Seleccion == true);
                    foreach (PesoFijo oPesoFijo in ListaPesosFijosSeleccionados)
                    {
                        //Por cada Peso fijo Seleccionado
                        for (int i = 1; i <= oPesoFijo.Etiquetas; i++)
                        {
                            //Imprimir Etiquetas de peso fijo
                            //Generar la Etiqueta del Producto
                            txbCantidad.Text = oPesoFijo.Peso.ToString();
                            etiquetas NuevaEtiqueta = CrearEtiqueta(oPesoFijo.Peso);
                            Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                            sbComandos.AppendLine(Comando);
                        }
                    }
                    Contexto.SaveChanges();

                    Imprimir(sbComandos.ToString());

                    Transaccion.Commit();
                    Contexto.Connection.Close();

                    MessageBox.Show("La impresión a terminado correctamente", string.Empty,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    MessageBox.Show("Error: " + ex.Message, string.Empty);
                }
            }
        }

        private void imprimirCantidadFija()
        {
            string Comando;
            StringBuilder sbComandos = new StringBuilder();
            Contexto = new Seguimiento_ACC_Entities();
            contenedores Contenedor = Contexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticulo.clave);
            catalog_comandos_etiquetas ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o=>o.etiqueta=="produccion");
            catalog_comandos_etiquetas ComandoTarima = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "tarima");
            int iNumeroEtiquetas = Convert.ToInt32(txbCantidadFija.Text); //Cantidad de etiquetas a imprimir

            if (Contenedor != null)
            {
                //Existe contenedor
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    bool bImprimirContenedor = false;
                    List<etiquetas> listaEtiquetas = new List<etiquetas>();

                    for (int i = 1; i <= iNumeroEtiquetas; i++)
                    {
                        // Generar la Etiqueta del Producto
                        etiquetas NuevaEtiqueta = CrearEtiqueta();
                        listaEtiquetas.Add(NuevaEtiqueta);

                        if (Contenedor.impresion_paquete == false)
                        {
                            // Si es contenedor es solo impresion, no se agrega el comando de la etiqueta
                            Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                            sbComandos.AppendLine(Comando);
                        }

                        /******************************* Contenedor **********************************/
                        if ((i % Contenedor.cantidad) == 0)
                        {
                            //Imprimir Contenedor
                            //Solo Imprimir la etiqueta del Contenedor
                            if (Contenedor.tipo == 2)
                            {
                                //Sumatoria Etiquetas
                                sUnidadPaquete = "PZAS";
                                paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Count, listaEtiquetas);
                                Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Count);
                                Comando = Comando.Replace("|unidad|", "Piezas");
                                sbComandos.AppendLine(Comando);
                                bImprimirContenedor = false;
                            }
                            else if (Contenedor.tipo == 1)
                            {
                                //Sumatoria Pesos
                                sUnidadPaquete = "KGS";
                                paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Sum(o => o.cantidad), listaEtiquetas);
                                Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Sum(o => o.cantidad));
                                Comando = Comando.Replace("|unidad|", lblUnidad.Text);
                                sbComandos.AppendLine(Comando);
                                bImprimirContenedor = false;
                            }
                            listaEtiquetas = new List<etiquetas>();
                        }
                        else
                        {
                            bImprimirContenedor = true;
                        }
                        /*****************************************************************************/
                    }
                    Contexto.SaveChanges();

                    if (bImprimirContenedor == true)
                    {
                        //Solo Imprimir la etiqueta del Contenedor
                        if (Contenedor.tipo == 2)
                        {
                            //Sumatoria Etiquetas
                            sUnidadPaquete = "PZAS";
                            paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Count, listaEtiquetas);
                            Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Count);
                            Comando = Comando.Replace("|unidad|", "Piezas");
                            sbComandos.AppendLine(Comando);
                            bImprimirContenedor = false;
                        }
                        else if (Contenedor.tipo == 1)
                        {
                            //Sumatoria Pesos
                            sUnidadPaquete = "KGS";
                            paquetes Paquete = CrearEtiquetaContenedor(listaEtiquetas.Sum(o => o.cantidad), listaEtiquetas);
                            Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, listaEtiquetas.Sum(o => o.cantidad));
                            Comando = Comando.Replace("|unidad|", lblUnidad.Text);
                            sbComandos.AppendLine(Comando);
                            bImprimirContenedor = false;
                        }
                        listaEtiquetas = new List<etiquetas>();
                    }

                    Imprimir(sbComandos.ToString());

                    Transaccion.Commit();
                    Contexto.Connection.Close();

                    MessageBox.Show("La impresión a terminado correctamente", string.Empty,
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    MessageBox.Show("Error: " + ex.Message, string.Empty);
                }
            }
            else
            {
                //Imprimir etiquetas sin contenedor
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {                    
                    for (int i = 0; i < iNumeroEtiquetas; i++)
                    {
                        etiquetas NuevaEtiqueta = CrearEtiqueta();                    
                        Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                        sbComandos.AppendLine(Comando);                                               
                    }
                    Contexto.SaveChanges();

                    Imprimir(sbComandos.ToString());

                    Transaccion.Commit();
                    Contexto.Connection.Close();

                    MessageBox.Show("La impresión a terminado correctamente", string.Empty, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    MessageBox.Show("Error: " + ex.Message, string.Empty);
                }
            }
        }

        private void imprimirPesoVariado()
        {
            Frm_ImpPesoVariado frmImprimirPesoVariado = new Frm_ImpPesoVariado(oArticulo, lblLote.Text, oBodega);
            frmImprimirPesoVariado.ShowDialog();
        }

        private void cbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            oBodega = (bodegas)cbCamara.SelectedItem;
        }

        private void btnBuscarPedidos_Click(object sender, EventArgs e)
        {

            string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
            Frm_BuscarPedido frmBuscarPedido = new Frm_BuscarPedido(Config.user.id_usuario);
            frmBuscarPedido.ShowDialog();
            oPedido = frmBuscarPedido.Pedido;
            if (oPedido != null)
            {
                txbNumPedido.Text = oPedido.codigo_pedido;
                lblLote.Text = oPedido.id_pedido.ToString();
                txbNumPedido.Enabled = false;
                btnBuscarArticulos.Enabled = true;
            }
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            Frm_BuscarArticulo frmBuscarArticulos = new Frm_BuscarArticulo();
            frmBuscarArticulos.ShowDialog();
            articulos ArticuloAux = frmBuscarArticulos.Articulo;
            if (ArticuloAux != null)
            {
                oArticulo = ArticuloAux;

                ActivarControles(true);
                ActivarOpciones(oArticulo);

                txbClave.Text = oArticulo.clave;
                txbArticulo.Text = oArticulo.articulo;
                oBodega = SourceBodegas.Find(o => o.id_bodega == oArticulo.id_bodega);
                cbCamara.SelectedItem = oBodega;
                ObtenerPesosFijos(oArticulo.clave);
                ActivarOpciones(oArticulo);
                ActualizarDatosEtiqueta();
            }
        }

        private string ObtenerComando(etiquetas oEtiqueta, catalog_comandos_etiquetas oCommand)
        {
            string Comando = oCommand.comando;
            Comando = Comando.Replace("|empaque|", lblEmpaque.Text + " " + getHoraServer().ToString("HH:mm"));
            Comando = Comando.Replace("|caducidad|", lblCaducidad.Text);
            Comando = Comando.Replace("|leyenda|", lblLeyenda.Text);
            Comando = Comando.Replace("|clave|", lblClave.Text);
            Comando = Comando.Replace("|para|", lblPara.Text);
            Comando = Comando.Replace("|lote|", lblLote.Text);
            Comando = Comando.Replace("|articulo|", lblArticulo.Text);
            Comando = Comando.Replace("|lblCantidadPeso|", lblCantidadPeso.Text);
            Comando = Comando.Replace("|pesoneto|", txbCantidad.Text);
            Comando = Comando.Replace("|unidad|", lblUnidad.Text);
            Comando = Comando.Replace("0000000000000", oEtiqueta.numero_etiqueta);
            if (numUpDnPiezas.Visible == true)
                Comando = Comando.Replace("|piezas|", "Piezas: " + numUpDnPiezas.Value);
            else
                Comando = Comando.Replace("|piezas|", string.Empty);

            return Comando;
        }

        private string ObtenerComandoContenedor(paquetes oEtiquetaContenedor, catalog_comandos_etiquetas oCommand, decimal fCantidad)
        {
            string Comando = oCommand.comando;
            Comando = Comando.Replace("|empaque|", lblEmpaque.Text + " " + getHoraServer().ToString("HH:mm"));
            Comando = Comando.Replace("|caducidad|", lblCaducidad.Text);
            Comando = Comando.Replace("|leyenda|", lblLeyenda.Text);
            Comando = Comando.Replace("|clave|", lblClave.Text);
            Comando = Comando.Replace("|para|", lblPara.Text);
            Comando = Comando.Replace("|lote|", lblLote.Text);
            Comando = Comando.Replace("|articulo|", lblArticulo.Text);
            Comando = Comando.Replace("|lblCantidadPeso|", lblCantidadPeso.Text);
            Comando = Comando.Replace("|pesoneto|", fCantidad.ToString());
            //Comando = Comando.Replace("|unidad|", lblUnidad.Text);
            Comando = Comando.Replace("0000000000000", oEtiquetaContenedor.numero_etiqueta);
            if (numUpDnPiezas.Visible == true)
                Comando = Comando.Replace("|piezas|", "Piezas: " + numUpDnPiezas.Value);
            else
                Comando = Comando.Replace("|piezas|", string.Empty);

            return Comando;
        }

        private etiquetas CrearEtiqueta()
        {
            etiquetas NuevaEtiqueta = new etiquetas();

            NuevaEtiqueta.tipo_etiqueta = "P";
            NuevaEtiqueta.id_lote = null;
            NuevaEtiqueta.id_pedido = Convert.ToInt32(lblLote.Text);
            NuevaEtiqueta.clave_articulo = oArticulo.clave;
            NuevaEtiqueta.fecha_empaque = dtpFechaEmpaque.Value;
            NuevaEtiqueta.fecha_caducidad = dtpFechaEmpaque.Value.AddDays(oArticulo.dias_caducidad);
            NuevaEtiqueta.id_bodega = oBodega.id_bodega;
            NuevaEtiqueta.id_usuario = Config.user.id_usuario;
            NuevaEtiqueta.cantidad = Convert.ToDecimal(txbCantidad.Text);
            NuevaEtiqueta.unidad = oArticulo.unidad;
            if (numUpDnPiezas.Visible == true) 
                NuevaEtiqueta.piezas = Convert.ToInt32(numUpDnPiezas.Value);                
            else 
                NuevaEtiqueta.piezas = null;
            NuevaEtiqueta.estatus = "A";

            /* Guardar Etiqueta */
            Contexto.etiquetas.AddObject(NuevaEtiqueta);
            Contexto.SaveChanges();

            //***** El numero <2> significa que la etiqueta se elaboró en "Procesados, Cortes o Mantequera".
            string sNumeroEtiqueta = getNumeroEtiqueta(2, NuevaEtiqueta.id_etiqueta);
            NuevaEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);

            return NuevaEtiqueta;
        }
        private etiquetas CrearEtiqueta(decimal fPeso)
        {
            etiquetas NuevaEtiqueta = new etiquetas();

            NuevaEtiqueta.tipo_etiqueta = "P";
            NuevaEtiqueta.id_lote = null;
            NuevaEtiqueta.id_pedido = Convert.ToInt32(lblLote.Text);
            NuevaEtiqueta.clave_articulo = oArticulo.clave;
            NuevaEtiqueta.fecha_empaque = dtpFechaEmpaque.Value;
            NuevaEtiqueta.fecha_caducidad = dtpFechaEmpaque.Value.AddDays(oArticulo.dias_caducidad);
            NuevaEtiqueta.id_bodega = oBodega.id_bodega;
            NuevaEtiqueta.id_usuario = Config.user.id_usuario;
            NuevaEtiqueta.cantidad = fPeso;
            NuevaEtiqueta.unidad = oArticulo.unidad;
            if (numUpDnPiezas.Visible == true)
                NuevaEtiqueta.piezas = Convert.ToInt32(numUpDnPiezas.Value);
            else
                NuevaEtiqueta.piezas = null;
            NuevaEtiqueta.estatus = "A";

            /* Guardar Etiqueta */
            Contexto.etiquetas.AddObject(NuevaEtiqueta);
            Contexto.SaveChanges();

            //***** El numero <2> significa que la etiqueta se elaboró en "Procesados, Cortes o Mantequera".
            string sNumeroEtiqueta = getNumeroEtiqueta(2, NuevaEtiqueta.id_etiqueta);
            NuevaEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);

            return NuevaEtiqueta;
        }

        private paquetes CrearEtiquetaContenedor(decimal fCantidad, List<etiquetas> ListaIDs)
        {
            paquetes NuevoPaquete = new paquetes();

            NuevoPaquete.estatus = "A";
            NuevoPaquete.cantidad = fCantidad;
            NuevoPaquete.unidad = sUnidadPaquete;
            NuevoPaquete.id_pedido = Convert.ToInt32(lblLote.Text);
            NuevoPaquete.fecha_creacion = DateTime.Now;
            NuevoPaquete.fecha_caducidad = dtpFechaEmpaque.Value.AddDays(oArticulo.dias_caducidad);
            NuevoPaquete.clave_articulo = ListaIDs[0].clave_articulo;

            /* Guardar Etiqueta Paquete */
            Contexto.paquetes.AddObject(NuevoPaquete);
            Contexto.SaveChanges();

            //***** El numero <3> significa que la etiqueta se elaboró en "Procesados, Cortes o Mantequera" y es un contenedor
            string sNumeroEtiqueta = getNumeroEtiqueta(3, NuevoPaquete.id_paquete);
            NuevoPaquete.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);

            paquetes_det detalle;
            foreach (etiquetas id in ListaIDs)
            {
                detalle = new paquetes_det();
                detalle.id_paquete = NuevoPaquete.id_paquete;
                detalle.id_etiqueta = id.id_etiqueta;
                Contexto.paquetes_det.AddObject(detalle);
                Contexto.SaveChanges();
            }

            Contexto.SaveChanges();
            return NuevoPaquete;
        }

        private string getNumeroEtiqueta(int tipo_etiqueta, long pId_etiqueta)
        {
            string etiqueta_id = Config.ID_SUCURSAL_CODIGO_DE_BARRAS;
            string numero = tipo_etiqueta.ToString() + 
                            etiqueta_id.ToString() + 
                            pId_etiqueta.ToString().PadLeft(9, '0');           
            return (numero);
        }

        private void Imprimir(string Comando)
        {
            string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
            RawPrinter.SendToPrinter("Etiqueta Produccion", Comando, sImpresoraEtiquetas);
        }

        private DateTime getHoraServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }
    }
}

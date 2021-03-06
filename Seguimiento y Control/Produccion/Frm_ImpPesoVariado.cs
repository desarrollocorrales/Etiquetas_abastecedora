﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Configuracion;
using Sofbr.Utils.Impresoras;
using System.IO.Ports;
using System.IO;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_ImpPesoVariado : Form
    {
        private string sLote;
        private bodegas oBodega;
        private articulos oArticulo;
        private int iContadorEtiquetas;
        private Seguimiento_ACC_Entities Contexto;
        private List<etiquetas> ListEtiquetas;
        private StringBuilder sbComandos;
        private string sUnidadPaquete;

        public Frm_ImpPesoVariado(articulos pArticulo, string pLote, bodegas pBodega)
        {
            InitializeComponent();

            sLote = pLote;
            oArticulo = pArticulo;
            iContadorEtiquetas = 0;
            oBodega = pBodega;
            ListEtiquetas = new List<etiquetas>();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (iContadorEtiquetas != 0)
            {
                //Imprimir Contenedor
                string Comando = string.Empty;
                Contexto = new Seguimiento_ACC_Entities();
                contenedores Contenedor = Contexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticulo.clave);
                catalog_comandos_etiquetas ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");
                catalog_comandos_etiquetas ComandoContenedor = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "tarima");

                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    if (Contenedor.tipo == 2)
                    {
                        //Sumatoria Etiquetas
                        sUnidadPaquete = "PZAS";
                        paquetes Paquete = CrearEtiquetaContenedor(ListEtiquetas.Count, ListEtiquetas);
                        Comando = ObtenerComandoContenedor(Paquete, ComandoContenedor, ListEtiquetas.Count, 2);
                    }
                    else if (Contenedor.tipo == 1)
                    {
                        //Sumatoria Pesos
                        sUnidadPaquete = "KG";
                        paquetes Paquete = CrearEtiquetaContenedor(ListEtiquetas.Sum(o => o.cantidad), ListEtiquetas);
                        Comando = ObtenerComandoContenedor(Paquete, ComandoContenedor, ListEtiquetas.Sum(o => o.cantidad), 1);
                    }

                    ListEtiquetas = new List<etiquetas>();
                    iContadorEtiquetas = 0;

                    Contexto.SaveChanges();

                    Imprimir(Comando);

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

            if (objBascula.IsOpen == true)
            {
                objBascula.Close();
            }

            this.Close();
        }

        private void Frm_ImpPesoVariado_Load(object sender, EventArgs e)
        {
            panelPreview.Enabled = true;
            CargarDatosEmpresa();
            ActualizarDatosEtiqueta();

            /***** Inicializar la Bascula *****/
            try
            {
                objBascula.Close();
                objBascula.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo inicializar la bascula" + Environment.NewLine +
                                ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /***********************************/
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarFechaEmpaque() == false)
            {
                MessageBox.Show("Error en la fecha de empaque...", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ImprimirPesoVariado();            
        }
        private bool ValidarFechaEmpaque()
        {
            if (dtpEmpaque.Value.Date > Servidor.getFechaServer().Date)
                return false;
            else
                return true;
        }

        private void CargarDatosEmpresa()
        {
            try
            {
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                string NombreEmpresa = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "nombre_empresa").valor;
                string RazonSocial = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "razon").valor;
                string Domicilio1 = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "domicilio1").valor;
                string Domicilio2 = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "domicilio2").valor;
                string LogoEtiqueta = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "logo_etiqueta").valor;

                lblNombreEmpresa.Text = NombreEmpresa + Environment.NewLine + RazonSocial;
                lblDomicilio.Text = Domicilio1 + Environment.NewLine + Domicilio2;
                lblRazon.Text = RazonSocial;
                pbLogoEtiqueta.ImageLocation = LogoEtiqueta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDatosEtiqueta()
        {
            lblLote.Text = sLote;
            lblCaducidad.Text = dtpEmpaque.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MM/yyyy");
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
                if (oArticulo.dias_caducidad > 1 && oArticulo.dias_caducidad < 31)
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

        private void dtpEmpaque_ValueChanged(object sender, EventArgs e)
        {
            lblCaducidad.Text = dtpEmpaque.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MM/yyyy");
        }

        private void ImprimirPesoVariado()
        {
            string Comando;
            sbComandos = new StringBuilder();
            Contexto = new Seguimiento_ACC_Entities();
            contenedores Contenedor = Contexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticulo.clave);
            catalog_comandos_etiquetas ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");
            catalog_comandos_etiquetas ComandoTarima = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "Tarima");

            if (Contenedor == null)
            {
                //Imprimir etiquetas sin contenedor
                ImprimirSinContenedor();
            }
            else
            {
                //Existe contenedor
                //Imprimir etiquetas y contenedor si se ha llegado a la cantidad
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    //Generar la Etiqueta del Producto
                    etiquetas NuevaEtiqueta = CrearEtiqueta();
                    ListEtiquetas.Add(NuevaEtiqueta);
                    iContadorEtiquetas++;

                    if (Contenedor.impresion_paquete == false)
                    {
                        Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                        sbComandos.AppendLine(Comando);
                    }

                    if (iContadorEtiquetas == Contenedor.cantidad)
                    {
                        //Imprimir Contenedor
                        //Solo Imprimir la etiqueta del Contenedor
                        if (Contenedor.tipo == 2)
                        {
                            //Sumatoria Etiquetas
                            sUnidadPaquete = "PZAS";
                            paquetes Paquete = CrearEtiquetaContenedor(ListEtiquetas.Count, ListEtiquetas);
                            Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, ListEtiquetas.Count, 2);
                            sbComandos.AppendLine(Comando);
                        }
                        else if (Contenedor.tipo == 1)
                        {
                            //Sumatoria Pesos
                            sUnidadPaquete = "KG";
                            paquetes Paquete = CrearEtiquetaContenedor(ListEtiquetas.Sum(o => o.cantidad), ListEtiquetas);
                            Comando = ObtenerComandoContenedor(Paquete, ComandoTarima, ListEtiquetas.Sum(o => o.cantidad), 1);
                            sbComandos.AppendLine(Comando);
                        }
                        ListEtiquetas = new List<etiquetas>();
                        iContadorEtiquetas = 0;
                    }

                    Contexto.SaveChanges();

                    Imprimir(sbComandos.ToString());

                    Transaccion.Commit();
                    Contexto.Connection.Close();
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    
                    StringBuilder sbMensaje = new StringBuilder();
                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                    {
                        sbMensaje.AppendLine(ex.InnerException.Message);
                    }

                    MessageBox.Show("Error: " + sbMensaje.ToString(), ex.GetType().ToString(), 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImprimirSinContenedor()
        {
            //Imprimir etiquetas sin contenedor
            string Comando;
            catalog_comandos_etiquetas ComandoEtiqueta;
            ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");

            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
            try
            {
                //Generar la Etiqueta del Producto
                etiquetas NuevaEtiqueta = CrearEtiqueta();
                Comando = ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
                Imprimir(Comando);

                Contexto.SaveChanges();

                Transaccion.Commit();
                Contexto.Connection.Close();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                Contexto.Connection.Close();
                MessageBox.Show("Error: " + ex.Message, string.Empty);
            }
        }

        #region *** Bascula ***

        private void objBascula_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Bascula();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Bascula()
        {
            //***** Leer Peso Total GROSS
            string sGross = objBascula.ReadLine();
            if (sGross.Trim() == string.Empty || sGross.Contains("GROSS") != true)
                return;
            
            string subGrossLbl = sGross.Substring(0, 5).Trim();
            string subGrossPeso = sGross.Substring(5, 14).Trim();
            string subGrossUnidad = sGross.Substring(19, 2).Trim();

            //***** Leer Peso del contenedor TARA
            string sTare = objBascula.ReadLine();
            string subNetPeso = "0";
            if (sTare.Length == 11)
            {
                subNetPeso = "0";
            }
            else
            {
                string subTareLbl = sTare.Substring(0, 5).Trim();
                string subTarePeso = sTare.Substring(5, 14).Trim();
                string subTareUnidad = sTare.Substring(19, 2).Trim();

                //***** Leer Peso del producto NETO
                string sNet = objBascula.ReadLine();
                string subNetLbl = sNet.Substring(0, 5).Trim();
                subNetPeso = sNet.Substring(5, 14).Trim();
                string subNetUnidad = sNet.Substring(19, 2).Trim();
            }

            if (subGrossLbl.ToUpper() == "GROSS")
            {
                if (subGrossUnidad.ToUpper() == "KG")
                {
                    //***** Convertir el Peso Neto a Decimal
                    decimal peso = Convert.ToDecimal(subNetPeso);
                    if (peso == 0)
                    {
                        //***** Si el Peso Neto es "0" Imprimir el Peso Total (GROSS) en la etiqueta
                        Enviar(subGrossPeso);
                    }
                    else
                    {
                        //***** Si el Peso Neto es diferente de "0" Imprimirlo en la etiqueta
                        Enviar(subNetPeso);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique las unidades de Medida ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    throw new IOException("Verifique las unidades de Medida");
                }
            }
            else
            {
                throw new IOException("Error al leer la bascula");
            }
        }
        private void Enviar(string sCadena)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txbCantidad.InvokeRequired == true)
            {
                SetTextCallback d = new SetTextCallback(Enviar);
                txbCantidad.Invoke(d, new object[] { sCadena });
            }
            else
            {
                this.txbCantidad.Text = sCadena;
                ImprimirPesoVariado();
            }
        }
        private delegate void SetTextCallback(string text);

        #endregion
 
        #region *** Impresion ***

        private string ObtenerComando(etiquetas oEtiqueta, catalog_comandos_etiquetas oCommand)
        {
            string Comando = oCommand.comando;
            Comando = Comando.Replace("|empaque|", dtpEmpaque.Value.ToString("dd/MM/yyyy") + " " + getFechaServer().ToString("HH:mm"));
            Comando = Comando.Replace("|caducidad|", lblCaducidad.Text);
            Comando = Comando.Replace("|leyenda|", lblLeyenda.Text);
            Comando = Comando.Replace("|clave|", lblClave.Text);
            Comando = Comando.Replace("|para|", lblPara.Text);
            Comando = Comando.Replace("|lote|", lblLote.Text);
            Comando = Comando.Replace("|articulo|", lblArticulo.Text);
            Comando = Comando.Replace("|lblCantidadPeso|", lblCantidadPeso.Text);
            Comando = Comando.Replace("|pesoneto|", Convert.ToDecimal(txbCantidad.Text).ToString("#,#.###"));
            Comando = Comando.Replace("|unidad|", lblUnidad.Text);
            Comando = Comando.Replace("0000000000000", oEtiqueta.numero_etiqueta);
            if (numUpDnPiezas.Visible == true)
                Comando = Comando.Replace("|piezas|", "Piezas: " + numUpDnPiezas.Value);
            else
                Comando = Comando.Replace("|piezas|", string.Empty);

            return Comando;
        }

        private string ObtenerComandoContenedor(paquetes oEtiquetaContenedor, catalog_comandos_etiquetas oCommand, decimal dCantidad, int iTipoContenedor)
        {
            string Comando = oCommand.comando;
            Comando = Comando.Replace("|empaque|", dtpEmpaque.Value.ToString("dd/MM/yyyy") + " " + getFechaServer().ToString("HH:mm"));
            Comando = Comando.Replace("|caducidad|", lblCaducidad.Text);
            Comando = Comando.Replace("|leyenda|", lblLeyenda.Text);
            Comando = Comando.Replace("|clave|", lblClave.Text);
            Comando = Comando.Replace("|para|", lblPara.Text);
            Comando = Comando.Replace("|lote|", lblLote.Text);
            Comando = Comando.Replace("|articulo|", lblArticulo.Text);
            if (iTipoContenedor == 1)
            {
                Comando = Comando.Replace("|lblCantidadPeso|", "Peso Neto");
                Comando = Comando.Replace("|unidad|", "KGs");
            }
            else if (iTipoContenedor == 2)
            {
                Comando = Comando.Replace("|lblCantidadPeso|", "Cantidad");
                Comando = Comando.Replace("|unidad|", "Pzas");
            }

            Comando = Comando.Replace("|pesoneto|", dCantidad.ToString("#,#.###"));            
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
            NuevaEtiqueta.fecha_empaque = dtpEmpaque.Value;
            NuevaEtiqueta.fecha_caducidad = dtpEmpaque.Value.AddDays(oArticulo.dias_caducidad);
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

            //***** El numero <2> Al inicio de la etiqueta, indica que se elaboró en Producción
            string sNumeroEtiqueta = getNumeroEtiqueta(2, NuevaEtiqueta.id_etiqueta);
            NuevaEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
            Contexto.SaveChanges();

            lblNumeroEtiqueta.Text = NuevaEtiqueta.numero_etiqueta;

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
            NuevoPaquete.fecha_caducidad = dtpEmpaque.Value.AddDays(oArticulo.dias_caducidad);
            NuevoPaquete.clave_articulo = ListaIDs[0].clave_articulo;

            /* Guardar Etiqueta Paquete */
            Contexto.paquetes.AddObject(NuevoPaquete);
            Contexto.SaveChanges();

            //***** El numero <3> Al inicio de la etiqueta, indica que se elaboró en Producción y que es un Contenedor
            string sNumeroEtiqueta = getNumeroEtiqueta(3, NuevoPaquete.id_paquete);
            NuevoPaquete.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
            Contexto.SaveChanges();

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
            string ID_SUCURSAL = Config.ID_SUCURSAL_CODIGO_DE_BARRAS;
            string numero = tipo_etiqueta.ToString() + ID_SUCURSAL + pId_etiqueta.ToString().PadLeft(9, '0');            
            return (numero);
        }

        private void Imprimir(string Comando)
        {
            string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
            RawPrinter.SendToPrinter("Etiqueta Produccion", Comando, sImpresoraEtiquetas);   
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }
        #endregion  
    }
}

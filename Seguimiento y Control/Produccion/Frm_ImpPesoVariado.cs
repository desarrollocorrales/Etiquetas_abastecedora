using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ConexionWLS;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Utilitarias;
using Seguimiento_y_Control.Entity;
using Sofbr.Utils.Impresoras;
using System.Configuration;
using System.Drawing;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_ImpPesoVariado : Form
    {
        private string RxString;
        private string sLote;
        private bodegas oBodega;
        private articulos oArticulo;
        private int iContadorEtiquetas; int contador=0;
        private Seguimiento_ACC_Entities Contexto;
        private List<etiquetas> ListEtiquetas;
        private StringBuilder sbComandos;
        private string sUnidadPaquete;
        string auxTxt = string.Empty; string empty = string.Empty;
        private List<catalog_comandos_etiquetas> SourceEtiquetas;

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

            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            SourceEtiquetas = Contexto.catalog_comandos_etiquetas.ToList();
            cbCamara.DataSource = SourceEtiquetas;
            cbCamara.ValueMember = "id_comando";
            cbCamara.DisplayMember = "etiqueta";

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

            if (Properties.Settings.Default.Etiqueta == "SanMateo")
            {
                pbLogoEtiqueta.Image = Properties.Resources.SanMateo;
                lblRazon.Text = "RANCHO SAN MATEO";
            }
            else if (Properties.Settings.Default.Etiqueta == "Sumesa")
            {
                pbLogoEtiqueta.Image = Properties.Resources.Sumesa;
                lblRazon.Text = "SUPER SUMESA";
            }
            else
            {
                pbLogoEtiqueta.Image = Properties.Resources.produccion;
                lblRazon.Text = "LOS CORRALES SA DE SV";
            }
                
                
                
                //Image.FromFile(Path.Combine(Application.StartupPath,"\\"+ Properties.Settings.Default.Etiqueta + ".jpg"));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarFechaEmpaque() == false)
            {
                MessageBox.Show("Error en la fecha de empaque...", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ImprimirPesoVariadoTorrey();            
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
                //IP_Torrey = SeguimientoContexto.configuracion.SingleOrDefault(o => o.config == "ip_torrey").valor;

                lblNombreEmpresa.Text = NombreEmpresa + Environment.NewLine + RazonSocial;
                lblDomicilio.Text = Domicilio1 + Environment.NewLine + Domicilio2;
                //lblRazon.Text = RazonSocial;
                //pbLogoEtiqueta.ImageLocation = LogoEtiqueta;
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

            catalog_comandos_etiquetas ComandoTarima = new catalog_comandos_etiquetas();
            catalog_comandos_etiquetas ComandoEtiqueta = new catalog_comandos_etiquetas();


            if (Properties.Settings.Default.Etiqueta != "")
            {
                //int idCom = ((List<catalog_comandos_etiquetas>)cbCamara.DataSource)[cbCamara.SelectedIndex].id_comando;
                ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == Properties.Settings.Default.Etiqueta);
                ComandoTarima = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "Tarima");
            }
            else
            {
                MessageBox.Show("No ha seleccionado una etiqueta Valida. Favor de ir al modulo de Administración", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                        Comando = 
                            ObtenerComando(NuevaEtiqueta, ComandoEtiqueta);
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
            catalog_comandos_etiquetas ComandoEtiqueta = new catalog_comandos_etiquetas();


            ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == Properties.Settings.Default.Etiqueta);
            //ComandoEtiqueta = Contexto.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");

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
                switch(Properties.Settings.Default.Bascula.ToUpper())
                {
                    case "AB": 
                        Bascula();
                        break;
                    case "T":
                        Torrey();
                        break;
                    case "CC":
                        contador++;
                        CobaCorp();                        
                        break;
                    case "TC4":
                        TorreyC4();
                        break;
                    case "CC4":
                        CobaCorpC4();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Bascula()
        {
            string str1 = this.objBascula.ReadLine();
            if (str1.Trim() == string.Empty || !str1.Contains("GROSS"))
                return;
            string str2 = str1.Substring(0, 5).Trim();
            string sCadena1 = str1.Substring(5, 14).Trim();
            string str3 = str1.Substring(19, 2).Trim();
            string str4 = this.objBascula.ReadLine();
            string sCadena2;
            if (str4.Length == 11)
            {
                sCadena2 = "0";
            }
            else
            {
                str4.Substring(0, 5).Trim();
                str4.Substring(5, 14).Trim();
                str4.Substring(19, 2).Trim();
                string str5 = this.objBascula.ReadLine();
                str5.Substring(0, 5).Trim();
                sCadena2 = str5.Substring(5, 14).Trim();
                str5.Substring(19, 2).Trim();
            }
            if (!(str2.ToUpper() == "GROSS"))
                throw new IOException("Error al leer la bascula");
            if (str3.ToUpper() == "KG")
            {
                if (Convert.ToDecimal(sCadena2) == new Decimal(0))
                    this.Enviar(sCadena1);
                else
                    this.Enviar(sCadena2);
            }
            else
            {
                int num = (int)MessageBox.Show("Verifique las unidades de Medida ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw new IOException("Verifique las unidades de Medida");
            }

            ////***** Leer Peso Total GROSS
            //string sGross = objBascula.ReadExisting();
            //sGross = sGross.Replace("\n", "");
            //sGross = sGross.Replace("\r", "");
            //if (sGross.Trim() == string.Empty || sGross.Contains("GROSS") != true)
            //    return;

            //string subGrossLbl = sGross.Substring(0, 5).Trim();
            //string subGrossPeso = sGross.Substring(5, 14).Trim();
            //string subGrossUnidad = sGross.Substring(19, 2).Trim();

            ////***** Leer Peso del contenedor TARA
            //string subNetPeso = "0";
            //if (sGross.Length == 63)
            //{
            //    string sTare = sGross.Substring(21, 21).Trim();
            //    subNetPeso = "0";
            //    if (sTare.Length == 11)
            //    {
            //        subNetPeso = "0";
            //    }
            //    else
            //    {
            //        string subTareLbl = sTare.Substring(0, 5).Trim();
            //        string subTarePeso = sTare.Substring(5, 14).Trim();
            //        string subTareUnidad = sTare.Substring(19, 2).Trim();

            //        //***** Leer Peso del producto NETO
            //        string sNet = sGross.Substring(42, 21).Trim();
            //        string subNetLbl = sNet.Substring(0, 5).Trim();
            //        subNetPeso = sNet.Substring(5, 14).Trim();
            //        string subNetUnidad = sNet.Substring(19, 2).Trim();
            //    }
            //}

            //if (subGrossLbl.ToUpper() == "GROSS")
            //{
            //    if (subGrossUnidad.ToUpper() == "KG")
            //    {
            //        //***** Convertir el Peso Neto a Decimal
            //        decimal peso = Convert.ToDecimal(subNetPeso);
            //        if (peso == 0)
            //        {
            //            //***** Si el Peso Neto es "0" Imprimir el Peso Total (GROSS) en la etiqueta
            //            Enviar(subGrossPeso);
            //        }
            //        else
            //        {
            //            //***** Si el Peso Neto es diferente de "0" Imprimirlo en la etiqueta
            //            Enviar(subNetPeso);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Verifique las unidades de Medida ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        throw new IOException("Verifique las unidades de Medida");
            //    }
            //}
            //else
            //{
            //    throw new IOException("Error al leer la bascula");
            //}
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

        #region *** Torrey C4 ***

        private void TorreyC4()
        {
            RxString = objBascula.ReadExisting();
            this.Invoke(new EventHandler(DisplayTextC4));
        }
        private void DisplayTextC4(object sender, EventArgs e)
        {
            try
            {
                if (RxString.Trim() != string.Empty)
                {
                    if (RxString.ToUpper().Contains("LBS") == true)
                    {
                        txbCantidad.Text = "Error";
                        MessageBox.Show("Verifique las unidades de Medida");
                    }
                    else
                    {
                        RxString = RxString.Trim();
                        var cantidad = RxString.Split(' ');

                        if (cantidad.Length == 1)
                        {
                            if (EsNumerico(cantidad[0]))
                            {
                                //var dCantidad = Convert.ToDecimal(cantidad[0]);
                                if (auxTxt != string.Empty) auxTxt = auxTxt + cantidad[0];
                                else auxTxt = cantidad[0];

                                txbCantidad.Text = auxTxt; //cantidad[0];

                                if(txbCantidad.Text.Length >= 4)
                                    ImprimirPesoVariado();
                            }
                            else auxTxt = string.Empty;
                        }
                        else if (cantidad.Length == 2)
                        {
                            if (EsNumerico(cantidad[0]))
                            {
                                //var dCantidad = Convert.ToDecimal(cantidad[0]);
                                if (auxTxt != string.Empty) auxTxt = auxTxt + cantidad[0];
                                else auxTxt = cantidad[0];

                                txbCantidad.Text = auxTxt; // cantidad[0];

                                if (txbCantidad.Text.Length >= 4)
                                    ImprimirPesoVariado();
                                auxTxt = string.Empty;
                            }
                        }
                        else
                        {
                            auxTxt = string.Empty;
                            MessageBox.Show("Error en el peso...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                while (ex != null)
                {
                    sbMensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                sbComandos.AppendLine(RxString + ": " + RxString.Length);
                MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool EsNumerico(string strIn)
        {
            try
            {
                decimal.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region * * * Coba Corp * * *
        private void CobaCorp()
        {
            if (contador > 2) return;
            else {
                if(contador==1){
                    RxString = objBascula.ReadExisting();
                }
                else if(contador==2){
                    RxString = RxString +objBascula.ReadExisting();
                this.Invoke(new EventHandler(CobaCorp_DisplayText));
                contador = 0;
                }
            }
        }
        //private void CobaCorp_DisplayText(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (RxString.Trim() != string.Empty)
        //        {
        //            if (RxString.ToUpper().Contains("LBS") == true)
        //            {
        //                txbCantidad.Text = "Error";
        //                MessageBox.Show("Verifique las unidades de Medida");
        //            }
        //            else
        //            {
        //                RxString = RxString.Trim();
        //                var peso = string.Empty;

        //                foreach (char caracter in RxString)
        //                {
        //                    if (Char.IsDigit(caracter) == true)
        //                    {
        //                        peso += caracter;
        //                    }
        //                    else if (Char.IsPunctuation(caracter)==true)
        //                    {
        //                        peso += caracter; 
        //                    }
        //                }

        //                var dCantidad = Convert.ToDecimal(peso);

        //                if (dCantidad > 0)
        //                {
        //                    txbCantidad.Text = peso;
        //                    ImprimirPesoVariado();
        //                }
        //                else
        //                {
        //                    //MessageBox.Show("Error en el peso. Debe ser mayor a cero...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        StringBuilder sbMensaje = new StringBuilder();
        //        while (ex != null)
        //        {
        //            sbMensaje.AppendLine(ex.Message);
        //            ex = ex.InnerException;
        //        }

        //        sbComandos.AppendLine(RxString + ": " + RxString.Length);
        //        MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void CobaCorp_DisplayText(object sender, EventArgs e)
        {
            try
            {
                if (!(this.RxString.Trim() != string.Empty))
                    return;
                if (this.RxString.ToUpper().Contains("LBS"))
                {
                    this.txbCantidad.Text = "Error";
                    int num = (int)MessageBox.Show("Verifique las unidades de Medida");
                }
                else
                {
                    this.RxString = this.RxString.Trim();
                    string empty = string.Empty;
                    foreach (char c in this.RxString)
                    {
                        if (char.IsDigit(c))
                            empty = empty.Trim() + new string(c, 1);
                        //empty += (string)(object)c;
                        else if (char.IsPunctuation(c))
                        {
                            if (c.ToString() == "-")
                            {
                            }
                            else
                                empty = empty.Trim() + new string(c, 1);
                            //empty += (string)(object)c;
                        }
                    }
                    if (Convert.ToDecimal(empty) > new Decimal(0))
                    {
                        this.txbCantidad.Text = empty;
                        this.ImprimirPesoVariado();
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exception = ex;
                StringBuilder stringBuilder = new StringBuilder();
                for (; exception != null; exception = exception.InnerException)
                    stringBuilder.AppendLine(exception.Message);
                this.sbComandos.AppendLine(this.RxString + ": " + (object)this.RxString.Length);
                int num = (int)MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void CobaCorpC4()
        {
            RxString = objBascula.ReadExisting();
            this.Invoke(new EventHandler(CobaCorp_DisplayTextC4));
            
        }


        private void CobaCorp_DisplayTextC4(object sender, EventArgs e)
        {
            try
            {
                if (!(this.RxString.Trim() != string.Empty))
                    return;
                if (this.RxString.ToUpper().Contains("LBS"))
                {
                    this.txbCantidad.Text = "Error";
                    int num = (int)MessageBox.Show("Verifique las unidades de Medida");
                }
                else
                {
                    this.RxString = this.RxString.Trim();
                    string empty = string.Empty;
                    foreach (char c in this.RxString)
                    {
                        if (char.IsDigit(c))
                            empty = empty.Trim() + new string(c, 1);
                        //empty += (string)(object)c;
                        else if (char.IsPunctuation(c))
                        {
                            if (c.ToString() == "-")
                            {
                            }
                            else
                                empty = empty.Trim() + new string(c, 1);
                            //empty += (string)(object)c;
                        }
                    }
                    if (Convert.ToDecimal(empty) > new Decimal(0))
                    {
                        this.txbCantidad.Text = empty;
                        this.ImprimirPesoVariado();
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exception = ex;
                StringBuilder stringBuilder = new StringBuilder();
                for (; exception != null; exception = exception.InnerException)
                    stringBuilder.AppendLine(exception.Message);
                this.sbComandos.AppendLine(this.RxString + ": " + (object)this.RxString.Length);
                int num = (int)MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        #endregion

        #region *** Torrey ***

        private void Torrey()
        {
            RxString = objBascula.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            try
            {
                if (RxString.Trim() != string.Empty)
                {
                    if (RxString.ToUpper().Contains("LBS") == true)
                    {
                        txbCantidad.Text = "Error";
                        MessageBox.Show("Verifique las unidades de Medida");
                    }
                    else
                    {
                        RxString = RxString.Trim();
                        var cantidad = RxString.Split(' ');

                        if (cantidad.Length == 2)
                        {
                            var dCantidad = Convert.ToDecimal(cantidad[0]);
                            if (dCantidad > 0)
                            {
                                txbCantidad.Text = cantidad[0];
                                ImprimirPesoVariado();
                            }
                            else
                            {
                                MessageBox.Show("Error en el peso...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                while (ex != null)
                {
                    sbMensaje.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }

                sbComandos.AppendLine(RxString + ": " + RxString.Length);
                MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (ValidarFechaEmpaque() == false)
                {
                    MessageBox.Show("Error en la fecha de empaque...", "",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //ImprimirPesoVariadoTorrey();
                ImprimirPesoVariado();
            }
        }
    }
}

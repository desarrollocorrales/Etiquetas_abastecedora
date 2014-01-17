using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Sofbr.Utils.Impresoras;
using Seguimiento_y_Control.Clases.Etiquetas;
using System.Text.RegularExpressions;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    public partial class Frm_PrevioImprimir : Form
    {
        private int ID_Lote;
        private articulos oArticulo;
        private proveedores oProveedor;

        private Seguimiento_ACC_Entities Contexto;

        /* Listas de Etiquetas por tipo*/
        public List<etiquetas> listaEtiquetasCantidadFija;
        public List<etiquetas> listaEtiquetasPesoFijo;
        public List<etiquetas> listaEtiquetasPesoVariado;
        /*******************************/

        public Frm_PrevioImprimir(articulos pArticulo, proveedores pProveedor)
        {
            InitializeComponent();
            this.oArticulo = pArticulo;
            this.oProveedor = pProveedor;
        }

        private void Frm_PrevioImprimir_Load(object sender, EventArgs e)
        {
            ID_Lote = CrearLote();
            Cargar();
        }

        private int CrearLote()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            lotes NuevoLote = new lotes();
            NuevoLote.id_usuario = Config.user.id_usuario;
            NuevoLote.fecha_creacion = Servidor.getFechaServer();

            SegContext.lotes.AddObject(NuevoLote);
            SegContext.SaveChanges();

            //Lote Creado con Exito
            return NuevoLote.id_lote;
        }

        private void Cargar()
        {
            Seguimiento_ACC_Entities Context = new Seguimiento_ACC_Entities();
            string sNombreArticulo = oArticulo.articulo;
            string sClaveArticulo = oArticulo.clave;
            string sProveedor = oProveedor.nombre;
            DateTime dtFechaEmpaque = DateTime.Now.AddDays(1);
            string sCaducidad = dtpEmpacado.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MMM/yyyy");
            string sLogoEtiqueta = Context.configuracion.FirstOrDefault(o => o.config == "logo_etiqueta").valor;            
            pbLogo.ImageLocation = sLogoEtiqueta;
            string sRazon = Context.configuracion.FirstOrDefault(o => o.config == "razon").valor;
            lblRazon.Text = sRazon;

            lblArticulo.Text = sNombreArticulo;
            lblClave.Text = sClaveArticulo;
            lblProveedor.Text = sProveedor;
            dtpEmpacado.Value = dtFechaEmpaque;
            txbCaducidad.Text = sCaducidad;
            lblUnidad.Text = oArticulo.unidad;

            if (listaEtiquetasPesoVariado.Count != 0)
                txbCantidad.Enabled = true;
            if (listaEtiquetasPesoFijo.Count != 0 || listaEtiquetasCantidadFija.Count != 0)
                txbCantidad.Enabled = false;
        }

        /*************************** Impresion de Etiquetas de Peso Variado *************************************/
        int iContadorEtiquetasPesoVariado = 0;
        private void ImprimirEtiquetasPesoVariado()
        {
            lblStatus.Text = "Imprimendo etiquetas de Peso Variado" + Environment.NewLine;
            lblStatus.Text += "Etiqueta " + (iContadorEtiquetasPesoVariado + 1) + " de " + listaEtiquetasPesoVariado.Count;
            
            etiquetas oEtiqueta = listaEtiquetasPesoVariado[iContadorEtiquetasPesoVariado];
            oEtiqueta.id_lote = ID_Lote;
            oEtiqueta.fecha_empaque = dtpEmpacado.Value;
            oEtiqueta.fecha_caducidad = oEtiqueta.fecha_empaque.AddDays(oArticulo.dias_caducidad);
            oEtiqueta.id_usuario = Config.user.id_usuario;
            oEtiqueta.fecha_recepcion = getFechaServer();
            oEtiqueta.id_proveedor = oProveedor.id_proveedor;
            /****************** Inicia Transaccion **********************/
            Contexto = new Seguimiento_ACC_Entities();
            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
            /************************************************************/
            try
            {
                oEtiqueta.estatus = "A";
                oEtiqueta.cantidad = Convert.ToDecimal(txbCantidad.Text);
                Contexto.etiquetas.AddObject(oEtiqueta);
                Contexto.SaveChanges();

                string sNumeroEtiqueta = getNumeroEtiqueta(oEtiqueta.id_etiqueta);
                oEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
                Contexto.SaveChanges();

                lblNumeroEtiqueta.Text = oEtiqueta.numero_etiqueta;

                /********************************* Impresion de Etiqueta ***********************/
                string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
                string Comando = ObtenerComando(oEtiqueta);
                RawPrinter.SendToPrinter("Etiqueta Recepcion", Comando, sImpresoraEtiquetas);
                Application.DoEvents();
                /*******************************************************************************/

                /****************** Termina Transaccion Correctamente **********************/
                Transaccion.Commit();
                Contexto.Connection.Close();
                /***************************************************************************/

                iContadorEtiquetasPesoVariado++;
            }
            catch (Exception ex)
            {
                /****************** Termina Transaccion Con Errores **************************/
                Transaccion.Rollback();
                Contexto.Connection.Close();
                /*****************************************************************************/

                string innerMessage = "Ocurrio un error con la base de datos";
                if (ex.InnerException != null)
                    innerMessage = ex.InnerException.Message;

                MessageBox.Show(innerMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (iContadorEtiquetasPesoVariado == listaEtiquetasPesoVariado.Count)
            {
                this.Close();
            }
        }
        /*************************** Fin de Impresion de Etiquetas de Peso Variado *********************************/

        /*************************** Impresion de Etiquetas de Cantida fija *************************************/
        private void ImprimirEtiquetasCantidadFija()
        {
            int iContadorCantidadFija = 1;
            foreach (etiquetas oEtiqueta in listaEtiquetasCantidadFija)
            {
                lblStatus.Text = "Imprimendo etiquetas de Cantidad Fija" + Environment.NewLine;
                lblStatus.Text += "Etiqueta " + (iContadorCantidadFija) + " de " + listaEtiquetasCantidadFija.Count;

                txbCantidad.Text = oEtiqueta.cantidad.ToString();

                oEtiqueta.estatus = "A";
                oEtiqueta.id_lote = ID_Lote;
                oEtiqueta.fecha_empaque = dtpEmpacado.Value;
                oEtiqueta.fecha_caducidad = oEtiqueta.fecha_empaque.AddDays(oArticulo.dias_caducidad);
                oEtiqueta.id_usuario = Config.user.id_usuario;
                oEtiqueta.fecha_recepcion = getFechaServer();
                oEtiqueta.id_proveedor = oProveedor.id_proveedor;
                /****************** Inicia Transaccion **********************/
                Contexto = new Seguimiento_ACC_Entities();
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                /************************************************************/
                try
                {                    
                    Contexto.etiquetas.AddObject(oEtiqueta);
                    Contexto.SaveChanges();

                    string sNumeroEtiqueta = getNumeroEtiqueta(oEtiqueta.id_etiqueta);
                    oEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
                    Contexto.SaveChanges();

                    lblNumeroEtiqueta.Text = oEtiqueta.numero_etiqueta;

                    /********************************* Impresion de Etiqueta ***********************/
                    string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
                    string Comando = ObtenerComando(oEtiqueta);
                    RawPrinter.SendToPrinter("Etiqueta Recepcion", Comando, sImpresoraEtiquetas);
                    Application.DoEvents();
                    /*******************************************************************************/

                    /****************** Termina Transaccion Correctamente **********************/
                    Transaccion.Commit();
                    Contexto.Connection.Close();
                    /***************************************************************************/
                }
                catch (Exception ex)
                {
                    /****************** Termina Transaccion Con Errores **************************/
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    /*****************************************************************************/

                    string innerMessage = "Ocurrio un error con la base de datos";
                    if (ex.InnerException != null)
                        innerMessage = ex.InnerException.Message;

                    MessageBox.Show(innerMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                iContadorCantidadFija++;
            }
        }
        /*************************** Fin de Impresion de Etiquetas de Cantida fija *********************************/

        /******************************* Impresion de Etiquetas de Pesos fijos *************************************/
        private void ImprimirEtiquetasPesosFijos()
        {
            int iContadorPesosFijos = 1;
            lblLote.Text = "LOTE: " + ID_Lote.ToString();

            foreach (etiquetas oEtiqueta in listaEtiquetasPesoFijo)
            {
                txbCantidad.Enabled = false;
                lblStatus.Text = "Imprimendo etiquetas de Pesos Fijos" + Environment.NewLine;
                lblStatus.Text += "Etiqueta " + (iContadorPesosFijos) + " de " + listaEtiquetasPesoFijo.Count;
                lblUnidad.Visible = true;
                lblUnidad.Text = oEtiqueta.unidad;
                lblClave.Text = oEtiqueta.clave_articulo;
                lblArticulo.Text = oArticulo.articulo;
                txbCantidad.Text = oEtiqueta.cantidad.ToString();

                oEtiqueta.estatus = "A";
                oEtiqueta.id_lote = ID_Lote;
                oEtiqueta.fecha_empaque = dtpEmpacado.Value;
                oEtiqueta.fecha_caducidad = oEtiqueta.fecha_empaque.AddDays(oArticulo.dias_caducidad);
                oEtiqueta.id_usuario = Config.user.id_usuario;
                oEtiqueta.fecha_recepcion = getFechaServer();
                oEtiqueta.id_proveedor = oProveedor.id_proveedor;

                /****************** Inicia Transaccion **********************/
                Contexto = new Seguimiento_ACC_Entities();
                Contexto.Connection.Open();
                IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
                /************************************************************/
                
                try
                {                    
                    Contexto.etiquetas.AddObject(oEtiqueta);
                    Contexto.SaveChanges();

                    string sNumeroEtiqueta = getNumeroEtiqueta(oEtiqueta.id_etiqueta);
                    oEtiqueta.numero_etiqueta = sNumeroEtiqueta + EAN13.getCheckDigit(sNumeroEtiqueta);
                    Contexto.SaveChanges();

                    lblNumeroEtiqueta.Text = oEtiqueta.numero_etiqueta;

                    /********************************* Impresion de Etiqueta ***********************/
                    string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
                    string Comando = ObtenerComando(oEtiqueta);
                    RawPrinter.SendToPrinter("Etiqueta Recepcion", Comando, sImpresoraEtiquetas);
                    Application.DoEvents();
                    /*******************************************************************************/

                    /****************** Termina Transaccion Correctamente **********************/
                    Transaccion.Commit();
                    Contexto.Connection.Close();
                    /***************************************************************************/
                }
                catch (Exception ex)
                {
                    /****************** Termina Transaccion Con Errores **************************/
                    Transaccion.Rollback();
                    Contexto.Connection.Close();
                    /*****************************************************************************/

                    string innerMessage = "Ocurrio un error con la base de datos";
                    if (ex.InnerException != null)
                        innerMessage = ex.InnerException.Message;

                    MessageBox.Show(innerMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                
                iContadorPesosFijos++;
            }
        }
        /*************************** Fin de Impresion de Etiquetas de Pesos fijos *********************************/

        private string  ObtenerComando(etiquetas oEtiqueta)
        {
            string Comando = EtiquetaRecepcion.Comando;

            Comando = Comando.Replace("|de|", oProveedor.nombre);
            Comando = Comando.Replace("|lote|", ID_Lote.ToString());
            Comando = Comando.Replace("|empaque|", oEtiqueta.fecha_empaque.ToString("dd/MM/yyyy HH:mm"));
            Comando = Comando.Replace("|caducidad|", oEtiqueta.fecha_caducidad.ToString("dd/MM/yyyy"));
            Comando = Comando.Replace("|clave|", oArticulo.clave);
            Comando = Comando.Replace("|articulo|", oArticulo.articulo);
            Comando = Comando.Replace("|pesoneto|", oEtiqueta.cantidad.ToString("#,#.###"));
            Comando = Comando.Replace("|unidad|", oEtiqueta.unidad);
            
            if (chbxPiezas.Checked == true)
                Comando = Comando.Replace("|piezas|", "Piezas: " + numUpDnPiezas.Value.ToString());
            else
                Comando = Comando.Replace("|piezas|", string.Empty); ;

            Comando = Comando.Replace("0000000000000", oEtiqueta.numero_etiqueta);
            if (oArticulo.leyenda == false)
                Comando = Comando.Replace("|leyenda|", string.Empty);
            else
                if (oArticulo.dias_caducidad > 30)
                    Comando = Comando.Replace("|leyenda|", "MANTENGASE EN CONGELACION");
                else
                    Comando = Comando.Replace("|leyenda|", "MANTENGASE EN REFRIGERACION");
            Comando += Environment.NewLine;

            return Comando;
        }

        private void dtpEmpacado_ValueChanged(object sender, EventArgs e)
        {
            txbCaducidad.Text = dtpEmpacado.Value.AddDays(oArticulo.dias_caducidad).ToString("dd/MMM/yyyy");
            if (listaEtiquetasPesoFijo.Count == 0 && listaEtiquetasCantidadFija.Count == 0)
                txbCantidad.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (ValidarFechaEmpaque() == false)
            {
                MessageBox.Show("Error en la fecha de empaque...", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaEtiquetasPesoFijo.Count != 0)
                ImprimirEtiquetasPesosFijos();

            if (listaEtiquetasCantidadFija.Count != 0)
                ImprimirEtiquetasCantidadFija();

            if (listaEtiquetasPesoVariado.Count != 0)
            {
                txbCantidad.Enabled = true;
                btnImprimir.Enabled = false;
                btnImprimir.Visible = false;
                btnImprimirPesoVariado.Location = new Point(332, 385);
                btnImprimirPesoVariado.Visible = true;

                //ImpresionPesoVariable();
            }
            else
            {
                this.Close();
            }
        }

        private void btnImprimirPesoVariado_Click(object sender, EventArgs e)
        {
            if (ValidarFechaEmpaque() == false)
            {
                MessageBox.Show("Error en la fecha de empaque...", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImpresionPesoVariable();
        }

        private bool ValidarImpresion()
        {
            try
            {               
                Regex ExpresionRegular = new Regex(@"^[0-9][0-9]*(\.[0-9][0-9]*)*$");

                if (ExpresionRegular.IsMatch(txbCantidad.Text))
                {
                    double cantidad = Convert.ToDouble(txbCantidad.Text);

                    if (cantidad > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.Equals('.',e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                if (e.KeyChar == 13)
                {
                    ImpresionPesoVariable();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool ValidarFechaEmpaque()
        {
            if (dtpEmpacado.Value.Date > Servidor.getFechaServer().Date)
                return false;
            else
                return true;
        }

        private void ImpresionPesoVariable()
        {
            if (ValidarImpresion())
            {
                ImprimirEtiquetasPesoVariado();
            }
            else
            {
                MessageBox.Show("Error en la cantidad de la etiqueta", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txbCantidad.SelectAll();
            txbCantidad.Focus();
        }

        private int GenerarLote()
        {
            Contexto = new Seguimiento_ACC_Entities();
            
            lotes objLote = new lotes();
            objLote.fecha_creacion = DateTime.Now;
            objLote.id_usuario = Config.user.id_usuario;
            Contexto.lotes.AddObject(objLote);
            Contexto.SaveChanges();
            lblLote.Text += objLote.id_lote.ToString().PadLeft(7,'0');
            return objLote.id_lote;
        }

        public string getNumeroEtiqueta(long pId_etiqueta)
        {
            string ID_SUCURSAL = Config.ID_SUCURSAL_CODIGO_DE_BARRAS;

            //***** El numero <1> Al inicio de la etiqueta, representa que es "Recepción de Mercancia"
            string numero = "1" + ID_SUCURSAL + pId_etiqueta.ToString().PadLeft(9, '0');
            return (numero);
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer.Date;
        }

        private void chbxPiezas_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnPiezas.Enabled = chbxPiezas.Checked;
        }

    }
}

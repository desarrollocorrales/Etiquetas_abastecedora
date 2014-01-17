using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    public partial class Frm_RecepcionInterna : Form
    {
        private List<paquetes_traspasados> LstPaquetesTraspasados;
        private List<string> lstNumerosDeEtiqueta;

        public Frm_RecepcionInterna()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarArchivo()
        {
            ofdEscaneo.ShowDialog();
            txbArchivo.Text = ofdEscaneo.FileName;
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            SeleccionarArchivo();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbArchivo.Text != string.Empty)
                {
                    LeerArchivo();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerArchivo()
        {
            string line;
            StreamReader sr = new StreamReader(txbArchivo.Text);

            lstNumerosDeEtiqueta = new List<string>();
            while ((line = sr.ReadLine()) != null)
                lstNumerosDeEtiqueta.Add(line);

            lstNumerosDeEtiqueta = lstNumerosDeEtiqueta.Distinct().ToList();

            sr.Close();
        }

        private void CargarDatos()
        {                   
            GridEtiquetasTraspasadas RowGridEtiquetas;
            List<GridEtiquetasTraspasadas> listGridEtiquetas = new List<GridEtiquetasTraspasadas>();

            Seguimiento_ACC_Entities Context = new Seguimiento_ACC_Entities();

            try
            {
                foreach (string sNumeroEtiqueta in lstNumerosDeEtiqueta)
                {
                    string TIPO_ETIQUETA = sNumeroEtiqueta.Substring(0, 1);
                    switch (TIPO_ETIQUETA)
                    {
                        case "1": case "2":
                            // Es Etiqueta Normal
                            RowGridEtiquetas = new GridEtiquetasTraspasadas();
                            etiquetas_traspasadas oEtiqueta =
                                Context
                                .etiquetas_traspasadas
                                .FirstOrDefault(o => o.numero_etiqueta == sNumeroEtiqueta);
                            if (oEtiqueta != null)
                            {
                                articulos oArticulo =
                                    Context
                                    .articulos
                                    .FirstOrDefault(o => o.clave == oEtiqueta.clave_articulo);
                                RowGridEtiquetas.oEtiquetaTraspasada = oEtiqueta;
                                RowGridEtiquetas.oArticulo = oArticulo;
                                listGridEtiquetas.Add(RowGridEtiquetas);
                            }
                            else
                            {
                                StringBuilder sbMensaje = new StringBuilder();
                                sbMensaje.AppendLine("No se encontró la etiqueta '" + sNumeroEtiqueta + "'");
                                sbMensaje.AppendLine("Por favor verifique que se haya realizado la descarga....");
                                MessageBox.Show(sbMensaje.ToString(), "Error", 
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "3": case "4":
                            // Es Etiqueta de Tarima
                            paquetes_traspasados PaqTRasp =
                                Context
                                .paquetes_traspasados
                                .FirstOrDefault(o => o.numero_etiqueta == sNumeroEtiqueta);
                            if (PaqTRasp != null)
                            {
                                //Obtener Las etiquetas de la tarima.
                                List<etiquetas_traspasadas> LstEtiquetasTarima=
                                    Context
                                    .etiquetas_traspasadas
                                    .Where(o=>o.numero_etiqueta_contenedor==sNumeroEtiqueta)
                                    .ToList();
                                foreach (etiquetas_traspasadas EtiqTrasp in LstEtiquetasTarima)
                                {
                                    RowGridEtiquetas = new GridEtiquetasTraspasadas();
                                    //Obtener El Articulo.
                                    articulos oArticulo =
                                        Context
                                        .articulos
                                        .FirstOrDefault(o => o.clave == EtiqTrasp.clave_articulo);

                                    RowGridEtiquetas.oEtiquetaTraspasada = EtiqTrasp;
                                    RowGridEtiquetas.oArticulo = oArticulo;
                                    listGridEtiquetas.Add(RowGridEtiquetas);
                                }
                                LstPaquetesTraspasados.Add(PaqTRasp);
                            }
                            else
                            {
                                StringBuilder sbMensaje = new StringBuilder();
                                sbMensaje.AppendLine("No se encontró la etiqueta '" + sNumeroEtiqueta + "'");
                                sbMensaje.AppendLine("Por favor verifique que se haya realizado la descarga....");
                                MessageBox.Show(sbMensaje.ToString(), "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }                                        
                }

                gridEtiquetas.DataSource =
                          listGridEtiquetas
                          .OrderBy(o => o.oEtiquetaTraspasada.numero_etiqueta)
                          .ToList();
                gvEtiquetas.BestFitColumns();
                btnRecibir.Enabled = true;

                if (gvEtiquetas.DataRowCount != 0)
                    btnRecibir.Enabled = true;
                else
                    btnRecibir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            Recibir();
        }

        private void Recibir()
        {
            etiquetas_traspasadas oEtiquetaAuxiliar;
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            Contexto.Connection.Open();
            IDbTransaction Transaccion = Contexto.Connection.BeginTransaction();
            try
            {
                List<GridEtiquetasTraspasadas> listaEtiquetasRecibir = (List<GridEtiquetasTraspasadas>)gridEtiquetas.DataSource;

                foreach (GridEtiquetasTraspasadas oGridEtiqueta in listaEtiquetasRecibir)
                {
                    oEtiquetaAuxiliar =
                        Contexto
                        .etiquetas_traspasadas
                        .FirstOrDefault(o => o.numero_etiqueta == oGridEtiqueta.oEtiquetaTraspasada.numero_etiqueta);
                    if (oEtiquetaAuxiliar != null)
                    {
                        //*** Solo las Etiquetas con estado pendiente
                        if (oEtiquetaAuxiliar.estado == "P")
                        {
                            /* Actualizar el estatus a ACTIVADO = A */
                            oEtiquetaAuxiliar.estado = "A";
                            /* Actualizar la bodega*/
                            oEtiquetaAuxiliar.id_bodega = oGridEtiqueta.oArticulo.id_bodega;
                            /* Asignar fecha de recepcion */
                            oEtiquetaAuxiliar.fecha_recepcion = 
                                Seguimiento_y_Control.Clases.Utilitarias.Servidor.getFechaServer().Date;
                            Contexto.SaveChanges();
                        }
                    }
                }

                foreach (paquetes_traspasados PaqTrasp in LstPaquetesTraspasados)
                {
                    //Actualizar estatus a "Activo"
                    paquetes_traspasados PaqAuxiliar =
                        Contexto
                        .paquetes_traspasados
                        .FirstOrDefault(o => o.id_paquete_traspasado == PaqTrasp.id_paquete_traspasado);

                    //Encontrar la primer etiqueta de la tarima para obtener el articulo
                    etiquetas_traspasadas EtiqTrasp =
                        Contexto
                        .etiquetas_traspasadas
                        .FirstOrDefault(o => o.numero_etiqueta_contenedor == PaqAuxiliar.numero_etiqueta);
                    
                    PaqAuxiliar.estado = "A";
                    PaqAuxiliar.clave_articulo = EtiqTrasp.clave_articulo;

                    Contexto.SaveChanges();
                }

                Transaccion.Commit();
                MessageBox.Show("La recepcion ha terminado con Exito!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("No se pudo concluir la recepcion.");
                sb.Append("Error: " + ex.Message);
                MessageBox.Show(sb.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerBodegaID(string claveArticulo)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            articulos oArticulo = SegContext.articulos.SingleOrDefault(o => o.clave == claveArticulo);
            return oArticulo.id_bodega;
        }

        private void Frm_RecepcionInterna_Load(object sender, EventArgs e)
        {
            LstPaquetesTraspasados = new List<paquetes_traspasados>();
        }
    }
}

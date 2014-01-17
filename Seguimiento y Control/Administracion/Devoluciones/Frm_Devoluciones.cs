using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Administracion;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control.Administracion.Devoluciones
{
    public partial class Frm_Devoluciones : Form
    {
        public Frm_Devoluciones()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdBuscar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sFileName = ofdBuscar.FileName;
                txbArchivo.Text = sFileName;
                List<string> listaDeEtiquetas = AbrirArchivo(sFileName);
                CargarEscaneo(listaDeEtiquetas);
                ValidarEstados();
            }
        }

        private void ValidarEstados()
        {
            List<GridDevoluciones> LstGridDevoluciones = (List<GridDevoluciones>)gridEtiquetas.DataSource;
            int iEtiquetasInactivas = LstGridDevoluciones.FindAll(o => o.Estado != "Activada").Count;

            if (iEtiquetasInactivas != LstGridDevoluciones.Count)
            {
                MessageBox.Show("Algunas etiquetas ya estan activas...", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAceptar.Enabled = false;
            }
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

            return lines.Distinct().ToList();
        }

        private void CargarEscaneo(List<string> ListaDeEtiquetas)
        {
            try
            {
                bool bError = false;
                Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

                GridDevoluciones RenglonGrid;
                List<GridDevoluciones> SourceGrid = new List<GridDevoluciones>();
                foreach (string Etiqueta in ListaDeEtiquetas)
                {
                    //***** Buscar en etiquetas locales
                    string TIPO_ETIQUETA = Etiqueta.Substring(0, 1);
                    string ID_SUCURSAL = Etiqueta.Substring(1, 2);

                    if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                    {
                        //Son locales
                        switch (TIPO_ETIQUETA)
                        {
                            case "1": case "2":
                                //No son tarimas
                                etiquetas EtqLocal = SegContext.etiquetas.FirstOrDefault(o => o.numero_etiqueta == Etiqueta);
                                if (EtqLocal != null)
                                {
                                    //Es una etiqueta local
                                    RenglonGrid = ObtenerRenglon(EtqLocal);
                                    RenglonGrid.NumeroEtiqueta = Etiqueta;
                                    SourceGrid.Add(RenglonGrid);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontro la etiqueta numero: " + Etiqueta,
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    bError = true;
                                    break;
                                }
                                break;

                            case "3": case "4":
                                //Son Tarimas
                                MessageBox.Show("No es posible devolver una tarima completa, deberá devolver cada una de las cajas...",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bError = true;
                                break;
                        }
                    }
                    else
                    {
                        //Son Traspasadas
                        switch (TIPO_ETIQUETA)
                        {
                            case "1": case "2":
                                //No son tarimas
                                etiquetas_traspasadas EtqTrasp = 
                                    SegContext
                                        .etiquetas_traspasadas
                                        .FirstOrDefault(o => o.numero_etiqueta == Etiqueta);

                                if (EtqTrasp != null)
                                {
                                    //Es una etiqueta local
                                    RenglonGrid = ObtenerRenglon(EtqTrasp);
                                    RenglonGrid.NumeroEtiqueta = Etiqueta;
                                    SourceGrid.Add(RenglonGrid);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontro la etiqueta numero: " + Etiqueta,
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    bError = true;
                                    break;
                                }
                                break;

                            case "3": case "4":
                                //Son Tarimas
                                MessageBox.Show("No es posible devolver una tarima completa, deberá devolver cada una de las cajas...",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bError = true;
                                break;
                        }
                    }                    
                }

                if (bError == false)
                {
                    gridEtiquetas.DataSource = SourceGrid;
                    gvEtiquetas.BestFitColumns();
                    btnAceptar.Enabled = true;
                }
                else
                {
                    gridEtiquetas.DataSource = null;
                    btnAceptar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                string TypeException = ex.GetType().ToString();
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.Message);

                MessageBox.Show(sbMensaje.ToString(), TypeException, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private GridDevoluciones ObtenerRenglon(etiquetas EtqLocal)
        {
            GridDevoluciones RenglonGrid = new GridDevoluciones();

            RenglonGrid.IdEtiqueta = EtqLocal.id_etiqueta;
            RenglonGrid.NumeroEtiqueta = EtqLocal.numero_etiqueta;
            if (EtqLocal.tipo_etiqueta == "R")
                RenglonGrid.NumeroLote = Convert.ToInt64(EtqLocal.id_lote);
            else
                RenglonGrid.NumeroLote = Convert.ToInt64(EtqLocal.id_pedido);
            RenglonGrid.FechaEmpaque = EtqLocal.fecha_empaque;
            RenglonGrid.FechaCaducidad = EtqLocal.fecha_caducidad;
            RenglonGrid.ClaveArticulo = EtqLocal.clave_articulo;
            RenglonGrid.Articulo = EtqLocal.articulos.articulo;
            RenglonGrid.Cantidad = EtqLocal.cantidad;
            RenglonGrid.Unidad = EtqLocal.unidad;
            RenglonGrid.Estado = EtqLocal.estatus;
            RenglonGrid.TipoEtiqueta = "EL";

            return RenglonGrid;
        }

        private GridDevoluciones ObtenerRenglon(etiquetas_traspasadas EtqTrasp)
        {
            GridDevoluciones RenglonGrid = new GridDevoluciones();

            RenglonGrid.IdEtiqueta = EtqTrasp.id_etiqueta_traspasada;
            RenglonGrid.NumeroEtiqueta = EtqTrasp.numero_etiqueta;
            RenglonGrid.NumeroLote = Convert.ToInt64(EtqTrasp.id_lote_origen);
            RenglonGrid.FechaEmpaque = EtqTrasp.fecha_empaque;
            RenglonGrid.FechaCaducidad = EtqTrasp.fecha_caducidad;
            RenglonGrid.ClaveArticulo = EtqTrasp.clave_articulo;
            RenglonGrid.Articulo = EtqTrasp.articulos.articulo;
            RenglonGrid.Cantidad = EtqTrasp.cantidad;
            RenglonGrid.Unidad = EtqTrasp.unidad;
            RenglonGrid.Estado = EtqTrasp.estado;
            RenglonGrid.TipoEtiqueta = "ET";

            return RenglonGrid;
        }

        /*
        private GridDevoluciones ObtenerRenglon(paquetes Paqlocal)
        {
            GridDevoluciones RenglonGrid = new GridDevoluciones();

            RenglonGrid.NumeroEtiqueta = Paqlocal.numero_etiqueta;
            RenglonGrid.NumeroLote = 0;
            RenglonGrid.FechaEmpaque = Paqlocal.fecha_creacion;
            RenglonGrid.FechaCaducidad = Paqlocal.fecha_caducidad;
            RenglonGrid.ClaveArticulo = "";
            RenglonGrid.Articulo = "CONTENEDOR";
            RenglonGrid.Cantidad = Paqlocal.cantidad;
            RenglonGrid.Unidad = Paqlocal.unidad;
            RenglonGrid.Estado = Paqlocal.estatus;
            RenglonGrid.TipoEtiqueta = "PL";

            return RenglonGrid;
        }

        private GridDevoluciones ObtenerRenglon(paquetes_traspasados PaqTrasp)
        {
            GridDevoluciones RenglonGrid = new GridDevoluciones();

            RenglonGrid.NumeroEtiqueta = PaqTrasp.numero_etiqueta;
            RenglonGrid.NumeroLote = 0;
            RenglonGrid.FechaEmpaque = PaqTrasp.fecha_creacion;
            RenglonGrid.FechaCaducidad = PaqTrasp.fecha_caducidad;
            RenglonGrid.ClaveArticulo = "";
            RenglonGrid.Articulo = "CONTENEDOR";
            RenglonGrid.Cantidad = PaqTrasp.cantidad;
            RenglonGrid.Unidad = PaqTrasp.unidad;
            RenglonGrid.Estado = PaqTrasp.estado;
            RenglonGrid.TipoEtiqueta = "PT";

            return RenglonGrid;
        }
        */

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarComentario() == false)
                return;

            DialogResult dr = 
                MessageBox.Show("¿Son datos correctos?", "Validar", 
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
                SegContext.Connection.Open();
                IDbTransaction Transaccion = SegContext.Connection.BeginTransaction();
                try
                {

                    Devolver(SegContext);
                    Transaccion.Commit();

                    MessageBox.Show("¡La devolución se efectuó correctamente!", "OK", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridEtiquetas.DataSource = null;
                    btnAceptar.Enabled = false;
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();

                    string TypeException = ex.GetType().ToString();
                    StringBuilder sbMensaje = new StringBuilder();
                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                        sbMensaje.AppendLine(ex.Message);

                    MessageBox.Show(sbMensaje.ToString(), TypeException, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (SegContext.Connection.State != ConnectionState.Closed)
                        SegContext.Connection.Close();
                }
            }
        }

        private void Devolver(Seguimiento_ACC_Entities SegContext)
        {
            List<GridDevoluciones> LstGridDevoluciones = (List<GridDevoluciones>)gridEtiquetas.DataSource;
            List<GridDevoluciones> LstEtiquetasLocales = LstGridDevoluciones.FindAll(o => o.TipoEtiqueta == "EL");
            List<GridDevoluciones> LstEtiquetasTraspasadas = LstGridDevoluciones.FindAll(o => o.TipoEtiqueta == "ET");

            foreach (GridDevoluciones Renglon in LstEtiquetasLocales)
            {
                bitacora oBitacora = new bitacora();
                etiquetas EtqLocal = SegContext.etiquetas.FirstOrDefault(o => o.id_etiqueta == Renglon.IdEtiqueta);
                
                EtqLocal.estatus = "A";
                EtqLocal.tipo_salida = null;

                oBitacora.numero_etiqueta = Renglon.NumeroEtiqueta;
                oBitacora.acción = "Devolución";
                oBitacora.observaciones = txbComentario.Text;
                oBitacora.fecha_hora = getFechaServer();
                oBitacora.id_usuario_creador = Config.user.id_usuario;

                SegContext.bitacora.AddObject(oBitacora);
                SegContext.SaveChanges();
            }

            foreach (GridDevoluciones Renglon in LstEtiquetasTraspasadas)
            {
                bitacora oBitacora = new bitacora();
                etiquetas_traspasadas EtqTrasp = 
                    SegContext.etiquetas_traspasadas.FirstOrDefault(o => o.id_etiqueta_traspasada == Renglon.IdEtiqueta);

                EtqTrasp.estado = "A";
                EtqTrasp.tipo_salida = null;

                oBitacora.numero_etiqueta = Renglon.NumeroEtiqueta;
                oBitacora.acción = "Devolución";
                oBitacora.observaciones = txbComentario.Text;
                oBitacora.fecha_hora = getFechaServer();
                oBitacora.id_usuario_creador = Config.user.id_usuario;

                SegContext.bitacora.AddObject(oBitacora);
                SegContext.SaveChanges();
            }
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }

        private bool ValidarComentario()
        {
            if (txbComentario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe escribir un comentario", "Error",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

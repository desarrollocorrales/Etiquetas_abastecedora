using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity.Traspasos;
using System.IO;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control.Topos.EntregaExterna
{
    public partial class Frm_EnvioEtiquetas : Form
    {
        private empresas objEmpresa;

        public Frm_EnvioEtiquetas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_EnvioEtiquetas_Load(object sender, EventArgs e)
        {
            CargarComboEmpresas();
        }
        private void CargarComboEmpresas()
        {
            try
            {
                Traspasos_Entities TraspasosContext = new Traspasos_Entities();
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                configuracion EmpresaOrigen = SeguimientoContexto.configuracion.FirstOrDefault(o => o.config == "id_EmpresaOrigen");
                long ID_EmpresaOrigen = Convert.ToInt64(EmpresaOrigen.valor);
                cbEmpresas.DataSource = TraspasosContext.empresas.Where(o => o.id_empresa != ID_EmpresaOrigen).ToList();
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);
                MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                Excepciones(ex);
            }
        }
        private void CargarDatos()
        {
            string sCodigoSalida = txbCodigoSalida.Text.ToUpper().Trim();
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            salidas_sucursales oSalida = SegContext.salidas_sucursales.FirstOrDefault(o => o.codigo_salida == sCodigoSalida);
            if (oSalida != null)
            {
                //Cargar los datos en el grid
                List<salidas_sucursales_det> LstSalidasDet =
                    SegContext.salidas_sucursales_det.Where(o => o.id_salida == oSalida.id_salida).ToList();

                GridEnvioEtiquetas RowGrid;
                List<GridEnvioEtiquetas> SourceGrid = new List<GridEnvioEtiquetas>();
                foreach (salidas_sucursales_det SalidaDet in LstSalidasDet)
                {                    
                    string TIPO_ETIQUETA = SalidaDet.numero_etiqueta.Substring(0, 1);
                    string ID_SUCURSAL = SalidaDet.numero_etiqueta.Substring(1, 2);

                    if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
                    {
                        //Es Local
                        switch (TIPO_ETIQUETA)
                        {
                            case "1": case "2":
                                //Es una Etiqueta Normal
                                Entity.etiquetas Etiqueta = 
                                    SegContext
                                    .etiquetas
                                    .FirstOrDefault(o => o.numero_etiqueta == SalidaDet.numero_etiqueta);

                                RowGrid = new GridEnvioEtiquetas();
                                RowGrid.Articulo = Etiqueta.articulos.articulo;
                                RowGrid.Cantidad = Etiqueta.cantidad;
                                RowGrid.ClaveArticuo = Etiqueta.clave_articulo;
                                RowGrid.ID_Estatus = Etiqueta.estatus;
                                RowGrid.NumeroEtiqueta = Etiqueta.numero_etiqueta;
                                RowGrid.Tipo_Etiqueta = 'L';
                                RowGrid.Unidad = Etiqueta.unidad;
                                RowGrid.NumeroEtiquetaPaquete = "Sin Tarima";
                                SourceGrid.Add(RowGrid);
                                break;
                            case "3": case "4":
                                //Es una Etiqueta de Tarima
                                Entity.paquetes Paquete = 
                                    SegContext
                                    .paquetes
                                    .FirstOrDefault(o => o.numero_etiqueta == SalidaDet.numero_etiqueta);

                                RowGrid = new GridEnvioEtiquetas();
                                RowGrid.Articulo = "Tarima";
                                RowGrid.Cantidad = Convert.ToDecimal(SalidaDet.cantidad);
                                RowGrid.ClaveArticuo = Paquete.clave_articulo;
                                RowGrid.ID_Estatus = Paquete.estatus;
                                RowGrid.NumeroEtiqueta = Paquete.numero_etiqueta;
                                RowGrid.Tipo_Etiqueta = 'L';
                                RowGrid.Unidad = SalidaDet.unidad;
                                RowGrid.NumeroEtiquetaPaquete = Paquete.numero_etiqueta;
                                SourceGrid.Add(RowGrid);

                                //Desglozar la tarima
                                List<paquetes_det> LstPaquetesDet =
                                    SegContext
                                    .paquetes_det
                                    .Where(o => o.id_paquete == Paquete.id_paquete)
                                    .ToList();
                                foreach (paquetes_det PaqueteDet in LstPaquetesDet)
                                {
                                    //si la etiqueta no se entregó con la tarima
                                    salidas_det salidaDetAux =
                                        SegContext
                                        .salidas_det
                                        .FirstOrDefault(o => o.numero_etiqueta == PaqueteDet.etiquetas.numero_etiqueta);
                                    if (salidaDetAux != null)
                                    {
                                        if (salidaDetAux.id_salida == oSalida.id_salida)
                                        {
                                            //La etiqueta pertenece al documento de salida
                                            RowGrid = new GridEnvioEtiquetas();
                                            RowGrid.Articulo = PaqueteDet.etiquetas.articulos.articulo;
                                            RowGrid.Cantidad = PaqueteDet.etiquetas.cantidad;
                                            RowGrid.ClaveArticuo = PaqueteDet.etiquetas.clave_articulo;
                                            RowGrid.ID_Estatus = PaqueteDet.etiquetas.estatus;
                                            RowGrid.NumeroEtiqueta = PaqueteDet.etiquetas.numero_etiqueta;
                                            RowGrid.Tipo_Etiqueta = 'L';
                                            RowGrid.Unidad = PaqueteDet.etiquetas.unidad;
                                            RowGrid.NumeroEtiquetaPaquete = Paquete.numero_etiqueta;
                                            SourceGrid.Add(RowGrid);
                                        }
                                    }
                                    else
                                    {
                                        //La etiqueta se entregó junto con la tarima.
                                        RowGrid = new GridEnvioEtiquetas();
                                        RowGrid.Articulo = PaqueteDet.etiquetas.articulos.articulo;
                                        RowGrid.Cantidad = PaqueteDet.etiquetas.cantidad;
                                        RowGrid.ClaveArticuo = PaqueteDet.etiquetas.clave_articulo;
                                        RowGrid.ID_Estatus = PaqueteDet.etiquetas.estatus;
                                        RowGrid.NumeroEtiqueta = PaqueteDet.etiquetas.numero_etiqueta;
                                        RowGrid.Tipo_Etiqueta = 'L';
                                        RowGrid.Unidad = PaqueteDet.etiquetas.unidad;
                                        RowGrid.NumeroEtiquetaPaquete = Paquete.numero_etiqueta;
                                        SourceGrid.Add(RowGrid);
                                    }
                                }
                                break;
                        }
                    }
                    else
                    {
                        //Es traspasada
                        switch (TIPO_ETIQUETA)
                        {
                            case "1":
                            case "2":
                                //Es una Etiqueta Normal
                                etiquetas_traspasadas EtiqTrasp =
                                    SegContext
                                    .etiquetas_traspasadas
                                    .FirstOrDefault(o => o.numero_etiqueta == SalidaDet.numero_etiqueta);

                                RowGrid = new GridEnvioEtiquetas();
                                RowGrid.Articulo = EtiqTrasp.articulos.articulo;
                                RowGrid.Cantidad = EtiqTrasp.cantidad;
                                RowGrid.ClaveArticuo = EtiqTrasp.clave_articulo;
                                RowGrid.ID_Estatus = EtiqTrasp.estado;
                                RowGrid.NumeroEtiqueta = EtiqTrasp.numero_etiqueta;
                                RowGrid.Tipo_Etiqueta = 'T';
                                RowGrid.Unidad = EtiqTrasp.unidad;
                                RowGrid.NumeroEtiquetaPaquete = "Sin Tarima";
                                SourceGrid.Add(RowGrid);
                                break;
                            case "3":
                            case "4":
                                //Es una Etiqueta de Tarima
                                paquetes_traspasados PaqTrasp =
                                    SegContext
                                    .paquetes_traspasados
                                    .FirstOrDefault(o => o.numero_etiqueta == SalidaDet.numero_etiqueta);

                                RowGrid = new GridEnvioEtiquetas();
                                RowGrid.Articulo = "Tarima";
                                RowGrid.Cantidad = Convert.ToDecimal(SalidaDet.cantidad);
                                RowGrid.ClaveArticuo = PaqTrasp.clave_articulo;
                                RowGrid.ID_Estatus = PaqTrasp.estado;
                                RowGrid.NumeroEtiqueta = PaqTrasp.numero_etiqueta;
                                RowGrid.Tipo_Etiqueta = 'T';
                                RowGrid.Unidad = SalidaDet.unidad;
                                RowGrid.NumeroEtiquetaPaquete = PaqTrasp.numero_etiqueta;
                                SourceGrid.Add(RowGrid);

                                //Desglozar la tarima
                                List<etiquetas_traspasadas> LstPaquetesDet =
                                    SegContext
                                    .etiquetas_traspasadas
                                    .Where(o => o.numero_etiqueta_contenedor == PaqTrasp.numero_etiqueta)
                                    .ToList();
                                foreach (etiquetas_traspasadas PaqueteDet in LstPaquetesDet)
                                {
                                    //si la etiqueta no se entregó con la tarima
                                    salidas_det salidaDetAux =
                                        SegContext
                                        .salidas_det
                                        .FirstOrDefault(o => o.numero_etiqueta == PaqueteDet.numero_etiqueta);
                                    if (salidaDetAux != null)
                                    {
                                        if (salidaDetAux.id_salida == oSalida.id_salida)
                                        {
                                            //La etiqueta pertenece al documento de salida
                                            RowGrid = new GridEnvioEtiquetas();
                                            RowGrid.Articulo = PaqueteDet.articulos.articulo;
                                            RowGrid.Cantidad = PaqueteDet.cantidad;
                                            RowGrid.ClaveArticuo = PaqueteDet.clave_articulo;
                                            RowGrid.ID_Estatus = PaqueteDet.estado;
                                            RowGrid.NumeroEtiqueta = PaqueteDet.numero_etiqueta;
                                            RowGrid.Tipo_Etiqueta = 'T';
                                            RowGrid.Unidad = PaqueteDet.unidad;
                                            RowGrid.NumeroEtiquetaPaquete = PaqTrasp.numero_etiqueta;
                                            SourceGrid.Add(RowGrid);
                                        }
                                    }
                                    else
                                    {
                                        //La etiqueta se entregó junto con la tarima.
                                        RowGrid = new GridEnvioEtiquetas();
                                        RowGrid.Articulo = PaqueteDet.articulos.articulo;
                                        RowGrid.Cantidad = PaqueteDet.cantidad;
                                        RowGrid.ClaveArticuo = PaqueteDet.clave_articulo;
                                        RowGrid.ID_Estatus = PaqueteDet.estado;
                                        RowGrid.NumeroEtiqueta = PaqueteDet.numero_etiqueta;
                                        RowGrid.Tipo_Etiqueta = 'T';
                                        RowGrid.Unidad = PaqueteDet.unidad;
                                        RowGrid.NumeroEtiquetaPaquete = PaqTrasp.numero_etiqueta;
                                        SourceGrid.Add(RowGrid);
                                    }
                                }
                                break;
                        }
                    }                    
                }

                gridEtiquetas.DataSource = SourceGrid;
                gvEiquetas.BestFitColumns();

                int iNumeroEtiquetas = SourceGrid.Count;
                int iNumeroEtiquetasEntregadas = SourceGrid.FindAll(o => o.ID_Estatus == "E").Count;

                if (iNumeroEtiquetas == iNumeroEtiquetasEntregadas)
                {
                    btnEnviar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hay etiquetas con estado incorrecto", "Error", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEnviar.Enabled = false;
                }
            }
            else
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("No se encontro la salida con codigo: " + sCodigoSalida);

                MessageBox.Show(sbMensaje.ToString(), "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
                
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Las etiquetas serán enviadas a " + cbEmpresas.Text);
            sb.AppendLine("¿Los datos son correctos?");
            DialogResult dr =
                MessageBox.Show(sb.ToString(), "Validar",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Enviar();
            }
        }
        private void Enviar()
        {            
            Traspasos_Entities TraspasosContext = new Traspasos_Entities();
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            List<GridEnvioEtiquetas> lstEtiquetasToSend = (List<GridEnvioEtiquetas>)gridEtiquetas.DataSource;
            List<GridEnvioEtiquetas> lstEtiqToSendLocales = lstEtiquetasToSend.FindAll(o => o.Tipo_Etiqueta == 'L');
            List<GridEnvioEtiquetas> lstEtiqToSendTraspasadas = lstEtiquetasToSend.FindAll(o => o.Tipo_Etiqueta == 'T');

            int id_empresaOrigen = 
                Convert.ToInt32(SegContext.configuracion.FirstOrDefault(o => o.config == "id_EmpresaOrigen").valor);
            Entity.Traspasos.etiquetas etiqueta_A_Enviar;

            TraspasosContext.Connection.Open();
            SegContext.Connection.Open();
            IDbTransaction TransaccionSeguimiento = SegContext.Connection.BeginTransaction();
            IDbTransaction TransaccionTraspaso = TraspasosContext.Connection.BeginTransaction();
            try
            {
                foreach (GridEnvioEtiquetas rowEtiquetaL in lstEtiqToSendLocales)
                {
                    string TIPO_ETIQUETA = rowEtiquetaL.NumeroEtiqueta.Substring(0, 1);

                    switch (TIPO_ETIQUETA)
                    {
                        case "1":
                        case "2":
                            //Es Etiqueta Normal
                            Entity.etiquetas EtiqLocal =
                                SegContext.etiquetas.FirstOrDefault(o => o.numero_etiqueta == rowEtiquetaL.NumeroEtiqueta);

                            etiqueta_A_Enviar = new Entity.Traspasos.etiquetas();
                            etiqueta_A_Enviar.numero_etiqueta = rowEtiquetaL.NumeroEtiqueta;
                            etiqueta_A_Enviar.tipo_etiqueta = EtiqLocal.tipo_etiqueta;
                            if (EtiqLocal.tipo_etiqueta == "R")
                                etiqueta_A_Enviar.id_lote_origen = (long)EtiqLocal.id_lote;
                            else
                                etiqueta_A_Enviar.id_lote_origen = (long)EtiqLocal.id_pedido;

                            etiqueta_A_Enviar.clave_articulo = EtiqLocal.clave_articulo;
                            etiqueta_A_Enviar.fecha_empaque = EtiqLocal.fecha_empaque;
                            etiqueta_A_Enviar.fecha_caducidad = EtiqLocal.fecha_caducidad;
                            etiqueta_A_Enviar.cantidad = EtiqLocal.cantidad;
                            etiqueta_A_Enviar.unidad = EtiqLocal.unidad;
                            etiqueta_A_Enviar.piezas = EtiqLocal.piezas;
                            etiqueta_A_Enviar.id_empresa_destino = objEmpresa.id_empresa;
                            etiqueta_A_Enviar.id_empresa_origen = id_empresaOrigen;
                            etiqueta_A_Enviar.estado = "P";
                            etiqueta_A_Enviar.numero_etiqueta_contenedor = rowEtiquetaL.NumeroEtiquetaPaquete;

                            TraspasosContext.etiquetas.AddObject(etiqueta_A_Enviar);
                            TraspasosContext.SaveChanges();

                            EtiqLocal.estatus = "T";
                            SegContext.SaveChanges();

                            break;
                        case "3":
                        case "4":
                            //Es Etiqueta de Tarima
                            Entity.paquetes oPaquete =
                                SegContext.paquetes.SingleOrDefault(o => o.numero_etiqueta == rowEtiquetaL.NumeroEtiqueta);

                            Entity.Traspasos.paquetes oPaqueteATraspasar = new Entity.Traspasos.paquetes();
                            oPaqueteATraspasar.numero_etiqueta = oPaquete.numero_etiqueta;
                            oPaqueteATraspasar.estado = "P";
                            oPaqueteATraspasar.cantidad = oPaquete.cantidad;
                            oPaqueteATraspasar.unidad = oPaquete.unidad;
                            oPaqueteATraspasar.id_pedido_origen = oPaquete.id_pedido;
                            oPaqueteATraspasar.fecha_creacion = oPaquete.fecha_creacion;
                            oPaqueteATraspasar.fecha_caducidad = oPaquete.fecha_caducidad;
                            oPaqueteATraspasar.id_empresa_origen = id_empresaOrigen;
                            oPaqueteATraspasar.id_empresa_destino = objEmpresa.id_empresa;

                            TraspasosContext.paquetes.AddObject(oPaqueteATraspasar);
                            TraspasosContext.SaveChanges();

                            oPaquete.estatus = "T";
                            SegContext.SaveChanges();

                            break;
                    }
                }

                foreach (GridEnvioEtiquetas rowEtiquetaT in lstEtiqToSendTraspasadas)
                {
                    string TIPO_ETIQUETA = rowEtiquetaT.NumeroEtiqueta.Substring(0, 1);

                    switch (TIPO_ETIQUETA)
                    {
                        case "1":
                        case "2":
                            //Es Etiqueta Normal
                            etiquetas_traspasadas EtiqTrasp =
                                SegContext
                                .etiquetas_traspasadas
                                .FirstOrDefault(o => o.numero_etiqueta == rowEtiquetaT.NumeroEtiqueta);

                            etiqueta_A_Enviar = new Entity.Traspasos.etiquetas();
                            etiqueta_A_Enviar.numero_etiqueta = rowEtiquetaT.NumeroEtiqueta;
                            etiqueta_A_Enviar.tipo_etiqueta = EtiqTrasp.tipo_etiqueta;
                            etiqueta_A_Enviar.id_lote_origen = (long)EtiqTrasp.id_lote_origen;

                            etiqueta_A_Enviar.clave_articulo = EtiqTrasp.clave_articulo;
                            etiqueta_A_Enviar.fecha_empaque = EtiqTrasp.fecha_empaque;
                            etiqueta_A_Enviar.fecha_caducidad = EtiqTrasp.fecha_caducidad;
                            etiqueta_A_Enviar.cantidad = EtiqTrasp.cantidad;
                            etiqueta_A_Enviar.unidad = EtiqTrasp.unidad;
                            etiqueta_A_Enviar.piezas = EtiqTrasp.piezas;
                            etiqueta_A_Enviar.id_empresa_destino = objEmpresa.id_empresa;
                            etiqueta_A_Enviar.id_empresa_origen = id_empresaOrigen;
                            etiqueta_A_Enviar.estado = "P";
                            etiqueta_A_Enviar.numero_etiqueta_contenedor = rowEtiquetaT.NumeroEtiquetaPaquete;

                            TraspasosContext.etiquetas.AddObject(etiqueta_A_Enviar);
                            TraspasosContext.SaveChanges();

                            EtiqTrasp.estado = "T";
                            SegContext.SaveChanges();

                            break;
                        case "3":
                        case "4":
                            //Es Etiqueta de Tarima
                            paquetes_traspasados PaqTrasp =
                                SegContext
                                .paquetes_traspasados
                                .SingleOrDefault(o => o.numero_etiqueta == rowEtiquetaT.NumeroEtiqueta);

                            Entity.Traspasos.paquetes oPaqueteATraspasar = new Entity.Traspasos.paquetes();
                            oPaqueteATraspasar.numero_etiqueta = PaqTrasp.numero_etiqueta;
                            oPaqueteATraspasar.estado = "P";
                            oPaqueteATraspasar.cantidad = PaqTrasp.cantidad;
                            oPaqueteATraspasar.unidad = PaqTrasp.unidad;
                            oPaqueteATraspasar.id_pedido_origen = PaqTrasp.id_pedido_origen;
                            oPaqueteATraspasar.fecha_creacion = PaqTrasp.fecha_creacion;
                            oPaqueteATraspasar.fecha_caducidad = PaqTrasp.fecha_caducidad;
                            oPaqueteATraspasar.id_empresa_origen = id_empresaOrigen;
                            oPaqueteATraspasar.id_empresa_destino = objEmpresa.id_empresa;

                            TraspasosContext.paquetes.AddObject(oPaqueteATraspasar);
                            TraspasosContext.SaveChanges();

                            PaqTrasp.estado = "T";

                            SegContext.SaveChanges();

                            break;
                    }
                }

                TransaccionSeguimiento.Commit();
                TransaccionTraspaso.Commit();

                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("¡El envio de etiquetas ha concluido con exito!");

                MessageBox.Show(sbMensaje.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridEtiquetas.DataSource = null;
                btnEnviar.Enabled = false;
            }
            catch (Exception ex)
            {
                TransaccionSeguimiento.Rollback();
                TransaccionTraspaso.Rollback();

                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("No fue posible realizar el envio.");
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                if (SegContext.Connection.State != ConnectionState.Closed)
                    SegContext.Connection.Close();

                if (TraspasosContext.Connection.State != ConnectionState.Closed)
                    TraspasosContext.Connection.Close();
            }
        }

        private void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            objEmpresa = (empresas)cbEmpresas.SelectedItem;
        }
    
        private void Excepciones(Exception ex)
        {
            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine("No fue posible realizar el envio.");
            sbMensaje.AppendLine(ex.Message);
            if (ex.InnerException != null)
                sbMensaje.AppendLine(ex.InnerException.Message);

            MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(),
                            MessageBoxButtons.OK, MessageBoxIcon.Error);  
        }

        private void gvEiquetas_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }
    }
}

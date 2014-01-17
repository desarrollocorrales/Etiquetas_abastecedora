using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Utilitarias;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Clases.Administracion;

namespace Seguimiento_y_Control.Administracion.Reimpresiones
{
    public partial class Frm_Eliminar_Etiquetas : Form
    {
        etiquetas Etiqueta;
        string sNumeroEtiqueta;
        catalog_comandos_etiquetas oComando;

        public Frm_Eliminar_Etiquetas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEtiqueta();
        }

        private void BuscarEtiqueta()
        {
            sNumeroEtiqueta = txbNumeroEtiqueta.Text;
            
            if (sNumeroEtiqueta.Length < 13)
                return;

            string ID_SUCURSAL = sNumeroEtiqueta.Substring(1, 2);
            string TIPO_ETIQUETA = sNumeroEtiqueta.Substring(0, 1);
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            etiquetas oEtiqueta = BuscarEtiquetaLocal(sNumeroEtiqueta);
            if (oEtiqueta != null)
            {
                Etiqueta = oEtiqueta;
                GridReimprimirEtiqueta RowGrid = new GridReimprimirEtiqueta();
                List<GridReimprimirEtiqueta> SourceGrid = new List<GridReimprimirEtiqueta>();
                RowGrid.Articulo = oEtiqueta.articulos.articulo;
                RowGrid.Cantidad = oEtiqueta.cantidad;
                RowGrid.ClaveArticulo = oEtiqueta.clave_articulo;
                RowGrid.NumeroEtiqueta = sNumeroEtiqueta;
                if (oEtiqueta.tipo_etiqueta == "P")
                {
                    RowGrid.TipoEtiqueta = "Produccion";
                    oComando =
                        SegContext.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "produccion");
                }
                else if (oEtiqueta.tipo_etiqueta == "R")
                {
                    RowGrid.TipoEtiqueta = "Recepcion";
                    oComando =
                        SegContext.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "recepcion");
                }
                RowGrid.Unidad = oEtiqueta.unidad;

                SourceGrid.Add(RowGrid);

                gridEtiqueta.DataSource = SourceGrid;
                gvEtiqueta.BestFitColumns();

                btnBorrar.Enabled = true;
                txbComentario.Enabled = true;
            }
            else
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("No se encontró la etiqueta con número: " + sNumeroEtiqueta);
                sbMensaje.AppendLine("Recuerde que solo es posible eliminar etiquetas locales.");

                MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                gridEtiqueta.DataSource = null;
                txbComentario.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        private etiquetas BuscarEtiquetaLocal(string NumeroEtiqueta)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            
            etiquetas oEtiqueta = 
                SegContext
                    .etiquetas
                    .FirstOrDefault(o => o.numero_etiqueta == NumeroEtiqueta
                                      && o.estatus == "A");
            if (oEtiqueta != null)
                return oEtiqueta;
            else
                return null;
        }

        private string getNombreProveedor(int id_proveedor)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            proveedores oProveedor = segContext.proveedores.FirstOrDefault(o => o.id_proveedor == id_proveedor);
            return oProveedor.nombre;
        }

        string sComentario;
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            sComentario = txbComentario.Text.ToUpper().Trim();
            if (sComentario == string.Empty)
            {
                MessageBox.Show("Debe agregar un comentario..", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine("¿Desea eliminar la etiqueta con número '" + sNumeroEtiqueta + "'?");
            DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar", 
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                Borrar();
            }
        }

        private void Borrar()
        {
            try
            {
                if (Etiqueta.estatus == "A")
                {
                    Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
                    etiquetas oEtiqueta =
                        segContext.etiquetas.FirstOrDefault(o => o.id_etiqueta == Etiqueta.id_etiqueta);
                    oEtiqueta.estatus = "B";


                    bitacora recordBitacora = new bitacora();
                    recordBitacora.acción = "Eliminación";
                    recordBitacora.fecha_hora = Servidor.getFechaServer();
                    recordBitacora.id_usuario_creador = Config.user.id_usuario;
                    recordBitacora.numero_etiqueta = sNumeroEtiqueta;
                    recordBitacora.observaciones = sComentario;

                    segContext.bitacora.AddObject(recordBitacora);
                    segContext.SaveChanges();

                    MessageBox.Show("Se ha eliminado la etiqueta '" + sNumeroEtiqueta + "'", "OK",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solo se pueden borrar etiquetas Activas", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string sTipo = ex.GetType().ToString();
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);

                MessageBox.Show(sbMensaje.ToString(), sTipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

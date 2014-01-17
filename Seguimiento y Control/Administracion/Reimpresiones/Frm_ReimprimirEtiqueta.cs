using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Configuracion;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Administracion;
using Seguimiento_y_Control.Clases.Utilitarias;
using Sofbr.Utils.Impresoras;

namespace Seguimiento_y_Control.Administracion.Reimpresiones
{
    public partial class Frm_ReimprimirEtiqueta : Form
    {
        string sLote;
        string sProveedor;
        etiquetas Etiqueta;
        string sNumeroEtiqueta;        
        catalog_comandos_etiquetas oComando;
        
        public Frm_ReimprimirEtiqueta()
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
            if (sNumeroEtiqueta.Length < 3)
                return;
            string ID_SUCURSAL = sNumeroEtiqueta.Substring(1, 2);
            string TIPO_ETIQUETA = sNumeroEtiqueta.Substring(0, 1);
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();

            if (ID_SUCURSAL == Config.ID_SUCURSAL_CODIGO_DE_BARRAS)
            {
                //Es etiqueta Local
                if (TIPO_ETIQUETA == "1" || TIPO_ETIQUETA == "2")
                {
                    //No es Tarima
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
                            sProveedor = string.Empty;
                            sLote = oEtiqueta.id_pedido.ToString();
                        }
                        else if (oEtiqueta.tipo_etiqueta == "R")
                        {
                            RowGrid.TipoEtiqueta = "Recepcion";
                            oComando =
                                SegContext.catalog_comandos_etiquetas.FirstOrDefault(o => o.etiqueta == "recepcion");
                            sProveedor = getNombreProveedor(Convert.ToInt32(oEtiqueta.id_proveedor));
                            sLote = oEtiqueta.id_lote.ToString();
                        }
                        RowGrid.Unidad = oEtiqueta.unidad;

                        SourceGrid.Add(RowGrid);

                        gridEtiqueta.DataSource = SourceGrid;
                        gvEtiqueta.BestFitColumns();

                        btnImprimir.Enabled = true;
                        txbComentario.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la etiqueta con número: " + sNumeroEtiqueta,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gridEtiqueta.DataSource = null;
                        txbComentario.Enabled = false;
                        btnImprimir.Enabled = false;
                    }
                }
                else
                {
                    //Es Tarima
                    MessageBox.Show("No se encontró la etiqueta con número: " + sNumeroEtiqueta,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    gridEtiqueta.DataSource = null;
                    txbComentario.Enabled = false;
                    btnImprimir.Enabled = false;
                }
            }
            else
            {
                //Es Etiqueta Traspasada
            }
        }

        private etiquetas BuscarEtiquetaLocal(string NumeroEtiqueta)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            etiquetas oEtiqueta = SegContext.etiquetas.FirstOrDefault(o => o.numero_etiqueta == NumeroEtiqueta
                                                                        && o.estatus == "A");
            if (oEtiqueta != null)
                return oEtiqueta;
            else
                return null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string sComentario = txbComentario.Text.Trim().ToUpper();

            if (sComentario == string.Empty)
            {
                MessageBox.Show("Debe agregar un comentario del porqué de la impresión...", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bitacora RecordBitacora = new bitacora();
                RecordBitacora.acción = "Reimpresión";
                RecordBitacora.fecha_hora = Servidor.getFechaServer();
                RecordBitacora.id_usuario_creador = Config.user.id_usuario;
                RecordBitacora.numero_etiqueta = sNumeroEtiqueta;
                RecordBitacora.observaciones = sComentario;

                Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();

                string sComandoAImprimir = ObtenerComando(Etiqueta, oComando);
                Imprimir(sComandoAImprimir);

                segContext.bitacora.AddObject(RecordBitacora);
                segContext.SaveChanges();

                MessageBox.Show("¡La reimpresion se ha realizado con exito!",
                                "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string ObtenerComando(etiquetas oEtiqueta, catalog_comandos_etiquetas oCommand)
        {
            string Comando = oCommand.comando;
            Comando = Comando.Replace("|empaque|", oEtiqueta.fecha_empaque.ToString("dd/MM/yyyy HH:mm"));
            Comando = Comando.Replace("|caducidad|", oEtiqueta.fecha_caducidad.ToString("dd/MM/yyyy"));

            if (oEtiqueta.articulos.leyenda == true)
            {
                if (oEtiqueta.articulos.dias_caducidad < 31)
                    Comando = Comando.Replace("|leyenda|", "MANTENGASE EN REFRIGERACION");
                else
                    Comando = Comando.Replace("|leyenda|", "MANTENGASE EN CONGELACION");
            }
            else
                Comando = Comando.Replace("|leyenda|", string.Empty);
            
            Comando = Comando.Replace("|clave|",oEtiqueta.clave_articulo);
            Comando = Comando.Replace("|para|", string.Empty);
            Comando = Comando.Replace("|de|", sProveedor);
            Comando = Comando.Replace("|lote|", sLote);
            Comando = Comando.Replace("|articulo|", oEtiqueta.articulos.articulo);
            Comando = Comando.Replace("|lblCantidadPeso|", "Cantidad: ");
            Comando = Comando.Replace("|pesoneto|", oEtiqueta.cantidad.ToString("0,0.000"));
            Comando = Comando.Replace("|unidad|", oEtiqueta.unidad);
            Comando = Comando.Replace("0000000000000", oEtiqueta.numero_etiqueta);
            if (oEtiqueta.piezas != null)
                Comando = Comando.Replace("|piezas|", "Piezas: " + oEtiqueta.piezas);
            else
                Comando = Comando.Replace("|piezas|", string.Empty);

            return Comando;
        }

        private void Imprimir(string Comando)
        {
            string sImpresoraEtiquetas = Properties.Settings.Default.Impresora;
            RawPrinter.SendToPrinter("Etiqueta Produccion", Comando, sImpresoraEtiquetas);
        }

        private string getNombreProveedor(int id_proveedor)
        {
            Seguimiento_ACC_Entities segContext = new Seguimiento_ACC_Entities();
            proveedores oProveedor = segContext.proveedores.FirstOrDefault(o => o.id_proveedor == id_proveedor);
            return oProveedor.nombre;
        }
    }
}

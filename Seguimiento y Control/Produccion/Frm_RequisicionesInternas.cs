using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Produccion;
using Seguimiento_y_Control.Clases.Configuracion;
using System.Text.RegularExpressions;
using Seguimiento_y_Control.Reportes;
using Seguimiento_y_Control.Clases.Utilitarias;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_RequisicionesInternas : Form
    {
        private articulos oArticulo;
        private List<articulos> listaArticulos;
        private List<catalog_unidades> listaUnidades;
        private List<ArticuloRequerir> listaArticulosRequerir;
        private List<bodegas> listaBodegas;

        public Frm_RequisicionesInternas()
        {
            InitializeComponent();
        }

        private void Frm_RequisicionesInternas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            listaArticulos = new List<articulos>();
            listaArticulos.AddRange(Contexto.articulos.ToList());

            cbClave.DataSource = listaArticulos;
            cbClave.DisplayMember = "clave";

            cbDescripcion.DataSource = listaArticulos;
            cbDescripcion.DisplayMember = "articulo";

            listaUnidades = new List<catalog_unidades>();
            listaUnidades.AddRange(Contexto.catalog_unidades.ToList());
            cbUnidad.DataSource = listaUnidades;
            cbUnidad.DisplayMember = "unidad";

            listaArticulosRequerir = new List<ArticuloRequerir>();

            listaBodegas = Contexto.bodegas.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarArticulo() == true)
            {
                AgregarItem();                
            }
        }
        private void AgregarItem()
        {
            try
            {
                ArticuloRequerir oArticuloRequerir = new ArticuloRequerir();
                oArticuloRequerir.articulo_a_requerir = oArticulo;
                oArticuloRequerir.cantidad_a_requrir = Convert.ToDecimal(txbCantidad.Text);
                oArticuloRequerir.unidad = cbUnidad.Text;
                oArticuloRequerir.sBodega = listaBodegas.FirstOrDefault(o => o.id_bodega == oArticulo.id_bodega).bodega;

                /*************************************************************************/
                // Si el articulo ya existe, sumarlo
                ArticuloRequerir oArticuloVaidar = listaArticulosRequerir.FirstOrDefault(o => o.articulo_a_requerir.clave == oArticuloRequerir.articulo_a_requerir.clave && o.unidad == oArticuloRequerir.unidad);
                if (oArticuloVaidar != null)
                {
                    List<ArticuloRequerir> listaAuxiliar = new List<ArticuloRequerir>();
                    listaAuxiliar.AddRange(listaArticulosRequerir.FindAll(o => o.articulo_a_requerir.clave == oArticulo.clave && o.unidad == oArticuloRequerir.unidad).ToList());
                    listaAuxiliar.Add(oArticuloRequerir);
                    decimal fSuma = listaAuxiliar.Sum(o => o.cantidad_a_requrir);

                    listaArticulosRequerir.RemoveAll(o => o.articulo_a_requerir.clave == oArticulo.clave && o.unidad == oArticuloRequerir.unidad);
                    oArticuloRequerir.cantidad_a_requrir = fSuma;
                }

                /*************************************************************************/
                // Agregar el articulo a la lista
                listaArticulosRequerir.Add(oArticuloRequerir);
                gridArticulos.DataSource = listaArticulosRequerir;
                gvArticulos.BestFitColumns();

                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;

                txbCantidad.Text = string.Empty;
                cbDescripcion.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarArticulo()
        {
            try
            {
                Regex ExpresionRegular = new Regex(@"^[0-9][0-9]*(\.[0-9][0-9]*)*$");

                if (ExpresionRegular.IsMatch(txbCantidad.Text))
                {
                    float cantidad = float.Parse(txbCantidad.Text);

                    if (cantidad > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    MessageBox.Show("La cantidad es incorrecta...", "",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvArticulos.RowCount == 1)
            {
                EliminarItem();
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                EliminarItem();
            }
        }
        private void EliminarItem()
        {
            try
            {
                ArticuloRequerir oArticuloRequerir = new ArticuloRequerir();
                int index = gvArticulos.GetSelectedRows().First();
                oArticuloRequerir = (ArticuloRequerir)gvArticulos.GetRow(index);
                listaArticulosRequerir.Remove(oArticuloRequerir);

                gridArticulos.DataSource = listaArticulosRequerir;
                gvArticulos.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            oArticulo = (articulos)cbClave.SelectedItem;
        }        
        private void cbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            oArticulo = (articulos)cbDescripcion.SelectedItem;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (gvArticulos.RowCount > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Hay articulos en la lista...");
                sb.Append("¿Realmente desea salir?");
                DialogResult dr = MessageBox.Show(sb.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.Equals('.', e.KeyChar))
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
                    if (ValidarArticulo() == true)
                    {
                        AgregarItem();                        
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (txbExpiracion.Text != string.Empty)
            {
                sb.AppendLine("Dias de vigencia del pedido: " + txbExpiracion.Text);
            }
            else
            {
                sb.AppendLine("Dias de vigencia del pedido: INDEFINIDO");
            }
            sb.AppendLine();
            sb.Append("¿Los datos son correctos?");
            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar Datos", 
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Guardar();
            }
        }
        private void txbExpiracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Guardar()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            IDbTransaction Transaccion = null;
            try
            {
                ReporteMovimientosMercancia RowReporte;
                List<ReporteMovimientosMercancia> oReporte = new List<ReporteMovimientosMercancia>();

                Contexto.Connection.Open();
                Transaccion = Contexto.Connection.BeginTransaction();

                configuracion oConfiguracion = Contexto.configuracion.FirstOrDefault(o=>o.config=="sucursal");

                pedidos_internos nuevoPedido = crearPedido();
                Contexto.pedidos_internos.AddObject(nuevoPedido);
                Contexto.SaveChanges();
                nuevoPedido.codigo_pedido = oConfiguracion.valor + "-P-" + nuevoPedido.id_pedido.ToString().PadLeft(7, '0');
                Contexto.SaveChanges();

                List<pedidos_internos_det> listaDetalles = crearDetalles(nuevoPedido.id_pedido);

                foreach (pedidos_internos_det oDetalle in listaDetalles)
                {
                    Contexto.pedidos_internos_det.AddObject(oDetalle);
                    Contexto.SaveChanges();

                    RowReporte = new ReporteMovimientosMercancia();
                    RowReporte.id_pedido = nuevoPedido.id_pedido;
                    RowReporte.codigo_pedido = nuevoPedido.codigo_pedido;
                    RowReporte.fecha_pedido = nuevoPedido.fecha;
                    RowReporte.nombre_usuario = Config.user.nombre;
                    RowReporte.bodega = getBodega(oDetalle.id_bodega);
                    RowReporte.clave_articulo = oDetalle.clave_articulo;
                    RowReporte.descripcion_articulo = getNombreArticuloRequerir(oDetalle.clave_articulo);
                    RowReporte.cantidad = oDetalle.cantidad;
                    RowReporte.unidad = oDetalle.unidad;
                    oReporte.Add(RowReporte);
                }                

                Transaccion.Commit();
                Contexto.Connection.Close();  

                MessageBox.Show("El pedido se ha guardado correctamente!!" + Environment.NewLine +
                                "Numero de pedido: " + nuevoPedido.id_pedido, "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                Imprimir(oReporte);
                LimpiarControles();                                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Transaccion.Rollback();
                Contexto.Connection.Close();
            }
        }
        private pedidos_internos crearPedido()
        {
            pedidos_internos nuevoPedido = new pedidos_internos();

            nuevoPedido.fecha = DateTime.Now;
            nuevoPedido.id_usuario = Config.user.id_usuario;
            nuevoPedido.tipo_pedido = "I";
            nuevoPedido.estatus = "D";

            if (txbExpiracion.Text.Trim() != string.Empty)
                nuevoPedido.dias_de_expiracion = Convert.ToInt32(txbExpiracion.Text.Trim());
            else
                nuevoPedido.dias_de_expiracion = null;

            return nuevoPedido;
        }
        private List<pedidos_internos_det> crearDetalles(int id_pedido)
        {
            List<pedidos_internos_det> listaDetalles = new List<pedidos_internos_det>();

            pedidos_internos_det oDetalle;
            foreach (ArticuloRequerir oArticulo in listaArticulosRequerir)
            {
                oDetalle = new pedidos_internos_det();
                oDetalle.id_pedido = id_pedido;
                oDetalle.clave_articulo = oArticulo.articulo_a_requerir.clave;
                oDetalle.id_bodega = oArticulo.articulo_a_requerir.id_bodega;
                oDetalle.cantidad = oArticulo.cantidad_a_requrir;
                oDetalle.unidad = oArticulo.unidad;                
                listaDetalles.Add(oDetalle);
            }

            return listaDetalles;
        }
        private void Imprimir(List<ReporteMovimientosMercancia> oRepor)
        {
            ImagenReportes ImagenReporte = new ImagenReportes();
            ImagenReporte.ImgReporte = new Bitmap(Application.StartupPath + "\\LogoReportes.jpg");
            xrpMovimientosMercancia oReporteMovimientos = new xrpMovimientosMercancia();

            oReporteMovimientos.DataSource = oRepor;
            oReporteMovimientos.ImagenReporte.Add(ImagenReporte);

            //************************* Respaldo *********************************************
            string BackUp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RequisicionesInternas";
            if (System.IO.Directory.Exists(BackUp) == false)
                System.IO.Directory.CreateDirectory(BackUp);

            oReporteMovimientos.ExportToPdf(BackUp + "\\" + oRepor[0].codigo_pedido + ".pdf");
            //*********************************************************************************

            oReporteMovimientos.ShowPreview();
        }
        private string getNombreArticuloRequerir(string clave)
        {
            ArticuloRequerir oArticuloRequerir;
            oArticuloRequerir = listaArticulosRequerir.FirstOrDefault(o => o.articulo_a_requerir.clave == clave);
            return oArticuloRequerir.articulo_a_requerir.articulo;
        }
        private string getBodega(int id_bodega)
        {
            string sBodega;
            sBodega = listaBodegas.FirstOrDefault(o => o.id_bodega == id_bodega).bodega;
            return sBodega;
        }
        private void LimpiarControles()
        {
            cbClave.Text = string.Empty;
            cbDescripcion.Text = string.Empty;
            txbCantidad.Text = string.Empty;
            txbExpiracion.Text = string.Empty;

            listaArticulosRequerir = new List<ArticuloRequerir>();
            gridArticulos.DataSource = listaArticulosRequerir;
            btnGuardar.Enabled = false;
        }
    }
}

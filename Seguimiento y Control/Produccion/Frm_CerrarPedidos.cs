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

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_CerrarPedidos : Form
    {
        private pedidos_internos oPedido;

        public Frm_CerrarPedidos()
        {
            InitializeComponent();
        }

        private void Frm_CerrarPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            lstbPedidos.DataSource = 
                SegContext.pedidos_internos.Where(o => o.estatus == "A").ToList();
        }

        private void lstbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            oPedido = (pedidos_internos)lstbPedidos.SelectedItem;
            lblFecha.Text = "Fecha de creación: " + oPedido.fecha.ToString("ddd dd/MMM/yyyy").ToUpper();
            CargarDetallesPedido();
        }

        private void CargarDetallesPedido()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<pedidos_internos_det> lstDetallesPedido = new List<pedidos_internos_det>();
            lstDetallesPedido =
                SegContext.pedidos_internos_det.Where(o => o.id_pedido == oPedido.id_pedido).ToList();

            List<ArticuloRequerir> SourceGrid = new List<ArticuloRequerir>();
            foreach (pedidos_internos_det Detalle in lstDetallesPedido)
            {
                ArticuloRequerir Renglon = new ArticuloRequerir();
                Renglon.articulo_a_requerir = getArticulo(Detalle.clave_articulo);
                Renglon.cantidad_a_requrir = Detalle.cantidad;
                Renglon.unidad = Detalle.unidad;
                SourceGrid.Add(Renglon);
            }

            gridPedidos.DataSource = SourceGrid;
            gvPedidos.BestFitColumns();
        }

        private articulos getArticulo(string clave)
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            articulos oArticulo = SegContext.articulos.SingleOrDefault(o => o.clave == clave);
            return oArticulo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine("El pedido: " + oPedido.codigo_pedido + " se cerrará");
            sbMensaje.AppendLine();
            sbMensaje.AppendLine("¿Esta seguro de realizar esta acción?");
            DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar", 
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
                SegContext.pedidos_internos.SingleOrDefault(o => o.id_pedido == oPedido.id_pedido).estatus = "C";
                SegContext.SaveChanges();

                MessageBox.Show("¡El pedido se ha cerrado con exito!", "OK", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPedidos();
            }
        }
    }
}

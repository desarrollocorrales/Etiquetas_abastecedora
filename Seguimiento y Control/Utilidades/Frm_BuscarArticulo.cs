using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Utilidades
{
    public partial class Frm_BuscarArticulo : Form
    {
        public articulos Articulo;
        private Seguimiento_ACC_Entities Contexto;

        public Frm_BuscarArticulo()
        {
            InitializeComponent();
            Contexto = new Seguimiento_ACC_Entities();
        }

        private void Frm_BuscarArticulo_Load(object sender, EventArgs e)
        {
            InicializarGrid();            
        }

        private void InicializarGrid()
        {
            gridArticulos.DataSource = Contexto.articulos;
            gvArticulos.BestFitColumns();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            gridArticulos.DataSource = 
                Contexto.articulos.Where(o => o.articulo.Contains(txbBuscar.Text) 
                                           || o.clave.Contains(txbBuscar.Text));
            gvArticulos.BestFitColumns();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo = ObtenerArticulo();
            this.Close();
        }

        private articulos ObtenerArticulo()
        {
            int iSelectedIndex = gvArticulos.GetSelectedRows()[0];
            articulos oArticulo = gvArticulos.GetRow(iSelectedIndex) as articulos;
            return oArticulo;
        }
    }
}

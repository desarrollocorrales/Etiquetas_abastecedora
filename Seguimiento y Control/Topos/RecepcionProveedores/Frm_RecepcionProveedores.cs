using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    public partial class Frm_RecepcionProveedores : Form
    {        
        private articulos oArticulo;
        private proveedores oProveedor;
        private StringBuilder sbValidar;
        private Seguimiento_ACC_Entities Contexto;
        
        private List<etiquetas> listaEtiquetasCantidadFija;
        private List<etiquetas> listaEtiquetasPesoFijo;
        private List<etiquetas> listaEtiquetasPesoVariado;

        private int iEtiquetasCantidadFija;
        private int iEtiquetasPesoVariado;
        private List<PesoFijo> listaPesosFijos;

        public Frm_RecepcionProveedores()
        {
            InitializeComponent();
            this.Contexto = new Seguimiento_ACC_Entities();
            listaPesosFijos = new List<PesoFijo>();
            listaEtiquetasCantidadFija = new List<etiquetas>();
            listaEtiquetasPesoFijo = new List<etiquetas>();
            listaEtiquetasPesoVariado = new List<etiquetas>();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GenerarEtiquetas();

                Frm_PrevioImprimir frmPrevioImprimir = new Frm_PrevioImprimir(oArticulo, oProveedor);
                frmPrevioImprimir.listaEtiquetasCantidadFija = this.listaEtiquetasCantidadFija;
                frmPrevioImprimir.listaEtiquetasPesoFijo = this.listaEtiquetasPesoFijo;
                frmPrevioImprimir.listaEtiquetasPesoVariado = this.listaEtiquetasPesoVariado;
                frmPrevioImprimir.ShowDialog();

                /********************* Limpiar listas ********************/
                this.listaEtiquetasCantidadFija = new List<etiquetas>();
                this.listaEtiquetasPesoFijo = new List<etiquetas>();
                this.listaEtiquetasPesoVariado = new List<etiquetas>();
                this.listaPesosFijos = new List<PesoFijo>();
                /*********************************************************/
            }
        }

        private void Frm_RecepcionProveedores_Load(object sender, EventArgs e)
        {
            CargarCombosBox();            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombosBox()
        {
            cbArticulos.DataSource = Contexto.articulos;
            cbArticulos.DisplayMember = "articulo";

            cbProveedores.DataSource = Contexto.proveedores;
            cbProveedores.DisplayMember = "nombre";

            cbBodegas.DataSource = Contexto.bodegas;
            cbBodegas.DisplayMember = "bodega";
        }

        private void cbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LLenarCampos();
        }

        private void LLenarCampos()
        {
            oArticulo = (articulos)cbArticulos.SelectedItem;

            /************************ Activar Controles ************************/
            lblClave.Text = oArticulo.clave;
            lblClave.Visible = true;
            cbProveedores.Enabled = true;
            cbBodegas.Enabled = true;
            txbEtiquetasPesoVariado.Enabled = oArticulo.peso_variado;
            if (oArticulo.cantidad_fija != null)
                txbEtiquetasCantidadFija.Enabled = true;
            else
                txbEtiquetasCantidadFija.Enabled = false;
            /*******************************************************************/

            SeleccionarBodega();
            ObtenerPesosFijos();

            txbEtiquetasPesoVariado.Text = "0";
            iEtiquetasPesoVariado = 0;
            txbEtiquetasCantidadFija.Text = "0";
            iEtiquetasCantidadFija = 0;

            if (oProveedor != null)
            {
                btnImprimir.Enabled = true;
            }

            listaEtiquetasCantidadFija = new List<etiquetas>();
            listaEtiquetasPesoFijo = new List<etiquetas>();
            listaEtiquetasPesoVariado = new List<etiquetas>();
        }

        private List<PesoFijo> ObtenerPesosFijos()
        {
            List<PesoFijo> lstPesosFijos = new List<PesoFijo>();
            
            try
            {
                List<pesos_fijos> PesosFijos = Contexto.pesos_fijos.Where(o => o.clave_articulo == oArticulo.clave).ToList();

                if (PesosFijos.Count != 0)
                {
                    PesoFijo oPesoFijo;
                    foreach (pesos_fijos peso_fijo in PesosFijos)
                    {
                        oPesoFijo = new PesoFijo();
                        oPesoFijo.Seleccion = true;
                        oPesoFijo.Peso = peso_fijo.cantidad;
                        oPesoFijo.Etiquetas = 0;
                        lstPesosFijos.Add(oPesoFijo);
                    }

                    gridPesosFijos.DataSource = lstPesosFijos;
                    gvPesosFijos.BestFitColumns();
                    gridPesosFijos.Enabled = true;
                }
                else
                {
                    gridPesosFijos.DataSource = null;
                    gridPesosFijos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error en pesos fijos",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lstPesosFijos;
        }

        private void SeleccionarBodega()
        {
            List<bodegas> lstBodegas = Contexto.bodegas.ToList();
            bodegas oBodega = lstBodegas.Find(o => o.id_bodega == oArticulo.id_bodega);
            cbBodegas.SelectedItem = oBodega;
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            oProveedor = (proveedores)cbProveedores.SelectedItem;

            if (oArticulo != null)
            {
                btnImprimir.Enabled = true;
            }
        }

        private bool Validar()
        {
            bool bExito = true;
            sbValidar = new StringBuilder();

            if (ValidarArticulo() == false) bExito = false;
            if (ValidarProveedor() == false) bExito = false;
            if (ValidarPesoVariado() == false) bExito = false;
            if (ValidarCantidadFija() == false) bExito = false;
            if (ValidarPesosFijos() == false) bExito = false;
            if (ValidarCantidadDeEtiquetas() == false) bExito = false;

            if (bExito == false)
            {
                MessageBox.Show(sbValidar.ToString(), "Recepción de Proveedores",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bExito;
        }

        private void cbArticulos_TextChanged(object sender, EventArgs e)
        {
            oArticulo = null;
            btnImprimir.Enabled = false;
            lblClave.Visible = false;
        }

        private void cbProveedores_TextChanged(object sender, EventArgs e)
        {
            oProveedor = null;
            btnImprimir.Enabled = false;
        }

        private bool ValidarArticulo()
        {
            if (oArticulo == null)
            {
                sbValidar.AppendLine("Por favor seleccione un articulo valido.");
                return false;
            }

            return true;
        }

        private bool ValidarProveedor()
        {
            if (oProveedor == null)
            {
                sbValidar.AppendLine("Por favor seleccione un proveedor valido.");
                return false;
            }
            return true;
        }

        private bool ValidarPesoVariado()
        {
            if (txbEtiquetasPesoVariado.Enabled == true)
            {
                try
                {
                    iEtiquetasPesoVariado = Convert.ToInt32(txbEtiquetasPesoVariado.Text);
                }
                catch
                {
                    sbValidar.AppendLine("Valor de etiquetas de peso variado incorrecta.");
                    return false;
                }
            }

            return true;
        }

        private bool ValidarCantidadFija()
        {
            if (txbEtiquetasCantidadFija.Enabled == true)
            {
                try
                {
                    iEtiquetasCantidadFija = Convert.ToInt32(txbEtiquetasCantidadFija.Text);
                }
                catch
                {
                    sbValidar.AppendLine("Valor de etiquetas de cantidad fija incorrecta.");
                    return false;
                }
            }
            return true;
        }

        private bool ValidarPesosFijos()
        {
            if (gridPesosFijos.Enabled == true)
            {
                List<PesoFijo> lstPesosFijos = (List<PesoFijo>)gridPesosFijos.DataSource;
                int iSeleccionados = lstPesosFijos.FindAll(o=>o.Seleccion==true).Count;
                if (iSeleccionados == 0)
                {
                    sbValidar.AppendLine("Seleccione al menos un peso fijo");
                    return false;
                }
                else
                {
                    listaPesosFijos = new List<PesoFijo>();
                    listaPesosFijos.AddRange(lstPesosFijos.FindAll(o => o.Seleccion == true));
                }
            }
            return true;
        }

        private void GenerarEtiquetas()
        {
            try
            {
                /****************** Generacion de Etiquetas ******************/
                GenerarEtiquetasPesoFijo();
                GenerarEtiquetasCantidadFija();
                GenerarEtiquetasPesoVariado();
                /*************************************************************/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, string.Empty,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCantidadDeEtiquetas()
        {
            int iSumaPesosFijos = 0;
            if (listaPesosFijos.Count != 0)
                iSumaPesosFijos = listaPesosFijos.Sum(o => o.Etiquetas);

            int CantidadDeEtiquetas = iEtiquetasPesoVariado + iEtiquetasCantidadFija + iSumaPesosFijos;
            if (CantidadDeEtiquetas <= 0)
            {
                sbValidar.AppendLine("Error en la cantidad de etiquetas a imprimir");
                return false;
            }

            return true;
        }

        private void GenerarEtiquetasPesoVariado()
        {
            for (int i = 0; i < iEtiquetasPesoVariado; i++)
            {
                etiquetas oEtiqueta = new etiquetas();
                oEtiqueta.tipo_etiqueta = "R";
                oEtiqueta.clave_articulo = oArticulo.clave;
                oEtiqueta.id_bodega = ((bodegas)cbBodegas.SelectedItem).id_bodega;
                oEtiqueta.unidad = oArticulo.unidad;

                listaEtiquetasPesoVariado.Add(oEtiqueta);
            }
        }

        private void GenerarEtiquetasCantidadFija()
        {
            for (int i = 0; i < iEtiquetasCantidadFija; i++)
            {
                etiquetas oEtiqueta = new etiquetas();
                oEtiqueta.tipo_etiqueta = "R";
                oEtiqueta.clave_articulo = oArticulo.clave;
                oEtiqueta.id_bodega = ((bodegas)cbBodegas.SelectedItem).id_bodega;
                oEtiqueta.cantidad = Convert.ToInt32(oArticulo.cantidad_fija);
                oEtiqueta.unidad = oArticulo.unidad;

                listaEtiquetasCantidadFija.Add(oEtiqueta);
            }
        }

        private void GenerarEtiquetasPesoFijo()
        {
            int iEtiquetasPesofijo = listaPesosFijos.Sum(o => o.Etiquetas);
            foreach (PesoFijo oPesoFijo in listaPesosFijos)
            {
                int iEtiquetas = oPesoFijo.Etiquetas;
                for (int i = 0; i < iEtiquetas; i++)
                {
                    etiquetas oEtiqueta = new etiquetas();
                    oEtiqueta.tipo_etiqueta = "R";
                    oEtiqueta.clave_articulo = oArticulo.clave;
                    oEtiqueta.cantidad = oPesoFijo.Peso;
                    oEtiqueta.id_bodega = ((bodegas)cbBodegas.SelectedItem).id_bodega;
                    oEtiqueta.unidad = oArticulo.unidad;

                    listaEtiquetasPesoFijo.Add(oEtiqueta);
                }
            }
        }

        private string getNumeroDeEtiqueta(int id_etiqueta)
        {
            string numEtiqueta = string.Empty;
            return numEtiqueta;
        }

        private void txbEtiquetasPesoVariado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbEtiquetasCantidadFija_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

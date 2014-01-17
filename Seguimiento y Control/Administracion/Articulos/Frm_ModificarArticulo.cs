using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Administracion;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Entity.Internet;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control.Administracion.Articulos
{
    public partial class Frm_ModificarArticulo : Form
    {
        private bool bModificoPesosFijos;
        private ArticuloMicrosip oArticuloMicrosip;
        private Entity.articulos oArticuloSeguimiento;

        public Frm_ModificarArticulo(ArticuloMicrosip pArticuloMicrosip)
        {
            InitializeComponent();
            this.oArticuloMicrosip = pArticuloMicrosip;
            this.oArticuloSeguimiento = obtenerArticuloSeguimiento(oArticuloMicrosip.Clave);
        }

        private void Frm_ModificarArticulo_Load(object sender, EventArgs e)
        {
            rbtnContenedorSi.Checked = false;
            CargarUnidades();
            CargarCamaras();
            CargarDatosArticulos();
            bModificoPesosFijos = false;
        }

        private void rbtnContenedorSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnContenedorSi.Checked == true)
            {
                //**** Mostrar Controles
                MostrarOcultarControles(true);
            }
            else
            {
                //**** Ocultar Controles
                MostrarOcultarControles(false);
            }
        }

        private void MostrarOcultarControles(bool opcion)
        {
            lblMedida.Visible = opcion;
            lblPiezasContenedor.Visible = opcion;
            PanelMedida.Visible = opcion;
            numUpDownPiezasContenedor.Visible = opcion;
            chbxEtiquetaContenedor.Visible = opcion;
        }

        private void chbxPiezas_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnPiezas.Enabled = chbxPiezas.Checked;
        }

        private void chbxCantidadFija_CheckedChanged(object sender, EventArgs e)
        {
            txbCantidadFija.Enabled = chbxCantidadFija.Checked;
        }

        private void chbxPesoFijo_CheckedChanged(object sender, EventArgs e)
        {
            txbPesoFijo.Enabled = chbxPesoFijo.Checked;
            btnAgregar.Enabled = chbxPesoFijo.Checked;
            btnEliminar.Enabled = chbxPesoFijo.Checked;
            lstbPesosFijos.Enabled = chbxPesoFijo.Checked;
        }

        private void CargarUnidades()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<catalog_unidades> lstUnidades = SeguimientoContexto.catalog_unidades.ToList();

            cbUnidad.DataSource = lstUnidades;
            cbUnidad.DisplayMember = "unidad";
            cbUnidad.ValueMember = "unidad";
        }

        private void CargarCamaras()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<bodegas> lstBodegas = SeguimientoContexto.bodegas.ToList();

            cbCamara.DataSource = lstBodegas;
            cbCamara.DisplayMember = "bodega";
            cbCamara.ValueMember = "id_bodega";
        }

        private void CargarDatosArticulos()
        {
            txbClave.Text = oArticuloMicrosip.Clave;
            txbNombre.Text = oArticuloMicrosip.Nombre;

            if (oArticuloSeguimiento != null)
            {
                //***** Llenar Controles
                cbUnidad.SelectedValue = oArticuloSeguimiento.unidad;
                txbCaducidad.Text = oArticuloSeguimiento.dias_caducidad.ToString();
                chbxLeyenda.Checked = oArticuloSeguimiento.leyenda;
                cbCamara.SelectedValue = oArticuloSeguimiento.id_bodega;

                if (oArticuloSeguimiento.piezas != null)
                {
                    chbxPiezas.Checked = true;
                    numUpDnPiezas.Value = Convert.ToDecimal(oArticuloSeguimiento.piezas);
                }

                if (oArticuloSeguimiento.cantidad_fija != null)
                {
                    chbxCantidadFija.Checked = true;
                    txbCantidadFija.Text = oArticuloSeguimiento.cantidad_fija.ToString();
                }
    
                chbxPesoVariado.Checked = oArticuloSeguimiento.peso_variado;

                List<pesos_fijos> lstPesosFijos = obtenerPesosFijos(oArticuloSeguimiento.clave);
                foreach(pesos_fijos peso in lstPesosFijos)
                {
                    lstbPesosFijos.Items.Add(peso.cantidad);
                }
                if (lstbPesosFijos.Items.Count != 0)
                {
                    chbxPesoFijo.Checked = true;
                }

                contenedores oContenedor = obtenerContenedor(oArticuloSeguimiento.clave);
                if (oContenedor != null)
                {
                    rbtnContenedorSi.Checked = true;
                    numUpDownPiezasContenedor.Value = oContenedor.cantidad;
                    chbxEtiquetaContenedor.Checked = oContenedor.impresion_paquete;
                    switch (oContenedor.tipo)
                    {
                        case 1:
                            rbtnGranel.Checked = true;
                            break;
                        case 2:
                            rbtnPiezas.Checked = true;
                            break;
                    }
                }
                else
                {
                    rbtnContenedorNo.Checked = true;
                }
            }
            else
            {
                rbtnContenedorNo.Checked = true;
            }
        }

        private Entity.articulos obtenerArticuloSeguimiento(string clave)
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            Entity.articulos oArticuloSeguimiento = SeguimientoContexto.articulos.FirstOrDefault(o => o.clave == clave);
            return oArticuloSeguimiento;
        }

        private List<pesos_fijos> obtenerPesosFijos(string clave)
        {
            List<pesos_fijos> lstPesosFijosRespuesta = null;
            
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            
            List<pesos_fijos> lstPesosFijos = SeguimientoContexto.pesos_fijos.ToList();
            lstPesosFijos = lstPesosFijos.FindAll(o => o.clave_articulo == clave);
            if (lstPesosFijos != null)
            {
                lstPesosFijosRespuesta = lstPesosFijos;
            }

            return lstPesosFijosRespuesta;
        }

        private contenedores obtenerContenedor(string clave)
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            contenedores oContenedor = SeguimientoContexto.contenedores.FirstOrDefault(o => o.clave_articulo == clave);

            return oContenedor;
        }

        private void txbCaducidad_TextChanged(object sender, EventArgs e)
        {
            if (txbCaducidad.Text != string.Empty)
            {
                int iDiasCaducidad = Convert.ToInt32(txbCaducidad.Text);
                if (iDiasCaducidad > 30)
                    chbxLeyenda.Text = "Mantengase en Congelación";
                else
                    chbxLeyenda.Text = "Mantengase en Refrigeración";
            }
        }

        private void txbCaducidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbCantidadFija_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbPesoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                if (txbPesoFijo.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbPiezasContenedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPesoFijo();
        }
        private void AgregarPesoFijo()
        {
            if (txbPesoFijo.Text != string.Empty && txbPesoFijo.Text != ".")
            {
                float dPesofijo = float.Parse(txbPesoFijo.Text);

                if (lstbPesosFijos.Items.Contains(dPesofijo) == false)
                {
                    lstbPesosFijos.Items.Add(dPesofijo);
                    btnEliminar.Enabled = true;
                    bModificoPesosFijos = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPesoFijo();
        }
        private void EliminarPesoFijo()
        {
            try
            {
                object dPesofijo = lstbPesosFijos.SelectedItem;
                lstbPesosFijos.Items.Remove(dPesofijo);

                if (lstbPesosFijos.Items.Count == 0)
                {
                    btnEliminar.Enabled = false;
                }
                bModificoPesosFijos = true;
            }
            catch
            {

            }
        }

        private void lstbPesosFijos_EnabledChanged(object sender, EventArgs e)
        {
            if (lstbPesosFijos.Items.Count == 0)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.oArticuloSeguimiento == null)
            {
                InsertarDatos();                
            }
            else
            {
                ActualizarDatos();                
            }
        }

        private void InsertarDatos()
        {
            if (ValidarDatos() == true)
            {
                Entity.articulos NuevoArticulo = new Entity.articulos();

                NuevoArticulo.clave = oArticuloMicrosip.Clave;
                NuevoArticulo.articulo = oArticuloMicrosip.Nombre;
                NuevoArticulo.dias_caducidad = Convert.ToInt32(txbCaducidad.Text);
                NuevoArticulo.id_bodega = Convert.ToInt32(cbCamara.SelectedValue);
                NuevoArticulo.peso_variado = chbxPesoVariado.Checked;
                NuevoArticulo.leyenda = chbxLeyenda.Checked;
                
                NuevoArticulo.unidad = Convert.ToString(cbUnidad.SelectedValue);

                if (chbxCantidadFija.Checked == true)
                {
                    NuevoArticulo.cantidad_fija = Convert.ToInt32(txbCantidadFija.Text);
                }

                if (chbxPiezas.Checked == true)
                {
                    NuevoArticulo.piezas = Convert.ToInt32(numUpDnPiezas.Value);
                }

                List<pesos_fijos> lstPesosFijos = new List<pesos_fijos>();
                if (chbxPesoFijo.Checked == true)
                {
                    pesos_fijos oPesoFijo;
                    foreach (object Peso in lstbPesosFijos.Items)
                    {
                        oPesoFijo = new pesos_fijos();
                        oPesoFijo.clave_articulo = oArticuloMicrosip.Clave;
                        oPesoFijo.cantidad = Convert.ToDecimal(Peso.ToString());
                        lstPesosFijos.Add(oPesoFijo);
                    }
                }

                Entity.Internet.articulos NuevoArticuloPortal = new Entity.Internet.articulos();
                NuevoArticuloPortal.clave = oArticuloMicrosip.Clave;
                NuevoArticuloPortal.nombre = oArticuloMicrosip.Nombre;
                NuevoArticuloPortal.id_linea = 0;
                NuevoArticuloPortal.id_area = Convert.ToInt32(Config.user.id_area);
                NuevoArticuloPortal.id_camara = Convert.ToInt32(cbCamara.SelectedValue);

                Logisn_Entities LogisContexto = new Logisn_Entities();
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();

                LogisContexto.Connection.Open();
                SeguimientoContexto.Connection.Open();
                IDbTransaction TransaccionInternet = LogisContexto.Connection.BeginTransaction();
                IDbTransaction TransaccionLocal = SeguimientoContexto.Connection.BeginTransaction();

                try
                {
                    //******* Actualizar bases de datos ************************************************************
                    //******* Agregar el articulo al portal
                    LogisContexto.articulos.AddObject(NuevoArticuloPortal);

                    //******* Agregar Articulo a la base de datos de Seguimiento
                    SeguimientoContexto.articulos.AddObject(NuevoArticulo);

                    //******* Agregar Pesos Fijos a la base de datos de Seguimiento
                    foreach (pesos_fijos oPesoFijo in lstPesosFijos)
                    {
                        SeguimientoContexto.pesos_fijos.AddObject(oPesoFijo);
                    }

                    LogisContexto.SaveChanges();
                    SeguimientoContexto.SaveChanges();

                    TransaccionInternet.Commit();
                    TransaccionLocal.Commit();

                    MessageBox.Show("El articulo fue guardado con exito!!!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string sMensaje = ex.Message + Environment.NewLine + Environment.NewLine;

                    if (ex.InnerException != null)
                    {
                        sMensaje += ex.InnerException.Message;
                    }

                    MessageBox.Show(sMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TransaccionInternet.Rollback();
                    TransaccionLocal.Rollback();
                }
                finally
                {
                    if (LogisContexto.Connection.State != ConnectionState.Closed)
                    {
                        LogisContexto.Connection.Close();
                    }
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                    {
                        SeguimientoContexto.Connection.Close();
                    }
                    //***************************************************************************************************
                }                
            }
        }

        private void ActualizarDatos()
        {
            if (ValidarDatos() == true)
            {
                Logisn_Entities LogisContexto = new Logisn_Entities();
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                //Seguimiento_ACC_Entities SegContextoPesoFijo = new Seguimiento_ACC_Entities();

                LogisContexto.Connection.Open();
                SeguimientoContexto.Connection.Open();
                //SegContextoPesoFijo.Connection.Open();
                IDbTransaction TransaccionInternet = LogisContexto.Connection.BeginTransaction();
                IDbTransaction TransaccionLocal = SeguimientoContexto.Connection.BeginTransaction();
                //IDbTransaction TransaccionPesosFijos = SegContextoPesoFijo.Connection.BeginTransaction();
                try
                {
                    //***** Obtener el articulo en la base de datos local y actualizarlo
                    Entity.articulos ArticuloSeguimiento =
                        SeguimientoContexto.articulos.FirstOrDefault(o => o.clave == oArticuloMicrosip.Clave);

                    ArticuloSeguimiento.articulo = oArticuloMicrosip.Nombre;
                    ArticuloSeguimiento.dias_caducidad = Convert.ToInt32(txbCaducidad.Text);
                    ArticuloSeguimiento.id_bodega = Convert.ToInt32(cbCamara.SelectedValue);
                    ArticuloSeguimiento.peso_variado = chbxPesoVariado.Checked;
                    ArticuloSeguimiento.leyenda = chbxLeyenda.Checked;

                    ArticuloSeguimiento.unidad = Convert.ToString(cbUnidad.SelectedValue);

                    if (chbxCantidadFija.Checked == true)
                    {
                        ArticuloSeguimiento.cantidad_fija = Convert.ToInt32(txbCantidadFija.Text);
                    }
                    else 
                    {
                        ArticuloSeguimiento.cantidad_fija = null;
                    }

                    if (chbxPiezas.Checked == true)
                    {
                        ArticuloSeguimiento.piezas = Convert.ToInt32(numUpDnPiezas.Value);
                    }
                    else 
                    {
                        ArticuloSeguimiento.piezas = null;
                    }

                    if (bModificoPesosFijos == true)
                    {
                        //***** Obtener Pesos fijos
                        List<pesos_fijos> lstPesosFijos = new List<pesos_fijos>();
                        if (chbxPesoFijo.Checked == true)
                        {
                            pesos_fijos oPesoFijo;
                            foreach (object Peso in lstbPesosFijos.Items)
                            {
                                oPesoFijo = new pesos_fijos();
                                oPesoFijo.clave_articulo = oArticuloMicrosip.Clave;
                                oPesoFijo.cantidad = Convert.ToDecimal(Peso.ToString());
                                lstPesosFijos.Add(oPesoFijo);
                            }
                        }

                        //*** Borrar Pesos Fijos
                        List<pesos_fijos> lstBorrar =
                            SeguimientoContexto.pesos_fijos.Where(o => o.clave_articulo == oArticuloMicrosip.Clave).ToList();
                        foreach (pesos_fijos oPesoFijo in lstBorrar)
                        {
                            SeguimientoContexto.pesos_fijos.DeleteObject(oPesoFijo);
                        }
                        SeguimientoContexto.SaveChanges();

                        //******* Agregar Pesos Fijos a la base de datos de Seguimiento       
                        foreach (pesos_fijos oPesoFijo in lstPesosFijos)
                        {
                            SeguimientoContexto.pesos_fijos.AddObject(oPesoFijo);
                        }
                        SeguimientoContexto.SaveChanges();
                    }

                    //***** Contenedores
                    if (rbtnContenedorSi.Checked == true)
                    {
                        contenedores contenedor =
                            SeguimientoContexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticuloMicrosip.Clave);
                        
                        if (contenedor != null)
                        {
                            //***** Borrar Contenedores
                            SeguimientoContexto.contenedores.DeleteObject(contenedor);
                            SeguimientoContexto.SaveChanges();
                        }

                        //***** Agregar Nuevo Conenedor
                        contenedores NuevoContenedor = new contenedores();
                        NuevoContenedor.clave_articulo = oArticuloMicrosip.Clave;
                        NuevoContenedor.cantidad = Convert.ToInt32(numUpDownPiezasContenedor.Value);
                        if (rbtnPiezas.Checked == true)
                            NuevoContenedor.tipo = 2;
                        if (rbtnGranel.Checked == true)
                            NuevoContenedor.tipo = 1;
                        NuevoContenedor.impresion_paquete = chbxEtiquetaContenedor.Checked;

                        SeguimientoContexto.contenedores.AddObject(NuevoContenedor);
                        SeguimientoContexto.SaveChanges();
                    }
                    else
                    {
                        contenedores contenedor =
                            SeguimientoContexto.contenedores.FirstOrDefault(o => o.clave_articulo == oArticuloMicrosip.Clave);
                        
                        if (contenedor != null)
                        {
                            //***** Borrar Contenedores
                            SeguimientoContexto.contenedores.DeleteObject(contenedor);
                            SeguimientoContexto.SaveChanges();
                        }
                    }

                    //******* Actualizar Articulo del Portal
                    Entity.Internet.articulos ArticuloPortal =
                        LogisContexto.articulos.FirstOrDefault(o => o.clave == oArticuloMicrosip.Clave);
                    ArticuloPortal.nombre = oArticuloMicrosip.Nombre;
                    ArticuloPortal.id_area = Convert.ToInt32(Config.user.id_area);
                    ArticuloPortal.id_camara = Convert.ToInt32(cbCamara.SelectedValue);
                    //***** Actualizar en la base de datos
                    LogisContexto.SaveChanges();
                    SeguimientoContexto.SaveChanges();

                    //TransaccionPesosFijos.Commit();
                    TransaccionInternet.Commit();
                    TransaccionLocal.Commit();

                    MessageBox.Show("El articulo fue actualizado con exito!!!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string sMensaje = ex.Message + Environment.NewLine + Environment.NewLine;

                    if (ex.InnerException != null)
                    {
                        sMensaje += ex.InnerException.Message;
                    }

                    MessageBox.Show(sMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TransaccionInternet.Rollback();
                    //TransaccionPesosFijos.Rollback();
                    TransaccionLocal.Rollback();
                }
                finally
                {
                    if (LogisContexto.Connection.State != ConnectionState.Closed)
                    {
                        LogisContexto.Connection.Close();
                    }
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                    {
                        SeguimientoContexto.Connection.Close();
                    }
                    //if (SegContextoPesoFijo.Connection.State != ConnectionState.Closed)
                    //{
                    //    SegContextoPesoFijo.Connection.Close();
                    //}
                }
            }
        }

        private bool ValidarDatos()
        {
            bool bRespuesta = false;
            
            try
            {
                if (txbCaducidad.Text == string.Empty)
                {
                    throw new FormatException("Debe indicar la caducidad del producto...");
                }

                if (chbxCantidadFija.Checked == true)
                {
                    if (txbCantidadFija.Text == string.Empty)
                    {
                        throw new FormatException("Debe indicar la cantidad fija a usar...");
                    }
                }

                if (chbxPesoFijo.Checked == true)
                {
                    if (lstbPesosFijos.Items.Count == 0)
                    {
                        throw new FormatException("Debe indicar por lo menos un peso fijo...");
                    }
                }

                bRespuesta = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bRespuesta;
        }
    }
}

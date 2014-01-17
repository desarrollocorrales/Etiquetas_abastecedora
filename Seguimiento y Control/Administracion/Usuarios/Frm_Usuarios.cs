using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Administracion.Usuarios
{
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            cbAreas.DataSource = CargarAreas();
            cbAreaModificar.DataSource = CargarAreas();
            cbUsernameModificar.DataSource = CargarUsuarios();
            cbUsernameEliminar.DataSource = CargarUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<areas> CargarAreas()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<areas> lstAreas = new List<areas>();
            lstAreas.AddRange(SeguimientoContexto.areas);

            return lstAreas.OrderBy(o=>o.nombre).ToList();
        }

        private List<usuarios> CargarUsuarios()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<usuarios> lstUsuarios = new List<usuarios>();
            lstUsuarios.AddRange(SeguimientoContexto.usuarios.Where(o => o.estado == true));

            return lstUsuarios.OrderBy(o => o.username).ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarAgregar() == true)
            {
                DialogResult dr =
                    MessageBox.Show("¿Desea Agregar al usuario \"" + txbNombreCompleto.Text.ToUpper() + "\"?",
                                    "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Agregar();
                }
            }
        }
        private void Agregar()
        {
            try
            {
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                SeguimientoContexto.Connection.Open();
                IDbTransaction Transaccion = SeguimientoContexto.Connection.BeginTransaction();
                try
                {
                    usuarios newUser = new usuarios();
                    newUser.nombre = txbNombreCompleto.Text.ToUpper();
                    newUser.id_area = Convert.ToInt64(cbAreas.SelectedValue);
                    newUser.username = txbUserName.Text.ToUpper();
                    newUser.password = txbPass1.Text.ToUpper();
                    newUser.estado = true;

                    SeguimientoContexto.usuarios.AddObject(newUser);
                    SeguimientoContexto.SaveChanges();

                    permisos newPermisos = new permisos();
                    newPermisos.id_usuario = newUser.id_usuario;
                    newPermisos.cadena_permisos = CrearCadenaPermisos();

                    SeguimientoContexto.permisos.AddObject(newPermisos);
                    SeguimientoContexto.SaveChanges();

                    Transaccion.Commit();
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                        SeguimientoContexto.Connection.Close();

                    cbUsernameModificar.DataSource = CargarUsuarios();
                    cbUsernameEliminar.DataSource = CargarUsuarios();

                    MessageBox.Show("¡El usuario fue agregado con exito!",
                                    string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    Transaccion.Rollback();
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                        SeguimientoContexto.Connection.Close();
                    throw;
                }
            }
            catch (Exception ex)
            {
                StringBuilder MensajeError = new StringBuilder();
                MensajeError.AppendLine(ex.Message);
                if (ex.InnerException != null)
                {
                    MensajeError.AppendLine(ex.InnerException.Message);
                }
                MessageBox.Show("Ocurrio un error al agregar el usuario" + Environment.NewLine + MensajeError.ToString(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CrearCadenaPermisos()
        {
            StringBuilder sCadenaPermisos = new StringBuilder();
            foreach (TabPage Tab in tabCntrlPermisos.TabPages)
            {
                foreach (CheckBox cntrl in Tab.Controls)
                {
                    if (cntrl.Tag != null)
                    {
                        if (cntrl.Checked == true)
                            sCadenaPermisos.Append(cntrl.Tag.ToString().ToUpper() + ".");
                    }
                }                
            }

            sCadenaPermisos.Append("ADMINISTRACION.IMPRESORA");

            return sCadenaPermisos.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarModificar() == true)
            {
                DialogResult dr =
                    MessageBox.Show("¿Desea Modificar al usuario \"" + txbNombreModificar.Text + "\"?",
                                    "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Modificar();
                }
            }
        }
        private void Modificar()
        {
            try
            {
                int id_User = (int)cbUsernameModificar.SelectedValue;

                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                SeguimientoContexto.Connection.Open();
                IDbTransaction Transaccion = SeguimientoContexto.Connection.BeginTransaction();

                try
                {
                    usuarios userToModify = SeguimientoContexto.usuarios.SingleOrDefault(o => o.id_usuario == id_User);
                    permisos permisosModify = SeguimientoContexto.permisos.SingleOrDefault(o => o.id_usuario == id_User);

                    userToModify.nombre = txbNombreModificar.Text.ToUpper();
                    userToModify.password = txbPassModificar1.Text.ToUpper();
                    userToModify.id_area = Convert.ToInt64(cbAreaModificar.SelectedValue);
                    SeguimientoContexto.SaveChanges();

                    permisosModify.cadena_permisos = CrearCadenaPermisos();
                    SeguimientoContexto.SaveChanges();

                    Transaccion.Commit();
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                        SeguimientoContexto.Connection.Close();

                    cbUsernameModificar.DataSource = CargarUsuarios();
                    cbUsernameEliminar.DataSource = CargarUsuarios();

                    MessageBox.Show("¡El usuario fue modificado con exito!",
                                    string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    Transaccion.Rollback();
                    if (SeguimientoContexto.Connection.State != ConnectionState.Closed)
                        SeguimientoContexto.Connection.Close();
                    throw;
                }
            }
            catch (Exception ex)
            {
                StringBuilder sMensajeError = new StringBuilder();
                sMensajeError.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sMensajeError.AppendLine(ex.Message);

                MessageBox.Show("Ocurrio un error al modificar al usuario" + Environment.NewLine + sMensajeError.ToString(),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = 
                MessageBox.Show("¿Desea eliminar al usuario \"" + txbNombreEliminar.Text + "\"?", 
                                "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Eliminar();
            }
        }
        private void Eliminar()
        {
            try
            {
                usuarios userSelected = (usuarios)cbUsernameEliminar.SelectedItem;

                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                usuarios userEliminar = SeguimientoContexto.usuarios.SingleOrDefault(o => o.id_usuario == userSelected.id_usuario);
                userEliminar.estado = false;
                SeguimientoContexto.SaveChanges();

                cbUsernameModificar.DataSource = CargarUsuarios();
                cbUsernameEliminar.DataSource = CargarUsuarios();

                txbNombreEliminar.Text = string.Empty;
                txbAreaEliminar.Text = string.Empty;

                MessageBox.Show("¡El usuario fue eliminado con exito!",
                                string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar al usuario" + Environment.NewLine + ex.Message, 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcUsuarios_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabCtrlUsuarios.SelectedTab.Text.ToUpper())
            {
                case "AGREGAR":
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    tabCntrlPermisos.Enabled = true;
                    break;
                case "MODIFICAR":
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    tabCntrlPermisos.Enabled = true;
                    break;
                case "ELIMINAR":
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    tabCntrlPermisos.Enabled = false;
                    break;
            }
        }

        private void chbxAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            /************************** Enabled **************************/
            chbxRecepProveedores.Enabled = chbxAlmacen.Checked;
            chbxRecepInterna.Enabled = chbxAlmacen.Checked;

            chbxEntregaProduccion.Enabled = chbxAlmacen.Checked;
            chbxEntregaVendedores.Enabled = chbxAlmacen.Checked;
            chbxEntregaSucursales.Enabled = chbxAlmacen.Checked;

            chbxEnvioMercancia.Enabled = chbxAlmacen.Checked;
            chbxTarimasRecep.Enabled = chbxAlmacen.Checked;
            chbxReimprmirSalidas.Enabled = chbxAlmacen.Checked;
            /*************************************************************/
            /************************** Checked **************************/
            chbxRecepProveedores.Checked = chbxAlmacen.Checked;
            chbxRecepInterna.Checked = chbxAlmacen.Checked;

            chbxEntregaProduccion.Checked = chbxAlmacen.Checked;
            chbxEntregaVendedores.Checked = chbxAlmacen.Checked;
            chbxEntregaSucursales.Checked = chbxAlmacen.Checked;

            chbxEnvioMercancia.Checked = chbxAlmacen.Checked;
            chbxTarimasRecep.Checked = chbxAlmacen.Checked;
            chbxReimprmirSalidas.Checked = chbxAlmacen.Checked;
            /*************************************************************/
        }

        private void chbxProduccion_CheckedChanged(object sender, EventArgs e)
        {
            /************************** Enabled **************************/
            chbxRequerir.Enabled = chbxProduccion.Checked;
            
            chbxCortes.Enabled = chbxProduccion.Checked;
            chbxProcesados.Enabled = chbxProduccion.Checked;
            chbxMantequera.Enabled = chbxProduccion.Checked;

            chbxCerrarRequiciciones.Enabled = chbxProduccion.Checked;
            chbxTarimasProd.Enabled = chbxProduccion.Checked;
            chbxImprimirTarimas.Enabled = chbxProduccion.Checked;
            /*************************************************************/
            /************************** Checked **************************/
            chbxRequerir.Checked = chbxProduccion.Checked;

            chbxCortes.Checked = chbxProduccion.Checked;
            chbxProcesados.Checked = chbxProduccion.Checked;
            chbxMantequera.Checked = chbxProduccion.Checked;

            chbxCerrarRequiciciones.Checked = chbxProduccion.Checked;
            chbxTarimasProd.Checked = chbxProduccion.Checked;
            chbxImprimirTarimas.Checked = chbxProduccion.Checked;
            /*************************************************************/
        }

        private void chbxDistribucion_CheckedChanged(object sender, EventArgs e)
        {
            /************************** Enabled **************************/
            chbxRequisicionesVendedores.Enabled = chbxDistribucion.Checked;
            chbxRequisicionesSucursales.Enabled = chbxDistribucion.Checked;
            /*************************************************************/
            /************************** Checked **************************/
            chbxRequisicionesVendedores.Checked = chbxDistribucion.Checked;
            chbxRequisicionesSucursales.Checked = chbxDistribucion.Checked;
            /*************************************************************/
        }

        private void chbxAdministracion_CheckedChanged(object sender, EventArgs e)
        {
            /************************** Enabled **************************/
            chbxAreas.Enabled = chbxAdministracion.Checked;
            chbxArticulos.Enabled = chbxAdministracion.Checked;
            chbxBodegas.Enabled = chbxAdministracion.Checked;
            chbxUsuarios.Enabled = chbxAdministracion.Checked;
            chbxReimprimirEtiquetas.Enabled = chbxAdministracion.Checked;
            chbxEliminarEtiquetas.Enabled = chbxAdministracion.Checked;
            chbxDevoluciones.Enabled = chbxAdministracion.Checked;
            chbxAsignaUnidades.Enabled = chbxAdministracion.Checked;
            /*************************************************************/
            /************************** Checked **************************/
            chbxAreas.Checked = chbxAdministracion.Checked;
            chbxArticulos.Checked = chbxAdministracion.Checked;
            chbxBodegas.Checked = chbxAdministracion.Checked;
            chbxUsuarios.Checked = chbxAdministracion.Checked;
            chbxReimprimirEtiquetas.Checked = chbxAdministracion.Checked;
            chbxEliminarEtiquetas.Checked = chbxAdministracion.Checked;
            chbxDevoluciones.Checked = chbxAdministracion.Checked;
            chbxAsignaUnidades.Checked = chbxAdministracion.Checked;
            /*************************************************************/
        }

        private void cbUsernameModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarios userModificar = (usuarios)cbUsernameModificar.SelectedItem;
            txbNombreModificar.Text = userModificar.nombre.ToUpper();
            txbPassModificar1.Text = userModificar.password;
            txbPassModificar2.Text = userModificar.password;
            cbAreaModificar.SelectedValue = userModificar.id_area;
            CargarPermisos();
        }

        private void cbUsernameEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarios userEliminar = (usuarios)cbUsernameEliminar.SelectedItem;
            txbNombreEliminar.Text = userEliminar.nombre.ToUpper();

            long ValueSelected = Convert.ToInt64(cbAreaModificar.SelectedValue);
            cbAreaModificar.SelectedValue = userEliminar.id_area;
            txbAreaEliminar.Text = cbAreaModificar.Text;
            cbAreaModificar.SelectedValue = ValueSelected;

        }

        private bool ValidarModificar()
        {
            string sPass1 = txbPassModificar1.Text.ToUpper();
            string sPass2 = txbPassModificar2.Text.ToUpper();

            if (sPass1 == sPass2)
            {
                if (sPass1.Length < 5)
                {
                    MessageBox.Show("Las contraseñas debe ser de al menos 5 caracteres...",
                                    "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }                
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales...",
                                "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }           
        }

        private bool ValidarAgregar()
        {
            string sPass1 = txbPass1.Text.ToUpper();
            string sPass2 = txbPass2.Text.ToUpper();

            if (sPass1 == sPass2)
            {
                if (sPass1.Length < 5)
                {
                    MessageBox.Show("Las contraseñas debe ser de al menos 5 caracteres...",
                                    "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales...",
                                "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CargarPermisos()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            int id_usuario = Convert.ToInt32(cbUsernameModificar.SelectedValue);

            permisos oPermisos = SeguimientoContexto.permisos.SingleOrDefault(o => o.id_usuario == id_usuario);
            if (oPermisos != null)
            {
                string sPermisos = oPermisos.cadena_permisos.ToUpper();
                string sTag = string.Empty;

                foreach (TabPage Tab in tabCntrlPermisos.TabPages)
                {
                    var Controles = Tab.Controls.Cast<Control>().OrderBy(o=>o.TabIndex);
                    foreach (CheckBox cntrl in Controles)
                    {
                        cntrl.Checked = false;

                        if (cntrl.Tag != null)
                        {
                            sTag = cntrl.Tag.ToString().ToUpper();
                            if (sPermisos.Contains(sTag))
                                cntrl.Checked = true;
                        }
                    }
                }
            }
        }

        private void chbxReportes_CheckedChanged(object sender, EventArgs e)
        {
            /************************** Enabled **************************/
            chbxReporteProd.Enabled = chbxReportes.Checked;
            chbxReporteRecep.Enabled = chbxReportes.Checked;
            chbxReporteMovim.Enabled = chbxReportes.Checked;
            /*************************************************************/
            /************************** Checked **************************/
            chbxReporteProd.Checked = chbxReportes.Checked;
            chbxReporteRecep.Checked = chbxReportes.Checked;
            chbxReporteMovim.Checked = chbxReportes.Checked;
            /*************************************************************/
        }
    }
}

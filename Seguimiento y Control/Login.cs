using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Configuracion;

namespace Seguimiento_y_Control
{
    public partial class Login : Form
    {
        Seguimiento_ACC_Entities segContext;

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (InicarSesion())
            {
                Properties.Settings.Default.Bascula = ((catalog_basculas)cmbBascula.SelectedItem).id_bascula;
                Properties.Settings.Default.Save();

                this.Hide();
                new MDI_Principal().ShowDialog();
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /* ------------- ACTUALIZACION v1.1 -------------------------------------- */

            this.ActiveControl = this.txbUser;

            /* ------------- ACTUALIZACION v1.1 -------------------------------------- */
            
            pbLogoSistema.ImageLocation = "LogoSistema.jpg";
            segContext = new Seguimiento_ACC_Entities();
            usuarios login = segContext.usuarios.FirstOrDefault();            
        }
        private void cargarBasculas()
        {
            List<catalog_basculas> lstBasculas = segContext.catalog_basculas.ToList();
            cmbBascula.DataSource = lstBasculas;
            cmbBascula.ValueMember = "id_bascula";
            cmbBascula.DisplayMember = "marca";

            if (Properties.Settings.Default.Bascula != string.Empty)
            {
                cmbBascula.SelectedValue = Properties.Settings.Default.Bascula;
            }
        }

        private bool InicarSesion()
        {
            string user = txbUser.Text.ToUpper();
            string pass = txbPass.Text.ToUpper();

            try
            {
                usuarios login =
                    segContext.usuarios.FirstOrDefault(o => o.username.ToUpper() == user && o.password.ToUpper() == pass);
                if (login == null)
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (login.estado == true)
                    {
                        Config.user = login;
                        Config.ID_SUCURSAL_CODIGO_DE_BARRAS =
                            segContext.configuracion.FirstOrDefault(o => o.config == "etiqueta_id").valor;
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine("Ocurrió un error: ");
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);
                MessageBox.Show(sbMensaje.ToString(), "Login",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (InicarSesion())
                {
                    this.Hide();
                    new MDI_Principal().ShowDialog();
                    this.Close();
                }
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            cargarBasculas();
        }
    }
}

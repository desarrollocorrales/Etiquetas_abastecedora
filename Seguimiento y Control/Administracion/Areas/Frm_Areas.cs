using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Administracion.Areas
{
    /// <summary>
    /// Formulario destinado a las Altas, Bajas y Cambios de las Areas de la Empresa
    /// </summary>
    public partial class Frm_Areas : Form
    {
        public Frm_Areas()
        {
            InitializeComponent();
        }

        #region ***** Agregar *****
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void Agregar()
        {
            if (ValidarAgregar() == true)
            {
                try
                {
                    areas newArea = new areas();
                    newArea.nombre = txbAreaAgregar.Text.ToUpper().Trim();

                    Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                    SeguimientoContexto.areas.AddObject(newArea);

                    SeguimientoContexto.SaveChanges();

                    MessageBox.Show("¡El área fue agregada con exito!", "OK", 
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridAreasAgregar.DataSource = CargarAreas();
                    gvAreasAgregar.BestFitColumns();

                    gridAreasModificar.DataSource = CargarAreas();
                    gvAreasModificar.BestFitColumns();

                    gridAreasEliminar.DataSource = CargarAreas();
                    gvAreasEliminar.BestFitColumns();

                }
                catch (Exception ex)
                {
                    StringBuilder sbMensaje = new StringBuilder();

                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                        sbMensaje.AppendLine(ex.InnerException.Message);

                    MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarAgregar()
        {
            string sNewArea = txbAreaAgregar.Text.ToUpper().Trim();
            if (sNewArea == string.Empty)
            {
                MessageBox.Show("Por favor introduzca el nombre de la nueva Área...", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine("¿Son los datos correctos?");
            sbMensaje.AppendLine("Area: " + sNewArea);
            DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar", 
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return false;
            else
                return true;
        }

        #endregion

        #region ***** Modificar *****

        private long id_area;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        private void Modificar()
        {
            if (ValidarModificar() == true)
            {
                try
                {
                    Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                    areas AreaToModify = SeguimientoContexto.areas.SingleOrDefault(o => o.id_area == id_area);

                    AreaToModify.nombre = txbAreaModificar.Text.ToUpper().Trim();
                    SeguimientoContexto.SaveChanges();

                    MessageBox.Show("¡El área fue modificada con exito!", "OK",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridAreasAgregar.DataSource = CargarAreas();
                    gvAreasAgregar.BestFitColumns();

                    gridAreasModificar.DataSource = CargarAreas();
                    gvAreasModificar.BestFitColumns();

                    gridAreasEliminar.DataSource = CargarAreas();
                    gvAreasEliminar.BestFitColumns();
                }
                catch (Exception ex)
                {
                    StringBuilder sbMensaje = new StringBuilder();

                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                        sbMensaje.AppendLine(ex.InnerException.Message);

                    MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarModificar()
        {
            string sNewNameArea = txbAreaModificar.Text.ToUpper().Trim();

            if (sNewNameArea == string.Empty)
            {
                MessageBox.Show("Por favor introduzca el nuevo nombre del Área...", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine("¿Son los datos correctos?");
            sbMensaje.AppendLine("Nuevo nombre de área: " + sNewNameArea);
            DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return false;
            else
                return true;
        }
        private void gvAreasModificar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int indexSelected = gvAreasModificar.GetSelectedRows()[0];
            areas AreaSelected = (areas)gvAreasModificar.GetRow(indexSelected);

            txbAreaModificar.Text = AreaSelected.nombre.ToUpper();
            id_area = AreaSelected.id_area;
        }

        #endregion

        #region ***** Eliminar *****

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            if (ValidarEliminar() == true)
            {
                try
                {
                    int indexSelected = gvAreasEliminar.GetSelectedRows()[0];
                    areas AreaToDelete = (areas)gvAreasEliminar.GetRow(indexSelected);

                    Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                    areas objToDelete = SeguimientoContexto.areas.SingleOrDefault(o => o.id_area == AreaToDelete.id_area);

                    SeguimientoContexto.areas.DeleteObject(objToDelete);

                    SeguimientoContexto.SaveChanges();

                    MessageBox.Show("¡El área fue eliminada con exito!", "OK",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridAreasAgregar.DataSource = CargarAreas();
                    gvAreasAgregar.BestFitColumns();

                    gridAreasModificar.DataSource = CargarAreas();
                    gvAreasModificar.BestFitColumns();

                    gridAreasEliminar.DataSource = CargarAreas();
                    gvAreasEliminar.BestFitColumns();
                }
                catch (Exception ex)
                {
                    StringBuilder sbMensaje = new StringBuilder();

                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                        sbMensaje.AppendLine(ex.InnerException.Message);

                    MessageBox.Show(sbMensaje.ToString(), ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidarEliminar()
        {
            int indexSelected = gvAreasEliminar.GetSelectedRows()[0];
            areas AreaToDelete = (areas)gvAreasEliminar.GetRow(indexSelected);

            string sMensaje = "Desea eliminar el área: " + AreaToDelete.nombre;
            DialogResult dr = MessageBox.Show(sMensaje, "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != System.Windows.Forms.DialogResult.Yes)
                return false;
            else
                return true;
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabCntrlAreas_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabCntrlAreas.SelectedTab.Text.ToUpper())
            {
                case "AGREGAR":
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
                case "MODIFICAR":
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;
                    break;
                case "ELIMINAR":
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = true;
                    break;
            }
        }

        private void Frm_Areas_Load(object sender, EventArgs e)
        {
            gridAreasAgregar.DataSource = CargarAreas();
            gvAreasAgregar.BestFitColumns();

            gridAreasModificar.DataSource = CargarAreas();
            gvAreasModificar.BestFitColumns();

            gridAreasEliminar.DataSource = CargarAreas();
            gvAreasEliminar.BestFitColumns();
        }

        private List<areas> CargarAreas()
        {
            List<areas> lstAreas = new List<areas>();

            try
            {
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                lstAreas.AddRange(SeguimientoContexto.areas);
            }
            catch (Exception ex)
            {
                StringBuilder sbMensaje = new StringBuilder();
                sbMensaje.AppendLine(ex.Message);
                if (ex.InnerException != null)
                    sbMensaje.AppendLine(ex.InnerException.Message);
                MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lstAreas;
        }             
    }
}

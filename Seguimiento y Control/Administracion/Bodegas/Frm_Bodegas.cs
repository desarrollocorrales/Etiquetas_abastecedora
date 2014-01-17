using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Entity.Internet;

namespace Seguimiento_y_Control.Administracion.Bodegas
{
    public partial class Frm_Bodegas : Form
    {
        public Frm_Bodegas()
        {
            InitializeComponent();
        }

        private void Frm_Bodegas_Load(object sender, EventArgs e)
        {
            inicializarPestañaAgregar();
            inicializarPestañaEliminar();
            inicializarPestañaModificar();
        }

        #region ***** Agregar *****

        private void inicializarPestañaAgregar()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<bodegas> lstBodegas = new List<bodegas>();
            lstBodegas.AddRange(SeguimientoContexto.bodegas);

            gridBodegas.DataSource = lstBodegas;
            gvBodegas.BestFitColumns();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            try
            {
                if (txbBodega.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Por favor introduzca el nombre de la bodega...", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Los datos son correctos?", string.Empty,
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        bodegas objBodega = new bodegas();
                        camaras objCamara = new camaras();

                        objBodega.bodega = txbBodega.Text.ToUpper();
                        objCamara.camara = txbBodega.Text.ToUpper();

                        Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                        Logisn_Entities LogisContexto = new Logisn_Entities();

                        SeguimientoContexto.Connection.Open();
                        LogisContexto.Connection.Open();

                        IDbTransaction TransaccionSeguimiento = SeguimientoContexto.Connection.BeginTransaction();
                        IDbTransaction TransaccionLogis = LogisContexto.Connection.BeginTransaction();
                        try
                        {
                            LogisContexto.camaras.AddObject(objCamara);
                            LogisContexto.SaveChanges();

                            SeguimientoContexto.bodegas.AddObject(objBodega);
                            SeguimientoContexto.SaveChanges();

                            TransaccionLogis.Commit();
                            TransaccionSeguimiento.Commit();

                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();

                            inicializarPestañaAgregar();
                            inicializarPestañaEliminar();
                            inicializarPestañaModificar();

                            MessageBox.Show("¡La bodega se agregó con exito!");
                        }
                        catch
                        {
                            TransaccionLogis.Rollback();
                            TransaccionSeguimiento.Rollback();
                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region ***** Modificar *****

        private void inicializarPestañaModificar()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<bodegas> lstBodegas = new List<bodegas>();
            lstBodegas.AddRange(SeguimientoContexto.bodegas);

            gridModificar.DataSource = lstBodegas;
            gvModificar.BestFitColumns();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            try
            {
                string sBodega = obtenerBodegaSeleccionada(gvModificar);

                if (sBodega == null)
                {
                    MessageBox.Show("Seleccione una bodega...", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (txbBodegaModificar.Text.Trim().Equals(string.Empty))
                    {
                        MessageBox.Show("Por favor introduzca el nombre de la bodega...", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult dr = MessageBox.Show("¿Desea Cambiar el nombre de la bodega \"" + sBodega + "\"?",
                                                       string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                        Logisn_Entities LogisContexto = new Logisn_Entities();

                        SeguimientoContexto.Connection.Open();
                        LogisContexto.Connection.Open();

                        IDbTransaction TransaccionSeguimiento = SeguimientoContexto.Connection.BeginTransaction();
                        IDbTransaction TransaccionLogis = LogisContexto.Connection.BeginTransaction();
                        try
                        {
                            bodegas objBodega =
                                SeguimientoContexto.bodegas.SingleOrDefault(o => o.bodega.ToUpper() == sBodega);
                            camaras objCamara =
                                LogisContexto.camaras.SingleOrDefault(o => o.camara.ToUpper() == sBodega);

                            objCamara.camara = txbBodegaModificar.Text.ToUpper();
                            LogisContexto.SaveChanges();

                            objBodega.bodega = txbBodegaModificar.Text.ToUpper();
                            SeguimientoContexto.SaveChanges();

                            TransaccionLogis.Commit();
                            TransaccionSeguimiento.Commit();

                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();

                            inicializarPestañaEliminar();
                            inicializarPestañaAgregar();
                            inicializarPestañaModificar();

                            MessageBox.Show("¡La bodega se modificó con exito!");
                        }
                        catch
                        {
                            TransaccionLogis.Rollback();
                            TransaccionSeguimiento.Rollback();
                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridModificar_Click(object sender, EventArgs e)
        {
            string sBodega = obtenerBodegaSeleccionada(gvModificar);
            txbBodegaModificar.Text = sBodega;
        }

        #endregion

        #region ***** Eliminar *****

        private void inicializarPestañaEliminar()
        {
            Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
            List<bodegas> lstBodegas = new List<bodegas>();
            lstBodegas.AddRange(SeguimientoContexto.bodegas);

            gridbodegasEliminar.DataSource = lstBodegas;
            gvBodegasEliminar.BestFitColumns();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            try
            {
                string sBodega = obtenerBodegaSeleccionada(gvBodegasEliminar);

                if (sBodega == null)
                {
                    MessageBox.Show("Seleccione una bodega...", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Desea eliminar la bodega \"" + sBodega + "\"?", string.Empty,
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                        Logisn_Entities LogisContexto = new Logisn_Entities();

                        SeguimientoContexto.Connection.Open();
                        LogisContexto.Connection.Open();

                        IDbTransaction TransaccionSeguimiento = SeguimientoContexto.Connection.BeginTransaction();
                        IDbTransaction TransaccionLogis = LogisContexto.Connection.BeginTransaction();
                        try
                        {
                            bodegas objBodega =
                                SeguimientoContexto.bodegas.SingleOrDefault(o => o.bodega.ToUpper() == sBodega);
                            camaras objCamara =
                                LogisContexto.camaras.SingleOrDefault(o => o.camara.ToUpper() == sBodega);

                            LogisContexto.camaras.DeleteObject(objCamara);
                            LogisContexto.SaveChanges();

                            SeguimientoContexto.bodegas.DeleteObject(objBodega);
                            SeguimientoContexto.SaveChanges();

                            TransaccionLogis.Commit();
                            TransaccionSeguimiento.Commit();

                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();

                            inicializarPestañaEliminar();
                            inicializarPestañaAgregar();
                            inicializarPestañaModificar();

                            MessageBox.Show("¡La bodega se eliminó con exito!");
                        }
                        catch
                        {
                            TransaccionLogis.Rollback();
                            TransaccionSeguimiento.Rollback();
                            SeguimientoContexto.Connection.Close();
                            LogisContexto.Connection.Close();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private string obtenerBodegaSeleccionada(DevExpress.XtraGrid.Views.Grid.GridView pGrid)
        {
            bodegas objBodega = new bodegas();

            int indexBodega = pGrid.GetSelectedRows()[0];
            objBodega = (bodegas)pGrid.GetRow(indexBodega);

            return objBodega.bodega;
        }
    }
}

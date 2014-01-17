using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity.Internet;

namespace Seguimiento_y_Control.Administracion.Articulos
{
    public partial class Frm_ArticulosUnidades : Form
    {
        private articulos oArticulo;
        private List<unidades> lstUnidades;
        private List<art_uni> lstArtUni;
        public Frm_ArticulosUnidades()
        {
            InitializeComponent();
        }

        private void Frm_ArticulosUnidades_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            BuscarArticuloPortal();
        }
        private void BuscarArticuloPortal()
        {
            string clave = txbClave.Text;
            Logisn_Entities LogisContext= new Logisn_Entities();
            if (clave != string.Empty)
            {
                oArticulo = LogisContext.articulos.FirstOrDefault(o => o.clave == clave);                
                if (oArticulo != null)
                {
                    lstUnidades = LogisContext.unidades.ToList();
                    var queryResults = 
                        LogisContext
                        .ExecuteStoreQuery<art_uni>("Select * From art_uni Where id_articulo = " + oArticulo.id_articulo);

                    lstArtUni = queryResults.ToList();
                    CargarGridArticulo();
                }
                else
                {
                    StringBuilder sbMensaje = new StringBuilder();
                    sbMensaje.Append("No se encontró el artículo con clave: " + clave);
                    MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarGridArticulo()
        {
            List<articulos> SourceGrid = new List<articulos>();
            SourceGrid.Add(oArticulo);
            gridArticulo.DataSource = SourceGrid;
            gvArticulo.BestFitColumns();

            CargarUnidadesDisponibles();
        }
        private void CargarUnidadesDisponibles()
        {
            foreach(art_uni UnidadArticulo in lstArtUni)
            {
                unidades BorrarUnidad = lstUnidades.Find(o=>o.id_unidad == UnidadArticulo.id_unidad);
                lstUnidades.Remove(BorrarUnidad);
            }

            gridUnidades.DataSource = lstUnidades;
            gvUnidades.BestFitColumns();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Asignar();
        }
        private void Asignar()
        {
            //Obtener la unidad seleccioanda
            int indexUnidad = gvUnidades.GetSelectedRows()[0];
            unidades UnidadSeleccionada = (unidades)gvUnidades.GetRow(indexUnidad);            

            StringBuilder sbMensaje = new StringBuilder();
            sbMensaje.AppendLine(string.Format("¿Desea asignar la unidad {0} al artículo {1}?",
                                                UnidadSeleccionada.unidad, oArticulo.nombre));
            DialogResult dr = MessageBox.Show(sbMensaje.ToString(), "Validar", 
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {                   
                    Logisn_Entities LogisContext = new Logisn_Entities();
                    
                    var entityConnection = (System.Data.EntityClient.EntityConnection)LogisContext.Connection;
                    IDbConnection conn = entityConnection.StoreConnection;
                    ConnectionState initialState = conn.State;

                    if (initialState != ConnectionState.Open) 
                        conn.Open();
                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            string.Format("Insert Into art_uni (id_articulo, id_unidad) Values ({0}, {1})", 
                                           oArticulo.id_articulo, UnidadSeleccionada.id_unidad);
                        cmd.ExecuteNonQuery();
                    }
                    if (initialState != ConnectionState.Open) 
                        conn.Close();

                    sbMensaje = new StringBuilder();
                    sbMensaje.AppendLine("¡¡La asignación se ha completado con exito!!");
                    MessageBox.Show(sbMensaje.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    sbMensaje = new StringBuilder();
                    sbMensaje.AppendLine(ex.Message);
                    if (ex.InnerException != null)
                        sbMensaje.AppendLine(ex.InnerException.Message);

                    if (sbMensaje.ToString().Contains("Duplicate"))
                    {
                        MessageBox.Show("El articulo ya cuenta con la unidad " + UnidadSeleccionada.unidad, ex.GetType().ToString(),
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(sbMensaje.ToString(), ex.GetType().ToString(),
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

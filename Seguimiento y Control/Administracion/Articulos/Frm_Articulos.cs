using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Administracion;

namespace Seguimiento_y_Control.Administracion.Articulos
{
    public partial class Frm_Articulos : Form
    {
        private ArticuloMicrosip oArticuloMicrosip;
        private List<ArticuloMicrosip> lstArticulos;
        public Frm_Articulos()
        {
            InitializeComponent();
        }

        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            CargarArticulosDesdeMicrosip();
        }
        private void CargarArticulosDesdeMicrosip()
        {
            try
            {
                Seguimiento_ACC_Entities ContextoSeguimiento = new Seguimiento_ACC_Entities();
                configuracion GruposArticulos = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "GruposLineas");

                FbConnection FbConexion = new FbConnection(obtenerStringDeConexion());
                FbCommand FbComando = new FbCommand(string.Empty, FbConexion);
                FbComando.CommandText =
                    string.Format(@"SELECT 
                                  CLAVES_ARTICULOS.CLAVE_ARTICULO,
                                  ARTICULOS.NOMBRE,
                                  LINEAS_ARTICULOS.LINEA_ARTICULO_ID
                                FROM
                                  CLAVES_ARTICULOS
                                  INNER JOIN ARTICULOS ON (CLAVES_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID)
                                  INNER JOIN LINEAS_ARTICULOS ON (LINEAS_ARTICULOS.LINEA_ARTICULO_ID = ARTICULOS.LINEA_ARTICULO_ID)
                                  INNER JOIN GRUPOS_LINEAS ON (GRUPOS_LINEAS.GRUPO_LINEA_ID = LINEAS_ARTICULOS.GRUPO_LINEA_ID)
                                WHERE
                                  CLAVES_ARTICULOS.ROL_CLAVE_ART_ID = '17' And 
                                  GRUPOS_LINEAS.GRUPO_LINEA_ID IN ({0}) And 
                                  ARTICULOS.ESTATUS <> 'S' 
                                ORDER BY
                                  ARTICULOS.NOMBRE", GruposArticulos.valor);
                FbDataAdapter FbAdapter = new FbDataAdapter(FbComando);

                DataTable DataResutado = new DataTable();
                FbAdapter.Fill(DataResutado);

                ArticuloMicrosip oArticulo;
                lstArticulos = new List<ArticuloMicrosip>();
                foreach (DataRow row in DataResutado.Rows)
                {
                    oArticulo = new ArticuloMicrosip();
                    oArticulo.Clave = row["CLAVE_ARTICULO"].ToString();
                    oArticulo.Nombre = row["NOMBRE"].ToString();
                    oArticulo.ID_Linea = Convert.ToInt32(row["LINEA_ARTICULO_ID"]);
                    lstArticulos.Add(oArticulo);
                }

                gridArticulos.DataSource = lstArticulos;
                gvArticulos.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string obtenerStringDeConexion()
        {
            StringBuilder sStringDeConexion = new StringBuilder();
            Seguimiento_ACC_Entities ContextoSeguimiento = new Seguimiento_ACC_Entities();

            configuracion ServidorMicrosip = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "ServidorMicrosip");
            configuracion PassMicrosip = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "PassMicrosip");
            configuracion UserMicrosip = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "UserMicrosip");
            configuracion PathMicrosip = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "PathMicrosip");
            configuracion PuertoMicrosip = ContextoSeguimiento.configuracion.SingleOrDefault(o => o.config == "PuertoMicrosip");

            sStringDeConexion.Append(string.Format("User={0};", UserMicrosip.valor));
            sStringDeConexion.Append(string.Format("Password={0};", PassMicrosip.valor));
            sStringDeConexion.Append(string.Format("Database={0}:{1};", ServidorMicrosip.valor, PathMicrosip.valor));
            sStringDeConexion.Append(string.Format("DataSource={0};", ServidorMicrosip.valor));
            sStringDeConexion.Append(string.Format("Port={0};", PuertoMicrosip.valor));

            return sStringDeConexion.ToString();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            int indexArticuloSeleccionado = gvArticulos.GetSelectedRows()[0];
            oArticuloMicrosip = (ArticuloMicrosip)gvArticulos.GetRow(indexArticuloSeleccionado);
            new Frm_ModificarArticulo(oArticuloMicrosip).ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<ArticuloMicrosip> lstAuxiliar = 
                lstArticulos.FindAll(o => o.Nombre.ToUpper().Contains(textBox1.Text.ToUpper())
                                       || o.Clave.Contains(textBox1.Text.ToUpper()));
            
            gridArticulos.DataSource = lstAuxiliar;
            gvArticulos.BestFitColumns();
        }
    }
}

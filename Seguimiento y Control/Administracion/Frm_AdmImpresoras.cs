using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Administracion;

namespace Seguimiento_y_Control.Administracion
{
    public partial class Frm_AdmImpresoras : Form
    {
        public Frm_AdmImpresoras()
        {
            InitializeComponent();
        }

        private void Frm_AdmImpresoras_Load(object sender, EventArgs e)
        {
            int i = 1;
            Impresora oImpresora = new Impresora();
            List<Impresora> lstImpresoras = new List<Impresora>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                oImpresora = new Impresora();
                oImpresora.ID = i;
                oImpresora.NombreImpresora = printer;
                lstImpresoras.Add(oImpresora);
                i++;
            }

            gridImpresoras.DataSource = lstImpresoras;
            gvImpresoras.BestFitColumns();
            gridImpresoras.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            //**** Obtener impresora seleccionada
            Impresora oImpresora = (Impresora)gvImpresoras.GetRow(gvImpresoras.GetSelectedRows()[0]);

            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("¿Desea configurar la impresora '{0}' ", oImpresora.NombreImpresora));
            sb.AppendLine(string.Format("como impresora predeterminada para etiquetas?"));
            DialogResult dr = MessageBox.Show(sb.ToString(), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Impresora = oImpresora.NombreImpresora;
                Properties.Settings.Default.Save();

                MessageBox.Show("La impresora se ha configurado correctamente", string.Empty, 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

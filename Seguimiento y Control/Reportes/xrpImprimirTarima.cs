using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Reportes
{
    public partial class xrpImprimirTarima : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpImprimirTarima()
        {
            InitializeComponent();
        }

        private void lblFechaCreacion_AfterPrint(object sender, EventArgs e)
        {
            lblFechaCreacion.Text = lblFechaCreacion.Text.ToUpper();
        }

        private void lblFechaCreacion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaCreacion.Text = lblFechaCreacion.Text.ToUpper();
        }

        private void lblTarimaID_AfterPrint(object sender, EventArgs e)
        {
            lblTarimaID.Text = "TARIMA #" + lblTarimaID.Text;
        }

        private void lblTarimaID_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTarimaID.Text = "TARIMA #" + lblTarimaID.Text;
        }
    }
}

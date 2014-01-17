using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Reportes
{
    public partial class xrpReporteRecepcion : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpReporteRecepcion()
        {
            InitializeComponent();
        }

        private void lblFecha_AfterPrint(object sender, EventArgs e)
        {
            lblFecha.Text = lblFecha.Text.ToUpper();
        }

        private void lblFecha_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFecha.Text = lblFecha.Text.ToUpper();
        }
    }
}

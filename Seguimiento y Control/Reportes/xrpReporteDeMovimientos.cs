using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Reportes
{
    public partial class xrpReporteDeMovimientos : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpReporteDeMovimientos()
        {
            InitializeComponent();
        }

        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel13.Text = xrLabel13.Text.ToUpper();
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel8.Text = xrLabel8.Text.ToUpper();
        }

        private void xrLabel10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel10.Text = xrLabel10.Text.ToUpper();
        }

    }
}

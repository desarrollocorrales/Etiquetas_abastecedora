using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Reportes
{
    public partial class xrpEntregaVendedores : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpEntregaVendedores()
        {
            InitializeComponent();
        }

        private void xrLabel11_AfterPrint(object sender, EventArgs e)
        {
            xrLabel11.Text = xrLabel11.Text.ToUpper();
        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel11.Text = xrLabel11.Text.ToUpper();
        }

    }
}

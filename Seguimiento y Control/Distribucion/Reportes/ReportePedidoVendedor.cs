using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public partial class ReportePedidoVendedor : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportePedidoVendedor()
        {
            InitializeComponent();
        }

        private void lblFechaPedido_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaPedido.Text = lblFechaPedido.Text.ToUpper();
        }

        private void lblFechaSurtir_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaSurtir.Text = lblFechaSurtir.Text.ToUpper();
        }

    }
}

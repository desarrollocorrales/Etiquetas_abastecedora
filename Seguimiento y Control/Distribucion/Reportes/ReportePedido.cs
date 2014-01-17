using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public partial class ReportePedido : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportePedido()
        {
            InitializeComponent();
        }

        private void lblFechaSurtir_TextChanged(object sender, EventArgs e)
        {
            lblFechaSurtir.Text = lblFechaSurtir.Text.ToUpper(); 
        }

        private void lblFechaPedido_TextChanged(object sender, EventArgs e)
        {
            lblFechaPedido.Text = lblFechaPedido.Text.ToUpper();
        }
    }
}

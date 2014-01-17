using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Seguimiento_y_Control.Entity;
using System.Linq;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public partial class RequisicionVendedor : DevExpress.XtraReports.UI.XtraReport
    {
        public RequisicionVendedor()
        {
            InitializeComponent();
        }

        private void lblFechaPedido_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaPedido.Text = lblFechaPedido.Text.ToUpper();
        }

        private void xrLabel21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel21.Text = xrLabel21.Text.ToUpper();
        }

        private void lblFechaRequi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaRequi.Text = getFechaServer().ToString("ddd dd/MMM/yyyy hh:mm tt").ToUpper();
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }

        private void lblFechaRequi_AfterPrint(object sender, EventArgs e)
        {
            lblFechaRequi.Text = getFechaServer().ToString("ddd dd/MMM/yyyy hh:mm tt").ToUpper();
        }
    }
}

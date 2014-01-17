using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Seguimiento_y_Control.Entity;
using System.Linq;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public partial class RequisicionSucursal : DevExpress.XtraReports.UI.XtraReport
    {
        public RequisicionSucursal()
        {
            InitializeComponent();
        }

        private void lblFechaPedido_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaPedido.Text = lblFechaPedido.Text.ToUpper();
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel8.Text = xrLabel8.Text.ToUpper();
        }

        private void lblFechaRequi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaRequi.Text = getFechaServer().ToString("ddd dd/MM/yyyy hh:mm tt").ToUpper();
        }

        private void lblFechaRequi_AfterPrint(object sender, EventArgs e)
        {
            lblFechaRequi.Text = getFechaServer().ToString("ddd dd/MM/yyyy hh:mm tt").ToUpper();
        }

        private DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }
    }
}

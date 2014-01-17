using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Seguimiento_y_Control.Entity;
using System.Collections.Generic;
using Seguimiento_y_Control.Clases.Produccion;
namespace Seguimiento_y_Control.Reportes
{
    public partial class xrpMovimientosMercancia : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpMovimientosMercancia()
        {
            InitializeComponent();
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel6.Text = xrLabel6.Text.ToUpper();
        }

    }
}

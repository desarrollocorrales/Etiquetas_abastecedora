using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Topos
{
    public class ReporteRecepcion
    {
        public int Contador { set; get; }
        public string NumeroEtiqueta { set; get; }
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
        public string Bodega { set; get; }
        public string Estado { set; get; }
        public string Salida { set; get; }

        public string Clave { set; get; }
        public string Articulo { set; get; }
        public DateTime FechaReporte { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Produccion
{
    public class ReporteTarima
    {
        public int ID_Tarima { set; get; }
        public string Responsable { set; get; }
        public DateTime FechaHoraCreacion { set; get; }

        public string Clave { set; get; }
        public string Articulo { set; get; }
        public string NumeroEtiqueta { set; get; }        
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
        public DateTime FechaProduccion { set; get; }
    }
}

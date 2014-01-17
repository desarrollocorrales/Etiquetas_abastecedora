using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Produccion
{
    public class ReporteProduccion
    {
        private string estado;

        public int Contador { get; set; }
        public string NumeroEtiqueta { set; get; }
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
        public string Bodega { set; get; }
        public string NumeroPedido { set; get; }

        public string Clave { set; get; }
        public string Articulo { set; get; }
        public DateTime FechaReporte { set; get; }

        public string Estado 
        {
            set
            {
                estado = value;
            }
            get
            {
                switch (estado)
                {
                    case "A": return "En Almacen";
                    case "E": return "Entregada";
                    case "P": return "Parcialmente Entregada";
                    default: return string.Empty;
                }
            }
        }
    }
}

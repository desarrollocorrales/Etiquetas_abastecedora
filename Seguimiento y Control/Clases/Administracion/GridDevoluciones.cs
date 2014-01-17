using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Administracion
{
    public class GridDevoluciones
    {
        private string sEstado;

        public long IdEtiqueta { get; set; }
        public string NumeroEtiqueta { get; set; }
        public long  NumeroLote { get; set; }
        public DateTime FechaEmpaque { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string ClaveArticulo { get; set; }
        public string Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Estado
        {
            set
            {
                sEstado = value;
            }
            get
            {
                switch (sEstado)
                {
                    case "A": return "Activada";
                    case "T": return "Traspasada";
                    case "E": return "Entregada";
                    case "B": return "Borrada";
                    default: return string.Empty;
                }
            }
        }
        public string TipoEtiqueta { get; set; }
    }
}

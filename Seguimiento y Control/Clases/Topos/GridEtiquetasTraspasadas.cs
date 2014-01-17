using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Topos
{
    public class GridEtiquetasTraspasadas
    {
        public etiquetas_traspasadas oEtiquetaTraspasada { set; get; }
        public articulos oArticulo { set; get; }
        public string Estado
        {
            get
            {
                switch (oEtiquetaTraspasada.estado)
                {
                    case "P": return "Pendiente";
                    case "A": return "Activada";
                    case "E": return "Entregada";
                    default: return string.Empty;
                }
            }
        }
    }
}

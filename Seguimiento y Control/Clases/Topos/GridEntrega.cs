using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Topos
{
    public class GridEntrega
    {
        public long ID_Etiqueta { set; get; }
        public string NumeroEtiqueta { set; get; }
        public string Clave_Articulo { set; get; }
        public string Articulo { set; get; }
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
        public string Estado { set; get; }
        public char Tipo { set; get; }
        public long ID_Bodega { set; get; }
        public DateTime Fecha_Empaque { set; get; }

        public string DescripcionEstado
        {
            get
            {
                switch (Estado)
                {
                    case "P": return "Pendiente";
                    case "A": return "Activada";
                    case "E": return "Entregada";
                    case "B": return "Eliminada";
                    case "T": return "Traspasada";
                    default: return string.Empty;
                }
            }
        }
    }
}

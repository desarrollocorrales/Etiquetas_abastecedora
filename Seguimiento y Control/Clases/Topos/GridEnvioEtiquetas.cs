using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Topos
{
    public class GridEnvioEtiquetas
    {
        public string NumeroEtiqueta { set; get; }        
        public string ClaveArticuo{ set; get; }
        public string Articulo { set; get; }
        public decimal Cantidad { set; get; }
        public string Unidad { set; get; }
        public string Estatus 
        {
            get
            {
                switch (ID_Estatus)
                {
                    case "A": return "Activa";
                    case "B": return "Eliminada";
                    case "E": return "Entregada";
                    case "P": return "Pendiente";
                    case "T": return "Traspasada";
                    default: return string.Empty;
                }
            }
        }
        public string ID_Estatus { set; get; }
        public char Tipo_Etiqueta { set; get; }
        public string NumeroEtiquetaPaquete { set; get; }
    }
}

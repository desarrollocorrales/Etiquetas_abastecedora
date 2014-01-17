using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Produccion
{
    public class ArticuloRequerir
    {
        public articulos articulo_a_requerir { get; set; }
        public string sBodega { get; set; }
        public decimal cantidad_a_requrir { get; set; }
        public string unidad { get; set; }
    }
}

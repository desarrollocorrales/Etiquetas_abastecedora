using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Produccion
{
    public class ReporteMovimientosMercancia
    {
        public int id_pedido { get; set; }
        public string codigo_pedido { get; set; }
        public DateTime fecha_pedido { get; set; }
        public string nombre_usuario { get; set; }
        public string bodega { get; set; }
        public string clave_articulo { get; set; }
        public string descripcion_articulo { get; set; }
        public decimal cantidad { get; set; }
        public string unidad { get; set; }
    }
}

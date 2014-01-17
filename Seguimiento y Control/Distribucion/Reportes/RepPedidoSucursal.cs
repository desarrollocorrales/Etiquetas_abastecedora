using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public class RepPedidoSucursal
    {
        public DateTime FechaPedido { set; get; }
        public DateTime FechaSurtir { set; get; }
        public String Responsable { set; get; }
        public String Sucursal { set; get; }
        public Int32 NumeroPedido { set; get; }
        public String Codigo { set; get; }
        public String Descripcion { set; get; }
        public Double Cantidad { set; get; }
        public String Unidad { set; get; }
        public String Observaciones { set; get; }
    }
}

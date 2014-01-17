using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Distribucion
{
    public partial class GridPedidoSucursal
    {
        public bool Seleccion { set; get; }
        public int ID_Pedido { set; get; }
        public int ID_Usuario { set; get; }
        public string Responsable { set; get; }
        public string Sucursal { set; get; }
        public DateTime FechaPedido { set; get; }
        public DateTime FechaSurtir { set; get; }
        public String Observaciones { set; get; }
    }
}

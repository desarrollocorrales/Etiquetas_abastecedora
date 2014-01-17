using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Distribucion
{
    public partial class GridPedidoVendedor
    {
        public bool Seleccion { set; get; }
        public int ID_Pedido { set; get; }
        public int ID_Usuario { set; get; }
        public int ID_Cliente { set; get; }
        public string Usuario { set; get; }
        public string Cliente { set; get; }
        public string Ruta { set; get; }
        public DateTime FechaPedido { set; get; }
        public DateTime FechaSurtir { set; get; }
        public string Observaciones { set; get; }
    }
}

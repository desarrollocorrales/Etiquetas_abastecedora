using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Topos
{
    public class RepEntregaInterna
    {
        public string NumSalida { set; get; }
        public DateTime Fecha { set; get; }
        public string NumPedido { set; get; }
        public usuarios Responsable { set; get; }
        public usuarios Solicitante { set; get; }
        public string Destino { set; get; }
        public GridEntrega RowEtiquetas { set; get; }
        public bodegas Bodega { get; set; }
    }
}

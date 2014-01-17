using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity.Internet;
using Seguimiento_y_Control.Entity;
namespace Seguimiento_y_Control.Clases.Topos
{
    public class RepEntregaExterna
    {
        public string NumSalida { set; get; }
        public DateTime Fecha { set; get; }
        public string NumPedido { set; get; }
        public string Responsable { set; get; }
        public string Solicitante { set; get; }
        public string Destino { set; get; }
        public GridEntrega RowEtiquetas { set; get; }
        public bodegas Bodega { get; set; }
    }
}

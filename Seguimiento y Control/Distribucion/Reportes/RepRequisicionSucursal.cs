using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Distribucion.Reportes
{
    public class RepRequisicionSucursal
    {
        public String sNumeroRequisicion { set; get; }
        public DateTime dtFechaSolicitud { set; get; }
        public DateTime dtFechaSurtir { set; get; }
        public String sSolicitante { set; get; }
        public String sDestino { set; get; }
        
        //***** Detalles
        public String sCodigo { set; get; }
        public String sDescripcion { set; get; }
        public decimal fCantidad { set; get; }
        public String sUnidad { set; get; }
        public String sAlmacen { set; get; }
    }
}

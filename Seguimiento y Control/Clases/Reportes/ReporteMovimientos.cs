using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguimiento_y_Control.Clases.Reportes
{
    public class ReporteMovimientos
    {
        public DateTime fechaInicial { set; get; }
        public DateTime fechaFinal { set; get; }
        public DateTime fecha { set; get; }
        public string Clave { set; get; }
        public string Articulo { set; get; }
        public string Unidad { set; get; }
        public decimal TotalEntradas { set; get; }
        public decimal TotalProduccion { set; get; }
        public decimal TotalSalidasInternas { set; get; }
        public decimal TotalSalidasVendedores { set; get; }
        public decimal TotalSalidasSucursales { set; get; }
        public decimal TotalSalidas 
        {
            get
            {
                return TotalSalidasInternas + TotalSalidasSucursales + TotalSalidasVendedores;
            }
        }
    }
}

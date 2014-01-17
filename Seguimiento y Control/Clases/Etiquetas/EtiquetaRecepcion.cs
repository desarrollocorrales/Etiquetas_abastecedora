using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Etiquetas
{
    public static class EtiquetaRecepcion
    {
        public static string Comando
        {
            get
            {
                Seguimiento_ACC_Entities SeguimientoContexto = new Seguimiento_ACC_Entities();
                string comando =
                    SeguimientoContexto
                        .catalog_comandos_etiquetas
                        .SingleOrDefault(o => o.etiqueta == "recepcion").comando;
                return comando;
            }
        }
    }
}

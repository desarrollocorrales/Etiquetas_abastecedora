using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Clases.Utilitarias
{
    public static class Servidor
    {
        public static DateTime getFechaServer()
        {
            Seguimiento_ACC_Entities dataContext = new Seguimiento_ACC_Entities();
            var queryResults = dataContext.ExecuteStoreQuery<DateTime>("Select now()");
            DateTime fechaServer = queryResults.First();
            return fechaServer;
        }
    }
}

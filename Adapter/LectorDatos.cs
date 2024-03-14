using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LectorDatos : IlectorDatos
    {
        public string leer()
        {
            return "Datos leídos de la fuente original";
        }
    }
}

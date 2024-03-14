using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method
{
    internal class LectorArchivoTextoFactory: IlectorArchivoFactory
    {
        public IlectorArchivo CrearLectorArchivo(string rutaArchivo)
        {
            return new LectorArchivoTexto(rutaArchivo);
        }
    }
}

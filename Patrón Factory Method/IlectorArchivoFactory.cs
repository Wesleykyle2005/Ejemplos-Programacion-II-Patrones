using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method
{
    public interface IlectorArchivoFactory
    {
        IlectorArchivo CrearLectorArchivo(string rutaArchivo);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method
{
    internal class LectorArchivoTexto: IlectorArchivo
    {
        private string _rutaArchivo;
        public LectorArchivoTexto(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }

        public string leer()
        {
            using (StreamReader reader = new StreamReader(_rutaArchivo))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

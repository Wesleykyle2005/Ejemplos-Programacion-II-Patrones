using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class LectorArchivo: ILectorDatos
    {
        private string _rutaArchivo;

        public LectorArchivo(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }
        public string LeerDatos()
        {
            using(StreamReader reader = new StreamReader(_rutaArchivo)) {

                return reader.ReadToEnd(); 
            }
        }
    }
}

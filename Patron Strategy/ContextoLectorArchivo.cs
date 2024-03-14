using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Strategy
{
    internal class ContextoLectorArchivo
    {
        private IlectorArchivo  _LectorArchivo;

        public ContextoLectorArchivo(IlectorArchivo LectorArchivo) {

            _LectorArchivo = LectorArchivo;

        }

        public void EstablecerEstragtegia(IlectorArchivo LectorArchivo)
        {
            _LectorArchivo = LectorArchivo;
        }
        public string LeerArchivo(string rutaArchivo) {
        
            return _LectorArchivo.leer(rutaArchivo);
        }



    }
}

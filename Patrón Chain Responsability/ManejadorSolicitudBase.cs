using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Chain_Responsability
{
    public abstract class ManejadorSolicitudBase: IManejadorDeSolicitud
    {
        private IManejadorDeSolicitud _siguiente;
        public void EstablecerSiguiente(IManejadorDeSolicitud siguiente)
        {
            _siguiente = siguiente;
        }

        public virtual void ManejarSolicitud(string solicitud)
        {
            if (_siguiente != null)
            {
                _siguiente.ManejarSolicitud(solicitud);
            }
        }
    }
}

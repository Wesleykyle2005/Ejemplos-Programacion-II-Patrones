using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Chain_Responsability
{
    public interface IManejadorDeSolicitud
    {
        void ManejarSolicitud(string solicitud);
        void EstablecerSiguiente(IManejadorDeSolicitud siguiente);

    }
}

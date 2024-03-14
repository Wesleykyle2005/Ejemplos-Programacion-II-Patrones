using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_observer
{
    internal interface ISujetoObservado
    {
        void AgregarObservador(IObserver observador);

        void EliminarObservador(IObserver observador);

        void NotificarObservadores();
    }
}

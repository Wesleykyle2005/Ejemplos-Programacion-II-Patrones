using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_observer
{
    internal interface IObserver
    {
        void Actualizar(string datos);
    }
}

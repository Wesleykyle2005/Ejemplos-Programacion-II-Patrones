using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_observer
{
    internal class ObservadorMostrarDatos: IObserver
    {
        public void Actualizar(string datos)
        {
            Console.WriteLine("Datos: "+ datos);
        }
    }
}

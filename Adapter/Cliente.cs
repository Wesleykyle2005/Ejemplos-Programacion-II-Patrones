using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Cliente
    {
        private IlectorDatos _lectorDatos;

        public Cliente(IlectorDatos lectorDatos)
        {
            _lectorDatos = lectorDatos;
        }

        public void RealizarOperacionLectura() {

            string datos = _lectorDatos.leer();
            Console.WriteLine("Datos leídos: " + datos);


        }
    }
}

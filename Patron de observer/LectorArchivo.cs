using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_observer
{
    internal class LectorArchivo: ISujetoObservado
    {
        private List<IObserver> _observadores = new List<IObserver>();
        private string _rutaArchivo;
        public LectorArchivo(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }
        public void AgregarObservador(IObserver observador) {
            _observadores.Add(observador);
        }
        public void EliminarObservador(IObserver observador)
        {
            _observadores.Remove(observador);
        }
        public void NotificarObservadores()
        {
            string datos = LeerDatos();
            foreach (var observador in _observadores)
            {
                observador.Actualizar(datos);
            }
        }
        private string LeerDatos()
        {
            using(StreamReader reader = new StreamReader(_rutaArchivo))
            {
                    return reader.ReadToEnd();
            }
        }
    }
}

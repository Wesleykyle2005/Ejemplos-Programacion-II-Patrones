using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Chain_Responsability
{
    internal class ManejadorSolicitudLectura: ManejadorSolicitudBase
    {
        public override void ManejarSolicitud(string solicitud)
        {
            if(solicitud == "lectura") {

                Console.WriteLine("Manejando solicitud");
                LeerDatos();
            }
            else
            {
                base.ManejarSolicitud (solicitud);
            }
           
        }

        private void LeerDatos()
        {
            Console.WriteLine("Datos leidos");
        }


    }
}

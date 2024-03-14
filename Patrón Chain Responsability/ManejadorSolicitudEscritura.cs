using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Chain_Responsability
{
    internal class ManejadorSolicitudEscritura: ManejadorSolicitudBase
    {
        public override void ManejarSolicitud(string solicitud)
        {
            if (solicitud == "escritura")
            {

                Console.WriteLine("Manejando solicitud de escritura");
                EscribirDatos();
            }
            else
            {
                base.ManejarSolicitud(solicitud);
            }
        }

        public void EscribirDatos()
        {
            Console.WriteLine("Datos escritos en el archivo");
        }
    }
}

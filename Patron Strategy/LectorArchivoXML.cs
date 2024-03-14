using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Strategy
{
    internal class LectorArchivoXML : IlectorArchivo
    {
        public string leer(string rutaArchivo)
        {
            //Lógica para leer un archivo de texto
            string Contenido;
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                Contenido = reader.ReadToEnd();
            }
            return Contenido;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class DecoradorLogger: DecoradorLectorDatos  
    {


        public DecoradorLogger(ILectorDatos lectorDatos): base(lectorDatos) {
        
        }

        public override string LeerDatos()
        {
            Console.WriteLine("Registrando operación");
            return base.LeerDatos();
        }
    }
}

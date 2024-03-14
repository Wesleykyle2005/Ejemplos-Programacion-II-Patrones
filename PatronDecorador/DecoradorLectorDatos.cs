using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public abstract class DecoradorLectorDatos:ILectorDatos
    {
        protected ILectorDatos _lectorDatos;



        public  DecoradorLectorDatos(ILectorDatos lectordatos)
        {
            _lectorDatos = lectordatos;
        }


        public virtual string LeerDatos()
        {
            return _lectorDatos.LeerDatos();
        }
    }

    
}

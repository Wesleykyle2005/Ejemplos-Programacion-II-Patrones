using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorStreamReader : IlectorDatos
    {



        private StreamReader _streamReader;

        public AdaptadorStreamReader( StreamReader streamReader )
        {
            _streamReader = streamReader;
        }
        public string leer()
        {
            return _streamReader.ReadLine();
        }
    }
}

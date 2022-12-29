using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._ModificadoresDeAcceso
{
    internal class ClasePublicaEjemplo
    {
        public string PruebaAccesoPublico { get; set; }

        private string PruebaAccesoPrivate { get; set; }

        public ClasePublicaEjemplo()
        {

        }

        public ClasePublicaEjemplo(string mensaje)
        {
            PruebaAccesoPrivate = mensaje;   
        }
    }

}

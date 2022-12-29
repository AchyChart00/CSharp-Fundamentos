using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._ClaseAbstracta.Piezas
{
    internal abstract class Pieza
    {

        public abstract decimal Area();
        protected abstract decimal Perimetro();

        public bool EjemploMetodo()
        {
            return false;
        }

        public int ValorNatural = 1;
    }
}

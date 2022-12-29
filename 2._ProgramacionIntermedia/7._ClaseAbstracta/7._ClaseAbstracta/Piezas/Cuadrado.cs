using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._ClaseAbstracta.Piezas
{
    internal class Cuadrado : Pieza
    {
        readonly decimal Lado;

        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public override decimal Area()
        {
            return Lado * Lado;
        }

        protected override decimal Perimetro()
        {
            return Lado * 4;
        }

    }
}

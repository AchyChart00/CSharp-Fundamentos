using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._ClaseAbstracta.Triangulos
{
    internal abstract class TrianguloBase
    {
        public abstract decimal Perimetro();

        public double CalcularAreaConHipotenusa(int lado, int hipotenusa)
        {
            double ladoB = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2));
            return lado * ladoB / 2;
        }

    }
}

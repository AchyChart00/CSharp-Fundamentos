using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Interfaces.Interfaces
{
    internal class Cuadrado : IPizza
    {
        public decimal Lado { get; private set; }
        public Cuadrado(decimal lado) { Lado = lado; }

        //La interfaz pide que agregue estos dos métodos
        public decimal Area()
        {
            return Lado * Lado;
        }
        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}

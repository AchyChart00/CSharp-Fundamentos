using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Static
{
    internal class CalculadoraMetodoEstatico
    {
        public static int numeroStatic = 1;
        public int numeroNoStatic = 1;
        public static int Suma(int x, int y)
        {
            return x + y;
        }

        public double Media(List<int> valores)
        {
            return valores.Average();
        }

        public void SumaNumeroStatic(int x)
        {
            numeroStatic += x;    
        }

        public void SumaNumeroNoStatic(int x)
        {
            numeroNoStatic += x;
        }

        public int obtenerNumeroStatic()
        {
            return numeroStatic;    
        }
        public int obtenerNumeroNoStatic()
        {
            return numeroNoStatic;
        }
    }
}

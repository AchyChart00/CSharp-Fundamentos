using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._TupleAndValueTuple
{
    internal class EjemploTuplas
    {
        public void ImprimirMensaje(Tuple<string, string, int> coche)
        {
            Console.WriteLine("Recepción de tupla en un método"); 
            Console.WriteLine($"El coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
        }

        public Tuple<string, string, int> CalcularCoche3()
        {
            return Tuple.Create("Ford", "Fiesta", 1995);
        }

        //Ejemplo ValueTuple
        public (string, string, int) CalcularMoto3()
        {
            return ("Honda", "CBR", 2005);
        }

        public void ImprimirMensajeMoto((string marca, string modelo, int year) moto)
        {
            Console.WriteLine($"Returno desde el metodo para ValueTuple");
            Console.WriteLine($"la moto es una {moto.marca} {moto.modelo} del año {moto.year}");
        }
    }
}

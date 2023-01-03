using System;

namespace _21._TupleAndValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Las tuplas es una estruvctura de datos la cual puede contener múltiples tipos
            //Tuple<T1>
            //Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
            //El límite de elementos es 8, además es inmutable.
            //La tupla es un reference type, por lo que se ubica en el heap

            //Creación de tuplas
            //Existen dos manera de crear tuplas
            //1._Especificar los tipos genéricos en el constructor
            Tuple<string, string, int> coche = new Tuple<string, string, int>("Audi", "A3", 2008);
            //2._Utilizando el método estático Create, el cual nos permite no tener que indicar los tipos de la tupla
            var coche2 = Tuple.Create("Opel", "Astral", 2005);

            //Acceder a las tuplas
            Console.WriteLine($"El primer coche es un {coche.Item1} {coche.Item2} del año {coche.Item3}");
            Console.WriteLine($"El segundo coche es un {coche2.Item1} {coche2.Item2} del año {coche2.Item3}");

            //Pasar tuplas por parametro
            EjemploTuplas ejemploTuplas= new EjemploTuplas();
            ejemploTuplas.ImprimirMensaje(coche);
            ejemploTuplas.CalcularCoche3();

            //ValueTuple
            //Es similar a la tupla pero con menos sintaxis
            (string, string, int) moto1 = ("Derbi", "Variant", 1980);
            Console.WriteLine($"la moto es una {moto1.Item1} {moto1.Item2} del año {moto1.Item3}");
            //También nos permite agregar nombre a los tipos
            (string marca, string modelo, int year) moto2 = ("Derbi", "Variant", 1980);
            Console.WriteLine($"la moto es una {moto2.marca} {moto2.modelo} del año {moto2.year}");

            //Deconstruir un objeto ValueTuple
            //Podemos recibir multiples valores de un ValueTuple y crear multiples variables individuales:
            //Si deseamos descartar una propiedad podemos agregar un guion bajo.
            //(_, _, int yearMoto3) = ejemploTuplas.CalcularMoto3();
            (string marcaMoto3, string modeloMoto3, int yearMoto3) = ejemploTuplas.CalcularMoto3();
            Console.WriteLine($"la moto es una {marcaMoto3} {modeloMoto3} del año {yearMoto3}");


        }
    }
}
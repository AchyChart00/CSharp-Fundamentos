using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._ArraysYListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de array e inicialización con new
            int[] arrayEnteros = new int[] { 1, 2 };
            //Declaración de array e inicialización con new
            int[] arrayEnterosSinNew = { 1, 2 };
            //Declaración de array
            int[] arrayEnterosInd = new int[5] ;
            arrayEnterosInd[0] = 25 ;
            arrayEnterosInd[1] = 50;
            arrayEnterosInd[2] = 89;
            arrayEnterosInd[3] = 63;
            arrayEnterosInd[4] = 45;

            Console.Write("ArrayEnteros");
            for(int arrayEntero = 0;  arrayEntero<2; arrayEntero++)
            {
                Console.WriteLine(arrayEnteros[arrayEntero]);
            }
            Console.Write("ArrayEnterosSinNew");
            for (int arrayEntero = 0; arrayEntero < 2; arrayEntero++)
            {
                Console.WriteLine(arrayEnterosSinNew[arrayEntero]);
            }

            Console.Write("ArrayEnterosSinNew");
            for (int arrayEntero = 0; arrayEntero < 5; arrayEntero++)
            {
                Console.WriteLine(arrayEnterosInd[arrayEntero]);
            }

            //Array multidimencional
            string[,] ciudades = new string[2,3];
            //dar valores a array multidimencional
            ciudades[0, 0] = "Teruel";
            ciudades[0, 1] = "Huesca";
            ciudades[0, 2] = "Zaragoza";
            ciudades[1, 0] = "Valencia";
            ciudades[1, 1] = "castellon";

            //Impresión de array multidimencional

            for (int i=0; i<2; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.WriteLine($"La ciudad es {ciudades[i, j]}");
                }
            }

            //jagged array
            //Los jagged array nos permiten tener arrays multidimencionales donde ocuparemos solo posiciónes de memoria especificos. 
            /*Para este ejemplo el empleado1 ha cambiado de sueldo 2 veces desde que está trabajando, mientras que el empleado2 ha cambiado de sueldo 7 veces.
            Utilizando un array multidimensional, tenemos que crear un array de la siguiente manera decimal[,] arraySueldos = new decimal[2, 7].Este ejemplo, 
            llevado a una lista con 10 mil o 10 millones de registros nos puede causar unos problemas de rendimiento y memoria terribles, ya que para el primer empleado, 
            estamos reservando 4 espacios de memoria que nunca vamos a utilizar. Para evitar este problema, disponemos de los jagged arrays.*/

            string[][] provincias = new string[3][];
            provincias[0] = new string[3];
            provincias[1] = new string[2];
            provincias[2] = new string[4];

            provincias[0][0] = "Huesca";
            provincias[0][1] = "Zaragoza";
            provincias[0][2] = "Teruel";

            provincias[1][0] = "Cáceres";
            provincias[1][1] = "Badajoz";

            provincias[2][0] = "A Coruña";
            provincias[2][1] = "Pontevedra";
            provincias[2][2] = "Ourense";
            provincias[2][3] = "Lugo";

            for (int i = 0; i < provincias.Length; i++)
            {
                System.Console.Write($"registro ({i}): ", i);

                for (int j = 0; j < provincias[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", provincias[i][j], j == (provincias[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }

            //listas en c#
            //Son similares a un tipo array, pero con la ventaja de que son mutables.

            List<string> provinciasList = new List<string>();
            List<string> aragon = new List<string>();

            provinciasList.Add("Teruel");
            provinciasList.Add("Tepotzotlan");
            provinciasList.Add("mexico");

            aragon.Add("CDMX");
            aragon.Add("Veracruz");

            provinciasList.AddRange(aragon);
            foreach (var a in provinciasList)
            {
                Console.WriteLine(a);
            }

            //Métodos de Listas

            string[] stringList;

            //Convertir array a Lista;
            stringList = provinciasList.ToArray();

            //Obtener el número de elementos dentro de una lista
            int numValues = provinciasList.Count();

            Console.WriteLine($"El número de valores dentro de la lista es de {numValues}");

            //obtener el primer y último elemento de nuestra variable tipo List

            string primerPosicion = provinciasList.First();
            string ultimaPosicion = provinciasList.Last();



            //LINQ 
            //Es un lenguaje de consultas a bases de datos, o al menos esa era su intención original. Mientras LINQ se estaba desarrollando se dieron cuenta que una List<T>
            //no deja de ser los resultados que obtenemos sobre hacer una consulta sobre una BBDD así que porqué no aprovecharlo y pode utilizarlo dentro de nuestro código, 
            //no solo para consultar si no para filtrar. 

            IEnumerable<string> ProvinciasFiltradas = provinciasList.Where( p=> p.Contains("i"));
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Provincias filtradas con LINQ");
            foreach (var a in ProvinciasFiltradas)
            {
                Console.WriteLine(a);
            }

            //Limpiar una lista 

            provinciasList.Clear();

        }
    }
}

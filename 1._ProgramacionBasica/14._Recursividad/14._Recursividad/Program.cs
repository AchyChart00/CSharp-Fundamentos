using System.Security.Cryptography.X509Certificates;

namespace _14._Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //¿Qué es recursividad?
            //Es un concepto que se indica cuando un método se llama a si mismo. Cuando creamos un método recursivo
            //debemos tener en cuenta que este tiene que terminar por lo que dentro del método debemos asegurarnos
            //de que no se está llamando así mismo todo el rato. Lo que quiere decir que el ciclo debe de ser finito.
            int numero = 10;
            int PrimerNumero = FactorialNumero(numero);
            Console.WriteLine(PrimerNumero);


            //Factorial de un número con for
            int i, resultado = 1;
            for (i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine(resultado);
        }

        public static int FactorialNumero(int numero)
        {
            Console.WriteLine(numero);
            if (numero == 0) return 1;
            int result = numero * FactorialNumero(numero - 1);
            Console.WriteLine(result);
            return result;
        }
    }
}
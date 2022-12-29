namespace SentenciasCondicionalesYLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Sentencia IF-else");
            int A = 5;
            int B = 10;
            //sentencia If else
            if (A < B)
            {
                Console.WriteLine("A es menor que B");

            }
            else
            {
                Console.WriteLine("A no es menor que B");
            }
            //Operador ternario
            //A < B ? Console.WriteLine("A es menor que B") : Console.WriteLine("A no es menor que B");

            //switch case

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Switch Case");
            string mes = "enero";

            switch (mes)
            {
                case "enero":
                    Console.WriteLine("Enero tiene 31 días");
                    break;
                case "febrero":
                    Console.WriteLine("Febrero tiene 28 días");
                    break;
                default:
                    Console.WriteLine("mes no encontrado");
                    break;
            }

            //Loops

            //Bucle For
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Bucle For");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }

            //Bucle While
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine($"Iteración en While {contador}");
                contador++;
            }

            //Bucle do-while
            int contadorDoWhile = 0;
            do
            {
                Console.WriteLine($"Iteración en Do-While {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile<10);


            int[] numbers = { 1, 3, 4, 5, 6, 7, 5, 34, 76 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"Iteración en foreach {number}");
            }

        }
    }
}
using System.Drawing;

namespace _3._EjercicicioTema1YTema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("1._Números Pares");
                Console.WriteLine("2._Números Perfectos");
                Console.WriteLine("3._Name Loop");
                Console.WriteLine("4._Salir");
                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        numerosPares();
                        break;
                    case 2:
                        numeroPerfecto();
                        break;
                    case 3:
                        nombreLoop();
                        break;
                    case 4:
                        Console.WriteLine("Usted a salido del programa");
                        break;
                    default: Console.WriteLine("No. no valido");
                        break;

                }
            } while (valor != 4);
            



        }

        public static void numerosPares()
        {
            //Primer ejercicio
            Console.WriteLine("Introduce un número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"Número par {num1}");
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine($"Número par {num2}");
            }
        }

        public static void numeroPerfecto()
        {
            //Segundo Ejercicio: números perfectos
            Console.WriteLine("Introduce un número y te dire si es un número perfecto");
            int isNumPerfect = int.Parse(Console.ReadLine());
            int aux = 1;
            int prueba = 0;
            int sum = 0;
            string respIsNum = "";
            for (int i = 0; i < isNumPerfect; i++)
            {
                prueba = i * aux;
                if (prueba % 2 == 0)
                {
                    sum += prueba;
                }
            }

            if (sum == isNumPerfect)
            {
                Console.WriteLine($"{isNumPerfect} es un número perfecto");
            }
            else { Console.WriteLine($"{isNumPerfect} no es un número perfecto"); }
        }

        public static void nombreLoop()
        {
            //Tercer ejercicio
            int condicion = 0;
            do
            {
                Console.WriteLine("Introduce el nombre de NetMentor");
                string nombre = Console.ReadLine();
                if (nombre.Equals("NetMentor"))
                {
                    condicion = 1;
                }
                else
                {
                    Console.WriteLine("Escribe NetMentor");
                }
            } while (condicion == 0);
        }
    }
}
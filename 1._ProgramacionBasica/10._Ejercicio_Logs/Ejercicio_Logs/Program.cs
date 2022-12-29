using System.Globalization;

namespace Ejercicio_Logs
{
    internal class Program
    {
        static string path = @"E:\FullStack\CSharp\CShapCurso\Ejercicio_Logs\Ejercicio_Logs\EjercicioLog.txt";
        static void Main(string[] args)
        {
            string salir;
            do
            {

                /*Console.WriteLine("Introduce día del mes");
                string diaMes = Console.ReadLine();
                Console.WriteLine("Introduce el mes");
                string mes = Console.ReadLine();
                Console.WriteLine("Introduce año");
                int anio = int.Parse(Console.ReadLine());*/

                Console.WriteLine("Introduce una fecha en formato yyyyMMdd");
                string fechaIntroducida = Console.ReadLine();
                var fecha = DateTime.ParseExact(fechaIntroducida, "yyyyMMdd", new CultureInfo("es-ES"));


                Console.WriteLine($"Fecha del Log: {fecha.DayOfWeek}, {fecha.Day}, de {fecha.ToString("MMMM")} de {fecha.Year}");
                string log = $"Fecha del Log: {fecha.DayOfWeek}, {fecha.Day}, de {fecha.ToString("MMMM")} de {fecha.Year}";

                Console.WriteLine("Desea Salir? yes, no");
                salir = Console.ReadLine();

                EscribirLog(log);
                Console.WriteLine(salir.Equals('y'));

            } while (salir.Equals("yes") == false);
        }

        public static void EscribirLog(string mensaje)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) { }
            }

            File.AppendAllLines(path, new List<string> { mensaje});
        }


    }
}
namespace _10._TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un tipo Anonimo es una lcase que no tiene nombre, lo cual quiere decir que no tenemos esa clase como tal en el código. La gran mayoría de las veces, 
            //utilizaremos tipo anónimos cuando realizamos queries
            //Para crear un tipo anonimo lo único que necesitamos es utilizar la palabra reservada new 
            var equipo = new { Nombre = "Real Betis", Ligas = 1 };

            string nombreEquipo = equipo.Nombre;
            string nombreToString = equipo.ToString();  

            Console.WriteLine(nombreEquipo);
            Console.WriteLine(nombreToString);

            //Enviar un tipo anónimo como parámetro
            //Enviar tipos anónimos no es una buena práctica que se deba hacer. 
            Console.WriteLine(test(equipo));
        }

        public static string test(dynamic equipo)
        {
            var t = equipo.Nombre;
            return t;
        }
    }
}
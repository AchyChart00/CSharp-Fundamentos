using System.Text;

namespace _5._CaracteresYCadenasTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo Char
            char caracter = 'A';
            Console.WriteLine($"Caracter {caracter}");

            //Tipo String

            string test = "Jacob Sánchez";
            Console.WriteLine($"Mi nombre es : {test}");

            //arreglo de caracteres
            char[] name = { 'N', 'E', 'T' };
            string stringName = new string( name );
            Console.WriteLine($"Arreglo de caracteres:  ${stringName}");

            //concatenación de dos variables
            string nombre1 = "JACOB";
            string nombre2 = "Sánchez";

            //Concatenación de strings
            var nombreConcatenado = nombre1 + nombre2;
            //interpolación de strings en c#
            Console.WriteLine($"Nombre concatenado : {nombreConcatenado}");

            //Formatear un string
            Console.WriteLine(string.Format("La temperatura actual es {0}°C", 15));

            //StringBuilder
            //Cuando creamos variables string son imutables, lo que significa que una vez se le asigna el valor este no puede cambiar. Con stringbuilder podemos mejorar el redimiento de nuestros strings

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hola Mundo");
            Console.WriteLine($"mensaje de StringBuilder: {sb.ToString()}");

        }
    }
}
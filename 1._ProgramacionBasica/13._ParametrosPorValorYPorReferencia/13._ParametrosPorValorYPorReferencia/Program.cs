namespace _13._ParametrosPorValorYPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parámetros por valor
            //Cuando tenemos un método le pasamos un parámetro, en verdad no estasmos mandando ese parámetro, estasmos mandando una copia de este, lo que significa, 
            //que fuera del método, el valor de la variable seguira siendo el mismo. Incluso si modificamos su valor internamente.
            int valorActual = 10;

            Actualizar(valorActual);
            Console.WriteLine($"El valor es: {valorActual}");

            Console.ReadKey();  
        }

        public static void Actualizar(int valor)
        {
            valor += 5;
            Console.WriteLine($"El valor en el método es : {valor}");
        }
    }
}
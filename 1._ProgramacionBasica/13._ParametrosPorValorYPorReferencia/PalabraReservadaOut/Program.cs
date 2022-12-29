namespace PalabraReservadaOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palabra reservada OUT
            //significa que la asignación de la variable está dentro del método al que se llama. No es necesario inicializar el valor de la variable, aunque si debemos instanciarla.
            int valorActual;
            ActualizarOut(out valorActual);
            Console.WriteLine($"El valor es:  {valorActual}");
            Console.ReadKey();
        }

        //public static void ActualizarOut(in int valor) También es posible evitar que se modifique el valor en el método con la palabra reservada in
        public static void ActualizarOut(out int valor)
        {
            valor = 13;
        }
    }
}
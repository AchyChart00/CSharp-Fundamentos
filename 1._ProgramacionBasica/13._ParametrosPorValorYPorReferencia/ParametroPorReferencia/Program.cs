namespace ParametroPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palabra Reservada REF
            //Utilizar la palabra reservada ref signifca que vas a pasar el valor por referencia a un método, lo que implica que el valor va a cambiar dentro del método, Además,
            //si deseamos utilizar ref la variable tiene que estar inicializada con anterioridad. 
            //Debemos de indicar en el método así como en la llamada del método que vamos a pasar un valor por referencia.

            int valorActual = 10;

            ActualizarRef(ref valorActual);
            Console.WriteLine($"El valor actual es: {valorActual}");
            Console.ReadKey();

        }

        public static void ActualizarRef(ref int valor)
        {
            valor += 2;
        }
    }
}
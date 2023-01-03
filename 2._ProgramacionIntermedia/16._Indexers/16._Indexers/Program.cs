namespace _16._Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Propiedad que nos permite trabajar con un objeto como si fuera un array
            /*[Modificador_acceso][tipo_return] this[index]
             {
                get{ return x[index]}
                set{x[index] = value;}
             }
             */

            EjemploIndexer ej = new EjemploIndexer();
            ej[0] = 1;
            int valor = ej[0];
            Console.WriteLine(valor);
        }
    }
}
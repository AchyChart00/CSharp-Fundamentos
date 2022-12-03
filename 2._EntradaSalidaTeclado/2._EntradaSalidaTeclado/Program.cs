namespace _2._EntradaSalidaTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número");
            int inTeclado = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro número");
            int inNum2 = int.Parse(Console.ReadLine());

            int suma = inTeclado + inNum2;
            Console.WriteLine($"El resultado de la suma es de {suma}");

            //Colocamos ReadKey para que se detenga el código hasta que presionamos una tecla.
            Console.ReadKey();
        }
    }
}
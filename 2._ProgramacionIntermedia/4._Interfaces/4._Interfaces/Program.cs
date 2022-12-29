using _4._Interfaces.Interfaces;
using _4._Interfaces.NewFolder;

namespace _4._Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pizza puede instanciar nuestras dos clases
            IPizza cuadrado = new Cuadrado(5);
            IPizza trianguloRectangulo = new TrianguloRectangulo(5,3);

            EjemploRepetidoMetodo metodoRepeditoEjemplo = new EjemploRepetidoMetodo();

            Console.WriteLine($"El área del cuadrado es {cuadrado.Area()}");
            Console.WriteLine($"El perímetro del cuadrdo es {cuadrado.Perimetro()}");

            Console.WriteLine($"El área del triángulo es {trianguloRectangulo.Area()}");
            Console.WriteLine($"El perímetro del triángulo es {trianguloRectangulo.Perimetro()}");
        }
    }
}
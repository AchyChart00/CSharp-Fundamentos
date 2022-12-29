using _7._ClaseAbstracta.Piezas;
using _7._ClaseAbstracta.Triangulos;

namespace _7._ClaseAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract se utiliza para indicar que los miembros de cada clase deben de ser implementados en las clases que derivan de ellas.
            //una clase abstracta no puede ser instanciada
            //las clases abstractas si pueden tener modificadores de acceeso

            //Principales diferencias con las interfaces

            //Podemos utilizar modificadores de acceso
            //Con interfaces podemos utilizar multiples interfaces. Mientras que con las clases abastractas solo se puede implementar una.
            //En una clase abstracta podemos incluir un constructor
            //Al poder incluir miembros no abstractos podemos incluir una implementación por defecto

            Cuadrado cuadrado = new Cuadrado(3);
            Escaleno escaleno = new Escaleno();
            Acutangulo acutangulo= new Acutangulo();

            escaleno.CalcularAreaConHipotenusa(1,5);
            acutangulo.CalcularAreaConHipotenusa(1,7);
        }
    }
}
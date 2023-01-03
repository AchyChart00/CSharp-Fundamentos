using System.Security.Cryptography.X509Certificates;

namespace _1._Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delegados
            //Es una referencia a un método
            //Cuando definimos un delegado estamos apuntando a un método
            //<modificador_acceso> delegate <tipo_returno> <nombre> (< parametros >[])
            // public delegate void ImprimirDelegado(string value){}

            EjemploDelegado ejemplo= new EjemploDelegado();
            ejemplo.EjemploDelegate();

            //Los delegados pueden funcíonar también con generics
            EjemploDelegadoGeneric ejemploGeneric = new EjemploDelegadoGeneric();
            ejemploGeneric.EjemploDelegate();

            //Delegate Action<T>
            //Es un tipo de delegado que apunta a un método que devuelve void, ya que action siempre devuelve void, pero puede contener de 0 a 16 parámetros
            DelegateAction delegadoAction = new DelegateAction();
            delegadoAction.EjemploDelegate();

            //Delegate action anónimos
            DelegateActionAnonimo delegadoActionAnonimo = new DelegateActionAnonimo();
            delegadoActionAnonimo.EjemploDelegate();

            //Delegados Func<in T, outTResult>
            //Similar al anterior, acepta de 1 a 16 parámetros y los tipos son genéricos. Con la diferencia de que en este caso, Func debe de devolver un valor y el último
            //tipo que se le asigna a Func es el tipo de retorno
            //En otras palabras, Func<int, string> es una función que recibe un int y devuelve un string
            Func<int, string> resultado = v => $"El resultado es {v}";
            Console.WriteLine(resultado(5));

            Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
            int valor = multiplicacion(3, 2);
            Console.WriteLine(valor);

            //Delegado Predicate<T>
            //Similar a los dos anteriores, en este caso, un predicate SIEMPRE devuelve un boolean. Por ejemplo Predicate<int> recibe un int y devuelve un boolean
            Predicate<int> mayorDeEdad = e => e >= 18;
            bool esMayorDeEdad = mayorDeEdad(10);
            Console.WriteLine(esMayorDeEdad);



        }
    }
}
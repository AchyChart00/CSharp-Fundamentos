namespace _15._Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generics es una funcionalidad que nos permite  crear código reusable entre multiples entidades
            //Cuando creamos código genero lo hacemos compatible con cualquier tipo de dato y por ello, seguro ante diferentes tipos
            
            //Uso de una clase Genérica
            OperationResult<Car> optResultCar = new OperationResult<Car>();
            OperationResult<Persona> optResultPerson = new OperationResult<Persona>();

            //Tambien se tiene la capacidad de condicionar los tipos
       /*     public interface IExample { }
        public class Example : IExample { }

        public class EjemploGeneric<T>
        where T : struct //tipo valor 
        where T : class // tipo referencia
        Where T : new() //constructor sin parametros
        Where T : IExample //Interfaz concreta
        Where T : Example //una clase concreta
        {

        }*/

    }
    }
}
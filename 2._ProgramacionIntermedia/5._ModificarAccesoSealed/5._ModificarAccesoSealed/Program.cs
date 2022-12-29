using System.Security.Cryptography.X509Certificates;

namespace _5._ModificarAccesoSealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sealed
            //Una sealed class o clase sellada es aquella de la cual no podemos heredar. Lo que quiere decir que no podemos implementar en otras clases para tener acceso a sus miembros.

            Moto moto = new Moto();
            Moto.ArrancarAuto();
        }

    }
    class Vehiculo
    {
        //Código
        public virtual void ArrancarAuto()
        {

        }
    }

    sealed class Coche : Vehiculo
    {
        //Nos dara error al tratar de derivar(hererdar) la clase Coche
        //class Furgoneta : Coche { }
        //class Furgon : Coche { }
        //class Turismo : Coche { }

        //Podemos incluir individualmente a cada método sealed, con esto ya no sera posible sobreescribir los métodos. 
        public  override void ArrancarAuto()
        {
            Console.WriteLine("Usted esta arrancando el auto");
        }
    }

    class Motoneta : Vehiculo
    {
        public sealed override void ArrancarAuto()
        {
            Console.WriteLine("Usted esta arrancando el Motoneta");
        }
    }

    class Moto : Motoneta
    {
        //Código

        //De esta forma el metodo no va a tener permitido sobre escribir el método
        //public override void ArrancarAuto()
        public static void ArrancarAuto()
        {
            int num = 5 + 5;
            Console.WriteLine($"Usted esta arrancando la Moto {num}");
        }

    }
}
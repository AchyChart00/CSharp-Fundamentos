using System.Security.Cryptography.X509Certificates;

namespace _9._POOyClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia de una clase
            Moto kawasaki = new Moto();
            //dar valores 
            kawasaki.Marca = "kawasaki";
            kawasaki.Modelo = "KX";
            kawasaki.NumeroRuedas = 4;
            kawasaki.VelocidadMaxima = 320;
            kawasaki.Piloto.Nacionalidad = "MEX";


            Console.WriteLine(kawasaki.Arrancar());
            Console.WriteLine(kawasaki.Acelerar());
            Console.WriteLine(kawasaki.ToString());

            //segunda moto 
            Moto suzuki= new Moto("Suzuki", "RX");
            Moto motoItalike = new Moto(210,2);
        }
    }
}
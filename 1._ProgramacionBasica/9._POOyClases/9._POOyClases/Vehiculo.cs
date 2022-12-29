using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._POOyClases
{
    internal class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo() { }   

        public Vehiculo(decimal velocidadMaxima, int NumeroRuedas)
        {
            VelocidadMaxima = velocidadMaxima;
            NumeroRuedas = NumeroRuedas;
        }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual string Acelerar()
        {
            return "El vehículo esta acelerando";
        }
        public virtual string Arrancar()
        {
            return "El vehículo esta encendiendo";
        }


    }
}

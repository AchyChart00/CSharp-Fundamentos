using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._POOyClases
{
    internal class Moto : Vehiculo
    {
        public Motorista Piloto { get; set; }

        public Moto() {
            Piloto = new Motorista(); 
            base.VelocidadMaxima = 320;
            base.NumeroRuedas= 2;
        }
        //sobrecarga de constructor
        public Moto(decimal velocidadMaxima, int numeroRudas)
        {
            Piloto = new Motorista();
            base.VelocidadMaxima= velocidadMaxima;
            base.NumeroRuedas= numeroRudas; 
        }

        public Moto(string marca, string modelo)
        {
            Piloto = new Motorista();
            base.Marca= marca;
            base.Modelo= modelo;     
        }

        public override string Acelerar()
        {
            return "La moto esta acelerando";
        }
        public override string Arrancar()
        {
            return "La moto esta encendiendo";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Marca: {this.Marca}\n");
            sb.Append($"Modelo: {this.Modelo}\n");
            sb.Append($"Número de ruedas: {this.NumeroRuedas}\n");
            sb.Append($"Velocidad Máxima: {this.VelocidadMaxima}\n");
            sb.Append($"Nacionalidad Piloto: {this.Piloto.Nacionalidad}");

            return sb.ToString();   
        }
    }
}

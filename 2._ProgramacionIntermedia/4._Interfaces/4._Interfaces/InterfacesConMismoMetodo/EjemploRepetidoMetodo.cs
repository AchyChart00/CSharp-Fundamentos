using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Interfaces.NewFolder
{
    internal class EjemploRepetidoMetodo : InterfazPrueba1, InterfazPrueba2
    {
        public EjemploRepetidoMetodo() { }

        void InterfazPrueba1.MetodoRepetido() { }
        void InterfazPrueba2.MetodoRepetido() { }
    }
}

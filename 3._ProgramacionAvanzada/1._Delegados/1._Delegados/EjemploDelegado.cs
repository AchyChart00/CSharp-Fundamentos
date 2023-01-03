using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Delegados
{
    //asignación de delegado
    public delegate void ImprimirDelegado(string value);
    internal class EjemploDelegado
    {
        private void Imprimir(string valor)
        {
            Console.WriteLine(valor);   
        }
        public void EjemploDelegate()
        {
            //declaración
            ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);

            //invocación
            imprimirDelegado("Texto de ejemplo en el delegado");
        }

    }
}

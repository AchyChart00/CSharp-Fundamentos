using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Delegados
{
    internal class DelegateActionAnonimo
    {
        private void Imprimir(string valor)
        {
            Console.WriteLine(valor);
        }

        public void EjemploDelegate()
        {
            //Declaración
            Action<string> imprimirDelegado = delegate(string valor)
            {
                Console.WriteLine(valor);   
            };

            //invocación
            imprimirDelegado("texto de ejemplo");
        }
    }
}

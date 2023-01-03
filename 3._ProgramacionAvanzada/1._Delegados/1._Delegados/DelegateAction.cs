using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Delegados
{
    internal class DelegateAction
    {

            private void Imprimir(string valor)
            {
                Console.WriteLine(valor);
            }

            public void EjemploDelegate()
            {
                //Declaración delegado Action
                Action<string> imprimirDelegado = Imprimir;

                //invocación
                imprimirDelegado("texto de ejemplo");
            }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _12._CrearExcepciones
{
    class FacturaDiferenteClienteException :  Exception
    {
        public FacturaDiferenteClienteException(string message) : base(message)
        {
            Console.WriteLine( message);
            Util.EnviarEmailAlerta("Intento Hackeo", message);
        }
    }
}

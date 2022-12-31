using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._ExtensionMethods
{
    internal  static class StringExtensions
    {
        //un extension method nos permite extender la funcionalidad de un objeto o tipo con métodos estáticos. 
        //Hay dos condiciones
        // el método tiene que ser estático
        //debemos incluir la palabra reservada this en el primer parámetro
        public static string PrimeraMayuscula(this string fraseInicial)
        {
            char primeraLetra = char.ToUpper(fraseInicial[0]);
            string RestoDeFrase = fraseInicial.Substring(1);    
            return primeraLetra+ RestoDeFrase;  
        }
    }
}

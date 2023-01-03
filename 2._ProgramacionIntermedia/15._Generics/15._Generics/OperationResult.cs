using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Generics
{
    //Condicionar la clase
    //internal class OperationResult<T> where T : class
    /*where T : struct //tipo valor 
        where T : class // tipo referencia
        Where T : new () //constructor sin parametros
        Where T : IExample //Interfaz concreta
        Where T : Example //una clase concreta*/
    internal class OperationResult
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public T Response { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(T obj)
        {
            Response = obj;
        }
    }
}

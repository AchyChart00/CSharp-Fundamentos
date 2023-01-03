using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Generics
{
    internal class OperationResultPersona
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public Persona Persona { get; set; }

        public OperationResultPersona()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(Persona pers)
        {
            Persona = pers;
        }
    }
}

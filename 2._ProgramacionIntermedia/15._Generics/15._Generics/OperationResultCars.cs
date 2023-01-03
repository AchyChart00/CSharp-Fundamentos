using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _15._Generics
{
    internal class OperationResultCars
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public Car Coche { get; set; }

        public OperationResultCars()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(Car coche)
        {
            Coche = coche;
        }
    }
}

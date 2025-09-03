using BasicCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Classes
{
    public class Operation : IOperation
    {
        private readonly Dictionary<char, IEquetion> operations;

        public Operation() { 
        
            operations = new Dictionary<char, IEquetion>();
        }

        public IEquetion checkContainOperation(char operation)
        {
            if (operations.ContainsKey(operation))
            {
                return operations[operation];
            }
            else
            {
                IEquetion newOperation = Helper.checkOperation(operation);
                operations.Add(operation, newOperation);
                return newOperation;
            }
        }
    }
}

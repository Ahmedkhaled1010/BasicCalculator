using BasicCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Classes
{
    public class Calculator : ICalculator
    {
        private readonly Operation operations;
        public Calculator()
        {
            operations = new Operation();
        }
        public double Calculate(double a, double b, char sympol)
        {
            IEquetion operation = operations.checkContainOperation(sympol);
            return operation.Execute(a, b);
        }
    }
}

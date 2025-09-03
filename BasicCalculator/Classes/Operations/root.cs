using BasicCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Classes.Operations
{
    public class root : IEquetion
    {
        public char Operation => '√';

        public double Execute(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }
    }
   
}

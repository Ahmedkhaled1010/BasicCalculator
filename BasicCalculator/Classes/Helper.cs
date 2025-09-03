using BasicCalculator.Classes.Operations;
using BasicCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Classes
{
    public class Helper 
    {
        public static IEquetion checkOperation(char operation)
        {
            switch(operation)
            {

                case '+':
                    return new Addition();
                case '-':
                    return new Subtraction();
                case '*':
                    return new Multiplication();
                case '/':
                    return new Division();
                default:
                    throw new InvalidOperationException("Operation not supported");
                }
            }
    }
}

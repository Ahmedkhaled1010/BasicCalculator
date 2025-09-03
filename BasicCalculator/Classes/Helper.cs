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

        public static void displayCalculator()
        {
            Console.WriteLine("Hello! Welcome To Basic Calculator");
            Console.WriteLine("Now we Support Basic Operation Like (+ , - , * , / , ^ , % , √ )");
            Console.WriteLine("Let's start if you Want to Finish Press '='");
            try
            {
                First();
            }
            catch(DivideByZeroException e)
            {
                resetCalculator(e);
            }
            catch(InvalidOperationException e)
            {
                resetCalculator(e);
            }
        }
        public static void First()
        {

            while (true)
            {
                Console.WriteLine("Please Enter The Number or Exit");
                var input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }

                double.TryParse(input, out double res);
                result(res);
            }


        }

        public static void result(double res)
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                Console.WriteLine("Enter operation (+, -, *, / , ^ , % , √ or =): ");
                Console.WriteLine(" If You Want Use √ , Press '?'");
                char sympol = Console.ReadLine()[0];
                if (sympol == '=')
                {
                    Console.WriteLine($"Final Result = {res}");
                    resetCalculator(null);
                    break;
                }
                Console.WriteLine("Please Enter The Number");
                double.TryParse(Console.ReadLine(), out double num);



                res = calculator.Calculate(res, num, sympol);
                Console.WriteLine(res);



            }
        }

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
                case '^':
                    return new Power();
                case '%':
                    return new Modulo();
                case '?':
                    return new root();
                default:
                    throw new InvalidOperationException("Operation not supported");
                }
            }
        public static void resetCalculator(Exception e)
        {
            Console.Clear();
            if (e is not null)
            {
                Console.WriteLine(e.Message);

            }

            displayCalculator();
        }
        }
}

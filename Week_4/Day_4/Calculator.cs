
using System;

namespace Hands_on
{
     class CalculatorApp
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    internal class Calculator
    {
        static void Main(string[] args)
        {
            CalculatorApp calculator = new CalculatorApp();

            int addResult = calculator.Add(10, 15);
            int subResult = calculator.Subtract(10, 5);

            Console.WriteLine("Addition = " + addResult);
            Console.WriteLine("Subtraction = " + subResult);
        }
    }
}

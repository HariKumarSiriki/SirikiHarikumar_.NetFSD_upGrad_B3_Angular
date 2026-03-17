using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public void Divide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Operation succesfully completed ");
            }
        }
    }
}

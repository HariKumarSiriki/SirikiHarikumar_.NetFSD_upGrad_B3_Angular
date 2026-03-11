using System;

class Problem2
{
    static void Main()
    {


        Console.Write("Enter First Number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Operator (+ - * /): ");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero not allowed");
                }
                else
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }

        Console.ReadLine();
    }
}

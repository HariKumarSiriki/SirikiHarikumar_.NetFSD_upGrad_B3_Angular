using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.Write("Enter Numerator: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Enter Denominator: ");
        int den = int.Parse(Console.ReadLine());

        c.Divide(num, den);

        Console.WriteLine("Program continues...");
        Console.ReadLine();
    }
}
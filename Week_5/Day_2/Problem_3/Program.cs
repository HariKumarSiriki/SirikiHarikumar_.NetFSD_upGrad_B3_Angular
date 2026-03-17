using ConsoleApp1;
using System;


class Program
{

    static void Main()
    {
        Console.Write("Enter Balance: ");
        double bal = double.Parse(Console.ReadLine());

        Console.Write("Enter Withdraw Amount: ");
        double amt = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(bal);

        try
        {
            account.Withdraw(amt);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }

        Console.ReadLine();
    }
}
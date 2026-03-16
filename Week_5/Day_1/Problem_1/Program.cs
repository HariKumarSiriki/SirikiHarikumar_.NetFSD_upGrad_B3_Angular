using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("3779847", 4000);

            bankAccount.Deposit(100);
            bankAccount.Withdraw(300);

            Console.ReadLine();
        }
    }
}

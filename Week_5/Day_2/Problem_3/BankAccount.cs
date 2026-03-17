using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // BankAccount Class
    class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
            }

            balance = balance - amount;
            Console.WriteLine("Withdrawal successful. Remaining balance: " + balance);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


    class BankAccount
    {
        private string _accNo;
        private double _balance;

        public string AccountNumber
        {
            get { return _accNo; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public BankAccount(string accNo, double balance)
        {
            _accNo = accNo;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount");
                return;
            }

            _balance += amount;
            Console.WriteLine($"Current Balance: {_balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Current Balance: {_balance}");
        }
    }
}


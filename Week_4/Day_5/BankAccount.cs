using System;

namespace Examples
{
    internal class BankAccount
    {
        private decimal _balance;
        private string _accountNumber;
        private string _accountHolder;

        public decimal Balance
        {
            get { return _balance; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Account holder name cannot be empty.");
                }
                else
                {
                    _accountHolder = value;
                }
            }
        }

        public BankAccount(string accountNumber, string accountHolder, decimal balance = 0)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;

            Console.WriteLine("Welcome to SBI Bank");
            Console.WriteLine($"Account created for {_accountHolder}");
            Console.WriteLine($"Current Balance : INR {_balance.ToString("F2")}");
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            _balance += amount;

            Console.WriteLine("Bank Message:");
            Console.WriteLine($"INR {amount.ToString("F2")} credited successfully.");
            Console.WriteLine($"Available Balance : INR {_balance.ToString("F2")}");
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return false;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Bank Message: Insufficient Balance.");
                return false;
            }

            _balance -= amount;

            Console.WriteLine("Bank Message:");
            Console.WriteLine($"INR {amount.ToString("F2")} debited successfully.");
            Console.WriteLine($"Available Balance : INR {_balance.ToString("F2")}");

            return true;
        }
    }
}
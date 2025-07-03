using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message): base(message) { }
    }

    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string holder, double balance)
        {
            AccountHolder = holder;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be more than 0");

            Balance += amount;
            Console.WriteLine($"Deposited {amount}/-. Current balance: {Balance}/-");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive");
          
            if (amount > Balance)
                throw new InsufficientBalanceException("No enough balance");

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}/-, Remaining balance: {Balance}/-");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {Balance}/-");
        }
    } 
    class Program1
    {
        static void Main()
        {
            BankAccount acc = new BankAccount("Nishitha", 2000);

            try
            {
                Console.WriteLine($"Welcome, {acc.AccountHolder}");
                Console.WriteLine("Enter transaction type D for Deposit, W for Withdraw: ");
                string type = Console.ReadLine();

                Console.Write("Enter amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (type == "D" || type == "d")
                    acc.Deposit(amount);
                else if (type == "W" || type == "w")
                    acc.Withdraw(amount);
                else
                    Console.WriteLine("Invalid transaction type");

                acc.ShowBalance();
                
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}

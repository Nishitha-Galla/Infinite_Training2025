using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Inheritance:

//1.Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
//D->Deposit
//W->Withdrawal
//-write a function that updates the balance depending upon the transaction type
//	-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance
//  function  Credit(int amount) 
//	-If transaction type is withdraw call the function debit by passing the amount to be withdrawn and update the balance
//  Debit(int amt) function
//- Pass the other information like Account no, customer name, acc type through constructor
//-write and call the show data method to display the values.

namespace Assignment3
{

    class Accounts //parent
    {
        protected int account_no;
        protected string customer_name;
        protected string account_type;
        protected string transaction_type;
        protected int amount;
        protected int balance;

        public Accounts(int acc_no, string name, string acc_type)
        {
            account_no = acc_no;
            customer_name = name;
            account_type = acc_type;
            balance = 0;

        }

        protected void Credit(int amt) //deposit
        {
            balance += amt;
            Console.WriteLine($"{amt} amount deposited");
        }

        protected void Debit(int amt) //withdraw
        {
            if (amt > balance)
            {
                Console.WriteLine("No enough balance");
            }
            else
            {
                balance -= amt;
                Console.WriteLine($"{amt} amount withdrawn");
            }
        }

        public virtual void Transaction(int type, int amt)
        {
            amount = amt;

            if (type == 1)
            {
                transaction_type = "Deposit";
                Credit(amount);
            }
            else if (type == 0)
            {
                transaction_type = "Withdraw";
                Debit(amount);
            }
            else
            {
                transaction_type = "Invalid";
                Console.WriteLine("Invalid option. Enter 1 to deposit or 0 to withdraw");
            }

        }

        //acc details
        public virtual void ShowData()
        {
            Console.WriteLine("\n===============Account Details=================");
            Console.WriteLine($"Account number: {account_no}");
            Console.WriteLine($"Customer name: {customer_name}");
            Console.WriteLine($"Account type: {account_type}");
            Console.WriteLine($"Transaction type: {transaction_type}");
            Console.WriteLine($"Transaction amount: {amount}/-");
            Console.WriteLine($"Current balance: {balance}/-");
        }
    }
    class CustomerAccount : Accounts //child
    {
        public CustomerAccount(int acc_no, string name, string acc_type) : base(acc_no, name, acc_type)
        {

        }
    }
    class Program1
    {
        static void Main()
        {
            CustomerAccount acc = new CustomerAccount(22, "Nishitha", "Savings");

            Console.Write("Enter 1 for deposit, 0 for withdrawal: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter amount: ");
            int amt = int.Parse(Console.ReadLine());

            acc.Transaction(choice, amt);
            acc.ShowData();

            Console.Read();
        }
    }
}






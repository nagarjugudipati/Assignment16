//using System;


//namespace ConAppAsssignment_16
//{
//    public class BankAccount
//    {
//        private static int accountCounter = 1000;
//        public int AccountNumber { get; }
//        public string AccountHolderName { get; }
//        private double Balance { get; set; }

//        public BankAccount(string accountHolderName)
//        {
//            AccountNumber = GenerateAccountNumber();
//            AccountHolderName = accountHolderName;
//            Balance = 0;
//        }

//        private static int GenerateAccountNumber()
//        {
//            return ++accountCounter;
//        }

//        public void Deposit(double amount)
//        {
//            if (amount <= 0)
//            {
//                throw new ArgumentException("Deposit amount must be greater than zero.");
//            }

//            Balance += amount;
//        }
//        public void Withdraw(double amount)
//        {
//            if (amount <= 0)
//            {
//                throw new ArgumentException("Withdrawal amount must be greater than zero.");
//            }

//            if (amount > Balance)
//            {
//                throw new InvalidOperationException("Insufficient funds.");
//            }

//            Balance -= amount;
//        }
//        public double GetBalance()
//        {
//            return Balance;
//        }

//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16
{
    public class BankAccount
    {
        private readonly int AccountNumber;
        public int A_no
        {
            get { return AccountNumber; }
        }
        private string AccountHolderName;
        public string A_name
        {
            get { return AccountHolderName; }
            set { AccountHolderName = value; }
        }
        private double Balance;



        public BankAccount(string name, int num)
        {
            this.AccountHolderName = name;
            this.AccountNumber = num;
            this.Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}.\nNew balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}.\nNew balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

    }
}

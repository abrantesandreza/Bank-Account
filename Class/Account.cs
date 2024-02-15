using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_Account.Enum;

namespace Bank_Account.Class
{
    public class Account
    {
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }

        public Account(AccountType accountType, double balance, double credit, string name) 
        {
            AccountType = accountType;
            Balance = balance;
            Credit = credit;
            Name = name;
        }

        public bool Withdraw(double withdrawalAmount)
        {
            if (Balance - withdrawalAmount < (Credit *-1))
            {
                Console.WriteLine("Insufficient funds!");
            }

            Balance -= withdrawalAmount;
            Console.WriteLine($"Everything is well! You're current balance amount, {Name}, is ${Balance}.");

            return true;
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;

            Console.WriteLine($"Everything is well! You're current balance amount,{Name} , is ${Balance}.");
        }

        public void Transfer(double transferAmount, Account destinationAccount)
        {
            if(Withdraw(transferAmount))
            {
                destinationAccount.Deposit(transferAmount);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Type of the account: " + AccountType + " | ";
            retorno += "Name: " + Name + " | ";
            retorno += "Balance: $" + Balance + ",00 | ";
            retorno += "Credit: $" + Credit + ",00";

            return retorno;
        }
    }
}

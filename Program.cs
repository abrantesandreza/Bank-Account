using System;
using Bank_Account.Class;
using Bank_Account.Enum;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        //ListAccounts();
                        break;
                    case "2":
                        //AddNewAccount();
                        break;
                    case "3":
                        //Transfer();
                        break;
                    case "4":
                        //WithDraw();
                        break;
                    case "5":
                        //Deposit();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }

            Console.WriteLine("Thank you for using our services!");
            Console.WriteLine();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Your account is initializing...");
            Console.WriteLine("Enter the following options wanted:");

            Console.WriteLine("1 - List all the accounts");
            Console.WriteLine("2 - Add new account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Close program");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return userOption;
        }

    }
}

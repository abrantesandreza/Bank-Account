using System;
using Bank_Account.Class;
using Bank_Account.Enum;

namespace Bank_Account
{
    class Program
    {
        static List<Account> accountList = new List<Account>();
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
                        AddNewAccount();
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

        private static void AddNewAccount()
        {
            Console.WriteLine(" | You chose add new account | ");
            Console.WriteLine();

            Console.WriteLine("Enter 1 to Fisical Person or 2 to Legal Person: ");
            int userEntryAccountType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the client's name: ");
            string userEntryName = Console.ReadLine();

            Console.WriteLine("Enter the inicial balance: ");
            double userEntryBalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the credit: ");
            double userEntryCredit = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountType: (AccountType)userEntryAccountType,
                                            balance: userEntryBalance, 
                                            credit: userEntryCredit,
                                            name: userEntryName);
            
            accountList.Add(newAccount);

            Console.WriteLine();
            Console.WriteLine("You just added a new account successfully!");
            Console.WriteLine();   

            Console.WriteLine("Check the new account >> \n" + newAccount);
            Console.ReadLine();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Your account is initializing...");
            Console.WriteLine();

            Console.WriteLine("Enter one of the following options wanted:");
            Console.WriteLine();

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

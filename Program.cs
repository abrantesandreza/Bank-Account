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
                        ListAccounts();
                        break;
                    case "2":
                        AddNewAccount();
                        break;
                    case "3":
                        Transfer();
                        break;
                    case "4":
                        WithDraw();
                        break;
                    case "5":
                        Deposit();
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

        private static void Transfer()
        {
            Console.WriteLine(" | You chose >> Transfer | ");
            Console.WriteLine();

            Console.Write("Enter the number of the source account: ");
            int indexSourceAccount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the destination account: ");
            int indexDestinationAccount = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to be transfered: ");
            double transferAmount = double.Parse(Console.ReadLine());

            accountList[indexSourceAccount - 1].Transfer(transferAmount, accountList[indexDestinationAccount - 1]);
        }

        private static void Deposit()
        {
            Console.WriteLine(" | You chose >> Deposit | ");
            Console.WriteLine();

            Console.Write("Enter the number of the account: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to be deposited: ");
            double depositAmount = double.Parse(Console.ReadLine());

            accountList[accountNumber - 1].Deposit(depositAmount);

            Console.WriteLine();
            Console.WriteLine("Your deposit was successfully executed!");
            Console.ReadLine();
        }

        private static void WithDraw()
        {
            Console.WriteLine(" | You chose >> WithDraw | ");
            Console.WriteLine();

            Console.Write("Enter the number of the account: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount to be withdrawed: ");
            double withdrawAmount = double.Parse(Console.ReadLine());

            accountList[accountNumber - 1].Withdraw(withdrawAmount);
        }

        private static void AddNewAccount()
        {
            Console.WriteLine(" | You chose >> Add new account | ");
            Console.WriteLine();

            Console.Write("Enter 1 to Fisical Person or 2 to Legal Person: ");
            int userEntryAccountType = int.Parse(Console.ReadLine());

            Console.Write("Enter the client's name: ");
            string userEntryName = Console.ReadLine();

            Console.Write("Enter the inicial balance: ");
            double userEntryBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter the credit: ");
            double userEntryCredit = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountType: (AccountType)userEntryAccountType,
                                            balance: userEntryBalance,
                                            credit: userEntryCredit,
                                            name: userEntryName);
            
            accountList.Add(newAccount);

            Console.WriteLine();
            Console.WriteLine("You just added a new account successfully!");
            Console.WriteLine();

            Console.WriteLine("New account >> \n" + newAccount);
            Console.WriteLine();

            Console.WriteLine("Enter to continue...");
            Console.ReadLine();
        }

        private static void ListAccounts()
        {
            Console.WriteLine(" | You chose >> List all accounts | ");
            Console.WriteLine();

            if (accountList.Count == 0) 
            {
                Console.WriteLine("Zero accounts registered.");
                Console.WriteLine();
                
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();

                return;
            }

            for (int i = 0; i < accountList.Count; i++)
            {
                Account account = accountList[i];
                Console.Write($"#{i + 1} - ");
                Console.WriteLine(account);
            }

            Console.WriteLine();
            Console.WriteLine("Enter to continue...");
            Console.ReadLine();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to your home account!");
            Console.WriteLine();

            Console.WriteLine("Enter one of the following options wanted:");
            Console.WriteLine();

            Console.WriteLine("1 - List all the accounts");
            Console.WriteLine("2 - Add new account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - Clear screen");
            Console.WriteLine("X - Close program");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return userOption;
        }
    }
}

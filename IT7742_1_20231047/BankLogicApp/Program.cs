using System;
using BankLogicApp;

namespace BankLogicApp
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Bank Manager Console App \n");

            // create customer
            var cust = new Customer(101, "Arun Patel", "arun.patel@bankmail.co.nz", staff: true);

            // create accounts
            var everyday = new EverydayAccount(11, 450.00);
            var invest = new InvestmentAccount(22, 620.00, rate: 4.0, failedFee: 10);
            var omni = new OmniAccount(33, 1320.43, rate: 4.0, overdraft: 100, failedFee: 10);

            var accounts = new Dictionary<int, Account>()
            {
                {1, everyday},
                {2, invest},
                {3, omni}
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an account to work with:");
                Console.WriteLine("1 - Everyday account");
                Console.WriteLine("2 - Investment account");
                Console.WriteLine("3 - Omni account");
                Console.WriteLine("4 - Show all account info");
                Console.WriteLine("0 - Exit");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                if (choice == "0")
                {
                    running = false;
                    break;
                }

                if (choice == "4")
                {
                    Console.WriteLine("\n--- Account Overview ---");
                    foreach (var acc in accounts.Values)
                        Console.WriteLine(acc.AccountInfo());
                    continue;
                }

                if (!int.TryParse(choice, out int num) || !accounts.ContainsKey(num))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                var a = accounts[num];
                Console.WriteLine($"\nNow using {a.GetType().Name} (ID: {a.GetAccountID()})");
                Console.WriteLine("a = Deposit | b = Withdraw | c = Add Interest | d = Info | x = Back");
                Console.Write("Action: ");
                var act = Console.ReadLine()?.Trim().ToLower();

                switch (act)
                {
                    case "a":
                        Console.Write("Enter deposit amount: ");
                        if (double.TryParse(Console.ReadLine(), out double dep))
                        {
                            a.Deposit(dep);
                            Console.WriteLine(a.LastMessage());
                        }
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case "b":
                        Console.Write("Enter withdrawal amount: ");
                        if (double.TryParse(Console.ReadLine(), out double w))
                        {
                            a.Withdraw(w, cust.IsStaff());
                            Console.WriteLine(a.LastMessage());
                        }
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case "c":
                        a.CalculateInterest();
                        Console.WriteLine(a.LastMessage());
                        break;

                    case "d":
                        Console.WriteLine(a.AccountInfo());
                        break;

                    case "x":
                        Console.WriteLine("Back to main menu...");
                        break;

                    default:
                        Console.WriteLine("Unknown action.");
                        break;
                }
            }

            Console.WriteLine("\nSession ended. Thank you!");
            Console.ResetColor();
        }
    }
}

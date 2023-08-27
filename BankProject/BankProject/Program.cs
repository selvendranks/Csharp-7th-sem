using System;

namespace BankProject
{
    using System;

    namespace BankApp
    {
        class Program
        {
            static string username = "system";
            static string password = "manager";

            static void Main(string[] args)
            {
                Console.WriteLine("************** REC Bank *****************");
                Console.WriteLine("::Login Page::");

                Console.Write("Username: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Login failed. Exiting...");
                }
            }

            static void MainMenu()
            {
                while (true)
                {
                    Console.WriteLine("\n:::Main menu:::");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Entered choise 1");
                            CustomersMenu();
                            break;
                        case 2:
                            Console.WriteLine("Entered choise 2");
                            AccountsMenu();
                            break;
                        case 3:
                            Console.WriteLine("Entered choise 3");
                            break;
                        case 4:
                            Console.WriteLine("Entered choise 4");
                            break;
                        case 5:
                            Console.WriteLine("Entered choise 5");
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void CustomersMenu()
            {
                while (true)
                {
                    Console.WriteLine("\n:::Customers menu:::");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Delete Customer");
                    Console.WriteLine("3. Update Customer");
                    Console.WriteLine("4. View Customers");
                    Console.WriteLine("0. Back to Main Menu");

                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Entered choise 1");
                            break;
                        case 2:
                            Console.WriteLine("Entered choise 2");
                            break;
                        case 3:
                            Console.WriteLine("Entered choise 3");
                            break;
                        case 4:
                            Console.WriteLine("Entered choise 4");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void AccountsMenu()
            {
                while (true)
                {
                    Console.WriteLine("\n:::Accounts menu:::");
                    Console.WriteLine("1. Add Account");
                    Console.WriteLine("2. Delete Account");
                    Console.WriteLine("3. Update Account");
                    Console.WriteLine("4. View Accounts");
                    Console.WriteLine("0. Back to Main Menu");

                    Console.Write("Enter choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Entered choise 1");
                            break;
                        case 2:
                            Console.WriteLine("Entered choise 2");
                            break;
                        case 3:
                            Console.WriteLine("Entered choise 3");
                            break;
                        case 4:
                            Console.WriteLine("Entered choise 4");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }

}

using System;

namespace ImportStorageSystem.Services
{
    public class MainMenu
    {
        static StorageOperator storageOperator = new StorageOperator();
        public void Show()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("======= IMPORT STORAGE SYSTEM =======");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Register New Operator");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("=====================================");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine()?.Trim() ?? string.Empty;
                if(option == "1")
                {
                    Console.Clear();
                    Login login = new Login();
                    login.Start(storageOperator);
                }
                else if(option == "2")
                {
                    RegisterForm register = new RegisterForm();
                    register.Show(storageOperator);
                }
                else if(option == "3")
                {
                    Console.WriteLine("\nClosing System. Goodbye!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nInvalid option! Press any key to try again...");
                    Console.ReadKey();

                }

            }
        }
    }
}
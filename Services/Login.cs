using System;
using ImportStorageSystem.Services;

namespace ImportStorageSystem.Services
{
    public class Login
    {
        public void Start(StorageOperator operatorList)
        {
            //string userName = "admin";
            //string password = "1234";

            Console.WriteLine("==== Import Storage System Login ====");
            
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Press (Enter) to make Login or type (Exit) to close de System");
                string exitChoice = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
                
                if(exitChoice == "exit")
                {
                    Console.WriteLine("The System has been Closed, goodbye");
                    break;
                }
                
                Console.Write("Login: ");
                string inputUser = Console.ReadLine()?.Trim() ?? string.Empty;

                Console.Write("Password: ");
                string inputPassword = Console.ReadLine()?.Trim() ?? string.Empty;

                operatorList.ValidateOperator(inputUser, inputPassword);
                
                i = -1;

                if( i == 2)
                {
                    Console.WriteLine(" You reached the 3rd try! Please try again later.");
                }
            }
        }
    }
}
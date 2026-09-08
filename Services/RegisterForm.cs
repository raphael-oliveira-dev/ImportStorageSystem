using System;
using ImportStorageSystem.Models;
using ImportStorageSystem.Services;

namespace ImportStorageSystem.Services
{
    public class RegisterForm
    {
        public void Show(StorageOperator storageOperator)
        {
            Console.Clear();
            Console.WriteLine("==== REGISTER NEW OPERATOR ====");
            Console.Write("Name: "); 
            string newUserName = Console.ReadLine()?.Trim() ?? string.Empty;
            Console.Write("Password: ");
            string newPassword = Console.ReadLine()?.Trim() ?? string.Empty;


            Console.WriteLine($"\nUser '{newUserName}' prepared for registration.");
            Console.WriteLine("Press any key to return to Main Menu...");
            Console.ReadKey();

            OperatorModel newOperator = new OperatorModel();
            newOperator.Name = newUserName;
            newOperator.Password = newPassword;

            storageOperator.AddOperator(newOperator);
        }
    }
}
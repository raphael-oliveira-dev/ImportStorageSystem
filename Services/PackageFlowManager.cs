using System;
using ImportStorageSystem.Models;

namespace ImportStorageSystem.Services
{
    public class PackageFlowManager
    {
        public void Start() // verificar se ja existe esse nome e lembrar de criar o metodo la no Login.cs
        {
            Package package = new Package();
            PackageCounter packageCounter = new PackageCounter();
            
            Console.WriteLine("========Import Storage System========");
            
            Console.Write("Current Location: ");
            string currentLocation = Console.ReadLine()?.Trim() ?? string.Empty;
            
            int packageSum = 0;
            while(true)
            {
                Console.Write("ID: ");
                string inputId = Console.ReadLine()?.Trim() ?? string.Empty;
                Console.Write("WEIGHT: ");
                decimal inputWeight = decimal.Parse(Console.ReadLine()?.Trim() ?? "0");
                //Console.WriteLine(++packageSum);

                package.CurrentLocal = currentLocation; 
                package.Id = inputId;
                package.Weight = inputWeight;

                packageCounter.CurrentTime = DateTime.Now;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"ID: {package.Id}\nORIGEM: {package.OrigemLocal}\nDESTINATION: {package.FinalLocal}");

                decimal newCalculatedWeight = packageCounter.CalculateWeight(inputWeight);

                Console.WriteLine("=======================================");
                Console.WriteLine($"TOTAL WEIGHT: {newCalculatedWeight}");
                Console.WriteLine($"TOTAL PACKAGES: {++packageSum}");
                Console.WriteLine($"CURRENT LOCATION: {package.CurrentLocal}");
                Console.WriteLine($"DATE/TIME: {packageCounter.CurrentTime}");
                Console.WriteLine("_______________________________________");
                
                Console.Write("Do you Want to ADD another package (yes/no)?");
                string exitChoice = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
                
                if( exitChoice == "n" || exitChoice == "no")
                {
                    Console.WriteLine("Closing Package Flow, Goodbye!");
                    break;
                }
                if(packageCounter.TotalWeight > 200)
                {
                    Console.WriteLine("The Pallet is overloaded!!! ");
                    Console.WriteLine($"The Total Weight now is {newCalculatedWeight}Kg.");
                    Console.WriteLine("Please Remove the Last package!!!");
                    break;
                }
            }
        }
    }
}
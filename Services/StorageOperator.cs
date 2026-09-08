using System;
using System.Collections.Generic;
using ImportStorageSystem.Models;

namespace ImportStorageSystem.Services
{
    public class StorageOperator
    {
        private List<OperatorModel> registeredOperators = new List<OperatorModel>();

        //method
        public void AddOperator(OperatorModel newOperator)
        {
            registeredOperators.Add(newOperator);
            Console.WriteLine($"Operator {newOperator.Name} registered successfully!");
        }

        public void ValidateOperator(string nameLogin, string passwordLogin)
        {
            foreach(OperatorModel op in registeredOperators)
            {
                if(nameLogin == op.Name && passwordLogin == op.Password)
                {
                    Console.WriteLine($"The Operator {op.Name} & The password: {op.Password} exists on our List of <T>");
                    PackageFlowManager packageFlowManager = new PackageFlowManager();
                    packageFlowManager.PackageFlow(op.Name);
                }

                
            }
            
        }
    }
    

}
using System;
using ImportStorageSystem.Services;

namespace ImportStorageSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            PackageFlowManager packageFlowManager = new PackageFlowManager();
            packageFlowManager.Start();
        }

    }
}
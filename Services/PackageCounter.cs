using System;

namespace ImportStorageSystem.Services
{
    public class PackageCounter
    {
        public decimal TotalWeight { get; set; }
        public DateTime CurrentTime { get; set; }                
        
        public decimal CalculateWeight(decimal addWeight)
        {
            TotalWeight += addWeight; // same thing than TotalWeight = TotalWeight + addWeight
            return TotalWeight;
        }
    }
}

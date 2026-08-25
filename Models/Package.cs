using System;

namespace ImportStorageSystem.Models
{
    public class Package
    {
        public string Id { get; set;} = string.Empty;
        public string OrigemLocal = "Canada";
        public string FinalLocal = "Brazil";
        public string CurrentLocal { get; set;} = string.Empty;
        public decimal Weight { get; set;}

    }
    
}
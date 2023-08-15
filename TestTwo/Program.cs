using System;

namespace Nullhandling
{
    class Address
    {
        public string? Building;
        public string? Street;
        public string? City; 
        public string? Region;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
        public  static void Main (string[] args) 
        {
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = null;
            address.Region = null;

        }
   
    }
}
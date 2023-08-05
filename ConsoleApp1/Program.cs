// The project is entirely meant to create a fully deployable desktop app

using System;

namespace IMS
{
   
    class Program
    {
        public const string DayofSendingBill = "Monday";
        public int CustomerId;
        public string FirstName;
        public string LastName;
        //public keyword means it can be accessed by an outside class
       
    }
    class NewCustomer
    {
        static void main(string[] args)
        {
            //Using the Program odject fields in our New customer object by calling it 
            var customer1 = new Program();
            customer1.FirstName = "John";
            Console.WriteLine(customer1.FirstName);
        }
        
    }
}
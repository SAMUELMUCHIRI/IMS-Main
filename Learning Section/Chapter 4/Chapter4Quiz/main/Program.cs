using System;
using System.Collections.Generic;
using PrimeFactorCalculator;

namespace NTest
{
    public class CTest
    {
 
         static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to find its prime factors:");
           
            //string input1 =Console.ReadLine();
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            // Use 'input' as an integer here
            string primeFactors = ClPrimeFactorCalculator.PrimeFactors(input);
            Console.WriteLine($"Prime factors of {input} are: {primeFactors}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
                     

            
        }
        
    }
}

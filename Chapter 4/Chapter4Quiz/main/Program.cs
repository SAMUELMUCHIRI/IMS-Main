using System;
using System.Collections.Generic;

namespace PrimeFactorCalculator
{
    public class PrimeFactorCalculator
    {
        public static string PrimeFactors(int number)
        {
            if (number <= 1)
                return "No prime factors";

            List<int> factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return string.Join(" x ", factors);
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to find its prime factors:");
           
            //string input1 =Console.ReadLine();
            int input = int.Parse(Console.ReadLine());

            string primeFactors = PrimeFactors(input);

            Console.WriteLine($"Prime factors of {input} are: {primeFactors}");
        }
        
    }
}

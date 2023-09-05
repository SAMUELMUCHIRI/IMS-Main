using System;
using PrimeFactorCalculator;

namespace PrimeFactorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to find its prime factors:");
            int input = int.Parse(Console.ReadLine());

            string primeFactors = PrimeFactorCalculator.PrimeFactors(input);

            Console.WriteLine($"Prime factors of {input} are: {primeFactors}");
        }
    }
}

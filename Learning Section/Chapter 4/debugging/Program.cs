using System;

using static System.Console;
namespace Debugging
    {
        class Program
        {
            static double Add(double a, double b)
                {
                return a + b; // deliberate bug!
                }
                static void Main(string[] args)
                {
                Console.WriteLine("Enter a number to add");
                string input=Console.ReadLine();
                
                try
                { 
                    double result;
                    double.TryParse(input , out result);
                    double a = 4.5; // or use var
                    double b = result;
                    double answer = Add(a, b);
                    WriteLine($"{a} + {b} = {answer}");
                    ReadLine(); // wait for user to press ENTER

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");

                }
               
                }
        }
    }
                    
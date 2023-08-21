using System;
using static System.Console;


namespace Chapter3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Controlling Flow and  Converting Types */
            // Chapter 3
            // unary operators
            
            int a = 5;
            //int b = a++;
            int c = ++a;
            double  e = 11.0;
            int f = 3;
            // WriteLine($" in postfix a is {a} , b is {b} ");
            //WriteLine($"in prefix it becomes : a is {a}, c is {c}");
            Console.WriteLine($"e is {e}, f is {f}");
            Console.WriteLine($"e x f = {e*f}");
            WriteLine($"e + f = {e+f}");
            WriteLine($"e - f = {e-f}");
            WriteLine($"e / f = {e/f}");
            WriteLine($"e % f = {e%f}");
            // Continuation
        }

    }
}
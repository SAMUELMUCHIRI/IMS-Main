using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    public static class castPrgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("number");
            string a = ReadLine();
            //also testing catching errors
            try
            {
            int b = int.Parse(a); // an int can be safely cast into a double
            WriteLine(b);
            }
           catch (OverflowException)
            {
            WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
            WriteLine("The age you entered is not a valid number format.");
            }
            Console.WriteLine("Correct parsing");
        }
    }
}
using System;
using static System.Console;
namespace BooleanOper
{
    public class BooleanOper
    {
        public static void Main(String[] args)
        {
            bool a = true;
            bool b = false;
            WriteLine($" And  |   a  |   b   ");
            WriteLine($"  a   |{a&a,-5} |{a&b,-5}");
            WriteLine($"  b   |{b&a,-5} |{b&b,-5}");
            WriteLine($" Or   |   a  |   b   ");
            WriteLine($"  a   |{a|a,-5} |{a|b,-5}");
            WriteLine($"  b   |{b|a,-5} |{b|b,-5}");
            WriteLine($" Xor  |   a  |   b   ");
            WriteLine($"  a   |{a^a,-5} |{a^b,-5}");
            WriteLine($"  b   |{b^a,-5} |{b^b,-5}");
            WriteLine($" a && Dostuff() = {a&&Dostuff()}");
            WriteLine($" b && Dostuff() = {b&&Dostuff()}");//compiler does not excecute it as it is already registered as false
            



            

        }
        private static bool Dostuff()
        {
            Console.WriteLine("am going to do stuff");
            return true;
        }
    }

}
using System;

namespace bitwiseBinary
{
    public class bitwiseBinary
    {
        public static void Main(string[] args)
        {
            int a = 10; // 0000 1010
            int b = 6; // 0000 0110
            Console.WriteLine($"a  &  b = {a&b}");
            Console.WriteLine($"a  |  b = {a|b}");
            Console.WriteLine($"a  ^  b = {a^b}");
            Console.WriteLine($"a <<  3 = {a<<3}");
            Console.WriteLine($"a  *  8 = {a*8}");
            Console.WriteLine($"b >>  1 = {b>>1}");
        }

    }
}
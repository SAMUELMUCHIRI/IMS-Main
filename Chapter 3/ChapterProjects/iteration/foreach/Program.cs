using System;
using static System.Console;

namespace ForeachST
{
    public class Forprogram
    {
        public static void Main(string[] args)
        {
            string[] names = { "Alice", "Barnes", "Charlie"};
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} Characters");
            }
        }
    }
}
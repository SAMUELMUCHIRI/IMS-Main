using System;

namespace Branching
{
    public static class ifStatements
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
             Console.WriteLine("There are no arguments.");
            }
            else if (args.Length == 1)
            {
            Console.WriteLine("There is one argument.");
            }
            else    
            {
                Console.WriteLine("there is more tham one argument");
            }
        }
    }
}
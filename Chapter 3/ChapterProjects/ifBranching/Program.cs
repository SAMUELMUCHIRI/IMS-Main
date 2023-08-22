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
            else
            {
            Console.WriteLine("There is at least one argument.");
            }
        }
    }
}
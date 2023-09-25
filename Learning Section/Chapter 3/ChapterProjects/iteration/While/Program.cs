using System;
using static System.Console;
using System.IO;

namespace IterationWhile
{
    public class    WhileClass
    {
        public static void Main(string[] args)
        {
        int x = 0;
        
        while (x < 100)
        {
        WriteLine(x);
        x=x+10;
        }
        }
    }
}
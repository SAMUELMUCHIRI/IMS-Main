using System;
using static System.Console;
using  System.IO;

namespace ForStatement
{
    public class Program003
    {
        public static void Main(string[] args)
        {
        int j = 0;    
        for (int i =1 ;i<10;i++)
        {

            Console.WriteLine(i);
            j+=i;
        }

        Console.WriteLine(j);

        }
    }
}

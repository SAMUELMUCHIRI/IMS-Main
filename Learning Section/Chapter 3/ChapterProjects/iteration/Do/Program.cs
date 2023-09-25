using System;
using static System.Console;
using  System.IO;

namespace doStatement
{
    public class Program002
    {
        public static void Main(string[] args)
        {
        string password = string.Empty;
        do
        {
            Write("Enter your password: ");
            password = ReadLine();
        }
        while (password != "Pa$$w0rd");

        
        WriteLine("Correct!");

        }
    }
}

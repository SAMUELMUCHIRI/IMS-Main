using System;

namespace Chapter3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            /*Console.Write("Hello Type in your name  ");
            string nameOfUser = Console.ReadLine();
            Console.Write("Whats your age if i may ask?  ");
            string ageOfUser = Console.ReadLine();
            Console.WriteLine("great");
            Console.WriteLine($"Hey {nameOfUser} you look young at {ageOfUser} pleasure to meet you "); */

            //the line below counts the number of arguments written by the user
            Console.WriteLine($"There are {args.Length} arguments.");
            foreach (string arg in args)
            {
                Console.WriteLine($"{count}   {arg}");
                count++;
            }
         

                

        }

    }
}
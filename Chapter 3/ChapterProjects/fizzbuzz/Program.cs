using System;
using static System.Console;


namespace Gfizzbuzz
{
    public class ProgramFizz
    {
        public static void Main(string[] args)
        {
            for (int i = 0;i<101;i++)
            {
                if ((i%10)==0)
                {
                    
                
                if ((i%15)==0)
                {
                    WriteLine("fizzbuzz ,");                    
                }
                else if ((i%5)==0)
                {
                    WriteLine("buzz ,");                    
                }
                else if ((i%3)==0)
                {
                    WriteLine("fizz ,");
                }
                else
                {
                    WriteLine($"{i} ,");
                }
                }
                else
                {
                    
                
                if ((i%15)==0)
                {
                    Write("fizzbuzz ,");                    
                }
                else if ((i%5)==0)
                {
                    Write("buzz ,");                    
                }
                else if ((i%3)==0)
                {
                    Write("fizz ,");
                }
                else
                {
                    Write($"{i} ,");
                }
                }
            }
        }
    }

}
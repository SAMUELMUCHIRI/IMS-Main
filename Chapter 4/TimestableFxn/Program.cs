using System;
using static System.Console;

namespace xTable
{
    public class ProgramTable
    {
        //writing my first function now
        public static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");
            for (int row =1;row<=12 ;row++)   
            {
                WriteLine($"{row} x {number} = {row*number}");

            }
            WriteLine();  
        }
        //the fxn does not return a value
        public static void RunTimesTable()
        {
            WriteLine("ENTER A NUMBER BETWEEN 1 -255");
           string input = ReadLine();
           try
           {
            byte newnumber = byte.Parse(input);
            TimesTable(newnumber);
           }
           catch (Exception ex)
           {
            WriteLine($"{ex.GetType()} says {ex.Message}");                      
            
           }

        }
        //the fxn returns a value of type decimal
        static decimal CalculateTax(decimal amount,string twoLetterRegionCode)
        {
            unchecked
            {
            
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland 
                    rate = 0.08M;
                    break;
                case "DK": // Denmark 
                case "NO": // Norway
                    rate = 0.25M;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2M;
                    break;
                case "HU": // Hungary
                    rate = 0.27M;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0M; break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05M;
                    break;
                case "CA": // California
                    rate = 0.0825M;
                    break;
                default: // most US states 
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }
        }
        //THE FXN does not return a value
        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();
            Write("Enter a two-letter region code: ");
            string region = ReadLine();
            if (decimal.TryParse(amountInText, out decimal amount))
            {
            decimal taxToPay = CalculateTax(amount, region);
            WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
            WriteLine("You did not enter a valid amount!");
            }
        }
        //creating  a fxn that calculates factorials
        static int Factorial(int ONumber)
        {
            int newProduct =1;
            if (ONumber == 0)
            {
                newProduct=0;
            }
            else if (ONumber == 1)
            {
                newProduct=1;                
            }
            else 
            {
                for (int i = 1; i<=ONumber;i++)
                {
                    newProduct *=i;
                }
                
            }
            return newProduct;
        }
        static void GetNum()
        {
            Console.Write("Enter a number to get its factorial  : ");
            string GotenNum = ReadLine();
            try
            {
                int ConvertedNum = int.Parse(GotenNum);
                //Factorial(CalculateTax(ConvertedNum, GotenNum));
                WriteLine("Completed parsing check");
                Console.WriteLine($" {ConvertedNum} ! = {Factorial(ConvertedNum)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }

    
    
        public static void Main(string[] args)
        {
            unchecked
            {
            //RunTimesTable();
            //RunCalculateTax();
            GetNum();
            }

        }
    }
    
}
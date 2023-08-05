using System;

namespace MyNamespace
{
    public class TestOne
    {
        static void Main(string[] args)
        {
            //lesson 101 Manipulating Strings

            string firstfriend = "Johnie";
            string secondfriend = "Maximus";
            Console.WriteLine($"Hello world it's the boys {firstfriend} and {secondfriend}");

            // Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Green;
            //utilizing trim
            string greetings = "     Hello       ";
            string starttrim_Greetings = greetings.TrimStart();
            string endtrim_Greetings = greetings.TrimEnd();
            Console.WriteLine($"{starttrim_Greetings} world it's the boys {firstfriend} and {secondfriend}");
            Console.WriteLine($"{endtrim_Greetings} world it's the boys {firstfriend} and {secondfriend}");
            //utilizing replace 
            string replace_Greetings = greetings.Replace("Hello", "Greetings");
            Console.WriteLine($"{replace_Greetings} world it's the boys {firstfriend} and {secondfriend}");
            //utilizing uppercase and lowercase functions
            string upper_Greetings = replace_Greetings.ToUpper();
            string lower_Greetings = replace_Greetings.ToLower();
            Console.WriteLine($"{upper_Greetings} world it's the boys {firstfriend} and {secondfriend}");
            Console.WriteLine($"{lower_Greetings} world it's the boys {firstfriend} and {secondfriend}");
            // searching for specific word in a string
            string Song_Lyrics = "why am i stressing ,say hello to your neighbour";
            Console.WriteLine(Song_Lyrics.Contains("hello"));
            Console.WriteLine(Song_Lyrics.Contains("greetings"));


            // working with integers
            int a = 2;
            int b = 3;
            int c = 4;
            Console.WriteLine(a+ b + c);    
            Console.WriteLine($"quotient {(a+b) / c}");
            Console.WriteLine($"remainder {(b + c) % a}");
            // integers always produce an integer result
            // to get max and min int values 
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The max value of an integer is {max} and the min value is {min}");
            // overflow and underflow condition in intergers
            int OverMax=max+3;
            int OverMin=min-3;
            Console.WriteLine($"Testing the Conditiov of an overflow that is {OverMax} and the overflow is {OverMin} notice the fact that it Wraps around");

            //double 
            double aa = 19;
            double bb = 23;
            double cc = 8;
            double dd = (aa+bb) / cc;
            double Maxima_Double = double.MaxValue;
            double Minima_Double = double.MinValue;
            Console.WriteLine(dd);
            Console.WriteLine($"the max value of a double is {Maxima_Double} and the minimum value is {Minima_Double}");
            //testing rounding errors in double
            double r4 = 1.0;
            double r5 = 3.0;
            Console.WriteLine(r4/r5);

            decimal d001 = decimal.MaxValue;
            decimal d002 = decimal.MinValue;
            Console.WriteLine($"the decimal max in {d001} and the decimal min is  {d002}");
            decimal r6 = 1.0M;
            decimal r7 = 3.0M;
            Console.WriteLine(r6 / r7);
            double radius = 1.2;
            double Area = Math.PI * radius * radius;
            Console.WriteLine(Area);


        }
    }
}
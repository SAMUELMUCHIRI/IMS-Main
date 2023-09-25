using System;
#nullable disable


// learning aboout enum type
[Flags]
public enum Days
{
 None = 0b_0000_0000, // 0
 Monday = 0b_0000_0001, // 1
 Tuesday = 0b_0000_0010, // 2
 Wednesday = 0b_0000_0100, // 4
 Thursday = 0b_0000_1000, // 8
 Friday = 0b_0001_0000, // 16
 Saturday = 0b_0010_0000, // 32
 Sunday = 0b_0100_0000, // 64
 Weekend = Saturday | Sunday
}

public enum time_day 
{
    Morning = 0,
    Lunch = 1,
    Evening = 2,

}

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
            //Public TestOne
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
            Days Today = Days.Monday;
            time_day watch = time_day.Evening;
            Console.WriteLine($"hello  it's a  {Today} {watch}");
            double loo1 = 0.1;
            double loo2 = 0.2;
            double loo3 =double.Epsilon;
            if (loo1+loo2 == 0.3)
            {
                Console.WriteLine($"{loo1} + {loo2} is equal to 0.3");
            }
            else
            {
                Console.WriteLine($"{loo1} + {loo2} is not equal to 0.3.double epsilon is {loo3}");

            }
            // Working with arrays

            string[] names;
            names = new string[10];
            names[0] = "Robert";
            names[1] = "Sarah";
            names[2] = "Erick";
            names[3] = "Dave";
            names[4] = "Stormzy";
            names[5] = "Jorja";
            names[6] = "Hill";
            names[7] = "Mercy";
            names[8] = "Cate";
            names[9] = "Joan";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Working with object type
            object height0 = 1.9;
            object name0 = "John";
            //note how we have to explicitly define our name variable
            int Length = ((string)name0).Length;
            Console.WriteLine(Length);
          
            // Working with dynamic type
            dynamic height1 = 1.8;
            dynamic name1 = "Ashley";
            int Length1 = name1.Length;
            Console.WriteLine(Length1);

            // working with null type note the question mark ? introduced in c#8.0
            int? count = null;
            Console.WriteLine(count);
            Console.WriteLine(count.GetValueOrDefault());

            //working with formatted strings
           string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);



        }
    }
}
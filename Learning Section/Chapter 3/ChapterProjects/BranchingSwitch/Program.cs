using System;
using static System.Console;
using System.IO;

namespace BranchingSwitch
{
    public class SwitchBranch
    {
        public static void Main(string[] args)
        {
            A_label:
                var number = (new Random()).Next(1, 7);
                WriteLine($"My random number is {number}");
             switch (number)
            {
            case 1:
            WriteLine("One");
            break; // jumps to end of switch statement 
            case 2:
            WriteLine("Two");
            goto case 1;
            case 3:
            case 4:
            WriteLine("Three or four");
            goto case 1;
            case 5:
            // go to sleep for half a second
            System.Threading.Thread.Sleep(500);
            goto A_label;
            default:
            WriteLine("Default"); 
            break;
            } // end of switch statement
        }
    }
}
using System;

namespace Chapter2Project
{
    class Sizes
    {
       
        public  static void Main (string[] args) 
        {
            sbyte sbytemax = sbyte.MaxValue;
            sbyte sbytemin = sbyte.MinValue;
            byte bytemax = byte.MaxValue;
            byte bytemin = byte.MinValue;
            short shortmax = short.MaxValue;
            short shortmin = short.MinValue;
            ushort ushortmax = ushort.MaxValue;
            ushort ushortmin = ushort.MinValue;
            int intmax = int.MaxValue;
            int intmin = int.MinValue;;
            uint uintmax = uint.MaxValue;
            uint uintmin = uint.MinValue;
            long longmax = long.MaxValue;
            long longmin = long.MinValue;
            ulong ulongmax = ulong.MaxValue;
            ulong ulongmin = ulong.MinValue;
            float floatmax = float.MaxValue;
            float floatmin = float.MinValue;
            double doublemax = double.MaxValue;
            double doublemin = double.MinValue;
            decimal decimalmax = decimal.MaxValue;
            decimal decimalmin = decimal.MinValue; 

         
           
               
           String s = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "Type", "Bytes of Memory (s)" , "Min","Max");
           String s1 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "Sbyte", sizeof(sbyte) , sbytemin, sbytemax);
           String s2 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "byte", sizeof(byte) , bytemin, bytemax);
           String s3 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "short", sizeof(short) , shortmin, shortmax);
           String s4 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "ushort", sizeof(ushort) , ushortmin, ushortmax);
           String s5 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "int", sizeof(int) , intmin, intmax);
           String s6 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "uint", sizeof(uint) , uintmin, uintmax);
           String s7 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "long", sizeof(long) , longmin, longmax);
           String s8 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "ulong", sizeof(ulong) , ulongmin, ulongmax);
           String s9 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "float", sizeof(float) , floatmin, floatmax);
           String s10 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "double", sizeof(double) , doublemin, doublemax);
           String s11 = String.Format("{0,-16} {1,-20} {2,30} {3,30 }", "decimal", sizeof(decimal) , decimalmin, decimalmax);
           Console.ForegroundColor = ConsoleColor.Black;
           Console.BackgroundColor = ConsoleColor.White;
           
           Console.WriteLine ("...................................................................................................");
           Console.WriteLine(s);
           Console.WriteLine ("...................................................................................................");
           Console.WriteLine(s1);
           Console.WriteLine (s2);
           Console.WriteLine (s3);
           Console.WriteLine (s4);
           Console.WriteLine (s5);
           Console.WriteLine (s6);
           Console.WriteLine (s7);
           Console.WriteLine (s8);
           Console.WriteLine (s9);
           Console.WriteLine (s10);
           Console.WriteLine (s11);
        
        
        }
   
    }
}
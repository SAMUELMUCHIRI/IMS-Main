
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace Instrumenting
{
     class Program
         {
         static void Main(string[] args)
             {
            // using Trace and Debug Classes
            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(
            File.CreateText("log.txt")));
            // text writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
             Trace.WriteLine("Trace says, I am watching!");
             }
         }
}
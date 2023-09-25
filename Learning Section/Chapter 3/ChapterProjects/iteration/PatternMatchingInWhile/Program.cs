using System;
using static System.Console;
using  System.IO;

namespace fileHandling
{
    public class Program001
    {
        public static void Main(string[] args)
        {
            string path=@"C:\Users\USER\source\repos\IMS-Main\Chapter 3\ChapterProjects\iteration\PatternMatchingInWhile";
            Stream s =File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);
            string message = string.Empty;
            switch (s)
            {
            case FileStream writeableFile when s.CanWrite:
            message = "The stream is a file that I can write to.";
            break;
            case FileStream readOnlyFile:
            message = "The stream is a read-only file.";
            break;
            case MemoryStream ms:
            message = "The stream is a memory address.";
            break;
            default: // always evaluated last despite its current position
            message = "The stream is some other type.";
            break;
            case null:
            message = "The stream is null.";
            break;
            }
            WriteLine(message);

        }
    }
}

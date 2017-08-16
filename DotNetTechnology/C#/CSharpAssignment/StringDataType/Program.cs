using System;

namespace StringDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "karan";
            Console.WriteLine(Name);

            //verbatim literal
            //verbatim literal is a string with an @ prefix, as in @"hello"
            //verbatim literals make escape sequences translate as normal printable characters to enhance readability.

            string path = "C:\\Users\\Karan\\Videos\\C#"; // less readable(Escape sequences in C#)
            Console.WriteLine(path);

            string path1 = @"C:\Users\Karan\Videos\C#"; //verbatim literal it is better readable
            Console.WriteLine(path1);

            Console.ReadKey();
        }
    }
}
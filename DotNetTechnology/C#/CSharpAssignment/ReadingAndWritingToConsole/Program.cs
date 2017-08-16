using System;

namespace ReadingAndWritingToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name");
            string LastName = Console.ReadLine();

            //Most Preferrable for concating variable
            Console.WriteLine("Hello {0} {1}", FirstName, LastName);

            // Console.WriteLine("Hello " + FirstName + " " + LastName);

            Console.ReadKey();
        }
    }
}
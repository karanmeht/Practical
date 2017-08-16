using System;
using System.Linq;

namespace RandomAlphanumericString
{
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("String : {0}", RandomString(8));
                Console.WriteLine("Numberr : {0}", RandomNumber(8));
                Console.WriteLine();
            }
            //Console.WriteLine("String : {0}",RandomString(8));
            //Console.WriteLine("Numberr : {0}", RandomNumber(8));
            Console.ReadKey();
        }
    }
}
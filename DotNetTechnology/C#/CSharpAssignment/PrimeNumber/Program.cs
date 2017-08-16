using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter Positive number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n / 2; ++i)
            {
                // condition for nonprime number
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine(" is a prime number.{0}", n);
            else
                Console.WriteLine(" is not a prime number.{0}", n);
            Console.ReadKey();
        }
    }
}
using System;
using System.Threading;
namespace MultiThreadingConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait 3 Seconds");
            Number.DoTimeConsomingWork();
            Console.Clear();
            Number.DisplayNumber();
            //Number n = new Number();
            //Thread T1 = new Thread(n.DisplayNumber);
            //T1.Start();
            Console.ReadKey();
        }
    }

    public class Number
    {
        public static void DoTimeConsomingWork()
        {
            Thread.Sleep(3000);
        }

        public static void DisplayNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
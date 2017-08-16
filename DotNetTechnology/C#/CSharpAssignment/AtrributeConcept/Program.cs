using System;
using System.Collections.Generic;
namespace AtrributeConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator.Add( 10, 20);
            Calculator.Add(new  List < int >(){ 10,20,30,40,50});
            Console.ReadKey();
        }
    }

    public class Calculator
    {
        [ObsoleteAttribute("use \"Add(List<int> Number)\" Method", true)]
        public static void Add(int FirstNumber, int SecondNumber)
        {
            Console.WriteLine(FirstNumber + SecondNumber);
        }

        public static void Add(List<int> Number)
        {
            int sum = 0;
            foreach(int n in Number)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
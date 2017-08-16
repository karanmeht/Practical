using System;

namespace ArrayUse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is a strongly typed
            int[] ArrayNumber = new int[3];
            // Without new key word
            //int[] ArrayNumber = {10,20,30};
            ArrayNumber[0] = 10;
            ArrayNumber[1] = 11;
            ArrayNumber[2] = 12;
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                Console.WriteLine(ArrayNumber[i]);
            }
            Console.ReadKey();
        }
    }
}
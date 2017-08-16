using System;

namespace MethodOverloading
{
    #region Overloading Concept
    /*
     Method overloading

    function overloading and method overloading terms are used interchangeably.
    method overloading allows a class to have multiple methods with the same name, but, with a different signature. so, in C# functions can be overloaded based on the number, type(int, float etc) and kind (Value,ref or out) of parameters.

    the signature of a method consists of the name of the method and the type, kind (value, reference, or output) and the number of its formal parameters. the signature of a method does not include the return type and the params modifier. so, it is not possible to overload a function, just based on the return type or params modifier.
    */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 10);
            Add(2, 5, 2.5F);

            Console.ReadKey();
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine(FN + SN);
        }

        // method Overloading
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine(FN + SN + TN);
        }

        public static void Add(int FN, int SN, out int TN)
        {
            Console.WriteLine(FN + SN);
            TN = FN + SN;
        }

        public static void Add(int FN, int SN, float TN)
        {
            Console.WriteLine(FN + SN + TN);
        }

        // ERROR
        //public static void Add(int FN, int SN)
        //{
        //    Console.WriteLine(FN + SN);
        //}

        //ERROR
        //public static void Add(int FN, int SN, params int TN)
        //{
        //    Console.WriteLine(FN + SN);
        //}

        //ERROR
        //public static int Add(int FN, int SN, int TN)
        //{

        //}
    }
}
using System;

namespace MethodParameters
{
    class Program
    {
        #region cover topics
        /*
         *  methhod parameters
         *  value parameters
         *  reference parameters
         *  out parameters
         *  parameters arrays
         */
        #endregion

        static void Main(string[] args)
        {
            int i = 10;
            int Sum = 0, Sub = 0;
            AddNumber(i);
            Console.WriteLine(i);

            ChangeValue(ref i);
            Console.WriteLine("\n {0}", i);

            Calculate(20, 10, out Sum, out Sub);
            Console.WriteLine("Sum = {0} sub = {1}", Sum, Sub);

            int[] Number = { 1, 2, 3, 4, 5 };

            ParamMethod();
            ParamMethod(Number);
            ParamMethod(1, 2, 3, 4, 5, 6, 7);
            Console.ReadLine();
        }

        #region value parameters
        // i and j are pointing to different memory locations. operations one variable will not affect the value of the other variable.
        public static void AddNumber(int j)
        {
            j = 101;
        }
        #endregion

        #region reference parameters
        // i and j are pointing to the same memory location. operations one variable will affect the value of the other variable.
        public static void ChangeValue(ref int j)
        {
            j = 101;
        }
        #endregion

        #region out parameters
        // use when you want a method to return more then one value.
        public static void Calculate(int FN, int SN, out int Addition, out int Substraction)
        {
            Addition = FN + SN;
            Substraction = FN - SN;
        }
        #endregion

        #region arrays parameters
        // the params keyword lets you specify a method parameter that taskes a variable number of arguments.
        // you can send a comma-separated list of arguments, or an array or no arguments.
        // params keyword should be last one in a method declaration, and only one params is permitted in a method declaration.

        //  public static void ParamMethod(params int[] Number,params string name) // get error
        //  public static void ParamMethod(params int[] Number, string name) // get error
        //  public static void ParamMethod(int[] Number,params string name) // right formate

        public static void ParamMethod(params int[] Number)
        {
            Console.WriteLine("there are {0} Elements", Number.Length);
            foreach (int n in Number)
            {
                Console.WriteLine(n);
            }
        }
        #endregion
    }
}
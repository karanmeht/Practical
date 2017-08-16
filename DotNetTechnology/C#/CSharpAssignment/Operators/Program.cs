using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List of Operator

            //Assignment operators =
            //Arithmentic operators +,-,*,/,%
            //comparison operators ==,!=,>,<,>=,<=
            //conditional operators &&,||
            //ternary operator ?:
            //null coalescing operators ??
            #endregion

            #region ternary operator

            //here example of ternary operator 
            // it is use to optimize code

            /*
             int Number = 10;
            bool IsNumber;

            if (Number == 10)
                IsNumber = true;
            else
                IsNumber = false;
            Console.WriteLine("number = 10 is {0}", IsNumber);
            */

            int Number = 15;
            bool IsNumber = Number == 10 ? true : false; // ? is true part , : is false part
            Console.WriteLine("number = 10 is {0}", IsNumber);
            #endregion

            Console.ReadKey();
        }
    }
}
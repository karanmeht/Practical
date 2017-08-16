using System;

namespace DelegateConcept
{
    // Delegate is a type safe function pointer
    public delegate void HelloFunctionDelegate(string Message);
    public delegate string Hello1(string Name);

    class Program
    {
        static void Main(string[] args)
        {
            //HelloFunctionDelegate del;
            //del = new HelloFunctionDelegate(Hello);

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello Method invoked");

            Hello1 strName = new Hello1(Name);
            Console.WriteLine(strName("karan"));
            Console.ReadLine();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        public static string Name(string Name)
        {
            return Name;
        }
    }
}
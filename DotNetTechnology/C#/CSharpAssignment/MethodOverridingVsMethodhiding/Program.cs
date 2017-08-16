using System;

namespace MethodOverridingVsMethodhiding
{
    #region Method overriding
    /*
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am Base class print method");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am Derived class print method");
        }
    }
    */
    #endregion

    #region Method hiding
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am Base class print method");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("I am Derived class print method");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass B = new DerivedClass();
            //B.Print();

            DerivedClass D = new DerivedClass();
            //((BaseClass)D).Print(); // type casting
            D.Print();
            Console.ReadKey();
        }
    }
}
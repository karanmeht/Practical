using System;

namespace AbstractConcept
{
    #region Abstract classes
    /*
        the abstract keyword is used to create abstract classes.

        An abstract class is incomplete and hence cannot be instantiated.

        an abstract class can only be used as base class.

        an abstract class cannot be sealed.

        sealed is a keyword. ex. sealed class Customer { }

        an abstract class may contain members(methods,properties,indexers, and events), but not mandatory.

        an abstract class member are private by default.

        A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members.

        an interface can inherit from another interface only and cannot inherit from an abstract class, where as an abstract class can inherit from another abstract class or another interface.

        if a class inherits an abstract class, there are 2 options available for that class
        option1: provide implementation for all the abstract members inherited form the base abstract class.
        option 2 : if the class does not wish to provide implementation for all the abstract members inherited from the abstract class, then the class has to be marked as abstract.

 */
    #endregion

    abstract class Customer
    {
        public abstract void Print();
        public void Print1()
        {
            Console.WriteLine("Abstract Class Print1 Method");
        }
    }
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print1();
            P.Print();
            Console.ReadKey();
        }

        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
using System;

namespace InterfaceConcept
{

    #region Interfaces Concept
    /*
   :: interfaces::

we create interfaces using interface keyword.just like classes interface also contains properties, methods, delegates or events, but only declarations and no implementations.

it is a compile time error to provide implementation for any interface member.

interface members are public by default, and they don't allow explicit access modifiers.

interfaces can't contain fields.

if a class or a struct inherits from an interface, it must provide implementation for all interface members, otherwise, we get a complier error.

A class or a struct can inherit from more than one interface at the same time, but where as, a class can't inherit from more than once class at same time.

interface can inherit from other interface. A class that inherit must provide implementation for all interface members in the entire interface inheritance chain.

we can't create an instance of an interface, but an interface reference variable can point to a derived class object.

 Access modifiers are not allowed on explicitly implemented interface members.

Interface Naming Convention: interface names are prefixed with capital I.
*/
    #endregion

    interface ICustomer1
    {
        void Print();
        void Print1();

        /*
         * Error 
         int id;
         public void Print();
        
        public void Print()
        {

        } 
         */
    }

    interface ICustomer2 : ICustomer1
    {
        void Print();
        void Print2();
    }

    class Customer : ICustomer2
    {
        public  void Print()  //default method  
        {
            Console.WriteLine("ICustomer1 Print Method");
        }

        void ICustomer2.Print() // explicit implementation type
        {
            Console.WriteLine("ICustomer2 Print Method");
        }

        public void Print1()
        {
            Console.WriteLine("Interface Print1 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface Print2 Method");
        }
    }

    sealed class Program
    {
        static void Main(string[] args)
        {
            ICustomer1 Icust = new Customer();
            Icust.Print();
            Customer C = new Customer();
            ((ICustomer2)C).Print();  // explicit calling type
            C.Print();
            C.Print1();
            C.Print2();
            Console.ReadKey();
        }
    }
}
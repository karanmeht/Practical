using System;

namespace InheritanceConcept
{
    #region cover topic
    /*
     * why inheritance
     * advantages of inheritance 
     * inheritance Syntax
     * inheritance concept
     
        why inheritance

pillars of object oriented programming
1)inheritance
2)Encapsulation
3)Abstraction
4)polymorphism

1. inheritance is one of the primary pillars of OOP.
2. it allows code reuse.
3. code reuse can reduce time and errors.


        inheritance syntax
public class ParentClass
{
	//parent class implementation
}

public class DerivedClass : ParentClass
{
	//Derived class implementation
}

1) in this example DerivedClass inherits from ParentClass
2) C# Support only single class inheritance
3) C# support multiple inheritance.
4) Child class is a specilization of base class.
5)base classes are automatically instantiated before derived classes.
6) parent class constructor executes before child class constructor.

     */
    #endregion

    #region other example
    /* 
 public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Class Constructor Called");
    }

    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling Parent class") // base keyword use for access base class members
    {
        Console.WriteLine("Child Class Constructor Called");
    }
}
*/
    #endregion

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Full Name: {0}", FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public int YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public int HourlySalary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ChildClass CC = new ChildClass();

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Mehta";
            FTE.LastName = "Karan";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Karan";
            PTE.LastName = "Mehta";
            PTE.HourlySalary = 5000;
            PTE.PrintFullName();

            Console.ReadKey();
        }
    }
}
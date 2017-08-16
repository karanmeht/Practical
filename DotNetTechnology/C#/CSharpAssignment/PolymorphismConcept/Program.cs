using System;

namespace PolymorphismConcept
{
    #region Polymorphiism concept
    /*
     Polymorphism
polymorphism is one of the primary pillars of OOP.
polymorphism allows you to invoke derived class methods through a base class reference during runtime.
in the base class the method is declared virtual, and in the derived class we override the same method.
the virtual keyword indicates, the method can be overridden in any derived class.
         */
    #endregion

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = " LN";
        public string Email;

        public virtual void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", FirstName + " " + LastName + " - Full Time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", FirstName + " " + LastName + " - Part Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", FirstName + " " + LastName + " - Temporary");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[4];

            emp[0] = new Employee();
            emp[1] = new FullTimeEmployee();
            emp[2] = new PartTimeEmployee();
            emp[3] = new TemporaryEmployee();

            foreach (Employee e in emp)
            {
                e.PrintFullName();
            }
            Console.ReadKey();
        }
    }
}
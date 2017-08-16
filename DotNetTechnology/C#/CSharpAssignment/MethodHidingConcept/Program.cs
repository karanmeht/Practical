using System;

namespace MethodHidingConcept
{
    #region inheritance concepts
    /*
     
     inheritance concepts
use the new keyword to hide a base class member. you will get a compiler warning, if you miss the ney keyword.

different ways to invoke a hidden base class member from derived class
1. use base keyword
2. cast child type to parent type and invoke the hidden member
3. ParentClass PC = new ChildClass()
   pc.Hiddenmethod()
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
        // hiding base class method
        public new void PrintFullName() // "new" keyword to remove worning 
        {
            Console.WriteLine("Full Name: {0}", FirstName + " " + LastName + "- Contractor");
        }
        public int HourlySalary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Mehta";
            FTE.LastName = "Karan";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            //Employee PTE = new PartTimeEmployee();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Karan";
            PTE.LastName = "Mehta";
            PTE.HourlySalary = 5000;
            //((Employee)PTE).PrintFullName();
            PTE.PrintFullName();

            Console.ReadKey();
        }
    }
}
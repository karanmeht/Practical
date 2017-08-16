using System;

namespace ClassConcept
{
    #region Cover topic
    /*
     * what is class
     * purpose of class constructor
     * Overloading class constructor 
     * understanding this keyword
     * Destructors
     */
    #endregion

    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() : this("No First Name Provided", "No First Name Provided")
        {

        }

        // constructor overloading
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName; // this keyword to clarify variable or method is definded in this class
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", _firstName + " " + _lastName);
        }

        //Destructor
        ~Customer()
        {
            //clean up code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.PrintFullName();

            Customer c2 = new Customer("Karan", "Mehta");
            c2.PrintFullName();

            Console.ReadKey();
        }
    }
}

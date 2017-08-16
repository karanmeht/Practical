using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialCustomer Customer = new PartialCustomer();
            Customer.FirstName = "Karan";
            Customer.LastName = "Mehta";
         
            Console.Write( Customer.FullName());
            Console.ReadKey();
        }
    }
}
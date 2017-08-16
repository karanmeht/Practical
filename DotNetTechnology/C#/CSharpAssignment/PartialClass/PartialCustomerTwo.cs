using System;

namespace PartialClass
{
    public partial class PartialCustomer
    {
        partial void Greeting();
        partial void Greeting()
        {
            Console.Write("Welcome ");
        }
        public string FullName()
        {
            Greeting();
            return FirstName + " " + LastName;
        }
    }
}

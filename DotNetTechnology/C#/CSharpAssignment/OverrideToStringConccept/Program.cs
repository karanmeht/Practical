using System;

namespace OverrideMethodsConccept
{
    #region OverrideToStringConccept
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "karan";
            c1.LastName = "Mehta";
            Console.WriteLine(c1.ToString());
            Console.ReadKey();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override string ToString()
        //{
        //    return FirstName + " " + LastName;
        //}
    }
    */
    #endregion

    #region OverrideEqualConccept
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "karan";
            c1.LastName = "Mehta";

            Customer c2 = new Customer();
            c2.FirstName = "karan";
            c2.LastName = "Mehta";

            Customer c3 = c1;
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c3 == c1);
            Console.WriteLine(c1.Equals(c2));

            Console.ReadKey();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Customer))
                return false;
            return FirstName == ((Customer)obj).FirstName && LastName == ((Customer)obj).LastName;
        }
    }
    
    #endregion

    #region Convert ToString and ToString
    /*
class Program
{
    static void Main(string[] args)
    {
        Customer c1 = null;


        Customer c2 = new Customer();
        c2.FirstName = "karan";
        c2.LastName = "Mehta";

        Console.WriteLine(Convert.ToString(c1)); // Null object allowed
        //Console.WriteLine(c1.ToString()); // Null object not allowed
        Console.WriteLine(c2.ToString());

        Console.ReadKey();
    }
}

class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
*/
    #endregion
}
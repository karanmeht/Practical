using System;

namespace EnumConcept
{
    #region Program1

    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customer[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customer[2] = new Customer
            {
                Name = "sam",
                Gender = Gender.Unknow
            };

            foreach (Customer c in customer)
            {
                Console.WriteLine("Name : {0} \t Gender : {1}", c.Name, c.Gender);
            }
            Console.ReadKey();
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknow
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    #endregion

    #region Program2
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[] value = (int[])Enum.GetValues(typeof(Gender));

            foreach (int val in value)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine();

            string[] Name = Enum.GetNames(typeof(Gender));

            foreach (string N in Name)
            {
                Console.WriteLine(N);
            }

            Console.ReadKey();
        }
    }
    public enum Gender
    {
        Male=5,
        Female=8,
        Unknow=10
    }
    */
    #endregion

}
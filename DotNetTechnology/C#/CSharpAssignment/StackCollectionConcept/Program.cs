using System;
using System.Collections.Generic;

namespace StackCollectionConcept
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region object Create
            Customer C1 = new Customer()
            {
                Id = 1001,
                Name = "Karan ",
                Salary = 30000,
                Type = "Retail Customer"
            };
            Customer C2 = new Customer()
            {
                Id = 1002,
                Name = "Pranav",
                Salary = 40000,
                Type = "Retail Customer"
            };
            Customer C3 = new Customer()
            {
                Id = 1003,
                Name = "Ritesh",
                Salary = 50000,
                Type = "Retail Customer"

            };
            Customer C4 = new Customer()
            {
                Id = 1004,
                Name = "Prakash",
                Salary = 40000,
                Type = "Corporate Customer"
            };
            Customer C5 = new Customer()
            {
                Id = 1005,
                Name = "sandip",
                Salary = 35000,
                Type = "Corporate Customer"
            };
            #endregion

            Stack<Customer> QueueCustomer = new Stack<Customer>();
            QueueCustomer.Push(C1);
            QueueCustomer.Push(C2);
            QueueCustomer.Push(C3);
            QueueCustomer.Push(C4);
            QueueCustomer.Push(C5);
            Console.WriteLine(" Lits of Stack");
            foreach (Customer c in QueueCustomer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", c.Id, c.Name, c.Salary);
            }

            Console.WriteLine("\n Peek Method");
            Customer PeekCustomer = QueueCustomer.Peek();
            Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", PeekCustomer.Id, PeekCustomer.Name, PeekCustomer.Salary);
            Console.WriteLine("Total number of queue = " + QueueCustomer.Count);

            Console.WriteLine("\n pop Method");
            Customer RemoveCustomer = QueueCustomer.Pop();
            Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", RemoveCustomer.Id, RemoveCustomer.Name, RemoveCustomer.Salary);
            Console.WriteLine("Total number of queue = " + QueueCustomer.Count);

            Console.WriteLine("\n Contains Method");
            if (QueueCustomer.Contains(C5))
            {
                Console.WriteLine("C5 Exists");
            }
            else
            {
                Console.WriteLine("C5 does not Exists");
            }
            Console.ReadKey();
        }
    }
}
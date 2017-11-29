using System;
using System.Collections.Generic;

namespace ListCollectionConcept
{

    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Customer other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
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


            SortByName sortByName = new SortByName();
            #endregion

            #region Add method

            Console.WriteLine("\n Add method");
            List<Customer> customer = new List<Customer>();
            customer.Add(C1);
            customer.Add(C2);
            customer.Add(C3);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", c.Id, c.Name, c.Salary);
            }
            #endregion

            #region Insert method
            Console.WriteLine("\n Insert method");
            customer.Insert(0, C3);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", c.Id, c.Name, c.Salary);
            }
            #endregion

            #region  IndexOf method
            Console.WriteLine("\n IndexOf method");
            Console.WriteLine("Index Of C3 object :: " + customer.IndexOf(C3)); // find object from zero poition
            Console.WriteLine("Index Of C3 object :: " + customer.IndexOf(C3, 2)); // find object from third poition
            #endregion

            #region Contains method
            Console.WriteLine("\n Contains method");
            if (customer.Contains(C3))
            {
                Console.WriteLine("C3 object exists in the List");
            }
            else
            {
                Console.WriteLine("C3 object does not exists in the List");
            }
            #endregion

            #region exists method
            Console.WriteLine("\n exists method");
            Console.WriteLine(customer.Exists(cust => cust.Name == "Ritesh"));
            Console.WriteLine(customer.Exists(cust => cust.Name.StartsWith("K")));
            #endregion

            #region Find method
            Console.WriteLine("\n Find method");
            Customer SalaryBaseFilter = customer.Find(x => x.Salary < 50000);
            Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", SalaryBaseFilter.Id, SalaryBaseFilter.Name, SalaryBaseFilter.Salary);

            #endregion

            #region FindLast method
            Console.WriteLine("\n FindLast method");
            Customer SalaryBaseFilter1 = customer.FindLast(x => x.Salary < 50000);
            Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", SalaryBaseFilter1.Id, SalaryBaseFilter1.Name, SalaryBaseFilter1.Salary);
            #endregion

            #region FindAll method
            Console.WriteLine("\n FindAll method");
            List<Customer> customers = customer.FindAll(x => x.Salary < 50000 & x.Salary > 30000);
            foreach (Customer c in customers)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2}", c.Id, c.Name, c.Salary);
            }
            #endregion

            #region FindIndex method
            Console.WriteLine("\n FindIndex method");
            int index = customer.FindIndex(x => x.Salary < 40000);
            Console.WriteLine("Index :: {0}", index);
            #endregion

            #region FindLastIndex method
            Console.WriteLine("\n FindLastIndex method");
            int LastIndex = customer.FindLastIndex(x => x.Salary < 50000);
            Console.WriteLine("Last Index :: {0}", LastIndex);
            #endregion

            #region AddRange method
            Console.WriteLine("\n AddRange method");
            List<Customer> CorporateCustomerList = new List<Customer>();
            CorporateCustomerList.Add(C4);
            CorporateCustomerList.Add(C5);
            customer.AddRange(CorporateCustomerList);

            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region GetRange method
            Console.WriteLine("\n GetRange method");
            List<Customer> GetRangeCustomer = customer.GetRange(4, 2);
            foreach (Customer c in GetRangeCustomer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region Remove method
            Console.WriteLine("\n Remove method");
            customer.Remove(C3);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region RemoveRange method
            Console.WriteLine("\n RemoveRange method");
            customer.RemoveRange(3, 2);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region RemoveAt method
            Console.WriteLine("\n RemoveAt method");
            customer.RemoveAt(2);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion 

            #region InsertRange method
            Console.WriteLine("\n InsertRange method");
            customer.InsertRange(2, CorporateCustomerList);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region RemoveAll method
            Console.WriteLine("\n RemoveAll method");
            customer.RemoveAll(x => x.Type == "Retail Customer");
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region Sort Method
            Console.WriteLine("\n Sort method");
            List<int> Number = new List<int>() { 1, 2, 5, 9, 4, 7, 0, 3, 8, 6 };
            Console.WriteLine("\n Orignal series");
            foreach (int n in Number)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n Sorting");
            Number.Sort();
            foreach (int n in Number)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region Reverse Method
            Console.WriteLine("\n Reverse method");
            Number.Reverse();
            foreach (int n in Number)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region Complex type sorting and reversing 
            Console.WriteLine("\n Sorting By Salary");
            customer.Sort();
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }

            Console.WriteLine("\n Sorting By Name");
            customer.Sort(sortByName);
            foreach (Customer c in customer)
            {
                Console.WriteLine("Id :: {0} \t Name :: {1} \t Salary :: {2} \t Type :: {3} ", c.Id, c.Name, c.Salary, c.Type);
            }
            #endregion

            #region TrueForAll method

            Console.WriteLine("\n TrueForAll method");
            Console.WriteLine("We are provided more than 20000 salary  :: " + customer.TrueForAll(y => y.Salary > 20000));
            //Console.WriteLine("Cutomer salary between 20000 to 30000  :: " + customer.TrueForAll(y => y.Salary > 20000 && y.Salary < 30000));
            #endregion

            Console.ReadKey();
        }
    }
}
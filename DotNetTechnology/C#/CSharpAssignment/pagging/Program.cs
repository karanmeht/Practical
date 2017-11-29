using System;
using System.Collections.Generic;

namespace pagging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Employee> e = new List<Employee>()
            {
                new Employee{Id=1,Name="karan" },
                new Employee{Id=2,Name="Pranav"}
            };
            foreach(Employee x in e)
            {
                Console.WriteLine(x.Id + x.Name);
            }
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
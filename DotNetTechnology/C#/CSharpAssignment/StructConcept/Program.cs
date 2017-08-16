using System;

namespace StructConcept
{
    #region struct Concept

    /*
     Structs
    just like classes structs can have
    1. private fields
    2. public properties
    3. Constructors
    4. methods

    object initializer syntax, introduced in c# 3.0 can be used to initialize either a struct or a class.
    we use struct keyword to create a struct.

        Classes Vs Structs

    A struct is a value type where as a class is a reference type.
    All the differences that are applicable to value type are also applicable to class and structs.
    struct are stroed on stack, where as classes are stored on the heap.
    value types hold thier value in memory where they are declared, but reference types hold a reference to an object in memory.
    value types are destoryed immediately after the scope is lost, where as for reference types only the reference variable is destroyed after the scope is lost. the object is later destroyed by garbage collector.
    when you copy a struct into another struct, a new copy of that struct gets created and modifications on one struct will not affect the values contained by the other struct.
    when you copy a class innto another class, we only get a copy of the reference variable. both the reference variables point to the same object on the heap. so, operations on one variable will affect the values contained by the other referencce variable.
    
    Structs can't have destructors, but classes can have destructors.
    struct can't have explicit parameter less constructor where as a class can.
    struct can't inherit from another class where as a class can, both struct and classes can inherit from an interface.
    examples of structs in the .Net framework -int (System.int32), double(System.Double) etc.
    Note: A class or a struct can't inherit from another struct. struct are sealed types.

    */
    #endregion

    public struct CustomerStructure
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Customer Id = {0} Name = {1}", Id, Name);
        }
    }

    public class CustomerClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Customer Id = {0} Name = {1}", Id, Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerStructure SC1 = new CustomerStructure();
            SC1.Id = 100;
            SC1.Name = "karan";

            CustomerStructure SC2 = SC1; // value type (struct)
            SC2.Name = "Pranav";

            Console.WriteLine("Struct =    SC1.Name = {0} : SC2.Name = {1}", SC1.Name, SC2.Name);

            CustomerClass CC1 = new CustomerClass();
            CC1.Id = 100;
            CC1.Name = "karan";

            CustomerClass CC2 = CC1; // reference type (class)
            CC2.Name = "Pranav";

            Console.WriteLine("Class =     CC1.Name = {0} : CC2.Name = {1}", CC1.Name, CC2.Name);

            Console.ReadKey();
        }
    }
}
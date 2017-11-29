using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConcept
{
    #region cover topic
    /*
     * Static class members
     * instance class members
     * Different between static and instance class members
     * an example explaining when you should make certain members static
     
         Static and instance class members
        when a class member inclues a static modifier,the member is class as static member.
        when no static modifier is present the member is called as non static member or instance member.

        static members are invoked using class name, where as instance members are invoked using instances (object) of the class.

        an instance member belongs to specific instance (object) of a class. ex: if i create 3 object of a class i will have 3 sets of instance members in the memory, where as there will ever be only one copy of a static member, no matter how many instances of a class are created

        note: class members = fields, methods, properties, events, indexers, constructors.

        Static Constructor
        static constructors are used to initialize static fields in a class.

        you declare a static constructor by using the keyword static in fornt of the constructor name.

        static constructor is called only once, no matter how many instances you create.

        static constructor are called before instance constructor
         */
    #endregion

    class Circle
    {
        static float _PI;
        int Redius;

        // only initialize static members
        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            _PI = 3.141F;
        }
        
        public Circle(int Redius)
        {
            Console.WriteLine("Instance Constructor Called");
            this.Redius = Redius;
        }

        public float CalculateArea()
        {
            return this.Redius * Circle._PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area1 = c1.CalculateArea();
            Console.WriteLine("Area = {0}",Area1);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);

            Console.ReadKey();
        }
    }
}

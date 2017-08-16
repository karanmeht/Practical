using System; // without assistance
using PATA = Project.TeamA; // with assistance
using PATB = Project.TeamB;

// namespace are use to organize your program
// they also provide assistance in avoiding name clashes

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectA.TeamA.ClassA.print();
            //ProjectA.TeamB.ClassA.print();
            PATA.ClassA.Print();
            PATB.ClassA.Print();
            Console.ReadKey();
        }
    }
}

namespace Project
{
    namespace TeamA
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }

}
namespace Project
{
    namespace TeamB
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }

}

using System;

namespace Methods
{
    class Program
    {
        #region Cover topic
        /*
         method syntax
         [attributes]
        access-modifiers return-type method-name(parameters)
        {
        	method body
        }
        */
        #endregion
        static void Main(string[] args)
        {
            Program.EventNumber();
            Program p = new Program();
            int sum = p.AddNumber(10, 20);
            Console.WriteLine("Sum={0}", sum);
            Console.ReadKey();
        }

        public int AddNumber(int FN, int SN)
        { 
            return FN + SN;
        }

        public static void EventNumber()
        {
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
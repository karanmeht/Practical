using System;
using System.Threading;

namespace NullableDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region nullable type

            // nullable type
            /* In C# type are divided into 2 broad category
             value type = int,float,double,structs,enums etc
             Reference type = interface, class,delegates,array etc

            by default value types are non nullable. to make them nullable use ?
            int i = 0 (i is a not nullable, so i cannot be set to null, i = null will generate compiler error)
            int? j = 0 (j is nullable int, so j = null is legal)

            string name = null is true.
            int number = null is false.

            Nullable types bridge the differences between C# types and database type.
            */

            bool? AreYouMojar = true;

            if (AreYouMojar == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMojar == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the Question");
            }
            
            #endregion

            #region Null Coalescing operator

            //Null Coalescing operator ??
            /*
            int? TicketsOnSale = null;
            int AvailableTickets;
            
            if(TicketsOnSale==null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }
            Console.WriteLine("AvailableTickets = {0}",AvailableTickets);
            */

            int? TicketsOnSale = null;
            int AvailableTickets;

            AvailableTickets = TicketsOnSale ?? 0; // ?? part is describe defualt part if TicketsOnSale is null then AvailableTickets = 0 
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

            Console.WriteLine("Wait Tickets adding");
            TicketsOnSale = 5;
            AvailableTickets += TicketsOnSale ?? 0;
            Thread.Sleep(2000);

            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
            #endregion

            Console.ReadKey();
        }
    }
}
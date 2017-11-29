using System;

namespace LoopInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while loop
            /*
            Console.WriteLine("please enter your target number:");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= UserTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }
            */
            #endregion

            #region do while loop
            /*
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("please enter your target number:");
                int UserTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                Console.WriteLine("\nDo you want to continue yes or no?");

                do
                {
                    Console.WriteLine("Please Enter Your Choice");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Option. Please say Yes or No...");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
            //Console.WriteLine(true & true);
            //Console.WriteLine(true & false);
            //Console.WriteLine(false & true);
            //Console.WriteLine(false & false);
            */
            #endregion

            #region for loop

            int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < Number.Length; i++)
            {
                Console.WriteLine(Number[i]);
            }
            

            // break and continue keyword
            
            for (int i = 0; i < Number.Length; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(Number[i]);
            }

            for (int i = 0; i < Number.Length; i++)
            {
                if (i == 8)
                    break;
                Console.WriteLine(Number[i]);
            }
            
            #endregion

            #region for each 
            // it is use for collection type like ArrayList , generic, HashTable
            //int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int n in Number)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            Console.ReadKey();
        }
    }
}
using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch statement

            Console.WriteLine("Enter User Number");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    break;
                case 30:
                    Console.WriteLine("your number is 30");
                    break;
                default:
                    Console.WriteLine("your number is Not between 10 and 30");
                    break;
            }

            /*
            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("your number is {0}.", UserNumber);
                    break;
                default:
                    Console.WriteLine("your number is Not between 10 and 30");
                    break;
            }
            */
            #endregion

            #region goto statement
            // using goto is bad programming style. we can should avoid goto by all means.
            int TotalCoffeeCost = 0;

            start: // Creating a label with (:)
            Console.WriteLine("please select your coffee size \n 1- Small, 2 - Miduam, 3 - Large \n");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("you selected rong choice. please try again......");
                    goto start; //Jump to label statement
            }

            decision:
            Console.WriteLine("do you want buy another coffee Yes - No");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("yoour choice {0} is invalid. please try again......",UserDecision);
                    goto decision;
            }

            Console.WriteLine("Thank you for shoping with us.");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
            #endregion
            Console.ReadKey();
        }
    }
}
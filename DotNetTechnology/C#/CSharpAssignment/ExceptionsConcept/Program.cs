using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionsConcept
{
    #region Exception handing

    /*
An exception is an unforeseen error that occurs when a programming running.

ex: 
trying to read from a file that does not exist, throws FileNotFoundException.
trying to read from a database table does not exist, throws a SqlException.

showing actual unhandled exceptions to the end user is bad for two reasons
1. user will be annoyed as they are cryptic and does not make much sense to the end users.
2. exceptions contain information, that can be used for hacking into your application.

an exception is actually a class that derives from system. exception class has several useful properties, that provide valuable information about the exception.

Message: gets a message that describes the current exception.
StackTrace: provides the call stack to the line number inthe method where the exception occurred.

We use try, catch and finally blocks for exception handling:
try:- the code that can possibly cause an exception will be in the try block.
catch:- handles the exception.
finally:- clean and free resources that the class was holding onto during the program execution. finally block is optional.
note: it is a good practice to always release resources in the finally block, because finally block is guarateed to execute, irrespective of whether there is an exception or not.
Specific exceptions will be caught before the base general exception, so specific exception block should always be on top of the base exception block. otherwise, you will encounter a compiler error.
         */
    #endregion

    #region Program1
    /*
        class Program
        {
            static void Main(string[] args)
            {
                int FN, SN;
                float? Div = null;
                try
                {
                    Console.WriteLine("Enter First Number::");
                    FN = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int.TryParse(Console.ReadLine(), out SN);

                    Div = FN / SN;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("divided number zero is Not valid");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n \n" + ex.StackTrace);
                }
                finally
                {
                    if (Div != null)
                        Console.WriteLine("Division = {0}", Div);
                    Console.ReadKey();
                }
            }
        }
      */
    #endregion

    #region Program2 (InnerException)
    /*
     first time Input fn= 5 sn=0.
     second time Input fn= 555555555555555555555555555 sn=5.
     see actual process of this program
     */
    /*
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    try
                    {
                        UserInput();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Please try again.  Last Chance");
                        try
                        {
                            UserInput();
                        }
                        catch (Exception)
                        {
                            throw new OverflowException("input is not valid", ex);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Main Exception = {0}", e.GetType().Name);
                    Console.WriteLine("Main InnerException = {0}", e.InnerException.GetType().Name);
                }
                finally
                {
                    Console.ReadKey();
                }
            }

            public static string Result(int FN, int SN)
            {
                return Convert.ToString((FN / SN));
            }
            public static void UserInput()
            {
                int FN, SN;

                Console.WriteLine("Enter First Number::");
                FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int.TryParse(Console.ReadLine(), out SN);

                Console.WriteLine("SUM = {0} ", Result(FN, SN));
            }
        }
        */
    #endregion

    #region Program3 (Custome Exception)

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    UserInput();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong \nPlease try again. Last Chance");
                    try
                    {
                        UserInput();
                    }
                    catch (Exception secondTime)
                    {
                        throw new SecondTimeAccessException(secondTime.Message, ex);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Main Exception Message = {0}", e.Message);
                Console.WriteLine("InnerException Message = {0}", e.InnerException.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static string Result(int FN, int SN)
        {
            return Convert.ToString((FN / SN));
        }
        public static void UserInput()
        {
            int FN, SN;

            Console.WriteLine("Enter First Number::");
            FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            SN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SUM = {0} ", Result(FN, SN));
        }
    }

    //custome Exception class
    public class SecondTimeAccessException : Exception
    {
        public SecondTimeAccessException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
    #endregion

}
using System;

namespace DatatypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region cover topic
            /*
             implicit conversions
             explicit conversions
             difference between parse() and try parse()
             if the number is in a string format you have 2 options - Parse() and TryParse()
             Parse() method throws an exception if it cannot parse the value where as TryParse() returns a bool indicating whether it succeeded or failed.
             use Parse() if you are sure the value will be valid, otherwise use TryParse()
             */
            #endregion

            #region implicit conversions
            /*
                        int i = 100;
                        //float is a bigger datatype then int so no loss data
                        //data and exceptions, hence implicit coversions
                        float f = i;
                        Console.WriteLine(f); 
            */
            #endregion

            #region Explicit conversions

            float f = 1000.00F;
            //cannot implicitly convert float to int
            //fractional part will be lost. float is bigger data type then int, so there is also a possibility of overflow exception
            //int i = f;

            //use explicit coversion using cast () operator. if value bigger to convert type then return mimimum value of datatype in resulat
            int i = (int)f;

            // or use conver class
            // if converted value is large then convert class throw exception
            //float f = 10021125464640.00F;
            //int i = Convert.ToInt32(f);

            ///Console.WriteLine(i);

            #endregion

            #region parse() method

            //string s = "100";
            //int i = int.Parse(s);
            //Console.WriteLine(i);

            #endregion

            #region TryParse() method

            int Result = 0;
            //here tryParse() method return bool type 
            // this line strNumber is convert integer and store in Result variable
            // if StrNumber variable is not converted then result is 0
            Console.WriteLine("Enter Number:");
            string StrNumber = Console.ReadLine();

            bool IsConversionSuccessful = int.TryParse(StrNumber, out Result);
            if (IsConversionSuccessful)
                Console.WriteLine(Result);
            else
                Console.WriteLine("Please enter valid number");
            #endregion
            Console.ReadKey();
        }
    }
}

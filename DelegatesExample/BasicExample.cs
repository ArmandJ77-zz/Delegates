using System;

namespace DelegatesExample
{
    class BasicExample
    {
        static void Main(string[] args)
        {
            //Declare a delegate which retruns an int and accepts a double as parameter
            delegate int RoundUpDelegate(double input);

            static void Main(string[] args)
            {
                //instantiate a new delegate type and point it to your method
                RoundUpDelegate calc = RoundUp;

                //use the delegate instance to invoke the RoundUp method
                Console.WriteLine(calc(22.7));
            }

            public static int RoundUp(double input)
            {
                return (int)Math.Ceiling(input);
            }
        }
    }
}

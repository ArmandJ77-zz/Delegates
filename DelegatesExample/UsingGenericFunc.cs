using System;

namespace DelegatesExample
{
    class UsingGenericFunc
    {
        static void Main(string[] args)
        {
            //Declaring a new func which expects a double as input but
            //will return an int as result of the pointer function
            Func<double, int> calc = RoundUp;

            //invoke the delegate
            Console.WriteLine(calc(22.7));
        }

        //Pointer function which does a basic calculation for demo 
        //purposes
        public static int RoundUp(double input)
        {
            return (int)Math.Ceiling(input);
        }
    }
}

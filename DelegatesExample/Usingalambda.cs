using System;

namespace DelegatesExample
{
    class Usingalambda
    {
        static void Main(string[] args)
        {
            //Declaring a new func which expects a double as input but
            //will return an int however now we are using a lambda
            //function to calculate the result instead of a method
            Func<double, int> calc = x => (int)Math.Ceiling(x);

            //Invoke delegate and console log result
            Console.WriteLine(calc(22.7));
        }
    }
}

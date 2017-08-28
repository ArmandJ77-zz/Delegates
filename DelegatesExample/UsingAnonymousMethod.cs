using System;

namespace DelegatesExample
{
    class UsingAnonymousMethod
    {
        static void Main(string[] args)
        {
            Func <double, int> convert = delegate (double input)
            {
                return (int)Math.Ceiling(input);
            };

            Console.WriteLine(convert(22.7));
        }
    }
}

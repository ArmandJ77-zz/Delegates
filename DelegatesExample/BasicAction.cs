using System;

namespace DelegatesExample
{
    class BasicAction
    {
        static void Main(string[] args)
        {
            Action<double> printActionDelegate = i => Console.WriteLine(Math.Ceiling(i).ToString());

            printActionDelegate(10);
        }
    }
}

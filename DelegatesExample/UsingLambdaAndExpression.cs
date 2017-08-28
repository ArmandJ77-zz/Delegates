using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesExample
{
    class UsingLambdaAndExpression
    {
        static void Main(string[] args)
        {
            Func<double, int> calc = x => (int)Math.Ceiling(x);

            List<double> InputCollection = new List<double> { 22.7, 13.2, 5.5, 9.78 };

            InputCollection.Select(x => calc(x))
                .ToList()
                .ForEach(z => Console.WriteLine(z));

            //OR

            //List<int> OutputCollection = InputCollection.Select(x => calc(x)).ToList();

            //OutputCollection.ForEach(x => Console.WriteLine(x));
        }
    }
}

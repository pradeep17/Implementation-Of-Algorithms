using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IterationSampl
{
    public class SampleIter
    {
        static void Main(string[] args)
        {
            object[] values = { "a", "b", 'c', "d", "f" };
            IterationSample collection = new IterationSample(values, 3);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    
}
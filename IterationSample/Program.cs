using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationSample
{
    class Program
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

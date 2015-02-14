using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data= {'c','c','d','s','b','a','a','b'};
            var c= data.Where(x => data.Count(y => x == y) >= 2).Distinct();
            c.ToList();
            var unique = data.Distinct().ToList();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            foreach (var item in unique)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

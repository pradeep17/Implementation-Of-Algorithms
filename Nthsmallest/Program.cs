using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nthsmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1, 2, 12, -10, 3 };
            int[] intArray = new int[] { 1, 2, 12, -10, 3 };
            Console.WriteLine("Original List:");
            intList.ForEach(a=>Console.WriteLine(a));
            //second largest
            var ele = (from e in intArray
                       orderby e descending
                       select e).Skip(1).First();
            Console.WriteLine("2nd largest element is {0}", ele.ToString());

            //3rd smallest
            IEnumerable<int> third = intArray.OrderBy(a => a).Skip(2).Take(1);
            Console.WriteLine("Third smallest element:");
            foreach (var i in third)
            {
                Console.WriteLine(i.ToString());
            }
            //another method to find 3rd 
            int find = intArray.OrderBy(a => a).Skip(2).First();
            Console.WriteLine("3rd smalles element is {0}", find.ToString());
            Console.ReadKey();
             }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        void changearray(string a)
        {
           
            a.Reverse();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            string a = "hello";
            Program p = new Program();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            p.changearray(a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lambda
{
    class Program
    {
        public delegate int Countit(int x);
        static void Main(string[] args)
        {
            Countit del = c => c + 5;
            int result = del(25);
            Console.WriteLine(result);
            
           
        }
    }
}

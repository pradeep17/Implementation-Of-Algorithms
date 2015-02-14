using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AlgorithmsImplementation.commonletters;

namespace Overrider
{
    class myBase
    {
       static int count = 0;
       public virtual double doSomething(int myint)
        {
            count++;
            Console.WriteLine("my int is {0}", myint/4.5);
            return count;
        }
    }
    class myDerived:myBase
    {
       public override double doSomething(int myint)
        {
           
            Console.WriteLine("my int is {0}", myint / 5);
            return myint / 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myBase derive = new myDerived();
            derive.doSomething(5);
            Console.WriteLine("typeof myderived: " + typeof(myBase));
           
            Console.ReadKey();
        }
    }
}

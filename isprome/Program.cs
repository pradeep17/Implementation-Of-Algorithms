using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isprime
{
    class Program
    {
        static void Main(string[] args)
        {
            if(isprime(569022201))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            Console.ReadLine();
        
        }

        private static bool isprime(int p)
        {
            bool isprime=true;
            if (p > 0)
            {
                if (p == 1)
                    return true;
                else if (p == 2)
                    return true;
                else
                {
                    for(int i = 2; i<p;i++)
                    {
                        if (p % i == 0)
                            isprime = false;
                        
                    }
                    return isprime;
                }
            }
            else
                return true;
        }
    }
}

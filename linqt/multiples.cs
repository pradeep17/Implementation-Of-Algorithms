using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqt
{

    class Algorithms
    {
        //Sum of numbers that are either divisible 3 or 5
        public static int sum3_5_mulitples()
        {
            int count = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    count += i;
            }
            return count;
        }
        //Sum of even Fibonacci number less than 4 million
        public static int sumevenfibo()
        {
            int f = 0, f0 = 0, f1 = 1, sum = 0;
            while (f < 4000000)
            {
                f = f0 + f1;
                if (f % 2 == 0)
                {
                    sum += f;
                }
                f0 = f1;
                f1 = f;
            }
            return sum;
        }
        public static UInt64 findgreatestprime_factor(UInt64 number)
        {
            UInt64 greatestFactor = 2;
            while (number > greatestFactor)
            {

                if (number % greatestFactor == 0)
                {
                    number /= greatestFactor;
                    greatestFactor = 2;
                }
                else
                {
                    greatestFactor++;
                }
            }
            return greatestFactor;

        }
    }
    class multiples
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Sum of numbers that are either divisible 3 or 5 " + Algorithms.sum3_5_mulitples());
            //  Console.WriteLine("Sum of even Fibonacci number less than 4 million " + Algorithms.sumevenfibo());
            Console.WriteLine("greatest prime factor: " + Algorithms.findgreatestprime_factor(600851475143));
            Console.ReadKey();
        }
    }

}

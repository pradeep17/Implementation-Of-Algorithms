using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountInversions
{
    class CountInv
    {
        /* Input : Array a takes in n numbers
         * count_inversions function call would 
         compute the number of inversions in the array a and 
         return the same.*/

        static void Main(string[] args)
        {

            int final = 0;

            int[] a = { 4, 3, 2, 1, 0 };
            final = CountInv.count_inversions(a, 0, a.Length - 1) + 1;
            Console.WriteLine("final count : " + (final));

            foreach (int item in a)
            {
                Console.WriteLine(item + "\t");

            }
            Console.ReadKey();
        }
        //Divide and conquer - just like Merge sort, divide into two arrays and have the variable count track the inversions
        private static int count_inversions(int[] a, int left, int right)
        {
            int inv = 0;
            int middle = 0;
            if (left < right)
            {
                middle = Convert.ToInt16(Math.Floor((left + right) / 2.0));
                inv += count_inversions(a, left, middle);
                inv += count_inversions(a, middle + 1, right);
                inv += merge_inversions(a, left, middle, right);
            }
            return inv;
        }

        private static int merge_inversions(int[] a, int left, int middle, int right)
        {

            int ip = left;

            int iq = middle + 1;
            int[] b = new int[a.Length];
            int inv = 0;
            for (int i = ip; i < right; i++)
            {
                if (ip <= middle && (iq > right || (a[ip] < a[iq])))
                {

                    b[i] = a[ip++];
                }
                else
                {


                    inv += middle - i + 1;

                    b[i] = a[iq++];

                }

            }
            for (int i = left; i <= right; i++)
            {

                a[i] = b[i];
            }
            return inv;
        }
    }
}

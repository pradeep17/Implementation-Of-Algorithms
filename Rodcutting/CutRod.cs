using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodcutting
{
    class CutRod
    {
        static void Main(string[] args)
        {
            int n = 40;
            int[] p = new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            int[] r =new int[p.Length];
            for (int i = 0; i < p.Length; i++)
                r[i] = -1;
            
            int max = cutrod(p, n,r);
            Console.WriteLine("Max price for cutting length "+ n + " is : " + max);
            Console.ReadKey();
        }
        public static int cutrod(int[] p, int n, int[] r)
        {
            if(r[n] > 0)
                return r[n];

            
            if (n == 0)
                return 0;

            int q = -111;
            for (int i = 1; i <= n; i++)
            {
                q = Math.Max(q, p[i] + cutrod(p,n-i,r));
            }
            r[n] = q;
            return q;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 *  select(L,k)
    {
    if (L has 10 or fewer elements)
    {
        sort L
        return the element in the kth position
    }

    partition L into subsets S[i] of five elements each
        (there will be n/5 subsets total).

    for (i = 1 to n/5) do
        x[i] = select(S[i],3)

    M = select({x[i]}, n/10)

    partition L into L1<M, L2=M, L3>M
    if (k <= Length(L1))
        return select(L1,k)
    else if (k > Length(L1)+Length(L2))
        return select(L3,k-Length(L1)-Length(L2))
    else return M
    }
 */

namespace DeterministicSelection
{

    class SelectionProblem
    {
      static int median(int[] array)
    {
        if (array.Length == 1)
        {
            return array[0];
        }
        int smallerCount = 0;
        for (int i = 0 ; i < array.Length ; i++)
        {
            for (int j = 0 ; j < array.Length ; j++)
            {
                if (array[i] < array[j])
                {
                    smallerCount++;
                }
            }
            if (smallerCount == (array.Length - 1)/2)
            {
                return array[i];
            }
            smallerCount = 0;
        }
        return -1; //should never happen
    }
    // finds pivot element of a given array recursively using DeterministicSelect
  static  int findpivot(int[] array)
    {       
        if (array.Length == 1)
        {
            return array[0];
        }
        //Divide A into n/5 groups of 5 elements each
        int numGroups = array.Length / 5;
        if (array.Length % 5 > 0)
        {
            numGroups++;
        }
        int[] setOfMedians = new int[numGroups];
        for (int i = 0 ; i < numGroups ; i++)
        {
            int[] subset;
            if(array.Length % 5 > 0)
            {
                if (i == numGroups - 1)
                {
                    subset = new int[array.Length % 5];
                }
                else
                {
                    subset = new int[5];
                }
            }
            else
            {
                subset = new int[5];
            }
            for (int j = 0; j < subset.Length ; j++)
            {
                subset[j] = array[5*i+j];
            }
            //Find the median of each group
            setOfMedians[i] = median(subset);
        }
        //Use DeterministicSelect to find the median, p, of the n/5 medians
        int goodPivot = DeterministicSelect(setOfMedians, setOfMedians.Length/2 );
        return goodPivot;
    }
      
//The algorithm in words:
//1. Divide n elements into groups of 5 
//2. Find median of each group (How? How long?)
//3. Use Select() recursively to find median x of the n/5? medians
//4. Partition the n elements around x. Let k = rank(x)
//5. if (i == k) then return x else (i > k) use Select() recursively to find (i-k)th 
//smallest element in last partition
//source  
//Lecture PDF mentioned in the blog post
//and MIT Lecture 6 order statistics.
 
  static int DeterministicSelect(int[] array, int k)
    {
        if (array.Length == 1)
        {
            return array[0];
        }
        int pivot = findpivot(array);
        //set is used to ignore duplicate values
        HashSet<int> A1 = new HashSet<int>();
        HashSet<int> A2 = new HashSet<int>();
     
        for (int i = 0; i < array.Length ; i++)
        {
            if (array[i] < pivot)
            {
                
                A1.Add(array[i]);
                
            }
            else if (array[i] > pivot)
            {
                A2.Add(array[i]);
                
            }
          

        }
        if (A1.Count >= k)
        { 
            return DeterministicSelect(A1.ToArray() ,k);
        }
        else if (A1.Count == k - 1)
        {
            return pivot;
        }
        else
        {
            return DeterministicSelect(A2.ToArray() , k - A1.Count - 1);
        }
    }

        static void Main(string[] args)
        {
            int[] a = {2,5,1,4,4,65,4,6,3,1,2,5,4,5,6,2,5,7,8,23,3};
            int min = DeterministicSelect(a, 9);
            Console.WriteLine("minimum element is :" + min);


            Console.ReadKey();

        }
    }
}



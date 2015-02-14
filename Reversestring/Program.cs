using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversestring
{
    class Program
    {
        //additional buffer
        public static string reverse(string input)

        {
            char[] characters = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; --i)
            {
                sb.Append(characters[i]);
            }


            return sb.ToString();
        }

        static void Main(string[] args)
        {
            //in place
            StringBuilder s1 =new StringBuilder("server");
            Console.WriteLine("string s1 is :" + s1);
            char temp;
            int count = s1.Length-1;
            for(int i = 0; i < s1.Length && i!=count;i++)
            {
                if(count >= 0)
                { 
                temp = s1[count];
                s1[count--] = s1[i];
                s1[i] = temp;
                }
                if (i == count)
                    break;
            }
            Console.WriteLine("reversed string s1 is :" + s1);
            Console.ReadKey();
        }
    }
}

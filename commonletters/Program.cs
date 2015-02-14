using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonletters
{
    class Program
    {
        static void findcommon(string s1, string s2)
        {
            List<string> result = new List<string>();
            string[] s1arr = s1.Split();
            string[] s2arr = s2.Split();
            //HashSet<char> s1unique = new HashSet<char>(s1arr);
            //HashSet<char> s2unique = new HashSet<char>(s2arr);
            result.AddRange(s1arr.Where(r => s2arr.Any(l => l.StartsWith(r))));
            // var unique= s1unique.Intersect<char>(s2unique);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }


        }


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
            string s2 = "used email before";
            string s1 = "used before";
            findcommon(s1, s2);
            Program p = new Program();

            string s3 = reverse(s1);
            Console.WriteLine(s3);
            string s = "new";
            
            int value = s[3];
            Console.WriteLine(value);
            Console.ReadKey();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace linqt
{
    class Program
    {

        static void read_input(List<string> instances, string input, List<string> clslbls)
        {
            
            try 
        {
            // Create an instance of StreamReader to read from a file. 
            // The using statement also closes the StreamReader. 
            using (StreamReader content = new StreamReader(input)) 
            {
                string line;
                while((line = content.ReadLine()) != null)
                {
                string lines = content.ReadLine();
                
                instances.AddRange(Regex.Split(lines,"\t"));
                char lastline = lines.Last();
                }
            }
               
               
        }
        catch (Exception e) 
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        }
        static void Main(string[] args)
        {
           
            Program p = new Program();
            List<string> instances;
            List<string> clslbls = new List<string>();
            instances = new List<string>();
            string trainfile = "C:\\Users\\Ap\\Documents\\SPRING 2014\\machine learning\\project 2\\train.dat";
            Program.read_input(instances, trainfile, clslbls);
            
            
            
            Console.ReadKey();
        }
    }
}

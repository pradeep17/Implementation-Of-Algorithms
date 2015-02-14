using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringperm
{
    abstract class Animal
    {
   
         public virtual void barker()
        {
            Console.WriteLine("bark only if required!!");
        }
         public abstract void talk();
         public abstract void fly();
         public abstract void dance();
         public abstract void hop();
         public abstract void initialize();

    }
    class Dog : Animal
    {
      



         public override void talk()
        {
            Console.WriteLine("I can bark");
        }

         public override void fly()
        {
            Console.WriteLine("I cannot fly");
        }
         public override void dance()
        {
            Console.WriteLine("I cannot dance");
        }
         public override void hop()
        {
            Console.WriteLine("I cannot hop either");
        }

        public override void initialize()
        {
            Console.WriteLine("I am a proud animal");
        }
    }
    class daburman:Dog
    {
        public override void barker()
        {
            Console.WriteLine("yowl with daburman");
        }
    }
    public class Program {


        public static void permute(string input)
        {
            int inputLength = input.Length;
            
            bool[] used = new bool[inputLength];
            StringBuilder outputString = new StringBuilder();
            char[] in1 = input.ToCharArray();
            Array.Sort(in1);
            doPermute(in1, outputString, used, inputLength, 0);

        }

        public static void doPermute(char[] in1, StringBuilder outputString, bool[] used, int inputLength, int level)
        {
            if (level == inputLength)
            {
                Console.WriteLine(outputString.ToString());
                return;
            }

            for (int i = 0; i < inputLength; ++i)
            {

                if (used[i] && outputString.ToString().Contains(in1[i])) continue;

                outputString.Append(in1[i]);
                used[i] = true;
                doPermute(in1, outputString, used, inputLength, level + 1);
                used[i] = false;
                outputString.Length = outputString.Length - 1;
            }
        }
        static void Main(string[] args)
        {
            
            string original = "aadjhl";
            Console.WriteLine("");
            
            Console.WriteLine("Results are :");
            Console.WriteLine("");
            permute(original);
            
            Animal dg = new daburman();
            dg.initialize();
            dg.fly(); dg.hop();
            dg.dance(); dg.talk();
            dg.talk();
            dg.barker();
            Console.ReadKey();
        }
    
    
    

    
}
}

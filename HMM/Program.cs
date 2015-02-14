using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HMM
{
    class Program
    {
        Dictionary<double, string> Q;
        double[,] A;
        Dictionary<Tuple<char,int>, double> B;
        List<string> O;
        public Program()
        {
            Q = new Dictionary<double, string>();
            B = new Dictionary<Tuple<char, int>, double>();
            O = new List<string>();
        }



        public void read_input(string file1, string file2)
        {
            string model;
            string test;
            string[] inputlines;
            string[] testlines;
            int sequence_num = 1;
            var sr1 = new StreamReader(file1);

            model = sr1.ReadToEnd();
            Console.WriteLine(model);
            var sr2 = new StreamReader(file2);

            test = sr2.ReadToEnd();
            Console.WriteLine(test);
            test.Trim();


            inputlines = model.Split('\n');
            testlines = test.Split('\n');
            foreach (var item in testlines)
            {
                Console.WriteLine("Observation sequence " + sequence_num + ": " + item);
                sequence_num++;
                int num_states = Convert.ToInt32(inputlines[0]);
                var initialPI = new List<double>();
                var TransitionProb = new List<double>();
                var outputAlphabets = new List<char>();
                var ObsSymbols = new List<char>();
                var ObservationProb = new List<double>();

                string[] ObservationSeq = Regex.Split(item, @"\W+");
                string[] digits = Regex.Split(inputlines[1], " ");

                foreach (string value in digits)
                {
                    float number;
                    if (float.TryParse(value, out number))
                        initialPI.Add(number);
                }

                int counter = 0;
                A = new double[num_states + 1, num_states + 1];
                for (int statenum = 0; statenum < num_states; statenum++)
                {

                    A[0, statenum] = initialPI[counter++];
                }

                digits = Regex.Split(inputlines[2], " ");
                foreach (var value in digits)
                {
                    float number;
                    if (float.TryParse(value, out number))
                        TransitionProb.Add(number);
                }
                counter = 0;
                for (int statecounter = 1; statecounter <= num_states; statecounter++)
                {
                    for (int state_num = 0; state_num < num_states; state_num++)
                    {
                        A[statecounter, state_num] = TransitionProb[counter++];

                    }
                }

                var num_opsymbols = Convert.ToInt32(inputlines[3]);
                digits = Regex.Split(inputlines[4], " ");
                foreach (var value in digits)
                {
                    char number;
                    if (char.TryParse(value, out number))
                        outputAlphabets.Add(number);
                }

                for (int count = 0; count < num_opsymbols; count++)
                {
                    ObsSymbols.Add(outputAlphabets[count]);
                }




                digits = Regex.Split(inputlines[5], " ");
                foreach (string value in digits)
                {
                    float number;
                    if (float.TryParse(value, out number))
                        ObservationProb.Add(number);
                }

                counter = 0;
                for (int op = 0; op < num_opsymbols; op++)
                {
                    for (int statecounter = 0; statecounter < num_states; statecounter++)
                    {
                        B.Add(new Tuple<char, int>(ObsSymbols[op], statecounter), ObservationProb[counter++]);
                    }
                }
                var tp = Tuple.Create('a',1);

                int ObsSeqLength = ObservationSeq.Length;
                Console.WriteLine(B[tp]);

            }

        }



        static void Main(string[] args)
        {
            Program hmm = new Program();
            string model = @"C:\Users\Ap\Documents\Visual Studio 2013\Projects\HMM\model.sdx";
            string test = @"C:\Users\Ap\Documents\Visual Studio 2013\Projects\AlgorithmsImplementation\HMM\test.dat";
            hmm.read_input(model, test);
            Console.WriteLine("Press any key to continue...");
            
           
        
            Console.ReadKey();
        }
    }
}

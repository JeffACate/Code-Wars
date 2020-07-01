using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public static class TribonacciSequence
    {
        public static void Run()
        {
            double[] signature = new double[] { 1, 1, 1 };
            //double[] signature = new double[] { 0, 0, 1 };
            //double[] signature = new double[] { 0, 1, 1 };
            int count = 10;
            double[] results = ProcessTribonacciSequence(signature, count);
            DisplayResults(results);
            Console.ReadLine();
        }
        private static double[] ProcessTribonacciSequence(double[] signature, int n)
        {
            if(n == 0)
            {
                return new double[0];
            }
            else
            {
                double[] sequence = new double[n];
                
                for (int i = 0; i < n; i++)
                    {
                        if (i < 3)
                        {
                            sequence[i] = signature[i];
                        }
                        else
                        {
                            sequence[i] = sequence[i-1] + sequence[i - 2] + sequence[i - 3];
                        }
                    }
                return sequence;
            }
            

        }
        private static void DisplayResults(double[] results)
        {
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine(i + " : " + results[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    class SquareEveryDigit
    {

        public static void Run()
        {
            // get number to test - input
            int testNumber = GetNumber();
            //square number
            int squaredNumber = SquareDigits(testNumber);

            Console.WriteLine($"{testNumber} processed is {squaredNumber}");
            Console.ReadLine();
        }
        public static int SquareDigits(int testNumber)
        {
            testNumber
            // parse number to int[]
            foreach(char number in testNumber)
            {
                
            }
            // square each number and store in a string

            // return result[]
            return 0;
        }

        private static int GetNumber()
        {
            return 9119;
        }
    }
}

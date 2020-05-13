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
            Stack<string> squaredDigit = new Stack<string>();
            int result;
            // parse number to int[]
            for (int i = testNumber; i >  0; i = (i - (i % 10))/10)
            {
                int number = i % 10;
                squaredDigit.Push(Math.Pow(number,2).ToString());
                
            }
            // square each number and store in a string
            string resultAsStrings = "";
            while(squaredDigit.Count > 0)
            {
                resultAsStrings = resultAsStrings + squaredDigit.Pop().ToString();
            }
            result = Convert.ToInt32(resultAsStrings);

            return result;
        }

        private static int GetNumber()
        {
            return 123;
        }
    }
}

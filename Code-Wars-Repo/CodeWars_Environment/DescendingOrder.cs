using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public static class DescendingOrder
    {
        public static void Run()
        {
            int answer = 0;
            answer = CreateDescendingOrder(123456789);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        private static int CreateDescendingOrder(int num)
        {
            int result = 0;
            List<int> numbersInNum = new List<int>();
            // Bust a move right here
            while (num > 0)
            {
                int tens = num % 10;
                numbersInNum.Add(tens);
                num = (num - tens) / 10;
            }
            numbersInNum.Sort();
            numbersInNum.Reverse();

            string resultAsString = "";
            foreach(int numb in numbersInNum)
            {
                resultAsString = resultAsString + numb;
            }
            Console.WriteLine(resultAsString);
            return result;
        }
    }
}

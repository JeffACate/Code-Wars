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
            int answer = CreateDescendingOrder(0);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        private static int CreateDescendingOrder(int num)
        {
            int result = 0;
            List<int> numbersInNum = new List<int>();
            // Bust a move right here

            if (num.Equals(0))
            {
                return 0;
            }
            else
            {
                while (num > 0)
                {
                    int tens = num % 10;
                    numbersInNum.Add(tens);
                    num = (num - tens) / 10;
                }
            }
            
            numbersInNum.Sort();
            numbersInNum.Reverse();

            string resultAsString = "";
            foreach(int numb in numbersInNum)
            {
                resultAsString = resultAsString + numb;
            }
            result = Int32.Parse(resultAsString);
            return result;
        }
    }
}

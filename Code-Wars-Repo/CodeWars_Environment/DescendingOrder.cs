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
            answer = CreateDescendingOrder(21445);
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
                numbersInNum.Add(num)
            }
            return result;
        }
    }
}

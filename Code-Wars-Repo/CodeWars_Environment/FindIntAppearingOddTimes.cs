using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public static class FindIntAppearingOddTimes
    {
        public static void Run()
        {
            int[] numbers = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            int number = FindNumberAppearingOddTimes(numbers);
            Console.WriteLine(number);
        }
        private static int FindNumberAppearingOddTimes(int[] numbers)
        {
            int number = 0;
            return number;
        }
    }
}

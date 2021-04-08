using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    class MovingZerosToEnd
    {
        public static void Run()
        {
            int[] sortedArr = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
            DisplayArr(sortedArr);
            Console.ReadKey();

        }

        static int[] MoveZeroes(int[] arr)
        {

            // TODO: Program me
            return arr;        
        }

        static void DisplayArr(int[] arr)
        {
            Console.Write($"sortedArr: {string.Join(", ", arr)}.");
        }
    }
}

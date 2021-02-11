using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    class YoureASquare
    {
        public static void Run()
        {
            Console.WriteLine($"-1 => False => {IsSquare(-1)} ");
            Console.WriteLine($" 0 => True  => {IsSquare(0)} ");
            Console.WriteLine($" 3 => False => {IsSquare(3)} ");
            Console.WriteLine($" 4 => True  => {IsSquare(4)} ");
            Console.WriteLine($"25 => True  => {IsSquare(25)} ");
        }
        private static bool IsSquare(int n)
        {
            return Math.Sqrt(n) - Math.Truncate(Math.Sqrt(n)) == 0 ? true : false;
        }
    }
}

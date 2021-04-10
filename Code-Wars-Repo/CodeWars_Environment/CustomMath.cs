using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public static class CustomMath
    {
        public static void Run()
        {
            int a = 9;
            int b = 3;
            int ans = Multiply(a, b);
            Console.WriteLine($"{a} x {b} = {ans}");
            
            a = 5;
            b = 4;
            ans = Multiply(a, b);
            Console.WriteLine($"{a} x {b} = {ans}");

            a = 165;
            b = 10;
            ans = Multiply(a, b);
            Console.WriteLine($"{a} x {b} = {ans}");
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }


    }
}

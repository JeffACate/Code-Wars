using System;

namespace CodeWars_Environment
{
    public static class SplitStringIntoPair
    {
        public static void Run()
        {
            Console.WriteLine(Solution("abc")); // should return ["ab", "c_"]
            Console.WriteLine(Solution("abcdef")); // should return ["ab", "cd", "ef"]
            Console.ReadLine();
        }

        public static string[] Solution(string str)
        {
            // create an array
            string[] sol = new string[str.Length / 2];
            // loop string and add 2 characters to the array
            // if last string < 2 add "_" 
            sol = str.Split(str.Length / 2);
            return sol;
        }
    }
}


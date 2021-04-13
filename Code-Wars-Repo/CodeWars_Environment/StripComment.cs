using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    static class StripComment
    {
        public static void Run()
        {
            StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" });
        }
        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] lines = text.Split('\n');
            int comment;
            foreach (string line in lines)
            {
                if (line.Contains(commentSymbols[0]))
                {
                    comment = line.IndexOf(commentSymbols[0]);
                }
                else if (line.Contains(commentSymbols[1])
                {
                    comment = line.IndexOf(commentSymbols[0]);
                }
                Console.WriteLine(line.Substring(0, comment));
            }
            return "";
        }
    }
}

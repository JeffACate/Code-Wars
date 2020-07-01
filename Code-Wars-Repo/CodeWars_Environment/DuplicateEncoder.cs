using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public static class DuplicateEncoder
    {
        public static void Run()
        {
            string word = "(( @";
            string encoding = EncodeDuplicate(word);
            Console.WriteLine(encoding);
            Console.ReadLine();
        }
        public static string EncodeDuplicate(string word)
        {
            word = word.ToLower();
            string result = "";
            int count;
            foreach (var letter in word)
            {
                count = word.Count(c => c == letter);
                if (count == 1)
                {
                    result += "(";
                }
                else
                {
                    result += ")";
                }
            }
            return result;
        }
    }
} 

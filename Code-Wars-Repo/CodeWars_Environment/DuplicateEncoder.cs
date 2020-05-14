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
            // GET a string
            string word = "Hello World";
            // Call method
            string encoding = EncodeDuplicate(word);
            //return new string;
            Console.WriteLine(encoding);
        }

        private static string EncodeDuplicate(string word)
        {
            string encoding = "";
            int count = 1;
            List<char> checkedLetters = new List<char>();
            List<char> charactersInWord = new List<char>();
            foreach (char character in word)
            {
                if (!charactersInWord.Contains(character))
                {
                    charactersInWord.Add(character);
                }
                
            }
            foreach (char character in charactersInWord)
            {
                if (true)
                {

                } 
            }
            return encoding;
        }
    }
}

namespace CodeWars_Environment
{
    public static class SplitStringIntoPair
    {
        public static void Run()
        {
            // Console.WriteLine("abc " + " should return [\"ab\", \"c_\"] =>" + Json.Encode(Solution("abc"))); // should return ["ab", "c_"]
            // Console.WriteLine("abcdef " + " should return [\"ab\", \"cd\", \"ef\"] =>" + Json.Encode(Solution("abcdef"))); // should return ["ab", "cd", "ef"]
            Console.ReadLine();
        }

        public static string[] Solution(string str)
        {
            string[] sol = new string[Convert.ToInt32(Math.Ceiling((double)str.Length / 2))];
            int next = 0;
            for (int i = 0; i < str.Length; i++)
            {
                string pair = "";
                int j = i + 1;
                pair = str[i].ToString();
                if (j <= str.Length - 1)
                {
                    pair += str[j].ToString();
                }
                else
                {
                    pair += "_";
                }
                if (i % 2 == 0)
                {
                    sol[next] = pair;
                    next++;
                }
            }
            return sol;
        }
    }
}


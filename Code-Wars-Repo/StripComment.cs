static class StripComment
{
    public static void Run()
    {
        StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new char[] { '#', '!' });
    }
    public static string StripComments(string text, char[] commentSymbols)
    {
        string temp = $"[{commentSymbols[0]}{commentSymbols[1]}]";
        string pattern = temp + @"[\s\w]*";
        RegexOptions options = RegexOptions.Multiline;
        Regex regex = new Regex(pattern, options);

        string substitution = @"";

        string[] lines = text.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = regex.Replace(lines[i], substitution).TrimEnd();
        }

        string result = string.Join("\n", lines);

        Console.WriteLine(result);

        return result;
    }
}
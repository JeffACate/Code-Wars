static class StripComment
{
    public static void Run()
    {
        StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new char[] { '#', '!' });
    }
    public static string StripComments(string text, char[] commentSymbols)
    {
        var firstSymbol = commentSymbols.Length;
        foreach (var sym in commentSymbols)
        {
            if (text.IndexOf(sym) >= 0 && text.IndexOf(sym) < firstSymbol)
            {
                firstSymbol = sym;
            }
        }
        return text.Substring(0, firstSymbol);
    }
}
public static class DirectionReductionKata
{
    public static string[] dirReduc(String[] arr)
    {
        var reducedDirections = arr.ToList();
        var oppos = new Dictionary<string, string>()
        {
            { "NORTH", "SOUTH" },
            { "SOUTH", "NORTH" },
            { "EAST", "WEST" },
            { "WEST", "EAST" },
        };
        for (int i = 0; i < reducedDirections.Count - 1; i++)
        {
            if (reducedDirections.Count <= 1)
            {
                return reducedDirections.ToArray();
            }
            if (reducedDirections[i] == oppos[reducedDirections[i + 1]])
            {
                reducedDirections.RemoveRange(i, 2);
                i = -1;
            }
        }
        foreach (var a in reducedDirections) { System.Console.Write(a + " "); }
        return reducedDirections.ToArray();
    }

    public static void Run()
    {
        Test1();
        Test2();
    }

    public static void Test1()
    {
        string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] b = new string[] { "WEST" };
        System.Console.WriteLine($"test 1 = {b.Equals(dirReduc(a))}");
    }

    public static void Test2()
    {
        string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        System.Console.WriteLine($"test 2 = {b.Equals(dirReduc(a))}");
    }
}
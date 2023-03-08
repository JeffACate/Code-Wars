public class Snail
{
    private int[][] array =
    {
        new []{1, 2, 3},
        new []{4, 5, 6},
        new []{7, 8, 9}
    };
    private int height;
    private int width;

    public Snail()
    {
        height = array.Length;
        width = array[0].Count();
    }

    public int[] Run()
    {
        var list = new List<int>();
        DisplayDims();

        for (int i = 0; i < width - 1; i++)
        {
            list.Add(array[0][i]);
            Console.Write(array[0][i]);
        }
        Console.WriteLine();

        for (int i = 0; i < height; i++)
        {
            Console.Write(array[i][width - 1]);
            list.Add(array[i][width - 1]);
        }
        Console.WriteLine();

        width--;
        height--;
        DisplayDims();

        for (int i = width - 1; i >= 0; i--)
        {
            list.Add(array[height][i]);
            Console.Write(array[height][i]);
        }
        Console.WriteLine();

        return list.ToArray();
    }
    public void DisplayDims()
    {
        Console.WriteLine("Height " + height);
        Console.WriteLine("Width " + width);
    }

    public int[] Run1()
    {
        List<int> list = new List<int>();
        foreach (int item in array[0])
        {
            list.Add(item);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }

            list.Add(array[i][array.Length - 1]);
        }
        int lastLine = array.Length - 1;
        for (int j = array[lastLine].Length - 2; j >= 0; j--)
        {
            list.Add(array[lastLine][j]);
        }
        for (int k = 0; k < array[lastLine - 1].Length - 1; k++)
        {
            list.Add(array[lastLine - 1][k]);
        }

        //
        // TO DO: implimend recursion
        //

        // display 2d array
        foreach (int[] arr in array)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        //display resulting 1d array
        foreach (int item2 in list)
        {
            Console.Write($"{item2} ");
        }

        // return array
        return list.ToArray();
    }
}
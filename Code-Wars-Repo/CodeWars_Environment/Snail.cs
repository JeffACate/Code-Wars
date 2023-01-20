namespace CodeWars_Environment
{
    public static class Snail
    {
        public static int[] Run()
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
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
}

namespace CodeWars_Environment
{
    class MovingZerosToEnd
    {
        public static void Run()
        {
            int[] sortedArr = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            DisplayArr(sortedArr);

            sortedArr = MoveZeroes(new int[] { 0, 0, 0 });
            DisplayArr(sortedArr);
        }

        static int[] MoveZeroes(int[] arr)
        {
            int count = 0;
            int j = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
                else
                {
                    arr[j] = arr[i];
                    j++;
                }
            }
            while (count > 0)
            {
                arr[j] = 0;
                j++;
                count--;
            }
            // TODO: Program me
            return arr;
        }

        static void DisplayArr(int[] arr)
        {
            Console.WriteLine($"sortedArr: {string.Join(", ", arr)}");
        }
    }
}

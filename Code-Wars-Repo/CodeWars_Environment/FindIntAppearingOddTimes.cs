namespace CodeWars_Environment
{
    public static class FindIntAppearingOddTimes
    {
        public static void Run()
        {
            int[] numbers = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            int number = FindNumberAppearingOddTimes(numbers);
            Console.WriteLine(number);
            Console.ReadLine();
        }
        private static int FindNumberAppearingOddTimes(int[] numbers)
        {
            foreach (int num in numbers)
            {
                int count = 0;
                count = numbers.Count(c => c == num);
                if (count % 2 != 0)
                {
                    return num;
                }
            }
            return numbers[0];
        }
    }
}

namespace CodeWars_Environment
{
    class SquareEveryDigit
    {
        public static void Run()
        {
            int testNumber = 123;
            int squaredNumber = SquareDigits(testNumber);
            Console.WriteLine($"{testNumber} processed is {squaredNumber}");
            Console.ReadLine();
        }
        public static int SquareDigits(int testNumber)
        {
            Stack<string> squaredDigit = new Stack<string>();
            int result;
            for (int i = testNumber; i > 0; i = (i - (i % 10)) / 10)
            {
                int number = i % 10;
                squaredDigit.Push(Math.Pow(number, 2).ToString());
            }
            string resultAsStrings = "";
            while (squaredDigit.Count > 0)
            {
                resultAsStrings = resultAsStrings + squaredDigit.Pop().ToString();
            }
            result = Convert.ToInt32(resultAsStrings);

            return result;
        }

    }
}

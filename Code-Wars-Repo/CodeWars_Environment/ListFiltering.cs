using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Helpers;

namespace CodeWars_Environment
{
    public class ListFiltering
    {
        public static void Run()
        {
            List<object> list = new List<object>() { 1, 2, "a", "b" };
            var list2 = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            IEnumerable<int> numbers = GetIntegersFromList(list);
            Console.WriteLine(Json.Encode(numbers));
            numbers = GetIntegersFromList(list2);
            Console.WriteLine(Json.Encode(numbers));
            Console.ReadLine();
            
        }
        private static IEnumerable<int> GetIntegersFromList(List<object> listOfObjects)
        {
            List<int> numbers = new List<int> ();
            foreach (object item in listOfObjects)
            {
                if (item.GetType().Name.ToString().Equals("Int32"))
                {
                    numbers.Add(Convert.ToInt32(item));
                }
            }
            return numbers;
        }
    }
}

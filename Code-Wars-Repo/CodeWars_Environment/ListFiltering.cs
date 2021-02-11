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
            IEnumerable<int> numbers = GetIntegersFromList(list);
            Console.WriteLine(Json.Encode(numbers));
            Console.ReadLine();
            
        }
        private static IEnumerable<int> GetIntegersFromList(List<object> listOfObjects)
        {            
            foreach (object item in list)
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

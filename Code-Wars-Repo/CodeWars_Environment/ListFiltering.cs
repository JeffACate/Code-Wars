using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Environment
{
    public class ListFiltering
    {
        public static void Run()
        {
            List<object> list = new List<object>() { 1, 2, "a", "b" };
            List<int> numbers = GetIntegersFromList(list);
            
        }
        private static List<int> GetIntegersFromList(List<object> list)
        {
            List<int> numbers = new List<int>();
            throw new NotImplementedException();
            return numbers;
        }
    }
}

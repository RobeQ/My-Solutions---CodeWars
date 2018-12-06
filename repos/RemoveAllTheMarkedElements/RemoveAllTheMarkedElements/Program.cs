using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllTheMarkedElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4 };
            int[] valuesList = new int[] { 1, 3 };
            int [] a = Remove(integerList, valuesList);
        }

        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            // return integerList.Where(x => !valuesList.Contains(x)).ToArray(); Rozwiązanie LINQ z neta

            List<int> intList = new List<int>(integerList);
            foreach (int value in valuesList)
                intList.RemoveAll(v => v == value);
            return intList.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_travel
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            Console.WriteLine(chooseBestSum(163, 3, ts));
        }

        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            int? output = null;
            var result = ls.ToArray().DifferentCombinations(k);

            foreach (var value in result)
            {
                if (value.ToArray().Sum() <= t && (output < value.ToArray().Sum() || output == null)) output = value.Sum();
            }
            return output;
        }

        public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}

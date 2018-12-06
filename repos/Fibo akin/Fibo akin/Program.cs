using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo_akin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthSupUK(50, 10));
            Console.WriteLine(Comp(200));
        }

        public static long LengthSupUK(int n, int k)
        {
            int count = 0;
            foreach (int value in Values(n))
                if(value >= k) count++;
            return count;
        }

        public static long Comp(int n)
        {
            int[] values = Values(n);
            int count = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1]) count++;
            }
            return count;
        }

        public static int[] Values(int n)
        {
            int[] values = new int[n];
            values[0] = 1;
            values[1] = 1;

            int higherIndex = 0;
            int lowerIndex = 0;
            for (int i = 2; i < n; i++)
            {
                higherIndex = i - values[i - 1];
                lowerIndex = i - values[i - 2];
                values[i] = values[higherIndex] + values[lowerIndex];
            }
            return values;
        }
    }
}

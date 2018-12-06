using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int a in ReverseSeq(5))
            {
                Console.WriteLine(a);
            }
        }

        public static int[] ReverseSeq(int n)
        {
            // return Enumerable.Range(1, n).Reverse().ToArray();      

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = i + 1;
            Array.Reverse(array);
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayMissing = { 0, 2, 4, 1, 3, 6, 7, 9, 8 };
            Console.WriteLine(FindMissing(arrayMissing));          
        }

        public static int FindMissing(int[] array)
        {
            Array.Sort(array);

            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != i)
                {
                    a = i;
                    break;
                }
                    
            }
            return a;
        }
    }
}

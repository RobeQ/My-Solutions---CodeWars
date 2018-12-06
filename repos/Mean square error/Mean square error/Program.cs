using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_square_error
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 10, 20, 10, 2 };
            int[] a2 = { 10, 25, 5, -2 };
            Console.WriteLine(Solution(a1, a2));
        }

        //solution([1,2,3], [4,5,6])                  // should === 9 ((9 + 9 + 9) / 3)
        //solution([10, 20, 10, 2], [10, 25, 5, -2])  // should === 16.5 ((0 + 25 + 25 + 16) / 4)  
        //solution([-1,0], [0,-1])                    // should === 1 ((1 + 1) / 2)

        public static double Solution(int[] firstArray, int[] secondArray)
        {
            // return firstArray.Zip(secondArray, (x, y) => (x - y) * (x - y)).Average(); Rozwiązanie LINQ

            double a = 0;
            for (int i = 0; i < firstArray.Length; i++)
                a += Math.Pow(Math.Abs(firstArray[i] - secondArray[i]), 2);
            return a / firstArray.Length;
        }
    }
}

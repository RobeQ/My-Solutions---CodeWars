using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_Array
{
    class Program
    {
        // TASK DESCRIPTION
        // Given an array of integers of any length, return an array that has 1 added to the value represented by the array.
        // the array can't be empty
        // only non-negative, single digit integers are allowed
        // Return nil (or your language's equivalent) for invalid inputs.
        // Examples
        // For example the array[2, 3, 9] equals 239, adding one would return the array [2, 4, 0].
        // [4, 3, 2, 5] would return [4, 3, 2, 6]

        static void Main(string[] args)
        {
            foreach (var v in UpArray(new int[] { 4,3,2,5,9,9 }))
            {
                Console.WriteLine(v);
            }
        }

        public static int[] UpArray(int[] num)
        {  
            if (num.Length == 0) return null;
            foreach (int i in num)
                if (i < 0 || i.ToString().Length > 1) return null;


            List<int> values = new List<int>();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == 9 && i == 0)
                {
                    values.Add(0);
                    values.Add(0);
                    values[0] = 1;
                }
                else if (num[i] == 9) values.Add(0);
                else
                {
                    values.Add(num[i] += 1);
                    for (int j = i - 1; j >= 0; j--)
                    {
                        values.Add(num[j]);
                    }
                    values.Reverse();
                    break;
                }
            }
            return values.ToArray();
        }
    }
}

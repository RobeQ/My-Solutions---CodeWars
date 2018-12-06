using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_or_rotate
{
    class Program
    {
        // TASK DESCRIPTION
        // The input is a string str of digits.
        // Cut the string into chunks (a chunk here is a substring of the initial string) of size sz(ignore the last chunk if its size is less than sz).
        // If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2, 
        // reverse that chunk; otherwise rotate it to the left by one position.Put together these modified chunks and return the result as a string.
        // If sz is <= 0 or if str is empty return ""
        // sz is greater(>) than the length of str it is impossible to take a chunk of size sz hence return "".
        // Examples:
        // revrot("123456987654", 6) --> "234561876549"
        // revrot("123456987653", 6) --> "234561356789"

        static void Main(string[] args)
        {
            Console.WriteLine(RevRot("1994033775182780067155464327690480265895", 5));
        }

        public static string RevRot(string strng, int sz)
        {
            if (sz <= 0 || strng == string.Empty || sz > strng.Length) return "";

            string output = "";
            char[] array;
            int[] arrayInt;

            int a = 0;
            for (int i = 0; i < strng.Length / sz; i++)
            {
                array = strng.Substring(a, sz).ToArray();
                arrayInt = Array.ConvertAll(array, c => (int)Char.GetNumericValue(c));
                if (arrayInt.Sum() % 2 == 0) output += string.Join("", array.Reverse());
                else output += strng.Substring(a + 1, sz - 1) + strng[a];
                a += sz;
            }
            return output;
        }
    }
}

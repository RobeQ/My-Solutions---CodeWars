using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramblies
{
    class Program
    {
        // Task DESCRIPTION
        // Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.
        // Notes:
        // Only lower case letters will be used(a-z). No punctuation or digits will be included.
        // Performance needs to be considered
        // Input strings s1 and s2 are null terminated.
        // Examples:
        // scramble('rkqodlw', 'world') ==> True
        // scramble('cedewaraaossoqqyt', 'codewars') ==> True
        // scramble('katas', 'steak') ==> False

        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("aabbcamaomsccdd", "commas"));
        }

        public static bool Scramble(string str1, string str2)
        {
            // return str2.All(x => str1.Count(y => x == y) >= str2.Count(y => y == x));

            List<char> strOneList = new List<char>(str1.ToCharArray());

            int count = 0;
            foreach (char letter in str2)
            {
                for (int i = 0; i < strOneList.Count; i++)
                {
                    if (letter == strOneList[i])
                    {
                        strOneList.RemoveAt(i);
                        count++;
                        break;
                    }
                }
                if (count == str2.Length) return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }

        public static int GetVowelCount(string str)
        {
            // return str.Count(i => "aeiou".Contains(i));  // EASIER WAY

            int vowelCount = 0;

            foreach (char vowel in str)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    vowelCount++;
            }

            return vowelCount;
        }
    }
}

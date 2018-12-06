using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detect_Pangram
{
        // TASK DESCRIPTION
        // A pangram is a sentence that contains every single letter of the alphabet at least once.
        // For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once(case is irrelevant).
        // Given a string, detect whether or not it is a pangram.Return True if it is, False if not.Ignore numbers and punctuation.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));
        }

        public static bool IsPangram(string str)
        {
            return string.Concat(str.ToLower().Where(x => Char.IsLetter(x)).OrderBy(c => c).Distinct()).Length >= 26;
        }
    }
}

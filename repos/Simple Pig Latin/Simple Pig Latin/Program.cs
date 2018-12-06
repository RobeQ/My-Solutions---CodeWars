using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Pig_Latin
{
    class Program
    {
        // TASK DESCRIPTION
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word.Leave punctuation marks untouched.
        // Examples
        // pigIt('Pig latin is cool'); // igPay atinlay siay oolcay
        // pigIt('Hello world !');     // elloHay orldway !

        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("bfn omv aeo cpc foi mlb ale !"));
        }

        public static string PigIt(string str)
        {
            string output = "";
            string[] words = str.Split();

            foreach (string word in words)
            {
                if (word.Length > 1 && words.Last() != word)
                    output += word.Substring(1, word.Length - 1) + word.First() + "ay ";  
                else if(word.Length > 1 && words.Last() == word)
                    output += word.Substring(1, word.Length - 1) + word.First() + "ay";
                else if (word.Length == 1 && !Char.IsLetter(word[0]))
                    output += word[0];
            }
            return output;
        }
    }
}

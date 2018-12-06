using System;
using System.Collections.Generic;
using System.Text;

namespace Duplicate_Encoder___CodeWars
{
    class Kata
    {
        public static string DuplicateEncode(string word)
        {
            string Word = word.ToLower();
            string actualWord = "";

            int a = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (Word[i] == Word[j])
                        a++;                   
                }
                if (a > 1)
                    actualWord += ")";
                else
                    actualWord += "(";

                a = 0;
            }
            return actualWord;
        }
    }
}

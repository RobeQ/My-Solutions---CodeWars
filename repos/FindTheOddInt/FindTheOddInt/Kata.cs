using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheOddInt
{
    class Kata
    {
        public static int find_it(int[] seq)
        {

            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;


            int a = 0;
            int b = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = 0; j < seq.Length; j++)
                {
                    b = seq[i];
                    if (seq[i] == seq[j])
                        a++;
                }
                if (a % 2 != 0)
                    break;
            }
            return b;
        }
    }
}

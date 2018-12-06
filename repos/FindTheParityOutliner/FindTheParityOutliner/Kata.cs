using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindTheParityOutliner
{
    class Kata
    {
        public static int Find(int[] integers)
        {
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 != 0);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();

            int n = 0;

            int b = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                int a = integers[i] % 2;
                if (a == 0)
                    b++;
            }

            if (b > 1)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    n = integers[i] % 2;
                    if (n != 0)
                    {
                        n = integers[i];
                        return n;
                    }
                }
            }
            for (int i = 0; i < integers.Length; i++)
            {
                n = integers[i] % 2;
                if (n == 0)
                {
                    n = integers[i];
                    break;
                }
            }
            return n;
        }
    }
}

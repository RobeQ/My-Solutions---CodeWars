using System;
using System.Collections.Generic;
using System.Text;

namespace UnflattenAList
{
    class Kata
    {
        public static object[] Unflatten(int[] flatArray)
        {
            object[] expected = new object[] { };

            int a = 0;
            for (int i = 0; i < flatArray.Length; i++)
            {
                if (flatArray[i] < 3)
                    expected[a] = flatArray[i];
                else
                {
                    expected[a] = flatArray.CopyTo()
                    i = flatArray[i];
                }
                a++;
            }

            return expected;
        }
    }
}


/*var input = new int[] { 3, 5, 2, 1 };
var expected = new object[] { new int[] { 3, 5, 2 }, 1 };
Assert.AreEqual(expected, Kata.Unflatten(input));*/
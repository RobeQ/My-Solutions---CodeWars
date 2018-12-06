using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(1424));
        }

        public static int DigitalRoot(long n)
        {
            if (n.ToString().Length == 1)
                return (int)n;
            char[] numberArray = n.ToString().ToArray();

            int value = 0;
            for (int i = 0; i < numberArray.Length; i++)
                value += (int)Char.GetNumericValue(numberArray[i]);

            return DigitalRoot(value);
        }
    }
}

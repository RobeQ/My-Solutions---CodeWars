using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplies_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }


        public static int Solution(int value)
        {
            //  return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum(); Wersja z neta
            List<int> digits = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    digits.Add(i);
                else if (i % 3 == 0)
                    digits.Add(i);
                else if (i % 5 == 0)
                    digits.Add(i);
            }
            return digits.Sum();
        }
    }
}

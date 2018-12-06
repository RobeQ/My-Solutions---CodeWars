using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cake(542, "kjlect"));
        }

        public static string Cake(int x, string y)
        {
            int candlesDroped = 0;

            for (int i = 0; i < y.Length; i++)
            {
                if (i % 2 != 0)
                    candlesDroped += (int)y[i] % 32;
                else
                    candlesDroped += y[i];
            }
            string output = ((double)candlesDroped / x * 100) > 70 ? "Fire!" : "That was close!";
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_trailing_zeros_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(531));
        }

        //Assert.AreEqual(1, Kata.TrailingZeros(5));
        //Assert.AreEqual(6, Kata.TrailingZeros(25));
        //Assert.AreEqual(131, Kata.TrailingZeros(531));

        public static int TrailingZeros(int n)
        {
            int output = 0;
            int pow = 1;
            do
                output += n / (int)Math.Pow(5, pow++);
            while (n / (int)Math.Pow(5, pow) >= 1);
            return output;
        }
    }
}

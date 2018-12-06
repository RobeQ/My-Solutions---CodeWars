using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Ann
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list = John(4);
            foreach (long digit in list)
            {
                Console.WriteLine(digit);
            }
            //Console.WriteLine(SumJohn(1));
        }

        public static List<long> John(long n)
        {
            count(n);
            return new List<long>(JohnTab);
        }

        public static List<long> Ann(long n)
        {
            count(n);
            return new List<long>(AnnTab);
        }

        public static long SumJohn(long n)
        {
            count(n);
            return JohnTab.Sum();
        }

        public static long SumAnn(long n)
        {
            count(n);
            return AnnTab.Sum();
        }

        public static long[] JohnTab;
        public static long[] AnnTab;

        private static void count(long days)
        {
            JohnTab = new long[days];
            AnnTab = new long[days];

            JohnTab[0] = 0;
            AnnTab[0] = 1;

            for (int i = 1; i < days; i++)
            {
                JohnTab[i] = i - AnnTab[JohnTab[i - 1]];
                AnnTab[i] = i - JohnTab[AnnTab[i - 1]];
            }
        }
    }
}

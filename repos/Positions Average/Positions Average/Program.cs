using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positions_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PosAverage("466960, 069060, 494940, 060069, 060090, 640009, 496464, 606900, 004000, 944096"));
        }

        public static double PosAverage(string s)
        {
            int commonPositions = 0;
            string[] numbers = s.Split(',').Select(p => p.Trim()).ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i < j)
                        for (int k = 0; k < numbers[i].Length; k++)
                        {
                            if (numbers[i][k] == numbers[j][k])
                                commonPositions++;
                        }
                }
            }
            double average = (((numbers.Length * (numbers.Length - 1)) / 2)) * numbers[0].Length;

            return (double)commonPositions / ((numbers.Length * (numbers.Length - 1) / 2) * numbers[0].Length) * 100;
        }
    }
}

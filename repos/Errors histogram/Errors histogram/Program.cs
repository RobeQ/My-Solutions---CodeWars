using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors_histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            // "u  3     ***\rw  4     ****\rx  6     ******\rz  6     ******"

            Console.WriteLine(hist("tpwaemuqxdmwqbqrjbeosjnejqorxdozsxnrgpgqkeihqwybzyymqeazfkyiucesxwutgszbenzvgxibxrlvmzihcbzzzzzz"));
        }

        //public static string hist(string s)
        //{
        //    int u = 0, w = 0, x = 0, z = 0;
        //    foreach (char c in s)
        //    {
        //        if (c == 'u')
        //            u++;
        //        else if (c == 'w')
        //            w++;
        //        else if (c == 'x')
        //            x++;
        //        else if (c == 'z')
        //            z++;
        //    }

        //    return string.Format("{0}{1}{2}{3}", hLine('u', u), hLine('w', w),
        //                                         hLine('x', x), hLine('z', z)).Trim('\r');
        //}

        //private static string hLine(char c, int n)
        //{
        //    return (n == 0) ? "" : string.Format("{0,-2} {1,-6}{2}\r", c, n, new string('*', n));
        //}

        public static string hist(string s)
        {
           int countU = 0;
            int countW = 0;
            int countX = 0;
            int countZ = 0;
            string output = "";

            char[] letters = s.ToCharArray();
           Array.Sort(letters);

            foreach (char letter in letters)
            {
                switch(letter)
                {
                    case 'u':
                        countU++;
                        break;
                    case 'w':
                        countW++;
                        break;
                    case 'x':
                        countX++;
                        break;
                    case 'z':
                        countZ++;
                        break;
                }
            }  
            if (countU >= 1) output += "u  " + countU + howManyStars(countU) + "\r";
            if (countW >= 1) output += "w  " + countW + howManyStars(countW) + "\r";
            if (countX >= 1) output += "x  " + countX + howManyStars(countX) + "\r";
            if (countZ >= 1) output += "z  " + countZ + howManyStars(countZ) + "\r";

            Console.WriteLine(string.Format("{0,-2} {1, -6}{2}\r", 'Q', 1, new string('*', 1)));

            return output.Trim('\r');
        }

        public static string howManyStars(int count)
        {
            string stars = "     ";
            if (count.ToString().Length > 1)
                stars = "    ";
            while (count > 0)
            {
                stars += "*";
                count--;
            }
            return stars;
        }
    }
}

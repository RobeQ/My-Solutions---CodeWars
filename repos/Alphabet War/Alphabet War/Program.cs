using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_War
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(AlphabetWar("zdqmwpbs"));
        }

        //The left side letters and their power:
        // w - 4
        // p - 3
        // b - 2
        // s - 1

        //The right side letters and their power:
        // m - 4
        // q - 3
        // d - 2
        // z - 1

        public static string AlphabetWar(string fight)
        {
            int leftSide = (fight.Count(c => c == 'w')) * 4;
            leftSide += (fight.Count(c => c == 'p')) * 3;
            leftSide += (fight.Count(c => c == 'b')) * 2;
            leftSide += (fight.Count(c => c == 's')) * 1;
            int rightSide = (fight.Count(c => c == 'm')) * 4;
            rightSide += (fight.Count(c => c == 'q')) * 3;
            rightSide += (fight.Count(c => c == 'd')) * 2;
            rightSide += (fight.Count(c => c == 'z')) * 1;

            string result = (leftSide > rightSide) && (leftSide != rightSide) ? "Left side wins!" : "Right side wins!";
            if (leftSide == rightSide) result = "Let's fight again!";
            return result;

            ////int leftSide = 0;
            ////int rightSide = 0;
            ////string result = "";

            ////for (int i = 0; i < fight.Length; i++)
            ////{
            ////    switch(fight[i])
            ////    {
            ////        case 'w':
            ////            leftSide += 4;
            ////            break;
            ////        case 'p':
            ////            leftSide += 3;
            ////            break;
            ////        case 'b':
            ////            leftSide += 2;
            ////            break;
            ////        case 's':
            ////            leftSide += 1;
            ////            break;
            ////        case 'm':
            ////            rightSide += 4;
            ////            break;
            ////        case 'q':
            ////            rightSide += 3;
            ////            break;
            ////        case 'd':
            ////            rightSide += 2;
            ////            break;
            ////        case 'z':
            ////            rightSide += 1;
            ////            break;
            ////    }
            ////}
            ////if (leftSide > rightSide) result = "Left side wins!";
            ////else if (leftSide < rightSide) result = "Right side wins!";
            ////else result = "Let's fight again!";
            ////return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_four
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "A_Red", "B_Red", "C_Red", "D_Red", "E_Red", "F_Red",
                "G_Red",
                "A_Red",
                "B_Red",
                "C_Red",
                "D_Red",
                "E_Red",
                "F_Red",
                "G_Red",
                "A_Red",
                "B_Red",
                "C_Red",
                "D_Red",
                "E_Red",
                "F_Red",
                "G_Red",
                "A_Red",
                "B_Red",
                "C_Red",
                "D_Red",
                "E_Red",
                "F_Red",
                "G_Red",
                "A_Red",
                "B_Red",
                "C_Red",
                "D_Red",
                "E_Red",
                "F_Red",
                "G_Red",
                "A_Red",
                "B_Red",
                "C_Red",
                "D_Red",
                "E_Red",
                "F_Red",
                "G_Red"
            };
            Console.WriteLine(WhoIsWinner(myList));
        }

        // retrun "Red" or "Yellow" or "Draw"

        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            int countA = 0, countB = 0, countC = 0, countD = 0, countE = 0, countF = 0, countG = 0;
            string[,] strip = new string[6, 7];

            foreach (string colour in piecesPositionList)
            {
                switch (colour.First())
                {
                    case 'A':
                        strip[countA, 0] = colour.Substring(2);
                        countA++;
                        break;
                    case 'B':
                        strip[countB, 1] = colour.Substring(2);
                        countB++;
                        break;
                    case 'C':
                        strip[countC, 2] = colour.Substring(2);
                        countC++;
                        break;
                    case 'D':
                        strip[countD, 3] = colour.Substring(2);
                        countD++;
                        break;
                    case 'E':
                        strip[countE, 4] = colour.Substring(2);
                        countE++;
                        break;
                    case 'F':
                        strip[countF, 5] = colour.Substring(2);
                        countF++;
                        break;
                    case 'G':
                        strip[countG, 6] = colour.Substring(2);
                        countG++;
                        break;
                }
                if (CheckHorizontal(strip).Length > 1) return CheckHorizontal(strip);
                if (CheckVertical(strip).Length > 1) return CheckVertical(strip);
                if (CheckDiagonalOne(strip).Length > 1) return CheckDiagonalOne(strip);
                if (CheckDiagonalTwo(strip).Length > 1) return CheckDiagonalTwo(strip);
                if (CheckDiagonalThree(strip).Length > 1) return CheckDiagonalThree(strip);
                if (CheckDiagonalFour(strip).Length > 1) return CheckDiagonalFour(strip);
            }
            return "Draw";
        }

        private static string CheckHorizontal(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;
            for (int i = 0; i < strip.GetLength(0); i++)
            {
                for (int j = 0; j < strip.GetLength(1); j++)
                {
                    if (strip[i, j] == colour && strip[i, j] != null)
                        fourTimes++;
                    else if (strip[i, j] != colour && strip[i, j] != null)
                    {
                        colour = strip[i, j];
                        fourTimes = 1;
                    }
                    else
                        colour = "";
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }
            return "";
        }

        private static string CheckVertical(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;
            for (int i = 0; i < strip.GetLength(1); i++)
            {
                for (int j = 0; j < strip.GetLength(0); j++)
                {
                    if (strip[j, i] == colour && strip[j, i] != null)
                        fourTimes++;
                    else if (strip[j, i] != colour && strip[j, i] != null)
                    {
                        colour = strip[j, i];
                        fourTimes = 1;
                    }
                    else
                        colour = "";
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }
            return "";
        }

        private static string CheckDiagonalTwo(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;

            for (int k = 5; k >= 0; k--)
            {
                int i = k;
                int j = 0;
                while (i <= 5)
                {
                    if (strip[i, j] == colour && strip[i, j] != null)
                        fourTimes++;
                    else if (strip[i,j] != colour && strip[i, j] != null)
                    {
                        colour = strip[i, j];
                        fourTimes = 1;
                    }
                    else
                        colour = "";

                    i = i + 1;
                    j = j + 1;
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }

            return "";
        }

        private static string CheckDiagonalThree(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;

            for (int k = 0; k <= 5; k++)
            {
                int i = k;
                int j = 6;
                while (i >= 0)
                {
                    if (strip[i, j] == colour && strip[i, j] != null)
                        fourTimes++;
                    else if (strip[i, j] != colour && strip[i, j] != null)
                    {
                        colour = strip[i, j];
                        fourTimes = 1;
                    }
                    else
                        colour = "";

                    i = i - 1;
                    j = j - 1;
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }

            return "";
        }

        private static string CheckDiagonalFour(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;

            for (int k = 0; k <= 5; k++)
            {
                int i = k;
                int j = 0;
                while (i >= 0)
                {
                    if (strip[i, j] == colour && strip[i, j] != null)
                        fourTimes++;
                    else if (strip[i, j] != colour && strip[i, j] != null)
                    {
                        colour = strip[i, j];
                        fourTimes = 1;
                    }
                    else
                        colour = "";

                    i = i - 1;
                    j = j + 1;
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }

            return "";
        }

        private static string CheckDiagonalOne(string[,] strip)
        {
            string colour = "";
            int fourTimes = 0;

            for (int k = 5; k >= 0; k--)
            {
                int i = k;
                int j = 6;
                while (i <= 5)
                {
                    if (strip[i, j] == colour && strip[i, j] != null)
                        fourTimes++;
                    else if (strip[i, j] != colour && strip[i, j] != null)
                    {
                        colour = strip[i, j];
                        fourTimes = 1;
                    }
                    else
                        colour = "";

                    i = i + 1;
                    j = j - 1;
                    if (fourTimes == 4) return colour;
                }
                fourTimes = 0;
            }

            return "";
        }
    }
}

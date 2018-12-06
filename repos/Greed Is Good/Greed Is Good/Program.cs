using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed_Is_Good
{
    class Program
    {
        //Greed is a dice game played with five six-sided dice.Your mission, should you choose to accept it, is to score a throw according to these rules. 
        //You will always be given an array with five six-sided dice values.
        //Three 1's => 1000 points
        //Three 6's =>  600 points
        //Three 5's =>  500 points
        //Three 4's =>  400 points
        //Three 3's =>  300 points
        //Three 2's =>  200 points
        //One   1   =>  100 points
        //One   5   =>   50 point
        //A single die can only be counted once in each roll. For example, 
        //a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points,but not both in the same roll.
        //Example scoring
        //Throw Score
        //---------   ------------------
        //5 1 3 4 1   50 + 2 * 100 = 250
        //1 1 1 3 1   1000 + 100 = 1100
        //2 4 4 5 4   400 + 50 = 450

        static void Main(string[] args)
        {
        }

        public static int Score(int[] dice)
        {
            int points = 0;

            int countOne = 0;
            int countTwo = 0;
            int countThree = 0;
            int countFour = 0;
            int countFive = 0;
            int countSix = 0;

            foreach (int digit in dice)
            {
                switch(digit)
                {
                    case 1:
                        countOne++;
                        if (countOne == 1) points += 100;
                        if (countOne == 2) points += 100;
                        if (countOne == 3) points += 800;
                        if (countOne == 4) points += 100;
                        if (countOne == 5) points += 100;
                        break;
                    case 2:
                        countTwo++;
                        if (countTwo == 3) points += 200;
                        break;
                    case 3:
                        countThree++;
                        if (countThree == 3) points += 300;
                        break;
                    case 4:
                        countFour++;
                        if (countFour == 3) points += 400;
                        break;
                    case 5:
                        countFive++;
                        if (countFive == 1) points += 50;
                        if (countFive == 2) points += 50;
                        if (countFive == 3) points += 400;
                        if (countFive == 4) points += 50;
                        if (countFive == 5) points += 50;
                        break;
                    case 6:
                        countSix++;
                        if (countSix == 3) points += 600;
                        break;
                }
            }
            return points;
        }
    }
}

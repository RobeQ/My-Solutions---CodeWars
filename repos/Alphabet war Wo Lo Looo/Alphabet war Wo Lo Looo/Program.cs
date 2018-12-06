using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_war_Wo_Lo_Looo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetWar("dtqbmjedwt"));
            //Console.WriteLine("Right side wins!" + "  " + AlphabetWar("z"));
            //Console.WriteLine("Left side wins!" + "  " + AlphabetWar("tz"));
            //Console.WriteLine("Right side wins!" + "  " + AlphabetWar("jz"));
            //Console.WriteLine("Left side wins!" + "  " + AlphabetWar("zt"));
            //Console.WriteLine("Right side wins!" + "  " + AlphabetWar("tzj"));
            //Console.WriteLine("Let's fight again!" + "  " + AlphabetWar("zdqmwpbs"));
            //Console.WriteLine("Left side wins!" + "  " + AlphabetWar("ztztztzs"));
        }


        public static string AlphabetWar(string fight)
        {
            StringBuilder letters = new StringBuilder();
            int rightSide = 0;
            int leftSide = 0;

            if (fight.Length == 1)
            {
                letters.Append(fight[0]);
            }
            else if (fight.Length == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (fight[0] == 't' || fight[0] == 'j')
                        letters.Append(ChangeLetter(fight[1], fight[0]));
                    else if (fight[1] == 't' || fight[1] == 'j')
                        letters.Append(ChangeLetter(fight[0], fight[1]));
                    else
                        letters.Append(fight[i]);

                }
            }
            else
            {
                for (int i = 0; i < fight.Length; i++)
                {
                    if (fight[i] == 't' || fight[i] == 'j') continue;
                    if (i == 0 && (fight[i + 1] == 't' || fight[i + 1] == 'j'))
                    {
                        letters.Append(ChangeLetter(fight[i], fight[i + 1]));
                    }
                    else if(i > 0 && i < fight.Length - 1)
                    {
                        if ((fight[i + 1] == 't' && fight[i - 1] == 'j') || (fight[i + 1] == 'j' && fight[i - 1] == 't'))
                        {
                            letters.Append(fight[i]);
                        }
                        else if ((fight[i + 1] == 't' && fight[i - 1] == 't') || (fight[i + 1] == 'j' && fight[i - 1] == 'j'))
                        {
                            letters.Append(ChangeLetter(fight[i], fight[i + 1]));
                        }
                        else if(fight[i - 1] == 't' || fight[i -1] == 'j')
                        {
                            letters.Append(ChangeLetter(fight[i], fight[i - 1]));
                        }
                        else if (fight[i + 1] == 't' || fight[i + 1] == 'j')
                        {
                            letters.Append(ChangeLetter(fight[i], fight[i + 1]));
                        }
                        else
                        {
                            letters.Append(fight[i]);
                        }
                    }
                    else if(i == fight.Length - 1 && (fight[i - 1] == 't' || fight[i - 1] == 'j'))
                    {
                        letters.Append(ChangeLetter(fight[i], fight[i - 1]));
                    }
                    else
                    {
                        letters.Append(fight[i]);
                    }
                }
            }
                       

            foreach (char v in letters.ToString())
            {
                switch(v)
                {
                    case 'w': leftSide += 4; break;
                    case 'p': leftSide += 3; break;
                    case 'b': leftSide += 2; break;
                    case 's': leftSide += 1; break;
                    case 'm': rightSide += 4; break;
                    case 'q': rightSide += 3; break;
                    case 'd': rightSide += 2; break;
                    case 'z': rightSide += 1; break;
                    default:
                        break;
                }
            }
            if (rightSide > leftSide) return "Right side wins!";
            else if (rightSide < leftSide) return "Left side wins!";
            return "Let's fight again!";
        }

        private static char ChangeLetter(char v, char tj)
        {
            if(tj == 'j')
                switch (v)
                {
                    case 'w': return 'm';
                    case 'p': return 'q';
                    case 'b': return 'd';
                    case 's': return 'z';
                    default: return v;
                }
            else
                switch(v)
                {
                    case 'm': return 'w';
                    case 'q': return 'p';
                    case 'd': return 'b';
                    case 'z': return 's';
                    default: return v;
                }
        }
    }
}
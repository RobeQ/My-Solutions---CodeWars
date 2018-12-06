using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Program
    {
        // TASK DESCRIPTION
        // John has invited people.His list is:
        // s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
        // Could you make a program that makes this string uppercase
        // gives it sorted in alphabetical order by last name.When the last names are the same, sort them by first name.
        // Last name and first name of a guest come in the result between parentheses separated by a comma. So the result of function meeting(s) will be:
        // "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
        // It can happen that in two distinct families with the same family name two people have the same first name too.

        static void Main(string[] args)
        {
            Console.WriteLine(Meeting("Anna:Wahl;Grace:Gates;James:Russell;Elizabeth:Rudd;Victoria:STAN;Jacob:Wahl;Alex:Wahl;Antony:Gates;Alissa:Meta;Megan:Bell;Amandy:Stan;Anna:Steve"));
        }

        public static string Meeting(string s)
        {
            string[][] nameLastname = s.Split(';').Select(x => x.Split(':').Select(p => p.ToUpper()).ToArray()).ToArray();

            Array.Sort(nameLastname, (first, second) => string.Compare(first[1], second[1]));
            string[] sorted = new string[nameLastname.Length];

            for (int i = 0; i < nameLastname.Length; i++)
            {
                sorted[i] += "(";
                for (int j = 1; j >= 0; j--)
                {
                    if (j == 0) sorted[i] += ", ";
                    sorted[i] += nameLastname[i][j];
                }
                sorted[i] += ")";
            }
            Array.Sort(sorted);

            return string.Join("", sorted);
        }
    }
}

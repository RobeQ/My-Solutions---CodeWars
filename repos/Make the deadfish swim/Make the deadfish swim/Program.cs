using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_the_deadfish_swim
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Parse("iiisdoso");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        //new object[] {"iiisdoso", new int[] {8, 64}},
        //new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},

        public static int[] Parse(string data)
        {
            List<int> listOfValues = new List<int>();
            int a = 0;
            foreach (char letter in data)
            {
                switch(letter)
                {
                    case 'i':
                        a++;
                        break;
                    case 'd':
                        a--;
                        break;
                    case 's':
                        a *= a;
                        break;
                    case 'o':
                        listOfValues.Add(a);
                        break;
                }
            }
            return listOfValues.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_feast_of_many_beasts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Feast("chickadee", "chocolate cake"));
        }

        public static bool Feast(string beast, string dish)
        {
            return beast.First() == dish.First() && beast.Last() == dish.Last();
        }
    }
}

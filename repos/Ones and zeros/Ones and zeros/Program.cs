using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ones_and_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example = new int[] { 1, 0, 1, 0 };
            Console.WriteLine(Change(example));
        }


        public static int Change(int[] binary)
        {
            return Convert.ToInt32(string.Join("", binary), 2);
        }
    }
}

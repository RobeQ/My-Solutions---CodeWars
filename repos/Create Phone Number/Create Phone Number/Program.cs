using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(CreatePhoneNumber(array));
        }

        // "(123) 456-7890"

        public static string CreatePhoneNumber(int[] numbers)
        {
            // string a = long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");  ----> Wersja z neta

            return string.Format("(" + String.Join("", numbers.Take(3).Select(o => o.ToString()).ToArray()) + ") "
                + String.Join("", numbers.Skip(3).Take(3).Select(o => o.ToString()).ToArray()) + "-" 
                + String.Join("", numbers.Skip(6).Take(4).Select(o => o.ToString()).ToArray()));
        }
    }
}

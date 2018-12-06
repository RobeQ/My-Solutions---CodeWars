using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backspaces_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CleanString("#abc#d##c"));
        }

        public static string CleanString(string s)
        {
            char[] array = s.ToCharArray();
            List<char> list = new List<char>();

            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case '#':
                        if (index == 0)
                            break;
                        index--;
                        list.RemoveAt(index);
                        break;
                    default:
                        list.Add(array[i]);
                        index++;
                        break;
                }
            }
            return new string(list.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnflattenAList_easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {3, 5, 2, 4, 1 };
            object[] array = Unflatten(input);
            Console.WriteLine(array[0]);
        }


        public static object[] Unflatten(int[] flatArray)
        {
            List<object> expected = new List<object>();

            for (int i = 0; i < flatArray.Count(); i++)
            {
                if(flatArray[i] < 3)
                {
                    expected.Add(flatArray[i]);
                }
                else
                {
                    expected.Add(flatArray.Skip(i).Take(flatArray[i]).ToList());
                    i = i + flatArray[i] - 1;
                }
            }
            return expected.ToArray();
        }
    }
}

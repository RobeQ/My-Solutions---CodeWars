using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30;
            Console.WriteLine("Before Swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After Swap: {0}, {1}", a, b);

            string c = "One", d = "Twelve";
            Console.WriteLine("Before Swap: {0}, {1}", c, d);
            Swap<string>(ref c, ref d);
            Console.WriteLine("After Swap: {0}, {1}", c, d);

            DisplayBaseClass<bool>();
        }

        static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Swap(ref Person a, ref Person b)
        {
            Person temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the swap method a {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}

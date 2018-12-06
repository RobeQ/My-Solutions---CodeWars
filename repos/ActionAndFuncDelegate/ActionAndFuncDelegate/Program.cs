using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(DisplayMessage);
            action("I wanna H2 Kawasaki", ConsoleColor.Green, 5);

            Func<int, int, int> f1 = new Func<int, int, int>(Add);
            int sum = f1(4, 16);
            Console.WriteLine(sum);

            Func<string, string, string> f2 = new Func<string, string, string>(SumToString);
            string sum2 = f2.Invoke("Ducati ", "Hypermotard");
            Console.WriteLine(sum2);

            Func<int, int, int> f3 = Add;
            Console.WriteLine(f3(41, 63));
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(string x, string y)
        {
            return (x + y).ToString();
        }
    }
}

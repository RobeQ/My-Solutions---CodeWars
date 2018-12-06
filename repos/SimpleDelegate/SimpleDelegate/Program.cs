using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            BinaryOp b = new BinaryOp(sm.Add);
            DisplayDelegateInfo(b);
            Console.WriteLine("10 + 25 = {0}", b(10, 25));
            Console.WriteLine("10 + 25 = {0}", b.Invoke(10, 25));

            BinaryOp b2 = new BinaryOp(sm.Subtract);
            DisplayDelegateInfo(b2);
            Console.WriteLine("10 - 25 = {0}", b2(10, 25));
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Method name: {0}", d.Method);
                Console.WriteLine("Type name: {0}", d.Target);
            }
        }
    }
}

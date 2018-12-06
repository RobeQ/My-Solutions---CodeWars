using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalDelegateSyntax();
            Console.WriteLine();
            AnonymousMethodSyntax();
            Console.WriteLine();
            LambdaExpressionSyntax();
            Console.WriteLine();
            Console.WriteLine();
            LambdaExpressionSyntax2();
        }

        static void LambdaExpressionSyntax2()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 41, 42, 61, 72, 34, 2, 7 });

            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine("Value of i is currently {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers");
            foreach (int e in evenNumbers)
            {
                Console.Write("{0}\t", e);
            }
        }

        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 41, 42, 61, 72, 34, 2, 7 });

            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers");
            foreach (int e in evenNumbers)
            {
                Console.Write("{0}\t", e);
            }
        }

        static void AnonymousMethodSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 41, 42, 61, 72, 34, 2, 7 });

            List<int> evenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

            Console.WriteLine("Here are your even numbers");
            foreach (int e in evenNumbers)
            {
                Console.Write("{0}\t", e);
            }
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 41, 42, 61, 72, 34, 2, 7 });

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(IsEvenNumber);

            Console.WriteLine("Here are your even numbers");
            foreach (int e in evenNumbers)
            {
                Console.Write("{0}\t", e);
            }
        }

        private static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
    }
}

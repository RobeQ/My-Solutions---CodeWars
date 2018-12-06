using System;

namespace FindTheParityOutliner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleTest2 = { 206847683, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781, 2 };
            Console.WriteLine(Kata.Find(exampleTest2));
            Console.ReadKey();
        }
    }
}

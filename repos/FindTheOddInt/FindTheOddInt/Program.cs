using System;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Console.ReadKey();
        }
    }
}

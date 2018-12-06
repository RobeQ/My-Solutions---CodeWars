using System;

namespace UnflattenAList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 2, 1 };

            Console.WriteLine(Kata.Unflatten(arr));
        }
    }
}

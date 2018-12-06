﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString() = {0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.ToString() = {0}", p.ToString());

            Console.WriteLine();

            Point<double> p2 = new Point<double>(3.43, 6.75);
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
        }
    }
}
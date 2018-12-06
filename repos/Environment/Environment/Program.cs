using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            byte b1 = 250;
            byte b2 = 100;
            byte byt = checked((byte)(b1 + b2));
            Console.WriteLine(byt);
            Console.WriteLine("sf's'fsf\\s\nf\\sg\"sg");
            Console.WriteLine("Model\tColor\tName\tSpeed");
            Console.WriteLine(char.IsPunctuation('?'));
            Console.WriteLine(char.IsWhiteSpace("Hi there", 2));
            Console.WriteLine(double.Epsilon);
            Console.WriteLine(false.GetHashCode());
            //string name = Console.ReadLine();
            //Console.WriteLine(name);
            Console.WriteLine("{0:x}", 99999);
            ShowEnvironmentDetails();
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (string drive in System.Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", System.Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", System.Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", System.Environment.Version);
            Console.WriteLine(System.Environment.MachineName);
            Console.WriteLine(System.Environment.UserName);
            Console.Beep();
        }
    }
}

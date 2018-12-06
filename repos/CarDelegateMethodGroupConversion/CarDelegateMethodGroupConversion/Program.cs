using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.RegisterWithCarEngine(CallMeHere);
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(CallMeHere);
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        private static void CallMeHere(string msgForCaller)
        {
            Console.WriteLine("=> Message from Car: {0}", msgForCaller);
        }
    }
}

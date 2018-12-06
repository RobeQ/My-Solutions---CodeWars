using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);
            c1.UnRegisterWithCarEngine(handler2);

            Console.WriteLine("****SPEEDING UP****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        private static void OnCarEngineEvent2(string msgForCaller)
        {
            Console.WriteLine("=> {0}", msgForCaller.ToUpper());
        }

        private static void OnCarEngineEvent(string msgForCaller)
        {
            Console.WriteLine("Message from Car object");
            Console.WriteLine("=> {0}", msgForCaller);
            Console.WriteLine("***********************\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Slug", 100, 10);
            //c1.AboutToBlow += OnAboutToBlow;
            //c1.Exploded += OnExplode;

            //EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExplodedEventHandler);
            //c1.Exploded += d;

            c1.AboutToBlow += (sender, e) => { Console.WriteLine("Going too fast! :)"); };

            c1.AboutToBlow += (sender, e) => { Console.WriteLine(sender + " says: " + e.msg.ToUpper()); };

            c1.Exploded += (sender, e) => Console.WriteLine(e.msg);

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
        }

        private static void CarExplodedEventHandler(object sender, CarEventArgs e)
        {
            if (sender is Car)
            {
                Car car = sender as Car;
                Console.WriteLine(car.PetName + " says: " + e.msg);
            }
        }

        private static void OnExplode(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

        private static void OnAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg.ToUpper());
        }
    }
}

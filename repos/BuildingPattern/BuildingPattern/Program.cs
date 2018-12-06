using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new BuildingPerson().Build();

            Person person1 = new BuildingPerson().WithFirstName("Robert").WithHeight(191).WithAge(27).Build();

            Person person2 = new BuildingPerson().Build();

            Person person3 = new BuildingPerson().WithFirstName("Ania").WithHeight(170).WithAge(30).Build();

            Console.WriteLine(person.FirstName + " " + person.LasttName + " " + person.Age + " " + person.Height);
            Console.WriteLine(person1.FirstName + " " + person1.LasttName + " " + person1.Age + " " + person1.Height);
            Console.WriteLine(person2.FirstName + " " + person2.LasttName + " " + person2.Age + " " + person2.Height);
            Console.WriteLine(person3.FirstName + " " + person3.LasttName + " " + person3.Age + " " + person3.Height);
            Console.ReadKey();
        }
    }
}

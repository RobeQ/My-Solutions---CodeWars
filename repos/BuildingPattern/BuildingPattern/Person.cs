using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPattern
{
    class Person
    {
       public Person(string firstName, string lastName, int age, int height)
        {
            this.FirstName = firstName;
            this.LasttName = lastName;
            this.Age = age;
            this.Height = height;
        }

        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // StackMethod();
            // UseSortedSet();
            UseDictionary();
        }

        private static void StackMethod()
        {
            Stack<Person> people = new Stack<Person>();
            people.Push(new Person { Name = "Robert", Surname = "Sokolski", Age = 27 });
            people.Push(new Person { Name = "Maciek", Surname = "Kowal", Age = 24 });
            people.Push(new Person { Name = "Michal", Surname = "Nowak", Age = 21 });
            Console.WriteLine(people.Peek().Name);
            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Pop().Name);
            Console.WriteLine(people.Pop().Name);
        }

        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person { Name = "Robert", Surname = "Sokolski", Age = 27 },
                new Person { Name = "Maciek", Surname = "Kowal", Age = 24 },
                new Person { Name = "Michal", Surname = "Nowak", Age = 21 },
                new Person { Name = "Mario", Surname = "Nowak", Age = 56 },
                new Person { Name = "Filip", Surname = "Nowak", Age = 12 },
                new Person { Name = "Adam", Surname = "Nowak", Age = 87 }
            };

            foreach (var person in setOfPeople)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void UseDictionary()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            people.Add("Robert", new Person { Name = "Robert", Surname = "Sokolski", Age = 27 });
            people.Add("Maciek", new Person { Name = "Maciek", Surname = "Kowal", Age = 24 });
            people.Add("Michal", new Person { Name = "Michal", Surname = "Nowak", Age = 21 });

            Person robert = people["Robert"];
            Console.WriteLine(robert.Name);

            Dictionary<string, Person> peopleA = new Dictionary<string, Person>()
            {
                ["Lisa"] = new Person { Name = "Lisa", Surname = "Black", Age = 31 },
                ["Homer"] = new Person { Name = "Homer", Surname = "Simpson", Age = 46 }
            };

            Person lisa = peopleA["Homer"];
            Console.WriteLine(lisa.Name);
        }
    }
}

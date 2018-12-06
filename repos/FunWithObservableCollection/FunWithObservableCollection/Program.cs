using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Stack;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{Name = "Robert", Surname = "Sokolski", Age = 27},
                new Person{Name = "Lisa", Surname = "Black", Age = 31}
            };

            people.CollectionChanged += OnPeopleChanged;

            people.Add(new Person { Name = "Maciek", Surname = "Nowak", Age = 21 });
            people.RemoveAt(1);
            people.Move(0, 1);
        }

        private static void OnPeopleChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.Name.ToString());
                }
                Console.WriteLine();
            }

            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.Name.ToString());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPattern
{
    class BuildingPerson
    {
        private string _firstName { get; set; }
        private string _lasttName { get; set; }
        private int _age { get; set; }
        private int _height { get; set; }

        public BuildingPerson()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            _firstName = "John";
            _lasttName = "Smith";
            _age = 26;
            _height = 185;
        }

        public BuildingPerson WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public BuildingPerson WithLastName(string lastName)
        {
            _lasttName = lastName;
            return this;
        }

        public BuildingPerson WithAge(int age)
        {
            _age = age;
            return this;
        }

        public BuildingPerson WithHeight(int height)
        {
            _height = height;
            return this;
        }

        public Person Build()
        {
            Person person = new Person(_firstName, _lasttName, _age, _height);
            return person;
        }
    }
}

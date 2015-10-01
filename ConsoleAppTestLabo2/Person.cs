using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLabo2
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public abstract bool BirthdayWish();

        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}

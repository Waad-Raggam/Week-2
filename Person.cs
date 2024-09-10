using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo11
{
    public class Person
    {
        // field
        public string Name;

        // property
        public string FirstName
        {
            get
            { return Name; }

            set
            {
                FirstName = value;
            }

            // backlog
        }


        // constructor
        public Person(string name)
        { Name = name; }

        // method

        public void DisplayInformation()
        {
            Console.WriteLine($"Person: {Name}");

        }

    }
}
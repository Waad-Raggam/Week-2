using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class Animal
    {
        // in common : eat
        public void Eat(string name)
        {
            Console.WriteLine($"The {name} is eating");
        }

        // override
        public virtual void Sound()
        {
            Console.WriteLine($"The animal makes sound");
        }
    }
}
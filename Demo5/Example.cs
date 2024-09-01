using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6
{
    public class Example
    {
        public string Name { get; set; }
        public Example(string name)
        {
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");

        }
    }
}
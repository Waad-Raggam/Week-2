using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo7
{
    public class Weather
    {
        public string Name { get; set; }
        public Weather(string name)
        {
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");

        }
    }
}
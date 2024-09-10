using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo11
{
    // implement the interface to the Fan class
    public class Fan : IPowerable
    {

        public string Power { get; set; }

        // 2 methods => from the interface
        public void TurnOn()
        {
            Console.WriteLine($"Fan is now ON");
            // return ("hi");

        }

        public void TurnOff()
        {
            Console.WriteLine($"Fan is now OFF");
        }
    }
}
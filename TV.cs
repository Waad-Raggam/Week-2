using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo11
{
    public class TV : IPowerable
    {

        // property
        public string Power { get; set; }

        public void TurnOn()
        {
            Console.WriteLine($"The TV is ON");
            // return ("hi");
        }


        public void TurnOff()
        {
            Console.WriteLine($"The TV is OFF");
        }

    }
}
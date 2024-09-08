using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class Duck : Animal
    {
        public void Quack()
        {
            Console.WriteLine($"The duck is quacking");
        }

        // demo for override
        public override void Sound()
        {
            // normal: The animal makes sound
            Console.WriteLine($"The duck quacks - from override");
        }
    }
}
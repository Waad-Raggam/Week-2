using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo9
{
    public class Dog : Animal
    {
        // other method
        public void Bark()
        {
            Console.WriteLine($"The dog is barking");
        }

        // demo for override
        public override void Sound()
        {
            // normal: The animal makes sound
            Console.WriteLine($"The dog barks - from override");

        }
    }
}
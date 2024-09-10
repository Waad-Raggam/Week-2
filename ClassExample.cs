using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo11
{
    public class ClassExample : Interface1, Interface2
    {

        // fields
        public int Age;
        public void Display()
        {
            Console.WriteLine($"smt");

        }
        public void GetData()
        {
            Console.WriteLine($"other method");

        }

        // it owns methods
        public void MethodClass()
        {
            Console.WriteLine($"This is method from original class");

        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6
{
    public class Box<T>
    // T => int
    // T => string
    {
        // field
        private T _value;
        // _value => int
        // _value => string

        // constructor
        public Box(T value)
        // value => int
        // value => string
        {
            _value = value;

        }

        public void Display(T value)
        {
            if (value is string)
            {
                //method for string
                Console.WriteLine($"T has string type");

            }
            else if (value is int)
            {
                // method for int
                Console.WriteLine($"T has int type");

            }
            else
            {
                Console.WriteLine($"The value has type: {value.GetType()}");

            }
            // switch
        }
    }
}
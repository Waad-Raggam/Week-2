using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo5
{
    public class Calculator
    {
        // private method
        private int Add(int x, int y)
        {
            return x + y;
        }

        // public method
        public void PerformCalculator(int a, int b)
        {
            // logic
            int result = Add(a, b);
            Console.WriteLine($"The result of add function: {result}");
        }

    }
}
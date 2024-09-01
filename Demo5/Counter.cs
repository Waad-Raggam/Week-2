using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo5
{
    public class Counter
    {
        // field - static
        // manage state
        public static int count = 0;

        // constructor
        public Counter()
        {
            count++;
        }
    }
}
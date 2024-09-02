using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6
{
    public class Person
    {
        // 2 methods using generic
        public static void PrintItem<K>(K item)
        {
            Console.WriteLine($"Item: {item}");

        }

        // method
        public static void PrintList<T>(List<T> list)
        {
            // print each item in list
            foreach (var item in list)
            {
                Console.WriteLine($"Item in list: {item}");

            }
        }



    }
}
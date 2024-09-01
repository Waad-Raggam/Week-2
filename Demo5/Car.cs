using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo5
{
    // naming convention: pascal case
    public class Car
    {
        // class component 1: field
        // variable belongs to class
        // store data
        // syntax: access modifier - type - name of field
        // private field => _firstName
        public string Brand;
        public string Model;
        public string Colour;
        public int Year;

        // class component 2: constructor
        // special method
        // int Add (itn a, int b)
        // { return a+b }
        // name of constructor = name of class
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            //Year = year;
        }


        // class component 3: method
        public void DisplayInformation()
        {
            Console.WriteLine($"Car: {Brand} - {Model} - {Year} ");

        }
        public int Add(int a, int b)
        {
            return a + b;
        }



    }
}
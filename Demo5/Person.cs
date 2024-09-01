using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo5
{
    public class Person
    {
        // private field
        // private string bankAccount;
        // "123"
        // "234"
        private string _firstName;
        private string _lastName;
        public int Age;

        // property: getter and setter
        // name of property
        public string FirstName
        {
            get; set;
            // get : see the field _firstName
            // set: change value of field "" => "Andrea"
            // old syntax
            // get {return  _firstName 
            // age>0, check null}
            // set{ _firstName = value;}
        }

        public string LastName
        {
            get; set;
        }




    }
}
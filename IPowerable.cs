using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo11
{
    public interface IPowerable
    {

        // do not have field
        // public string Power;

        // field
        // string powerType;

        string Power { get; set; }

        // field: powerType
        // string Power
        // {
        //     get
        //     {
        //         return powerType;
        //     }
        //     set
        //     {
        //         powerType = value;
        //     }
        // }

        // => not possible to have backlog



        // constructor => dont have constructor 
        // IPowerable(){}
        // cant use methods directly





        // methods
        void TurnOn();
        void TurnOff();

        // auto has access modifier as PUBLIC
    }
}
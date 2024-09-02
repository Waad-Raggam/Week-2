using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6
{
    public class ProductItem
    {
        public string Name;
        public int Quantity;
        public DateTime CreatedDate;

        // constructor
        public ProductItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            CreatedDate = DateTime.Now;
        }
    }
}
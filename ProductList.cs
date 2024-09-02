using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// list of ProductItem
namespace Demo6
{
    public class ProductList
    {
        // field
        // list of object
        // in each object has Name, Quantity, CreatedDate
        // items = []
        // item = [
        // {Name: "item1", Quantity: 1, CreatedDate: 11.06},
        // {Name: "item2", Quantity: 2, CreatedDate: 11.09},
        // ]
        public List<ProductItem> items;

        // constructor
        public ProductList()
        {
            items = new List<ProductItem>();
        }

        // logic
        // add new product to product list
        public void AddProduct(ProductItem item)
        {

            // validation
            // check if item is exist or not
            // contains
            // foreach (var existItem in items)
            // {
            //     // condition
            //     if (existItem.Name == item.Name)
            //     {
            //         Console.WriteLine($"Cant add product with same name");

            //     }
            // }

            // Linq: Any
            // bool
            var isExist = items.Any(i => i.Name == item.Name);
            if (items.Any(i => i.Name == item.Name))
            {
                Console.WriteLine($"Cant add product with same name");

            }
            items.Add(item);

        }

        // remove a product in list
        public void RemoveProduct(string name)

        {
            // step 1: find product has Watch
            // FirstOrDefault
            // element
            var item = items.FirstOrDefault(i => i.Name == name);
            // item: {"Watch", 5, 11:08}
            // step 2: 
            // before: [{"Laptop", 10}, {"Phone",20},{"Tablet", 15}, {"Watch", 5} ]
            items.Remove(item);
            // after:  [{"Laptop", 10}, {"Phone",20},{"Tablet", 15} ]

        }

        // sum of all quantity
        public int GetCurrentVolume()
        {
            int result = items.Sum(i => i.Quantity);
            return result;
        }

        // sort by name
        // OrderBy
        // public List<ProductItem> SortByName()
        // {
        //     // list
        //     // items: List of ProductItem
        //     return items.OrderBy(i => i.Name).ToList();
        //     // return  [{"Laptop", 10}, {"Phone",20},{"Tablet", 15} ]

        // }
        public void SortByName()
        {
            // list
            // items: List of ProductItem
            // sort by Name
            var result = items.OrderBy(i => i.Name).ToList();
            // sort by quantity
            // var result = items.OrderBy(i => i.Quantity).ToList();
            // return type: List

            items = result;
            // return  [{"Laptop", 10}, {"Phone",20},{"Tablet", 15} ]

        }




    }
}
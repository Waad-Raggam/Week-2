using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public class ProductList
    {
        public List<string> _products;

        // step 1
        private IMessageService _messageService;

        // step 2: constructor
        public ProductList(IMessageService messageService)
        {
            _messageService = messageService;
            _products = new List<string>();

        }

        public void AddProduct(string item1)
        {
            _products.Add(item1);
            // use logic
            _messageService.PrintMessageSuccess(item1);
        }

        public void RemoveProduct(string item1)
        {
            _products.Remove(item1);
            // use logic
            _messageService.PrintMessageSuccess(item1);

        }




    }
}
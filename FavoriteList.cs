using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public class FavoriteList
    {
        // fav list = list of string
        // way1: only create a list without initial
        public List<string> _favorites;

        // way 2: create + initial as empty list
        // public List<string> _favorites = new List<string>();

        // way 3: create + initial + provide the initial value of list 
        // public List<string> _favorites = new List<string>() { "item 1", "item2" };

        // create a field
        private IMessageService _messageService;

        // constructor
        // inject Interface to class (constructor)
        // inject interface - NOT CLASS Directly
        public FavoriteList(IMessageService messageService)
        {
            _messageService = messageService;
            _favorites = new List<string>();
        }

        // methods
        public void AddFav(string item1)
        {
            _favorites.Add(item1);
            // use logic
            _messageService.PrintMessageSuccess(item1);
            // Console.WriteLine($"A item is added");
            // implementation 

        }

        public void RemoveFav(string item1)
        {
            _favorites.Remove(item1);
            // logic 
            _messageService.PrintMessageSuccess(item1);
        }

        // methods:  _messageService.PrintMessageSuccess();


    }
}
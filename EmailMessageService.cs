using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    // step 2: create class that implement Interface
    public class EmailMessageService : IMessageService
    {
        public void PrintMessageSuccess(string message)
        {
            Console.WriteLine($"A item is added from email: {message}");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public class SMSMessageService : IMessageService
    {
        public void PrintMessageSuccess(string message)
        {
            Console.WriteLine($"A item is added from sms: {message}");
        }

    }
}
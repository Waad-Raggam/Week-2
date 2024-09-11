using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public class PaypalPayment : IPaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} via Paypal");

        }

    }
}
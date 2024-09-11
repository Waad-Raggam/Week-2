using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public class PaymentProcessor
    {

        // create field
        private IPaymentService _paymentService;

        // inject in to constructor
        public PaymentProcessor(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // 2 methods
        // send money
        public void SendMoney(decimal amount)
        {
            // transfer amount => account 
            // 0 => 5
            _paymentService.ProcessPayment(amount);
        }


    }
}
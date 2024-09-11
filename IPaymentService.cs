using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12
{
    public interface IPaymentService
    {
        // only name+return
        // no implementation
        void ProcessPayment(decimal amount);
    }
}
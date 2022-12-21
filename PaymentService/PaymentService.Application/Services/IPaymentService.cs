using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Services
{
    public interface IPaymentService
    {
        PaymentDto GetPaymentofOrder(Guid OrderId);
        PaymentDto GetPayment(Guid PaymentId);
        bool CreatePayment(Guid OrderId, int Amount);
        void PayDone(Guid Paymentid, string Authority, long RefId);
    }
}

using System;

namespace OrderService.MessagingBus.RecievedMessages
{
    public class PaymentOrderMessage
    {
        public Guid OrderId { get; set; }
    }
}
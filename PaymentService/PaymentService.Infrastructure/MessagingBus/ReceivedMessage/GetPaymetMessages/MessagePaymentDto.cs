using System;

namespace PaymentService.Infrastructure.MessagingBus.ReceivedMessage.GetPaymetMessages
{
    public class MessagePaymentDto
    {
        public Guid OrderId { get; set; }
        public int Amount { get; set; }
    }
}
using System;

namespace OrderService.MessagingBus.RecievedMessages
{
    public class UpdateProductNameMessage
    {
        public Guid Id { get; set; }
        public string NewName { get; set; }
    }
}
using System;

namespace BasketService.MessageingBus.ReceivedMessages.ProductMessages
{
    public class UpdateProductNameMessage
    {
        public Guid Id { get; set; }
        public string NewName { get; set; }
    }
}
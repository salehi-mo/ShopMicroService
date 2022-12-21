using System;

namespace OrderService.MessagingBus.RecievedMessages
{
    public class BasketItem
    {
        public string BasketItemId { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
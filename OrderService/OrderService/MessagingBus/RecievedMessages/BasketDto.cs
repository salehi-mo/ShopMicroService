using System;
using System.Collections.Generic;

namespace OrderService.MessagingBus.RecievedMessages
{
    public class BasketDto
    {
        public string BasketId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string UserId { get; set; }
        public int TotalPrice { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public string MessageId { get; set; }
        public DateTime Creationtime { get; set; }
    }
}
using OrderService.Model.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderService.Model.Services
{
    public interface IOrderService
    {

        List<OrderDto> GetOrdersForUser(string UserId);
        OrderDetailDto GetOrderById(Guid Id);
        ResultDto RequestPayment(Guid OrderId);

    }
}

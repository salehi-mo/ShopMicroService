using Microservices.Web.Frontend.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Web.Frontend.Services.OrderServices
{
    public interface IOrderService
    {
        List<OrderDto> GetOrders(string UserId);
        OrderDetailDto OrderDetail(Guid OrderId);
        ResultDto RequestPayment(Guid OrderId);

    }
}

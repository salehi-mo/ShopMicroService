using Microservices.Web.Frontend.Models.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Web.Frontend.Services.BasketServices
{
    public interface IBasketService
    {
        BasketDto GetBasket(string UserId);
        ResultDto AddToBasket(AddToBasketDto addToBasket, string UserId);
        ResultDto DeleteFromBasket(Guid Id);
        ResultDto UpdateQuantity(Guid BasketItemId, int quantity);
        ResultDto ApplyDiscountToBasket(Guid basketId, Guid discountId);

        ResultDto Checkout(CheckoutDto checkout);
         

    }
}

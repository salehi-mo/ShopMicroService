using System;

namespace BasketService.Model.Services.ProductServices
{
    public interface IProductService
    {
        bool UpdateProductName(Guid ProductId, string productName);
    }
}

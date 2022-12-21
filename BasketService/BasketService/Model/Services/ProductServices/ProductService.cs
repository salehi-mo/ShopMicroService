using System;
using BasketService.Infrastructure.Contexts;

namespace BasketService.Model.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly BasketDataBaseContext context;

        public ProductService(BasketDataBaseContext context)
        {
            this.context = context;
        }

        public bool UpdateProductName(Guid ProductId, string productName)
        {
            var product = context.Products.Find(ProductId);
            if (product != null)
            {
                product.ProductName = productName;
                context.SaveChanges();
                
            }
            return true;

        }
    }
}
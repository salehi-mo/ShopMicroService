using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Model.Services
{
    public interface IProductService
    {
        List<ProductDto> GetProductList();
        ProductDto GetProduct(Guid Id);
        void AddNewProduct(AddNewProductDto addNewProduct);
        bool UpdateProductName(UpdateProductDto updateProduct);
    }

    //public record UpdateProductDto(Guid ProductId, string Name);
}

using System;

namespace ProductService.Model.Services
{
    public class UpdateProductDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
       
    }
}
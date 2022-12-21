using System;

namespace ProductService.Model.Services
{
    public class ProductCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Category { get; set; }
    }
}
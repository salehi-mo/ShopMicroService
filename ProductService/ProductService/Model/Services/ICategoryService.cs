using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Model.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();
        void AddNewCatrgory(CategoryDto category);
    }
}

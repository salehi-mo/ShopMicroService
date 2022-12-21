
using BasketService.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketService.Model.Services.DiscountServices
{
    public interface IDiscountService
    {
        DiscountDto GetDiscountById(Guid DiscountId);
        ResultDto<DiscountDto> GetDiscountByCode(string Code);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscountService.Model.Services
{
    public interface IDiscountService
    {
        DiscountDto GetDiscountByCode(string Code);
        DiscountDto GetDiscountById(Guid Id  );
     
        bool UseDiscount(Guid Id);
        bool AddNewDiscount(string Code, int Amount);
    }
}

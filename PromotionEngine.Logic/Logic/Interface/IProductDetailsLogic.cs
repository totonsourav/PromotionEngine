using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Interface
{
    public interface IProductDetailsLogic
    {
		IEnumerable<ProductCartModel> GetAllProductsWithDetails();
    }
}

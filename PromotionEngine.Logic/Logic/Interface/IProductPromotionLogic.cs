using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Interface
{
	public interface IProductPromotionLogic
   {
		List<ProductCouponModel> GetAllCouponsAvailable();
		decimal CalculationLogic(List<ProductCartModel> productCartCollection, string productCouponApplied);
	}
}

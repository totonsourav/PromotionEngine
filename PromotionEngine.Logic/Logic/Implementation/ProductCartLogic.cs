using System.Collections.Generic;

using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductCartLogic : IProductCartLogic
	{
		public ProductBuyModel CalculateTotalFromProductCart(List<ProductCartModel> productCartCollection, string productCouponApplied)
		{
			ProductBuyModel productBuyModel = new ProductBuyModel();
		 	productBuyModel.productCartModel = productCartCollection;
			productBuyModel.productCouponModel = new ProductPromotionLogic().GetAllCouponsAvailable();
			productBuyModel.productBuyTotalAmount = new ProductPromotionLogic().CalculationLogic(productCartCollection, productCouponApplied);
			return productBuyModel;
		}
	}
}

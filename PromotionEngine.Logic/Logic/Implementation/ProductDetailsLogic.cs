using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;
using System.Collections.Generic;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductDetailsLogic : IProductDetailsLogic
	{
		/// <summary>
		/// Mocking the data for now till the database layer accessibility comes into picture
		/// </summary>
		/// <returns></returns>
		public ProductBuyModel GetAllProductsWithDetails()
		{
			var productDetailsCollection = new List<ProductCartModel>()
			{
				new ProductCartModel('A', 50),
				new ProductCartModel('B', 30),
				new ProductCartModel('C', 20),
				new ProductCartModel('D', 15)
			};

			var productCouponCollection = new ProductPromotionLogic().GetAllCouponsAvailable();
			return new ProductBuyModel(productDetailsCollection, productCouponCollection);
		}
	}
}

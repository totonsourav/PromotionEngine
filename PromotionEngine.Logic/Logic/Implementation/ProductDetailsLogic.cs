using System.Collections.Generic;
using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductDetailsLogic : IProductDetailsLogic
	{
		public IEnumerable<ProductCartModel> GetAllProductsWithDetails()
		{
			var productDetailsCollection = new List<ProductCartModel>()
			{
				new ProductCartModel('A', 50),
				new ProductCartModel('B', 30),
				new ProductCartModel('C', 20),
				new ProductCartModel('D', 10)
			};

			return productDetailsCollection;
		}
	}
}

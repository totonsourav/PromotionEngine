using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using PromotionEngine.Logic.Logic.Implementation;
using PromotionEngine.Logic.Models;
using PromotionEngine.Core.Utility;

namespace PromotionEngine.Core.Controllers
{
	/// <summary>
	/// This controller includes all the functions related to the products details which the user will 
	/// able to see in the Product Details Page
	/// </summary>
	public class ProductDetailsController : Controller
	{
		ProductDetailsLogic productDetailsLogic = null;

		/// <summary>
		/// Get all the product details in the Product Details page
		/// </summary>
		/// <returns></returns>
		// GET: ProductDetails
		[HttpGet]
		public ActionResult GetAllProductsWithDetails()
		{
			ProductBuyModel productBuyModel = null;

			// When the application gets loaded for the first time, then, it will retrieve from the mock data/database
			// but will get retrieved from the session, when the user has selected the product units and 
			// wanted to check their total invoice amount
			if (HttpContext.Session.GetObject<ProductBuyModel>("productBuyModel") != null)
				productBuyModel = (HttpContext.Session.GetObject<ProductBuyModel>("productBuyModel"));
			else
			{
				productDetailsLogic = new ProductDetailsLogic();
				productBuyModel = productDetailsLogic.GetAllProductsWithDetails();
				HttpContext.Session.SetObject("productBuyModel", productBuyModel);
			}

			return View(productBuyModel);
		}
	}
}
using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Logic.Logic.Implementation;

namespace PromotionEngine.Core.Controllers
{
	public class ProductDetailsController : Controller
    {
		  ProductDetailsLogic productDetailsLogic = null;

		  // GET: ProductDetails
		  [HttpGet]
        public ActionResult GetAllProductsWithDetails()
        {
			   productDetailsLogic = new ProductDetailsLogic();
			   var productDetails =  productDetailsLogic.GetAllProductsWithDetails();

				return View(productDetails);
        }

		  // GET: ProductDetails/Details/5
		  [HttpGet]
		  public ActionResult GetProductDetails(int id)
        {
            return View();
        }

        // GET: ProductDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductDetails/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductDetails/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductDetails/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductDetails/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductDetails/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
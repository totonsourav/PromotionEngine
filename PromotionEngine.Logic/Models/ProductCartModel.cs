using System;
using System.Collections.Generic;
using System.Text;
using PromotionEngine.Logic.Models;
using System.ComponentModel;

namespace PromotionEngine.Logic.Models
{
	 /// <summary>
	 /// 
	 /// </summary>
    public class ProductCartModel : ProductDetailsModel
    {
		[DisplayName("Buy")]
		public int productUnitcount { get; set; }

		public ProductCartModel() { }

		public ProductCartModel(Char productId, decimal productUnitPrice, int productUnitcount=0)
		{
			this.productId = productId;
			this.productUnitPrice = productUnitPrice;
			this.productUnitcount = this.productUnitcount;
		}
	}
}

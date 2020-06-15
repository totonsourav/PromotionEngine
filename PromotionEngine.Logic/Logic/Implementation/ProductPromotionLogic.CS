using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using PromotionEngine.Logic.Logic.Interface;
using PromotionEngine.Logic.Models;

namespace PromotionEngine.Logic.Logic.Implementation
{
	/// <summary>
	/// 
	/// </summary>
	public class ProductPromotionLogic : IProductPromotionLogic
	{
		/// <summary>
		/// Mocking the data for now till the database layer accessibility comes into picture
		/// </summary>
		/// <returns></returns>
		public List<ProductCouponModel> GetAllCouponsAvailable()
		{
			var productCouponsCollection = new List<ProductCouponModel>()
			{
				new ProductCouponModel(1, "Coupon-1", "3 of A's for 130", DateTime.Now),
				new ProductCouponModel(2, "Coupon-2", "2 of B's for 45", DateTime.Now),
				new ProductCouponModel(3, "Coupon-3", "C + D for 30", DateTime.Now)
			};

			return productCouponsCollection;
		}

		/// <summary>
		/// ****: Next Step Implementation : CouponClass can be created as base class and the respective coupons can be 
		/// created as derived classes and can override the couponLogic functionality. 
		/// The base class will get called if no coupons are being applied. We can use a factory pattern to 
		/// implement the functionality.
		/// </summary>
		/// <param name="productCartCollection"></param>
		/// <param name="productCouponApplied"></param>
		/// <returns></returns>
		public decimal CalculationLogic(List<ProductCartModel> productCartCollection, string productCouponApplied)
		{
			decimal totalAmount = 0;
			try
			{
				// Logic starts
				if (productCouponApplied != "")
				{
					switch (productCouponApplied)
					{
						case "Coupon-1":
							foreach (var item in productCartCollection)
							{
								if (item.productUnitcount == 0)
									continue;
								else
								{
									if (item.productId.Equals('A'))
									{
										int count = item.productUnitcount;
										if (count >= 3)
										{
											totalAmount += 130;
											count -= 3;
										}
										if (count > 0)
											totalAmount += count * item.productUnitPrice;
									}
									else
									{
										totalAmount += item.productUnitPrice * item.productUnitcount;
									}
								}
							}
							break;
						case "Coupon-2":
							foreach (var item in productCartCollection)
							{
								if (item.productUnitcount == 0)
									continue;
								else
								{
									if (item.productId.Equals('B'))
									{
										int count = item.productUnitcount;
										if (count >= 2)
										{
											totalAmount += 45;
											count -= 2;
										}
										if (count > 0)
											totalAmount += count * item.productUnitPrice;
									}
									else
									{
										totalAmount += item.productUnitPrice * item.productUnitcount;
									}
								}
							}
							break;
						case "Coupon-3":
							StringBuilder productCombination = new StringBuilder();

							foreach (var item in productCartCollection)
							{
								if (item.productUnitcount == 0)
									continue;
								else
								{
									var productId = item.productId;
									if (item.productId.Equals('C') || item.productId.Equals('D'))
									{
										int count = item.productUnitcount;
										if (count == 1)
										{
											productCombination.Append(Char.ToString(item.productId));
										}
										else
										{
											count -= 1;
											totalAmount += count * item.productUnitPrice;
											productCombination.Append(Char.ToString(item.productId));
										}
									}
									else
									{
										totalAmount += item.productUnitcount * item.productUnitPrice;
									}
								}
							}
							if (productCombination.ToString().Equals("CD"))
								totalAmount += 30;
							else
							  if (productCombination.ToString().Equals("C"))
								totalAmount += productCartCollection.Where(x => x.productId == 'C').Select(x => x.productUnitPrice).FirstOrDefault();
							else
								totalAmount += productCartCollection.Where(x => x.productId == 'D').Select(x => x.productUnitPrice).FirstOrDefault();
							break;
					}
				}
				else
				{
					foreach (var item in productCartCollection)
					{
						totalAmount += item.productUnitPrice * item.productUnitcount;
					}
				}
				return totalAmount;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
	}
}

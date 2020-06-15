using System;

namespace PromotionEngine.Logic.Models
{
	public class ProductCouponModel
    {
		public int couponId { get; set; }
	
		public string couponName { get; set; }

		public string couponDescription { get; set; }

		public DateTime couponExpirationDate { get; set; }

		public ProductCouponModel() { }

		public ProductCouponModel(int couponId, string couponName, string couponDescription, DateTime couponExpirationDate)   {
			this.couponId = couponId;
			this.couponName = couponName;
			this.couponDescription = couponDescription;
			this.couponExpirationDate = couponExpirationDate;
		}
	 }
}

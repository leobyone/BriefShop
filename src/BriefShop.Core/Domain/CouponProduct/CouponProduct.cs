using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 优惠劵商品表
	/// </summary>
	public class CouponProduct: Entity<int>
	{
		/// <summary>
		/// 优惠劵类型id
		/// </summary>
		public int CouponTypeId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }
	}
}

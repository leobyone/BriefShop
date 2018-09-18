using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 套装商品表
	/// </summary>
	public class SuitProduct: Entity<int>
	{
		/// <summary>
		/// 促销活动id
		/// </summary>
		public int PmId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 折扣
		/// </summary>
		public int Discount { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Number { get; set; }
	}
}

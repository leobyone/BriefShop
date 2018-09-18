using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品库存表
	/// </summary>
	public class ProductStock: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 商品数量
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// 商品库存警戒线
		/// </summary>
		public int Limit { get; set; }

	}
}

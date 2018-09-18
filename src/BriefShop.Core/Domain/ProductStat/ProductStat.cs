using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品统计数据表
	/// </summary>
	public class ProductStat: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 分类
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// 值
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Count { get; set; }
	}
}

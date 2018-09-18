using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	///商品图片表
	/// </summary>
	public class ProductImage: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 商品图片
		/// </summary>
		public string ShowImg { get; set; }

		/// <summary>
		/// 是否为主图
		/// </summary>
		public int IsMain { get; set; }

		/// <summary>
		/// 商品图片排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

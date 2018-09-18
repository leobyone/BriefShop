using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品sku表
	/// </summary>
	public class ProductSKU: Entity<int>
	{
		/// <summary>
		/// sku组id
		/// </summary>
		public int SKUGid { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 属性id
		/// </summary>
		public int AttributeId { get; set; }

		/// <summary>
		/// 属性值id
		/// </summary>
		public int AttributeValueId { get; set; }

		/// <summary>
		/// 输入值
		/// </summary>
		public string InputValue { get; set; }

	}
}

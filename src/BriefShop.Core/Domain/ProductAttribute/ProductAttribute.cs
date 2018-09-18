using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品属性表
	/// </summary>
	public class ProductAttribute: Entity<int>
	{
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

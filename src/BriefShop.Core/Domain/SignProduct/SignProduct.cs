using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 签名商品表
	/// </summary>
	public class SignProduct: Entity<int>
	{
		/// <summary>
		/// 签名
		/// </summary>
		public string Sign { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		[ForeignKey("ProductId")]
		public Product Product { get; set; }
	}
}

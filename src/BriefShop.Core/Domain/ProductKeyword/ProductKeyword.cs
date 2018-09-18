using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品关键词表
	/// </summary>
	public class ProductKeyword: Entity<int>
	{
		public const int MaxKeywordLength = 40;

		/// <summary>
		/// 关键词
		/// </summary>
		[MaxLength(MaxKeywordLength)]
		public string Keyword { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 相关性
		/// </summary>
		public int Relevancy { get; set; }

	}
}

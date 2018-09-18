using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品咨询类型表
	/// </summary>
	public class ProductConsultType: Entity<int>
	{
		public const int MaxTitleLength = 30;

		/// <summary>
		/// 咨询类型标题
		/// </summary>
	    [Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

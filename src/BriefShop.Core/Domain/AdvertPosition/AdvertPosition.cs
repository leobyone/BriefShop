using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 广告位置表
	/// </summary>
	public class AdvertPosition:Entity<int>
	{
		public const int MaxTitleLength = 50;
		public const int MaxDescriptionLength = 150;

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder{ get; set; }

		/// <summary>
		/// 广告位置标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 广告位置描述
		/// </summary>
		[MaxLength(MaxDescriptionLength)]
		public string Description { get; set; }

	}
}

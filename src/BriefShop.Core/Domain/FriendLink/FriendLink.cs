using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 友情链接表
	/// </summary>
	public class FriendLink: Entity<int>
	{
		public const int MaxNameLength = 50;
		public const int MaxTitleLength = 100;

		/// <summary>
		/// 名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// logo
		/// </summary>
		public string Logo { get; set; }

		/// <summary>
		/// url
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// target
		/// </summary>
		public int Target { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }
	}
}

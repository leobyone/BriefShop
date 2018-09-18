using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 帮助表
	/// </summary>
	public class Help: Entity<int>
	{
		public const int MaxTitleLength = 60;

		/// <summary>
		/// 父id
		/// </summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 链接
		/// </summary>
		[RegularExpression(@"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")]
		public string Url { get; set; }

		/// <summary>
		/// 描述
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }
	}
}

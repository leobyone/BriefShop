using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 导航栏表
	/// </summary>
	public class Nav: Entity<int>
	{
		public const int MaxNameLength = 50;
		public const int MaxTitleLength = 50;

		/// <summary>
		/// 父编号
		/// </summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 级别
		/// </summary>
		public int Layer { get; set; }

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
		/// 网址
		/// </summary>
		[RegularExpression(@"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$")]
		public string Url { get; set; }

		/// <summary>
		/// 打开目标
		/// </summary>
		public int Target { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

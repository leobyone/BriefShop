using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 新闻类型表
	/// </summary>
	public class NewsType: Entity<int>
	{
		public const int MaxNameLength = 60;

		/// <summary>
		/// 名称
		/// </summary>
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

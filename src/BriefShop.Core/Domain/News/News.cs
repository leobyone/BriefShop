using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 新闻表
	/// </summary>
	public class News: Entity<int>
	{
		public const int MaxTitleLength = 100;

		/// <summary>
		/// 新闻类型id
		/// </summary>
		public int NewsTypeId { get; set; }

		/// <summary>
		/// 是否显示
		/// </summary>
		public int IsShow { get; set; }

		/// <summary>
		/// 是否置顶
		/// </summary>
		public int IsTop { get; set; }

		/// <summary>
		/// 是否置首
		/// </summary>
		public int IsHome { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 网址
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// 内容
		/// </summary>
		public string Body { get; set; }

	}
}

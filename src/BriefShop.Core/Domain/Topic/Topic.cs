using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 活动专题表
	/// </summary>
	public class Topic: Entity<int>
	{
		public const int MaxTitleLength = 100;

		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 是否显示
		/// </summary>
		public int IsShow { get; set; }

		/// <summary>
		/// 编号
		/// </summary>
		public string SN { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 头部html
		/// </summary>
		public string HeadHtml { get; set; }

		/// <summary>
		/// 主体html
		/// </summary>
		public string BodyHtml { get; set; }

	}
}

using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 广告表
	/// </summary>
	public class Advert: Entity<int>
	{
		public const int MaxTitleLength = 50;

		/// <summary>
		/// 点击数
		/// </summary>
		public int ClickCount { get; set; }

		/// <summary>
		/// 广告位置id
		/// </summary>
		public int AdvertPositionId { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public int State { get; set; }

		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 图片
		/// </summary>
		public string Image { get; set; }

		/// <summary>
		/// 网址
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// 扩展字段1
		/// </summary>
		public string ExtField1 { get; set; }

		/// <summary>
		/// 扩展字段2
		/// </summary>
		public string ExtField2 { get; set; }

		/// <summary>
		/// 扩展字段3
		/// </summary>
		public string ExtField3 { get; set; }

		/// <summary>
		/// 扩展字段4
		/// </summary>
		public string ExtField4 { get; set; }

		/// <summary>
		/// 扩展字段5
		/// </summary>
		public string ExtField5 { get; set; }

	}
}

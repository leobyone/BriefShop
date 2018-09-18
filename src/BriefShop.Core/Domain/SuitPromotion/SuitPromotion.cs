using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 套装促销活动表
	/// </summary>
	public class SuitPromotion: Entity<int>
	{
		public const int MaxNameLength = 50;

		/// <summary>
		/// 开始时间1
		/// </summary>
		public DateTime StartTime1 { get; set; }

		/// <summary>
		/// 结束时间1
		/// </summary>
		public DateTime EndTime1 { get; set; }

		/// <summary>
		/// 开始时间2
		/// </summary>
		public DateTime StartTime2 { get; set; }

		/// <summary>
		/// 结束时间2
		/// </summary>
		public DateTime EndTime2 { get; set; }

		/// <summary>
		/// 开始时间3
		/// </summary>
		public DateTime StartTime3 { get; set; }

		/// <summary>
		/// 结束时间3
		/// </summary>
		public DateTime EndTime3 { get; set; }

		/// <summary>
		/// 用户等级下限
		/// </summary>
		public int UserRankLower { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public int State { get; set; }

		/// <summary>
		/// 名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 配额上限
		/// </summary>
		public int QuotaUpper { get; set; }

		/// <summary>
		/// 限购一次
		/// </summary>
		public int OnlyOnce { get; set; }

	}
}

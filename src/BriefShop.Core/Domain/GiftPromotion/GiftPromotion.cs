using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 赠品促销活动表
	/// </summary>
	public class GiftPromotion: Entity<int>
	{
		public const int MaxNameLength = 50;

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 活动开始时间1
		/// </summary>
		public DateTime StartTime1 { get; set; }

		/// <summary>
		/// 活动结束时间1
		/// </summary>
		public DateTime EndTime1 { get; set; }

		/// <summary>
		/// 活动开始时间2
		/// </summary>
		public DateTime StartTime2 { get; set; }

		/// <summary>
		/// 活动结束时间2
		/// </summary>
		public DateTime EndTime2 { get; set; }

		/// <summary>
		/// 活动开始时间3
		/// </summary>
		public DateTime StartTime3 { get; set; }

		/// <summary>
		/// 活动结束时间3
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
		/// 活动名称
		/// </summary>
	    [Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 活动上限
		/// </summary>
		public int QuotaUpper { get; set; }

	}
}

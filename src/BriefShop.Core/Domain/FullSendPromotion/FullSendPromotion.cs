using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 满赠促销活动
	/// </summary>
	public class FullSendPromotion: Entity<int>
	{
		public const int MaxNameLength = 50;

		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime { get; set; }

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
		/// 限制金额
		/// </summary>
		public int LimitMoney { get; set; }

		/// <summary>
		/// 添加金额
		/// </summary>
		public int AddMoney { get; set; }

	}
}

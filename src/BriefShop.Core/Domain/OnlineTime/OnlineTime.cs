using Abp.Domain.Entities;
using System;

namespace BriefShop.Core
{
	/// <summary>
	/// 在线时间表
	/// </summary>
	public class OnlineTime: Entity<int>
	{
		/// <summary>
		/// 合计
		/// </summary>
		public int Total { get; set; }

		/// <summary>
		/// 年
		/// </summary>
		public int Year { get; set; }

		/// <summary>
		/// 月
		/// </summary>
		public int Month { get; set; }

		/// <summary>
		/// 周
		/// </summary>
		public int Week { get; set; }

		/// <summary>
		/// 日
		/// </summary>
		public int Day { get; set; }

		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime { get; set; }
	}
}

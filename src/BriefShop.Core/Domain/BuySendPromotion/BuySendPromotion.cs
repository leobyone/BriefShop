using Abp.Domain.Entities;
using System;

namespace BriefShop.Core
{
	/// <summary>
	/// 买送促销活动表
	/// </summary>
	public class BuySendPromotion: Entity<int>
	{
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
		public string Name { get; set; }

		/// <summary>
		/// 类型(0代表全场参加，1代表部分商品参加，2代表部分商品不参加)
		/// </summary>
		public BuySendType Type { get; set; }

		/// <summary>
		/// 购买数量
		/// </summary>
		public int BuyCount { get; set; }

		/// <summary>
		/// 赠送数量
		/// </summary>
		public int SendCount { get; set; }

		public int CompareTo(BuySendPromotion other)
		{
			if (this.BuyCount > other.BuyCount)
				return 1;
			if (this.BuyCount < other.BuyCount)
				return -1;
			return 0;
		}
	}
}

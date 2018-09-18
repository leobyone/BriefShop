using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 优惠券类型表
	/// </summary>
	public class CouponType: Entity<int>
	{
		public const int MaxNameLength = 50;

		/// <summary>
		/// 状态
		/// </summary>
		public int State { get; set; }

		/// <summary>
		/// 优惠劵类型名称
		/// </summary>	
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 金额
		/// </summary>		
		public int Money { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// 发放方式(0代表免费领取,1代表手动发放,2代表随活动发放)
		/// </summary>
		public SendMode SendMode { get; set; }

		/// <summary>
		/// 领取方式(当且仅当发放方式为免费领取时有效.0代表无限制,1代表限领一张,2代表每天限领一张)
		/// </summary>
		public GetMode GetMode { get; set; }

		/// <summary>
		/// 使用方式(0代表可以叠加,1代表不可以叠加)
		/// </summary>
		public UseMode UseMode { get; set; }

		/// <summary>
		/// 最低用户级别
		/// </summary>
		public int UserRankLower { get; set; }

		/// <summary>
		/// 订单总计下限
		/// </summary>		
		public int OrderAmountLower { get; set; }

		/// <summary>
		/// 限制分类id
		/// </summary>
		public int LimitCategoryId { get; set; }

		/// <summary>
		/// 限制品牌id
		/// </summary>
		public int LimitBrandId { get; set; }

		/// <summary>
		/// 限制商品
		/// </summary>
		public int LimitProductId { get; set; }

		/// <summary>
		/// 发放开始时间
		/// </summary>		
		public DateTime SendStartTime { get; set; }

		/// <summary>
		/// 发放结束时间
		/// </summary>		
		public DateTime SendEndTime { get; set; }

		/// <summary>
		/// 使用过期时间
		/// </summary>
		public int UseExpireTime { get; set; }

		/// <summary>
		/// 使用开始时间
		/// </summary>		
		public DateTime UseStartTime { get; set; }

		/// <summary>
		/// 使用结束时间
		/// </summary>		
		public DateTime UseEndTime { get; set; }

	}
}

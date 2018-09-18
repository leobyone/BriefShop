using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 单品促销活动表
	/// </summary>
	public class SinglePromotion: Entity<int>
	{
		public const int MaxNameLength = 50;

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

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
		/// 活动名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 活动广告语
		/// </summary>
		public string Slogan { get; set; }

		/// <summary>
		/// 折扣类型,0代表折扣，1代表直降，2代表折后价
		/// </summary>
		public DiscountType DiscountType { get; set; }

		/// <summary>
		/// 折扣值
		/// </summary>
		public int DiscountValue { get; set; }

		/// <summary>
		/// 优惠劵类型id
		/// </summary>
		public int CouponTypeId { get; set; }

		/// <summary>
		/// 支付积分
		/// </summary>
		public int PayCredits { get; set; }

		/// <summary>
		/// 是否限制库存
		/// </summary>
		public int IsStock { get; set; }

		/// <summary>
		/// 库存
		/// </summary>
		public int Stock { get; set; }

		/// <summary>
		/// 订单配额下限
		/// </summary>
		public int QuotaLower { get; set; }

		/// <summary>
		/// 订单配额上限
		/// </summary>
		public int QuotaUpper { get; set; }

		/// <summary>
		/// 最大购买数量
		/// </summary>
		public int AllowBuyCount { get; set; }

	}
}

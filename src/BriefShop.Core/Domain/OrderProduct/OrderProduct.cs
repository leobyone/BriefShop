using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 订单商品表
	/// </summary>
	public class OrderProduct : Entity<int>
	{
		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// sessionId
		/// </summary>
		public string SessionId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 分类id
		/// </summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 品牌id
		/// </summary>
		public int BrandId { get; set; }

		/// <summary>
		/// 商品折扣价格
		/// </summary>
		public decimal DiscountPrice { get; set; }

		/// <summary>
		/// 是否评价(0代表未评价，1代表已评价)
		/// </summary>
		public int IsReview { get; set; }

		/// <summary>
		/// 真实数量
		/// </summary>
		public int RealCount { get; set; }

		/// <summary>
		/// 商品购买数量
		/// </summary>
		public int BuyCount { get; set; }

		/// <summary>
		/// 商品邮寄数量
		/// </summary>
		public int SendCount { get; set; }

		/// <summary>
		/// 商品类型(0为普遍商品,1为普通商品赠品,2为套装商品赠品,3为套装商品,4满赠商品)
		/// </summary>
		public ProductType Type { get; set; }

		/// <summary>
		/// 支付积分
		/// </summary>
		public int PayCredits { get; set; }

		/// <summary>
		/// 赠送优惠劵类型id
		/// </summary>
		public int CouponTypeId { get; set; }

		/// <summary>
		/// 普通商品时为单品促销活动id,赠品时为赠品促销活动id,套装商品时为套装促销活动id,满赠赠品时为满赠促销活动id
		/// </summary>
		public int ExtCode1 { get; set; }

		/// <summary>
		/// 普通商品时为买送促销活动id,赠品时为赠品赠送数量,套装商品时为套装商品数量
		/// </summary>
		public int ExtCode2 { get; set; }

		/// <summary>
		/// 普通商品时为赠品促销活动id,套装商品时为赠品促销活动id
		/// </summary>
		public int ExtCode3 { get; set; }

		/// <summary>
		/// 普通商品时为满赠促销活动id
		/// </summary>
		public int ExtCode4 { get; set; }

		/// <summary>
		/// 普通商品时为满减促销活动id
		/// </summary>
		public int ExtCode5 { get; set; }

		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime { get; set; }

	}
}

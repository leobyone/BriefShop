using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 订单表
	/// </summary>
	public class Order: Entity<int>
	{
		/// <summary>
		/// 订单编号
		/// </summary>
		public string OSN { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 订单状态
		/// </summary>
		public OrderState OrderState { get; set; }

		/// <summary>
		/// 商品合计
		/// </summary>
		public decimal ProductAmount { get; set; }

		/// <summary>
		/// 订单合计
		/// </summary>
		public decimal OrderAmount { get; set; }

		/// <summary>
		/// 剩余金钱
		/// </summary>
		public decimal SurplusMoney { get; set; }

		/// <summary>
		/// 是否评价
		/// </summary>
		public int IsReview { get; set; }

		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 配送单号
		/// </summary>
		public string ShipSN { get; set; }

		/// <summary>
		/// 配送方式系统名
		/// </summary>
		public string ShipSystemName { get; set; }

		/// <summary>
		/// 配送方式昵称
		/// </summary>
		public string ShipFriendName { get; set; }

		/// <summary>
		/// 配送时间
		/// </summary>
		public DateTime ShipTime { get; set; }

		/// <summary>
		/// 支付方式(0代表货到付款，1代表在线付款)
		/// </summary>
		public int PayMode { get; set; }

		/// <summary>
		/// 支付单号
		/// </summary>
		public string PaySN { get; set; }

		/// <summary>
		/// 支付方式系统名
		/// </summary>
		public string PaySystemName { get; set; }

		/// <summary>
		/// 支付方式昵称
		/// </summary>
		public string PayFriendName { get; set; }

		/// <summary>
		/// 支付时间
		/// </summary>
		public DateTime PayTime { get; set; }

		/// <summary>
		/// 配送区域id
		/// </summary>
		public int RegionId { get; set; }

		/// <summary>
		/// 收货人
		/// </summary>
		public string Consignee { get; set; }

		/// <summary>
		/// 手机号
		/// </summary>
		[RegularExpression(@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$")]
		public string Mobile { get; set; }

		/// <summary>
		/// 固话号
		/// </summary>
		[RegularExpression(@"^(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}$")]
		public string Phone { get; set; }

		/// <summary>
		/// 邮箱
		/// </summary>
		[RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]+$")]
		public string Email { get; set; }

		/// <summary>
		/// 邮政编码
		/// </summary>
		[RegularExpression(@"[1-9]\d{5}(?!\d)")]
		public string ZipCode { get; set; }

		/// <summary>
		/// 详细地址
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// 最佳送货时间
		/// </summary>
		public DateTime BestTime { get; set; }

		/// <summary>
		/// 配送费用
		/// </summary>
		public decimal ShipFee { get; set; }

		/// <summary>
		/// 满减
		/// </summary>
		public int FullCut { get; set; }

		/// <summary>
		/// 折扣
		/// </summary>
		public decimal Discount { get; set; }

		/// <summary>
		/// 支付积分数量
		/// </summary>
		public int PayCreditCount { get; set; }

		/// <summary>
		/// 支付积分金额
		/// </summary>
		public decimal PayCreditMoney { get; set; }

		/// <summary>
		/// 优惠劵金额
		/// </summary>
		public int CouponMoney { get; set; }

		/// <summary>
		/// 重量
		/// </summary>
		public int Weight { get; set; }

		/// <summary>
		/// 买家备注
		/// </summary>
		public string BuyerRemark { get; set; }

		/// <summary>
		/// ip地址
		/// </summary>
		public string IP { get; set; }

	}
}

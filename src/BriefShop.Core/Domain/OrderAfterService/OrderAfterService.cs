using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 订单售后服务
	/// </summary>
	public class OrderAfterService: Entity<int>
	{
		/// <summary>
		/// 状态
		/// </summary>
		public OrderState State { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 订单商品id
		/// </summary>
		public int OrderProductId { get; set; }

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
		/// 数量
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// 金钱
		/// </summary>
		public decimal Money { get; set; }

		/// <summary>
		/// 类型(0代表退货,1代表换货,2代表维修)
		/// </summary>
		public OrderAfterServiceType Type { get; set; }

		/// <summary>
		/// 申请原因
		/// </summary>
		public string ApplyReason { get; set; }

		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime ApplyTime { get; set; }

		/// <summary>
		/// 审核结果
		/// </summary>
		public string CheckResult { get; set; }

		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime CheckTime { get; set; }

		/// <summary>
		/// 配送公司id
		/// </summary>
		public int ShipCoId1 { get; set; }

		/// <summary>
		/// 配送公司名称
		/// </summary>
		public string ShipCoName1 { get; set; }

		/// <summary>
		/// 配送单号
		/// </summary>
		public string ShipSN1 { get; set; }


		/// <summary>
		/// 邮寄给商城时间
		/// </summary>
		public DateTime SendTime { get; set; }

		/// <summary>
		/// 商城收货时间
		/// </summary>
		public DateTime ReceiveTime { get; set; }

		/// <summary>
		/// 配送公司id
		/// </summary>
		public int ShipCoId2 { get; set; }

		/// <summary>
		/// 配送公司名称
		/// </summary>
		public string ShipCoName2 { get; set; }

		/// <summary>
		/// 配送单号
		/// </summary>
		public string ShipSN2 { get; set; }

		/// <summary>
		/// 邮寄给客户时间
		/// </summary>
		public DateTime BackTime { get; set; }

	}
}

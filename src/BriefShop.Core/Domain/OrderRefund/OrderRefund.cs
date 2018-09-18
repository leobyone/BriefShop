using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 订单退款表
	/// </summary>
	public class OrderRefund: Entity<int>
	{
		/// <summary>
		/// 状态
		/// </summary>
		public OrderState State { get; set; }

		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 售后服务id
		/// </summary>
		public int ASId { get; set; }

		/// <summary>
		/// 退款金额
		/// </summary>
		public decimal RefundMoney { get; set; }

		/// <summary>
		/// 申请时间
		/// </summary>
		public DateTime ApplyTime { get; set; }

		/// <summary>
		/// 退款单号
		/// </summary>
		public string RefundSN { get; set; }

		/// <summary>
		/// 退款时间
		/// </summary>
		public DateTime RefundTime { get; set; }

	}
}

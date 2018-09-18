using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品评价表
	/// </summary>
	public class ProductReview: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 订单商品记录id
		/// </summary>
		public int OPRId { get; set; }

		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 父id
		/// </summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public int State { get; set; }

		/// <summary>
		/// 星星
		/// </summary>
		public int Star { get; set; }

		/// <summary>
		/// 评价质量
		/// </summary>
		public int Quality { get; set; }

		/// <summary>
		/// 评价信息
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 评价时间
		/// </summary>
		public DateTime ReviewTime { get; set; }

		/// <summary>
		/// 支付积分
		/// </summary>
		public int PayCredits { get; set; }

		/// <summary>
		/// 购买时间
		/// </summary>
		public DateTime BuyTime { get; set; }

		/// <summary>
		/// ip
		/// </summary>
		public string IP { get; set; }
	}
}

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 优惠劵表
	/// </summary>
	public class Coupon: Entity<int>, IHasCreationTime
	{
		/// <summary>
		/// 优惠劵编号
		/// </summary>
		public string CouponSN { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 优惠劵类型id
		/// </summary>
		public int CouponTypeId { get; set; }

		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 使用时间
		/// </summary>
		public DateTime UseTime { get; set; }

		/// <summary>
		/// 使用ip
		/// </summary>
		public string UseIP { get; set; }

		/// <summary>
		/// 金额
		/// </summary>		
		public int Money { get; set; }

		/// <summary>
		/// 激活时间
		/// </summary>
		public DateTime ActivateTime { get; set; }

		/// <summary>
		/// 激活ip
		/// </summary>
		public string ActivateIP { get; set; }

		/// <summary>
		/// 创建用户id
		/// </summary>
		public int CreateUserId { get; set; }

		/// <summary>
		/// 创建订单id
		/// </summary>
		public int CreateOrderId { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreationTime { get; set; }

		/// <summary>
		/// 创建ip
		/// </summary>
		public string CreateIP { get; set; }

	}
}

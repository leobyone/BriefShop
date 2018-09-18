using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品评价质量表
	/// </summary>
	public class ProductReviewQuality: Entity<int>
	{
		/// <summary>
		/// 评价id
		/// </summary>
		public int ReviewId { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 评价时间
		/// </summary>
		public DateTime VoteTime { get; set; }
	}
}

using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 浏览历史表
	/// </summary>
	public class BrowseHistory: Entity<int>
	{
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 浏览次数
		/// </summary>
		public int Times { get; set; }

		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime { get; set; }
	}
}

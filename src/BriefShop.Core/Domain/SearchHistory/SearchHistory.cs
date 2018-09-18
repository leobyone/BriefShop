using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 搜索历史表
	/// </summary>
	public class SearchHistory: Entity<int>
	{
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 搜索词
		/// </summary>
		public string Word { get; set; }

		/// <summary>
		/// 搜索次数
		/// </summary>
		public int Times { get; set; }

		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime { get; set; }
	}
}

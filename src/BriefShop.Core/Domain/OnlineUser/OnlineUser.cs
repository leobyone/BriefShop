using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 在线用户表
	/// </summary>
	public class OnlineUser: Entity<int>
	{
		/// <summary>
		/// 在线用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 在线用户sessionid
		/// </summary>
		public string SessionId { get; set; }

		/// <summary>
		/// 在线用户ip
		/// </summary>
		public string IP { get; set; }

		/// <summary>
		/// 区域id
		/// </summary>
		public int RegionId { get; set; }

		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime { get; set; }

	}
}

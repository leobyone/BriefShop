using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 禁止IP表
	/// </summary>
	public class BannedIP: Entity<int>
	{
		/// <summary>
		/// ip地址
		/// </summary>
		[Required]
		public string IP { get; set; }

		/// <summary>
		/// 解禁时间
		/// </summary>
		public DateTime LiftBanTime { get; set; }

	}
}

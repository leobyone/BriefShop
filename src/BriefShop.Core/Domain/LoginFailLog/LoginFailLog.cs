using Abp.Domain.Entities;
using System;

namespace BriefShop.Core
{
	/// <summary>
	/// 登录失败日志表
	/// </summary>
	public class LoginFailLog: Entity<int>
	{
		/// <summary>
		/// 登录ip
		/// </summary>
		public long LoginIP { get; set; }

		/// <summary>
		/// 失败次数
		/// </summary>
		public int FailTimes { get; set; }

		/// <summary>
		/// 最后登录时间
		/// </summary>
		public DateTime LastLoginTime { get; set; }

	}
}

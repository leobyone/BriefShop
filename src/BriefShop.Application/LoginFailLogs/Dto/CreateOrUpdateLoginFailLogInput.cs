using Abp.AutoMapper;
using BriefShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefShop.LoginFailLogs.Dto
{
	[AutoMapTo(typeof(LoginFailLog))]
	public class CreateOrUpdateLoginFailLogInput
	{
		/// <summary>
		/// id
		/// </summary>
		public int? Id { get; set; }

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

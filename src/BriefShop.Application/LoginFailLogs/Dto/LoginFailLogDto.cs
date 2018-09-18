using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BriefShop.Core;
using System;

namespace BriefShop.LoginFailLogs.Dto
{
	[AutoMapFrom(typeof(LoginFailLog))]
	public class LoginFailLogDto: EntityDto<int>
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

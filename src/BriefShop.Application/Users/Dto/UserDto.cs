using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BriefShop.Core;

namespace BriefShop.Users.Dto
{
	/// <summary>
	/// 用户表列表Dto
	/// </summary>
	[AutoMapFrom(typeof(User))]
	public class UserDto : EntityDto<int>
	{
		/// <summary>
		/// 用户名称
		/// </summary>
		[DisplayName("用户名称")]
		public string UserName { get; set; }

		/// <summary>
		/// 用户邮箱
		/// </summary>
		[DisplayName("用户邮箱")]
		public string Email { get; set; }

		/// <summary>
		/// 用户手机
		/// </summary>
		[DisplayName("用户手机")]
		public string Mobile { get; set; }

		/// <summary>
		/// 用户密码
		/// </summary>
		[DisplayName("用户密码")]
		[Required]
		public string Password { get; set; }

		/// <summary>
		/// 用户管理员组id
		/// </summary>
		[DisplayName("用户管理员组id")]
		public int AdminGroupId { get; set; }

		/// <summary>
		/// 用户等级id
		/// </summary>
		[DisplayName("用户等级id")]
		public int UserRankId { get; set; }

		/// <summary>
		/// 用户昵称
		/// </summary>
		[DisplayName("用户昵称")]
		public string NickName { get; set; }

		/// <summary>
		/// 用户头像
		/// </summary>
		[DisplayName("用户头像")]
		public string Avatar { get; set; }

		/// <summary>
		/// 支付积分
		/// </summary>
		[DisplayName("支付积分")]
		public int PayCredits { get; set; }

		/// <summary>
		/// 等级积分
		/// </summary>
		[DisplayName("等级积分")]
		public int RankCredits { get; set; }

		/// <summary>
		/// 是否验证邮箱
		/// </summary>
		[DisplayName("是否验证邮箱")]
		public int VerifyEmail { get; set; }

		/// <summary>
		/// 是否验证手机
		/// </summary>
		[DisplayName("是否验证手机")]
		public int VerifyMobile { get; set; }

		/// <summary>
		/// 解禁时间
		/// </summary>
		[DisplayName("解禁时间")]
		public DateTime LiftBanTime { get; set; }

		/// <summary>
		/// 盐值
		/// </summary>
		[DisplayName("盐值")]
		public string Salt { get; set; }
	}
}

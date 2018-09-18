using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 用户表
	/// </summary>
	public class User: Entity<int>
	{
		/// <summary>
		///用户名称
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 用户邮箱
		/// </summary>
		[RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]+$")]
		public string Email { get; set; }

		/// <summary>
		/// 用户手机
		/// </summary>
		[RegularExpression(@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$")]
		public string Mobile { get; set; }

		/// <summary>
		/// 用户密码
		/// </summary>
		[Required]
		[RegularExpression(@"^[a-zA-Z]\w{5,17}$")]
		public string Password { get; set; }

		///<summary>
		///用户管理员组id
		///</summary>
		public int AdminGroupId { get; set; }

		///<summary>
		///用户等级id
		///</summary>
		public int UserRankId { get; set; }

		/// <summary>
		/// 用户昵称
		/// </summary>
		public string NickName { get; set; }

		/// <summary>
		/// 用户头像
		/// </summary>
		public string Avatar { get; set; }

		///<summary>
		///支付积分
		///</summary>
		public int PayCredits { get; set; }

		/// <summary>
		/// 等级积分
		/// </summary>
		public int RankCredits { get; set; }

		/// <summary>
		/// 是否验证邮箱
		/// </summary>
		public int VerifyEmail { get; set; }

		/// <summary>
		/// 是否验证手机
		/// </summary>
		public int VerifyMobile { get; set; }

		/// <summary>
		/// 解禁时间
		/// </summary>
		public DateTime LiftBanTime { get; set; }

		///<summary>
		///盐值
		///</summary>
		public string Salt { get; set; }

		public User CreateGuest()
		{
			var user = new User()
			{
				Id = -1,
				UserName = "guest",
				Email = "",
				Mobile = "",
				Password = "",
				UserRankId = 6,
				AdminGroupId = 1,
				NickName = "游客",
				Avatar = "",
				PayCredits = 0,
				RankCredits = 0,
				VerifyEmail = 0,
				VerifyMobile = 0,
				LiftBanTime = new DateTime(1900, 1, 1),
				Salt = ""
			};

			return user;
		}
	}
}

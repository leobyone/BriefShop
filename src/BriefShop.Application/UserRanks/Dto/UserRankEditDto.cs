using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using BriefShop.Core;

namespace BriefShop.Core.Dtos
{
	/// <summary>
	/// 用户等级表编辑用Dto
	/// </summary>
	[AutoMapTo(typeof(UserRank))]
	public class UserRankEditDto
	{
		/// <summary>
		///   主键Id
		/// </summary>
		[DisplayName("主键Id")]
		public int? Id { get; set; }

		/// <summary>
		/// 是否是系统等级
		/// </summary>
		[DisplayName("是否是系统等级")]
		public int System { get; set; }

		/// <summary>
		/// 用户等级标题
		/// </summary>
		[DisplayName("用户等级标题")]
		[Required]
		public string Title { get; set; }

		/// <summary>
		/// 用户等级头像
		/// </summary>
		[DisplayName("用户等级头像")]
		public string Avatar { get; set; }

		/// <summary>
		/// 用户等级积分上限
		/// </summary>
		[DisplayName("用户等级积分上限")]
		public int CreditsUpper { get; set; }

		/// <summary>
		/// 用户等级积分下限
		/// </summary>
		[DisplayName("用户等级积分下限")]
		public int CreditsLower { get; set; }

		/// <summary>
		/// 限制天数
		/// </summary>
		[DisplayName("限制天数")]
		public int LimitDays { get; set; }

	}
}

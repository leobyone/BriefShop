using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 用户等级表
	/// </summary>
	public class UserRank: Entity<int>
	{
		public const int MaxTitleLength = 50;

		///<summary>
		///是否是系统等级
		///</summary>
		public int System { get; set; }

		///<summary>
		///用户等级标题
		///</summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 用户等级头像
		/// </summary>
		public string Avatar { get; set; }

		///<summary>
		///用户等级积分上限
		///</summary>
		public int CreditsUpper { get; set; }

		///<summary>
		///用户等级积分下限
		///</summary>
		public int CreditsLower { get; set; }

		/// <summary>
		/// 限制天数
		/// </summary>
		public int LimitDays { get; set; }

	}
}

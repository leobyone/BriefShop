using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BriefShop.Core;

namespace BriefShop.UserRanks.Dto
{
	/// <summary>
	/// 用户等级列表Dto
	/// </summary>
	[AutoMapFrom(typeof(UserRank))]
	public class UserRankDto : EntityDto<int>
	{
		///<summary>
		///是否是系统等级
		///</summary>
		public int System { get; set; }

		///<summary>
		///用户等级标题
		///</summary>
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

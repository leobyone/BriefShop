using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 管理员组表
	/// </summary>
	public class AdminGroup : Entity<int>
	{
		public const int MaxTitleLength = 50;

		/// <summary>
		/// 管理员组标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 管理员组行为列表
		/// </summary>
		public string ActionList { get; set; }
	}
}

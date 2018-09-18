using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 后台操作表
	/// </summary>
	public class AdminAction: Entity<int>
	{
		public const int MaxTitleLength = 256;

		/// <summary>
		/// 操作标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 操作行为
		/// </summary>
		public string Action { get; set; }

		/// <summary>
		/// 父id
		/// </summary>
		public int ParentId{ get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder{ get; set; }
	}
}

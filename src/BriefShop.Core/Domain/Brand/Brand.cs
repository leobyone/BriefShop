using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 品牌表
	/// </summary>
	public class Brand: Entity<int>
	{
		public const int MaxNameLength = 20;

		/// <summary>
		/// 品牌排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 品牌名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 品牌logo
		/// </summary>
		public string Logo { get; set; }

	}
}

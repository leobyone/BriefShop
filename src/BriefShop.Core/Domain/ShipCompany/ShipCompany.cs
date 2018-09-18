using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 配送公司表
	/// </summary>
	public class ShipCompany: Entity<int>
	{
		public const int MaxNameLength = 30;

		/// <summary>
		/// 名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

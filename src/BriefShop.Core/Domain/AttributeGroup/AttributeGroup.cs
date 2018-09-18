using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 属性分组表
	/// </summary>
	public class AttributeGroup:Entity<int>
	{
		public const int MaxNameLength = 20;

		/// <summary>
		/// 分类id
		/// </summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 分组名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 分组排序
		/// </summary>
		public int DisplayOrder { get; set; }

	}
}

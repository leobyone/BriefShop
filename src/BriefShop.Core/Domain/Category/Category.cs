using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 分类表
	/// </summary>
	public class Category: Entity<int>
	{
		public const int MaxNameLength = 60;

		/// <summary>
		/// 分类排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 分类名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 分类价格范围
		/// </summary>
		public string PriceRange { get; set; }

		/// <summary>
		/// 父id
		/// </summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 层级
		/// </summary>
		public int Layer { get; set; }

		/// <summary>
		/// 是否有子节点
		/// </summary>
		public int HasChild { get; set; }

		/// <summary>
		/// 分类路径
		/// </summary>
		public string Path { get; set; }

	}
}

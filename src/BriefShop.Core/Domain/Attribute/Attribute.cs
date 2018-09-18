using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 属性表
	/// </summary>
	public class Attribute:Entity<int>
	{
		public const int MaxNameLength = 30;

		/// <summary>
		/// 属性名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 分类id
		/// </summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 分组id
		/// </summary>
		public int AttributeGroupId { get; set; }

		/// <summary>
		/// 展示类型(0代表文字,1代表图片)
		/// </summary>
		public int ShowType { get; set; }

		/// <summary>
		/// 是否是筛选属性
		/// </summary>
		public int IsFilter { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}

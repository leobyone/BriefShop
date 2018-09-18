using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 属性值表
	/// </summary>
	public class AttributeValue: Entity<int>
	{
		/// <summary>
		/// 是否为输入值
		/// </summary>
		public int IsInput { get; set; }

		/// <summary>
		/// 属性值排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 属性id
		/// </summary>
		public int AttrId { get; set; }

		/// <summary>
		/// 属性值
		/// </summary>
		[Required]
		public string AttrValue { get; set; }

		/// <summary>
		/// 属性名
		/// </summary>
		[Required]
		public string AttrName { get; set; }

		/// <summary>
		/// 属性名
		/// </summary>
		[Required]
		public string AttrDisplayOrder { get; set; }

		/// <summary>
		/// 属性名
		/// </summary>
		[Required]
		public string AttrShowType { get; set; }

		/// <summary>
		/// 属性分组id
		/// </summary>
		public int AttrGroupId { get; set; }

		/// <summary>
		/// 属性分组名称
		/// </summary>
		public int AttrGroupName { get; set; }

		/// <summary>
		/// 属性分组排序
		/// </summary>
		public int AttrGroupDisplayOrder { get; set; }
	}
}

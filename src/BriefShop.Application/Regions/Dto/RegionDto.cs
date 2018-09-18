using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BriefShop.Core;

namespace BriefShop.Regions.Dto
{
	[AutoMapFrom(typeof(Region))]
	public class RegionDto : EntityDto<int>
	{
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 拼写
		/// </summary>
		public string Spell { get; set; }

		/// <summary>
		/// 简拼
		/// </summary>
		public string ShortSpell { get; set; }

		/// <summary>
		/// 排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 父id
		/// </summary>
		public int ParentId { get; set; }

		/// <summary>
		/// 级别
		/// </summary>
		public int Layer { get; set; }

		/// <summary>
		/// 省id
		/// </summary>
		public int ProvinceId { get; set; }

		/// <summary>
		/// 省名称
		/// </summary>
		public string ProvinceName { get; set; }

		/// <summary>
		/// 市id
		/// </summary>
		public int CityId { get; set; }

		/// <summary>
		/// 市名称
		/// </summary>
		public string CityName { get; set; }
	}
}

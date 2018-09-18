using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 用户配送地址表
	/// </summary>
	public class ShipAddress: Entity<int>
	{
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 区域id
		/// </summary>
		public int RegionId { get; set; }

		/// <summary>
		/// 是否是默认地址
		/// </summary>
		public int IsDefault { get; set; }

		/// <summary>
		/// 别名
		/// </summary>
		public string Alias { get; set; }

		/// <summary>
		/// 收货人
		/// </summary>
		public string Consignee { get; set; }

		/// <summary>
		/// 收货人手机
		/// </summary>
		[RegularExpression(@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$")]
		public string Mobile { get; set; }

		/// <summary>
		/// 收货人固定电话
		/// </summary>
		[RegularExpression(@"^(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}$")]
		public string Phone { get; set; }

		/// <summary>
		/// 收货人邮箱
		/// </summary>
		[RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]+$")]
		public string Email { get; set; }

		/// <summary>
		/// 邮政编码
		/// </summary>
		[RegularExpression(@"[1-9]\d{5}(?!\d)")]
		public string ZipCode { get; set; }

		/// <summary>
		/// 地址
		/// </summary>
		public string Address { get; set; }

	}
}

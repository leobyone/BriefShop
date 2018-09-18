using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 满赠商品表
	/// </summary>
	public class FullSendProduct: Entity<int>
	{
		/// <summary>
		/// 满赠促销活动id
		/// </summary>
		public int PmId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 类型
		/// </summary>
		public int Type { get; set; }
	}
}

using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 满减商品表
	/// </summary>
	public class FullCutProduct: Entity<int>
	{
		/// <summary>
		/// 促销活动id
		/// </summary>
		public int PmId { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }
	}
}

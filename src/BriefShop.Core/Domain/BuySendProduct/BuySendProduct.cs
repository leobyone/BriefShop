using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 买送商品表
	/// </summary>
	public class BuySendProduct: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 促销活动id
		/// </summary>
		public int PmId { get; set; }

	}
}

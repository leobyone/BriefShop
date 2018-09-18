using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 赠品表
	/// </summary>
	public class Gift : Entity<int>
	{
		/// <summary>
		/// 促销活动id
		/// </summary>
		public int PmId { get; set; }

		/// <summary>
		/// 赠品id
		/// </summary>
		public int GiftId { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }
	}
}

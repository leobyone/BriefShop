using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefShop.Core
{
	/// <summary>
	/// 关联商品表
	/// </summary>
	public class RelateProduct: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 关联商品id
		/// </summary>
		public int RelateProductId { get; set; }
	}
}

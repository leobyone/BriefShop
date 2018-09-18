using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 定时商品表
	/// </summary>
	public class TimeProduct: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 上架状态(0代表无需上架,1代表等待执行上架,2代表已经执行上架)
		/// </summary>
		public int OnSaleState { get; set; }

		/// <summary>
		/// 下架状态(0代表无需下架,1代表等待执行下架,2代表已经执行下架)
		/// </summary>
		public int OutSaleState { get; set; }

		/// <summary>
		/// 上架时间
		/// </summary>
		public DateTime OnSaleTime { get; set; }

		/// <summary>
		/// 下架时间
		/// </summary>
		public DateTime OutSaleTime { get; set; }

	}
}

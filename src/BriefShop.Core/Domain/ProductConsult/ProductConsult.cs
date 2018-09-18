using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 商品咨询表
	/// </summary>
	public class ProductConsult: Entity<int>
	{
		/// <summary>
		/// 商品id
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// 咨询类型id
		/// </summary>
		public int ConsultTypeId { get; set; }

		/// <summary>
		/// 状态(0代表显示，1代表屏蔽)
		/// </summary>
		public int State { get; set; }

		/// <summary>
		/// 咨询用户id
		/// </summary>
		public int ConsultUserId { get; set; }

		/// <summary>
		/// 回复用户id
		/// </summary>
		public int ReplyUserId { get; set; }

		/// <summary>
		/// 咨询时间
		/// </summary>
		public DateTime ConsultTime { get; set; }

		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime ReplyTime { get; set; }

		/// <summary>
		/// 咨询内容
		/// </summary>
		public string ConsultMessage { get; set; }

		/// <summary>
		/// 回复内容
		/// </summary>
		public string ReplyMessage { get; set; }

		/// <summary>
		/// 咨询昵称
		/// </summary>
		public string ConsultNickName { get; set; }

		/// <summary>
		/// 回复昵称
		/// </summary>
		public string ReplyNickName { get; set; }

		/// <summary>
		/// 咨询ip
		/// </summary>
		public string ConsultIP { get; set; }

		/// <summary>
		/// 回复ip
		/// </summary>
		public string ReplyIP { get; set; }

	}
}

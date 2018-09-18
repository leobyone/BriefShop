using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 订单处理表
	/// </summary>
	public class OrderAction : Entity<int>
	{
		public const int MaxDescriptionLength = 250;

		/// <summary>
		/// 订单id
		/// </summary>
		public int OrderId { get; set; }

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 真实名称
		/// </summary>
		public string RealName { get; set; }

		/// <summary>
		/// 管理员组id
		/// </summary>
		public int AdminGroupId { get; set; }

		/// <summary>
		/// 管理员组标题
		/// </summary>
		public string AdminGroupTitle { get; set; }

		/// <summary>
		/// 处理类型
		/// </summary>
		public int ActionType { get; set; }

		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime ActionTime { get; set; }

		/// <summary>
		/// 处理描述
		/// </summary>
		[MaxLength(MaxDescriptionLength)]
		public string ActionDescription { get; set; }

	}
}

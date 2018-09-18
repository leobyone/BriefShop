using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 积分日志表
	/// </summary>
	public class CreditLog: Entity<int>
	{
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 支付积分
		/// </summary>
		public int PayCredits { get; set; }

		/// <summary>
		/// 等级积分
		/// </summary>
		public int RankCredits { get; set; }

		/// <summary>
		/// 动作类型
		/// </summary>
		public int Action { get; set; }

		/// <summary>
		/// 动作代码
		/// </summary>
		public int ActionCode { get; set; }

		/// <summary>
		/// 动作时间
		/// </summary>
		public DateTime ActionTime { get; set; }

		/// <summary>
		/// 动作描述
		/// </summary>
		public string ActionDes { get; set; }

		/// <summary>
		/// 操作人
		/// </summary>
		public int Operator { get; set; }

	}
}

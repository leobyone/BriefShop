using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 管理员操作日志表
	/// </summary>
	public class AdminOperateLog : Entity<int>
	{
		public const int MaxNickNameLength = 20;
		public const int MaxDescriptionLength = 200;

		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 用户昵称
		/// </summary>
		public string NickName { get; set; }

		/// <summary>
		/// 管理员组id
		/// </summary>
		public int AdminGroupId{ get; set; }

		/// <summary>
		/// 管理员组标题
		/// </summary>
		public string AdminGroupTitle { get; set; }

		/// <summary>
		/// 操作动作
		/// </summary>
		public string Operation{ get; set; }

		/// <summary>
		/// 操作描述
		/// </summary>
		[MaxLength(MaxDescriptionLength)]
		public string Description{ get; set; }

		/// <summary>
		/// ip
		/// </summary>
		public string IP{ get; set; }

		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperateTime{ get; set; }
	}
}

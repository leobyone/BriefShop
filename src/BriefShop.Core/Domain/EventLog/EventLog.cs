using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 事件日志表
	/// </summary>
	public class EventLog: Entity<int>
	{
		public const int MaxTitleLength = 200;

		/// <summary>
		/// 事件键值
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// 事件标题
		/// </summary>
		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		/// <summary>
		/// 服务器
		/// </summary>
		public string Server { get; set; }

		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime ExecuteTime { get; set; }
	}
}

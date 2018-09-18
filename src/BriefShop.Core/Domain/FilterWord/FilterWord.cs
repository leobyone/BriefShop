using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Core
{
	/// <summary>
	/// 过滤词表
	/// </summary>
	public class FilterWord: Entity<int>
	{
		public const int MaxMatchLength = 250;
		public const int MaxReplaceLength = 250;

		/// <summary>
		/// 匹配词
		/// </summary>
		[MaxLength(MaxMatchLength)]
		public string Match { get; set; }

		/// <summary>
		/// 替换词
		/// </summary>
		[MaxLength(MaxReplaceLength)]
		public string Replace { get; set; }
	}
}

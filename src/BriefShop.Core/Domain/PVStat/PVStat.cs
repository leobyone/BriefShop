using Abp.Domain.Entities;

namespace BriefShop.Core
{
	/// <summary>
	/// PV统计表
	/// </summary>
	public class PVStat: Entity<int>
	{
		/// <summary>
		/// 类别
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// 值
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// 数量
		/// </summary>
		public int Count { get; set; }

	}
}

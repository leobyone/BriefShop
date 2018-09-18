using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	/// <summary>
	/// 开放授权表
	/// </summary>
	public class OAuth: Entity<int>
	{
		/// <summary>
		/// 用户id
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// 开放id
		/// </summary>
		public string OpenId { get; set; }

		/// <summary>
		/// 服务商
		/// </summary>
		public string Server { get; set; }

	}
}

using Abp.AutoMapper;
using BriefShop.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.UserDetails.Dto
{
	[AutoMapFrom(typeof(UserDetail))]
	public class UserDetailDto
	{
		public int UserId { get; set; }

		/// <summary>
		/// 最后访问时间
		/// </summary>
		public DateTime LastVisitTime { get; set; }

		/// <summary>
		/// 最后访问ip
		/// </summary>
		public string LastVisitIP { get; set; }

		/// <summary>
		/// 最后访问区域id
		/// </summary>
		public int LastVisitRgId { get; set; }

		/// <summary>
		/// 用户注册时间
		/// </summary>
		public DateTime RegisterTime { get; set; }

		/// <summary>
		/// 用户注册ip
		/// </summary>
		public string RegisterIP { get; set; }

		/// <summary>
		/// 用户注册区域id
		/// </summary>
		public int RegisterRegionId { get; set; }

		///<summary>
		///用户性别(0代表未知，1代表男，2代表女)
		///</summary>
		public int Gender { get; set; }

		/// <summary>
		/// 用户真实名称
		/// </summary>
		public string RealName { get; set; }

		///<summary>
		///用户出生日期
		///</summary>
		public DateTime Birthday { get; set; }

		/// <summary>
		/// 身份证号
		/// </summary>
		[RegularExpression(@"^\d{15}|\d{18}$")]
		public string IdCard { get; set; }

		///<summary>
		///区域id
		///</summary>
		public int RegionId { get; set; }

		///<summary>
		///所在地
		///</summary>
		public string Address { get; set; }

		///<summary>
		///简介
		///</summary>
		public string Bio { get; set; }
	}
}

using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Extensions;
using BriefShop.Core;

namespace BriefShop.Core.Dtos
{
	/// <summary>
	/// 用于添加或编辑 用户表时使用的DTO
	/// </summary>

	public class GetUserForEditOutput
	{
		/// <summary>
		/// User编辑状态的DTO
		/// </summary>
		public UserEditDto User { get; set; }
	}
}

using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using BriefShop.Core;

namespace BriefShop.Core.Dtos
{
	/// <summary>
	/// 用户表新增和编辑时用Dto
	/// </summary>
	public class CreateOrUpdateUserInput
	{
		/// <summary>
		/// 用户表编辑Dto
		/// </summary>
		public UserEditDto UserEditDto { get; set; }
	}
}

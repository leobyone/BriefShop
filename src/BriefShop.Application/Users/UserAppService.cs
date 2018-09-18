using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using BriefShop.Users;
using BriefShop.Users.Dto;
using System;
using System.Threading.Tasks;

namespace BriefShop.Core
{
	/// <summary>
	/// 用户表应用层服务的接口实现方法
	/// </summary>
	public class UserAppService : BriefShopAppServiceBase, IUserAppService
	{
		private readonly IRepository<User, int> _userRepository;

		/// <summary>
		/// 构造方法
		/// </summary>
		public UserAppService(IRepository<User, int> userRepository)
		{
			_userRepository = userRepository;
		}

		#region 用户表管理

		/// <summary>
		/// 通过指定email获取用户表ListDto信息
		/// </summary>
		public async Task<UserDto> GetUserByEmailAsync(string email)
		{
			var user = await _userRepository.SingleAsync(m => m.Email == email);

			return ObjectMapper.Map<UserDto>(user);
		}

		/// <summary>
		/// 通过指定id获取用户表ListDto信息
		/// </summary>
		public async Task<UserDto> GetUserByIdAsync(EntityDto<int> input)
		{
			try
			{
				var user = await _userRepository.GetAsync(input.Id);

				if (user == null) return null;

				return ObjectMapper.Map<UserDto>(user);
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// 通过指定用户id和密码获取用户表ListDto信息
		/// </summary>
		public async Task<UserDto> GetUserByUserIdAndPwdAsync(GetUserByUidAndPwdInput input)
		{
			try
			{
				var user = await _userRepository.SingleAsync(m => m.Id == input.UserId && m.Password == input.Password);

				if (user == null) return null;

				return ObjectMapper.Map<UserDto>(user);
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// 通过指定用户名称获取用户表ListDto信息
		/// </summary>
		public async Task<UserDto> GetUserByNameAsync(string name)
		{
			var user = await _userRepository.SingleAsync(m => m.UserName == name);

			return ObjectMapper.Map<UserDto>(user);
		}

		/// <summary>
		/// 通过指定用户手机获取用户表ListDto信息
		/// </summary>
		public async Task<UserDto> GetUserByMobileAsync(string mobile)
		{
			var user = await _userRepository.SingleAsync(m => m.Mobile == mobile);

			return ObjectMapper.Map<UserDto>(user);
		}

		/// <summary>
		/// 通过用户id更新用户等级
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task UpdateUserRankByUserIdAsync(UpdateUserRankByUserIdInput input)
		{
			try
			{
				var entity = await _userRepository.GetAsync(input.Id);

				entity = ObjectMapper.Map<User>(input);

				await _userRepository.UpdateAsync(entity);
			}
			catch(Exception ex)
			{
				throw new UserFriendlyException(L("CouldNotFoundTheUser"));
			}
		}

		#endregion
	}
}

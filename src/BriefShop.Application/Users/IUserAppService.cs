using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BriefShop.Users.Dto;
using System.Threading.Tasks;

namespace BriefShop.Users
{
	/// <summary>
	/// 用户表服务接口
	/// </summary>
	public interface IUserAppService : IApplicationService
	{
		#region 用户表管理

		/// <summary>
		/// 通过指定邮箱获取用户表ListDto信息
		/// </summary>
		Task<UserDto> GetUserByEmailAsync(string email);

		/// <summary>
		/// 通过指定id获取用户表ListDto信息
		/// </summary>
		Task<UserDto> GetUserByIdAsync(EntityDto<int> input);

		/// <summary>
		/// 通过指定用户id和密码获取用户表ListDto信息
		/// </summary>
		Task<UserDto> GetUserByUserIdAndPwdAsync(GetUserByUidAndPwdInput input);

		/// <summary>
		/// 通过指定用户名称获取用户表ListDto信息
		/// </summary>
		Task<UserDto> GetUserByNameAsync(string name);

		/// <summary>
		/// 通过指定用户手机获取用户表ListDto信息
		/// </summary>
		Task<UserDto> GetUserByMobileAsync(string mobile);

		Task UpdateUserRankByUserIdAsync(UpdateUserRankByUserIdInput input);

		#endregion
	}
}

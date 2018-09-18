using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.UI;
using BriefShop.Core;
using BriefShop.LoginFailLogs.Dto;
using System;
using System.Threading.Tasks;

namespace BriefShop.LoginFailLogs
{
	/// <summary>
	/// LoginFailLog应用层服务的接口实现方法
	/// </summary>
	public class LoginFailLogAppService : BriefShopAppServiceBase, ILoginFailLogAppService
	{
		private readonly IRepository<LoginFailLog, int> _loginFailLogRepository;

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="loginFailLogRepository"></param>
		public LoginFailLogAppService(IRepository<LoginFailLog, int> loginFailLogRepository)
		{
			_loginFailLogRepository = loginFailLogRepository;
		}

		/// <summary>
		/// 获得登录失败次数
		/// </summary>
		/// <param name="loginIP"></param>
		/// <returns></returns>
		public async Task<int> GetLoginFailTimesByIPAsync(string loginIP)
		{
			var entity = await GetLoginFailLogByIPAsync(CommonHelper.ConvertIPToLong(loginIP));

			if (entity == null)
			{
				return 0;
			}

			//超过15分钟
			if (entity.LastLoginTime.AddMinutes(15) < DateTime.Now)
			{
				return 0;
			}

			return entity.FailTimes;
		}

		/// <summary>
		/// 增加登录失败次数
		/// </summary>
		/// <param name="loginIP"></param>
		/// <param name="loginTime"></param>
		/// <returns></returns>
		public void AddLoginFailTimes(string loginIP, DateTime loginTime)
		{
			CreateOrUpdateLoginFailLogInput input = new CreateOrUpdateLoginFailLogInput();
			input.LoginIP = CommonHelper.ConvertIPToLong(loginIP);
			input.LastLoginTime = loginTime;

			CreateOrUpdateLoginFailLog(input);
		}

		/// <summary>
		/// 添加或更新登录失败日志
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public void CreateOrUpdateLoginFailLog(CreateOrUpdateLoginFailLogInput input)
		{
			try
			{
				var loginFailLog = _loginFailLogRepository.Single(m => m.LoginIP == input.LoginIP);

				input.Id = loginFailLog.Id;
				input.FailTimes = 1;
				UpdateLoginFailLog(input);
			}
			catch (Exception ex)
			{
				CreateLoginFailLog(input);
			}
		}

		/// <summary>
		/// 删除登录失败日志
		/// </summary>
		/// <param name="loginIP"></param>
		/// <returns></returns>
		public async Task DeleteLoginFailLogByIPAsync(long loginIP)
		{
			await _loginFailLogRepository.DeleteAsync(m => m.LoginIP == loginIP);
		}

		/// <summary>
		/// 根据ip获取登录失败日志记录
		/// </summary>
		/// <param name="loginIP"></param>
		/// <returns></returns>
		public async Task<LoginFailLogDto> GetLoginFailLogByIPAsync(long loginIP)
		{
			try
			{
				var loginFailLog = await _loginFailLogRepository.SingleAsync(m => m.LoginIP == loginIP);

				return ObjectMapper.Map<LoginFailLogDto>(loginFailLog);
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		//public async Task<ListResultDto<LoginFailLogDto>> GetLoginFailLogByIP(long loginIP)
		//{
		//	//条件过滤
		//	var loginFailLogs = await _loginFailLogRepository.GetAll()
		//		.WhereIf(loginIP > 0, m => m.LoginIP == loginIP)
		//		.ToListAsync();

		//	return new ListResultDto<LoginFailLogDto>(loginFailLogs.MapTo<List<LoginFailLogDto>>());
		//}

		/// <summary>
		/// 添加登录失败日志记录
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		protected virtual void CreateLoginFailLog(CreateOrUpdateLoginFailLogInput input)
		{
			try
			{
				var entity = ObjectMapper.Map<LoginFailLog>(input);

				LoginFailLog x = _loginFailLogRepository.Insert(entity);
			}
			catch (Exception ex)
			{
				throw new UserFriendlyException(L("CouldNotInsertTheLoginFailLog"));
			}
		}

		/// <summary>
		/// 更新登录失败日志记录
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		protected virtual void UpdateLoginFailLog(CreateOrUpdateLoginFailLogInput input)
		{
			try
			{
				var entity = _loginFailLogRepository.Get(input.Id.Value);

				input.FailTimes = entity.FailTimes + 1;
				entity = ObjectMapper.Map<LoginFailLog>(input);

				_loginFailLogRepository.UpdateAsync(entity);
			}
			catch (Exception ex)
			{
				throw new UserFriendlyException(L("CouldNotFoundTheLoginFailLog"));
			}
		}
	}
}

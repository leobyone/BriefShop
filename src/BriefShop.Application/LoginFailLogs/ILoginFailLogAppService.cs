using Abp.Application.Services;
using BriefShop.LoginFailLogs.Dto;
using System;
using System.Threading.Tasks;

namespace BriefShop.LoginFailLogs
{
	public interface ILoginFailLogAppService: IApplicationService
	{
		Task<int> GetLoginFailTimesByIPAsync(string loginIP);

		void AddLoginFailTimes(string loginIP, DateTime loginTime);

		Task<LoginFailLogDto> GetLoginFailLogByIPAsync(long loginIP);

		void CreateOrUpdateLoginFailLog(CreateOrUpdateLoginFailLogInput input);

		Task DeleteLoginFailLogByIPAsync(long loginIP);
	}
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BriefShop.Core.Dtos;
using BriefShop.UserRanks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefShop.UserRanks
{
	/// <summary>
	/// 用户等级表服务接口
	/// </summary>
	public interface IUserRankAppService : IApplicationService
	{
		Task<GetUserRankListOutput> GetUserRankListAsync();

		Task<GetUserRankListOutput> GetUserRankListCacheAsync();

		Task CreateOrUpdateUserRankAsync(CreateOrUpdateUserRankInput input);

		Task DeleteUserRankByIdAsync(EntityDto<int> input);

		Task<UserRankDto> GetUserRankByCredits(int credits);
	}
}

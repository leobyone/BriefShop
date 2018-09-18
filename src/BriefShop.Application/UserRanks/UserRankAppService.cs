using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using BriefShop.Core.Dtos;
using BriefShop.UserRanks;
using BriefShop.UserRanks.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BriefShop.Core
{
	/// <summary>
	/// 用户等级表服务实现
	/// </summary>

	public class UserRankAppService : BriefShopAppServiceBase, IUserRankAppService
	{
		private readonly IRepository<UserRank, int> _userRankRepository;
		private readonly ICacheManager _cacheManager;

		/// <summary>
		/// 构造方法
		/// </summary>
		public UserRankAppService(IRepository<UserRank, int> userRankRepository, ICacheManager cacheManager)
		{
			_userRankRepository = userRankRepository;
			_cacheManager = cacheManager;
		}

		#region 用户等级表管理

		/// <summary>
		/// 获取用户等级表列表
		/// </summary>
		public async Task<GetUserRankListOutput> GetUserRankListAsync()
		{
			var userRanks = await _userRankRepository.GetAllListAsync();

			return new GetUserRankListOutput
			{
				UserRanks = ObjectMapper.Map<List<UserRankDto>>(userRanks)
			};
		}

		/// <summary>
		/// 获取用户等级表列表
		/// </summary>
		public async Task<GetUserRankListOutput> GetUserRankListCacheAsync()
		{
			var cache = _cacheManager.GetCache(CacheKeys.SHOP_USERRANK_LIST);

			var userRanks = await cache.GetAsync(CacheKeys.SHOP_USERRANK_LIST,
				async () =>
				{
					return await GetUserRankListAsync();
				});

			return userRanks;
		}

		/// <summary>
		/// 新增或更改用户等级表
		/// </summary>
		public async Task CreateOrUpdateUserRankAsync(CreateOrUpdateUserRankInput input)
		{
			if (input.UserRankEditDto.Id.HasValue)
			{
				await UpdateUserRankAsync(input.UserRankEditDto);
			}
			else
			{
				await CreateUserRankAsync(input.UserRankEditDto);
			}
		}

		/// <summary>
		/// 新增用户等级表
		/// </summary>
		public virtual async Task<UserRankEditDto> CreateUserRankAsync(UserRankEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

			var entity = ObjectMapper.Map<UserRank>(input);
			entity = await _userRankRepository.InsertAsync(entity);

			return entity.MapTo<UserRankEditDto>();
		}

		/// <summary>
		/// 编辑用户等级表
		/// </summary>
		public virtual async Task UpdateUserRankAsync(UserRankEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新

			var entity = await _userRankRepository.GetAsync(input.Id.Value);
			entity = ObjectMapper.Map<UserRank>(input);

			await _userRankRepository.UpdateAsync(entity);
		}

		/// <summary>
		/// 删除用户等级表
		/// </summary>
		public async Task DeleteUserRankByIdAsync(EntityDto<int> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _userRankRepository.DeleteAsync(input.Id);
		}

		/// <summary>
		/// 获得积分对应的用户等级
		/// </summary>
		/// <param name="credits">积分</param>
		/// <returns></returns>
		public async Task<UserRankDto> GetUserRankByCredits(int credits)
		{
			var userRanks = await GetUserRankListCacheAsync();

			foreach (UserRankDto item in userRanks.UserRanks)
			{
				if (item.System == 0
					&& item.CreditsLower <= credits
					&& (item.CreditsUpper > credits || item.CreditsUpper == -1))
				{
					return item;
				}
			}

			return null;
		}

		#endregion
	}
}

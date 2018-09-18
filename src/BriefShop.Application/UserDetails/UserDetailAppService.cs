using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using BriefShop.Core;
using BriefShop.UserDetails.Dto;
using System;
using System.Threading.Tasks;

namespace BriefShop.UserDetails
{
	public class UserDetailAppService : BriefShopAppServiceBase, IUserDetailAppService
	{
		private readonly IRepository<UserDetail, int> _userDetailRepository;

		public UserDetailAppService(IRepository<UserDetail, int> userDetailRepository)
		{
			_userDetailRepository = userDetailRepository;
		}

		public async Task UpdateUserLastVisit(UpdateUserLastVisitInput input)
		{
			try
			{
				var entity = await _userDetailRepository.GetAsync(input.UserId);

				entity.LastVisitIP = input.IP;
				entity.LastVisitRgId = input.RegionId;
				entity.LastVisitTime = input.VisitTime;

				await _userDetailRepository.UpdateAsync(entity);
			}
			catch (Exception ex)
			{
				throw new UserFriendlyException("CouldNotFoundTheUser");
			}
		}
	}
}

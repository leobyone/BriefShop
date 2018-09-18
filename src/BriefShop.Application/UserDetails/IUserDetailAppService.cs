using Abp.Application.Services;
using BriefShop.UserDetails.Dto;
using System.Threading.Tasks;

namespace BriefShop.UserDetails
{
	public interface IUserDetailAppService: IApplicationService
	{
		Task UpdateUserLastVisit(UpdateUserLastVisitInput input);
	}
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BriefShop.Regions.Dto;
using System.Threading.Tasks;

namespace BriefShop.Regions
{
	/// <summary>
	/// 区域表服务接口
	/// </summary>
	public interface IRegionAppService : IApplicationService
	{
		Task<GetAllRegionOutput> GetAllRegionAsync();

		Task<GetAllRegionOutput> GetRegionListAsync(int parentId);

		Task<RegionDto> GetRegionByIdAsync(EntityDto<int> input);

		Task<RegionDto> GetRegionByNameAndLayerAsync(string name, int layer);

		Task<RegionDto> SeekAsync(GetIPInput input);

		Task<RegionDto> GetRegionByIPAsync(GetIPInput input);
	}
}

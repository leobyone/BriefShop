using AutoMapper;
using BriefShop.Core;
using BriefShop.Regions.Dto;

namespace BriefShop.Regions.Mappers
{
	/// <summary>
	/// Region映射配置
	/// </summary>
	public class RegionDtoMapper : IDtoMapping
	{
		public void CreateMapping(IMapperConfigurationExpression mapper)
		{
			mapper.CreateMap<Region, RegionDto>();
		}
	}
}

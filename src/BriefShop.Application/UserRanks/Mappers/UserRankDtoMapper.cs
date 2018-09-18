using AutoMapper;
using BriefShop.Core;
using BriefShop.UserRanks.Dto;

namespace BriefShop.UserRanks.Mappers
{
	/// <summary>
	/// UserRank映射配置
	/// </summary>
	public class UserRankDtoMapper : IDtoMapping
	{
		public void CreateMapping(IMapperConfigurationExpression mapper)
		{
			mapper.CreateMap<UserRank, UserRankDto>();		
		}
	}
}

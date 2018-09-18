using AutoMapper;
using BriefShop.Core;
using BriefShop.UserDetails.Dto;

namespace BriefShop.UserDetails.Mappers
{
	/// <summary>
	/// UserDetail映射配置
	/// </summary>
	public class UserDetailDtoMapper : IDtoMapping
	{
		public void CreateMapping(IMapperConfigurationExpression mapper)
		{
			mapper.CreateMap<UserDetail, UserDetailDto>();

			var map = mapper.CreateMap<UpdateUserLastVisitInput, UserDetail>();
			map.ForMember(m => m.Id, o => o.Ignore());
		}
	}
}

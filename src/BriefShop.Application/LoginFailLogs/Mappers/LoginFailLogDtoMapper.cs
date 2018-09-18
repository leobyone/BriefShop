using AutoMapper;
using BriefShop.Core;
using BriefShop.LoginFailLogs.Dto;

namespace BriefShop.LoginFailLogs.Mappers
{
	/// <summary>
	/// LoginFailLog映射配置
	/// </summary>
	public class LoginFailLogDtoMapper : IDtoMapping
	{
		public void CreateMapping(IMapperConfigurationExpression mapper)
		{
			mapper.CreateMap<LoginFailLog, LoginFailLogDto>();
		}
	}
}

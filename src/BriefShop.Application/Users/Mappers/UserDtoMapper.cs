using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BriefShop.Core;
using BriefShop.Users.Dto;

namespace BriefShop.Users.Mappers
{
	/// <summary>
	/// User映射配置
	/// </summary>
	public class UserDtoMapper : IDtoMapping
	{
		public void CreateMapping(IMapperConfigurationExpression mapper)
		{
			mapper.CreateMap<User, UserDto>();
			mapper.CreateMap<UserDto, User>();
			mapper.CreateMap<UpdateUserRankByUserIdInput, User>();

			var map = mapper.CreateMap<UpdateUserRankByUserIdInput, User>();
			map.ForMember(m => m.Id, o => o.Ignore());
		}
	}
}

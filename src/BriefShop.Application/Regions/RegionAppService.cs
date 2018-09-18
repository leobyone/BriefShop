using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Linq.Extensions;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.UI;
using BriefShop.Core;
using BriefShop.Regions.Dto;
using System.Data.Entity;
using BriefShop.IP;
using Abp.WebApi.Client;
using System.Web;

namespace BriefShop.Regions
{
	/// <summary>
	/// Region应用层服务的接口实现方法
	/// </summary>
	public class RegionAppService : BriefShopAppServiceBase, IRegionAppService
	{
		private readonly IRepository<Region, int> _regionRepository;
		private readonly IAbpWebApiClient _abpWebApiClient;

		public RegionAppService(
			IRepository<Region, int> regionRepository,
			IAbpWebApiClient abpWebApiClient)
		{
			_regionRepository = regionRepository;
			_abpWebApiClient = abpWebApiClient;
		}

		public async Task<GetAllRegionOutput> GetAllRegionAsync()
		{
			var regions = await _regionRepository.GetAllListAsync();

			return new GetAllRegionOutput
			{
				Regions = ObjectMapper.Map<List<RegionDto>>(regions)
			};
		}

		public async Task<RegionDto> GetRegionByIdAsync(EntityDto<int> input)
		{
			try
			{
				var region = await _regionRepository.GetAsync(input.Id);

				if (region == null) return null;

				return ObjectMapper.Map<RegionDto>(region);
			}
			catch
			{
				return null;
			}
		}

		public async Task<RegionDto> GetRegionByNameAndLayerAsync(string name, int layer)
		{
			try
			{
				var region = await _regionRepository.SingleAsync(m => m.Name == name && m.Layer == layer);

				if (region == null) return null;

				return ObjectMapper.Map<RegionDto>(region);
			}
			catch
			{
				return null;
			}
		}

		public async Task<GetAllRegionOutput> GetRegionListAsync(int parentId)
		{
			var regions = await _regionRepository.GetAll()
							 .WhereIf(parentId > 0, m => m.ParentId == parentId)
							 .ToListAsync();

			return new GetAllRegionOutput
			{
				Regions = ObjectMapper.Map<List<RegionDto>>(regions)
			};
		}

		/// <summary>
		/// 根据ip地址确定所在区域
		/// </summary>
		/// <param name="ip">ip地址</param>
		/// <returns></returns>
		public async Task<RegionDto> SeekAsync(GetIPInput iPInput)
		{
			IPLocation ipLocation = new IPSeekManage().SearchLocation(iPInput.IP);
			if (ipLocation == null || ipLocation.Country.Length == 0)
				return null;

			string country = ipLocation.Country;

			int startIndex = country.IndexOf("省");
			int endIndex = country.IndexOf("市");
			if (startIndex > 0 && endIndex > 0 && endIndex > startIndex)
			{
				RegionDto regionDto = await GetRegionByNameAndLayerAsync(country.Substring(startIndex + 1, endIndex - startIndex), 2);
				if (regionDto != null)
					return regionDto;
			}

			EntityDto<int> input = new EntityDto<int>();

			if (country.StartsWith("北京"))
			{
				input.Id = 35;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("天津"))
			{
				input.Id = 36;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("上海"))
			{
				input.Id = 107;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("重庆"))
			{
				input.Id = 269;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("四川省"))
			{
				if (country.Length == 3)
				{
					input.Id = 23;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("四川省阿坝州"))
				{
					input.Id = 288;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("四川省甘孜州"))
				{
					input.Id = 289;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("四川省凉山州"))
				{
					input.Id = 290;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("湖南省"))
			{
				if (country.Length == 3)
				{
					input.Id = 18;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("湖南省湘西州"))
				{
					input.Id = 230;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("湖北省"))
			{
				if (country.Length == 3)
				{
					input.Id = 17;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("湖北省神农架林区"))
				{
					input.Id = 1997;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("广西"))
			{
				if (country.Length == 2)
				{
					input.Id = 20;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(2, country.IndexOf('市') - 2), 2);
			}
			else if (country.StartsWith("云南省"))
			{
				if (country.Length == 3)
				{
					input.Id = 25;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省楚雄州"))
				{
					input.Id = 308;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省红河州"))
				{
					input.Id = 309;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省文山州"))
				{
					input.Id = 310;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省西双版纳州"))
				{
					input.Id = 311;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省大理州"))
				{
					input.Id = 312;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省德宏州"))
				{
					input.Id = 313;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省怒江州"))
				{
					input.Id = 314;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("云南省迪庆州"))
				{
					input.Id = 315;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("黑龙江省"))
			{
				if (country.Length == 4)
				{
					input.Id = 8;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(4, country.IndexOf('市') - 4), 2);
				else if (country.Contains("地区"))
					return await GetRegionByNameAndLayerAsync(country.Substring(4, country.IndexOf("地区") - 3), 2);
			}
			else if (country.StartsWith("吉林省"))
			{
				if (country.Length == 3)
				{
					input.Id = 7;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("吉林省延边州"))
				{
					input.Id = 93;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("内蒙古"))
			{
				if (country.Length == 3)
				{
					input.Id = 5;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("盟"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('盟') - 3), 2);
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("贵州省"))
			{
				if (country.Length == 3)
				{
					input.Id = 24;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("贵州省黔西南"))
				{
					input.Id = 296;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("贵州省黔东南"))
				{
					input.Id = 298;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("贵州省黔南州"))
				{
					input.Id = 299;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("甘肃省"))
			{
				if (country.Length == 3)
				{
					input.Id = 28;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("甘肃省临夏州"))
				{
					input.Id = 345;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("甘肃省甘南"))
				{
					input.Id = 346;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("新疆"))
			{
				if (country.Length == 2)
				{
					input.Id = 31;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆阿勒泰"))
				{
					input.Id = 373;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆昌吉州"))
				{
					input.Id = 364;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆博尔塔拉州"))
				{
					input.Id = 365;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆巴音郭楞州"))
				{
					input.Id = 366;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆克孜勒苏柯尔州"))
				{
					input.Id = 368;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("新疆伊犁州"))
				{
					input.Id = 371;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(2, country.IndexOf('市') - 2), 2);
				else if (country.Contains("地区"))
					return await GetRegionByNameAndLayerAsync(country.Substring(2, country.IndexOf("地区") - 1), 2);
			}
			else if (country.StartsWith("青海省"))
			{
				if (country.Length == 3)
				{
					input.Id = 29;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省海北州"))
				{
					input.Id = 349;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省黄南州"))
				{
					input.Id = 350;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省海南州"))
				{
					input.Id = 351;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省果洛州"))
				{
					input.Id = 352;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省玉树州"))
				{
					input.Id = 353;
					return await GetRegionByIdAsync(input);
				}
				else if (country.StartsWith("青海省海西州"))
				{
					input.Id = 354;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(3, country.IndexOf('市') - 3), 2);
			}
			else if (country.StartsWith("西藏"))
			{
				if (country.Length == 2)
				{
					input.Id = 26;
					return await GetRegionByIdAsync(input);
				}
				else if (country.Contains("市"))
					return await GetRegionByNameAndLayerAsync(country.Substring(2, country.IndexOf('市') - 2), 2);
				else if (country.Contains("地区"))
					return await GetRegionByNameAndLayerAsync(country.Substring(2, country.IndexOf("地区") - 1), 2);
			}
			else if (country.StartsWith("香港"))
			{
				input.Id = 3241;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("澳门"))
			{
				input.Id = 3242;
				return await GetRegionByIdAsync(input);
			}
			else if (country.StartsWith("台湾"))
			{
				input.Id = 3240;
				return await GetRegionByIdAsync(input);
			}
			return null;
		}

		/// <summary>
		/// 根据ip地址确定所在区域
		/// </summary>
		/// <param name="iPInput"></param>
		/// <returns></returns>
		public async Task<RegionDto> GetRegionByIPAsync(GetIPInput iPInput)
		{
			RegionDto regionDto = new RegionDto();
			HttpCookie cookie = HttpContext.Current.Request.Cookies["loc"];
			if (cookie != null)
			{
				if (cookie["ip"] == iPInput.IP)
				{
					EntityDto entityDto = new EntityDto();
					entityDto.Id = TypeHelper.StringToInt(cookie["regionid"]);
					regionDto = await GetRegionByIdAsync(entityDto);
				}
				else
				{
					cookie.Values["ip"] = iPInput.IP;
					regionDto = await SeekAsync(iPInput);
					if (regionDto != null)
						cookie.Values["regionid"] = regionDto.Id.ToString();
					else
						cookie.Values["regionid"] = "-1";
					cookie.Expires = DateTime.Now.AddYears(1);

					HttpContext.Current.Response.AppendCookie(cookie);
				}

			}
			else
			{
				cookie = new HttpCookie("loc");
				cookie.Values["ip"] = iPInput.IP;
				regionDto = await SeekAsync(iPInput);
				if (regionDto != null)
					cookie.Values["regionid"] = regionDto.Id.ToString();
				else
					cookie.Values["regionid"] = "-1";
				cookie.Expires = DateTime.Now.AddYears(1);

				HttpContext.Current.Response.AppendCookie(cookie);
			}

			if (regionDto != null)
				return regionDto;
			else
				return new RegionDto() { Id = -1, Name = "未知区域" };
		}
	}
}

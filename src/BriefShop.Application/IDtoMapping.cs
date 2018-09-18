using AutoMapper;

namespace BriefShop
{
	/// <summary>
	/// 实现该接口以进行映射规则创建
	/// </summary>
	public interface IDtoMapping
	{
		void CreateMapping(IMapperConfigurationExpression mapper);
	}
}

using Abp.AutoMapper;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using System.Reflection;

namespace BriefShop
{
	[DependsOn(typeof(BriefShopCoreModule), typeof(AbpAutoMapperModule))]
	public class BriefShopApplicationModule : AbpModule
	{
		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			//注册IDtoMapping
			IocManager.IocContainer.Register(
				Classes.FromAssembly(Assembly.GetExecutingAssembly())
					.IncludeNonPublicTypes()
					.BasedOn<IDtoMapping>()
					.WithService.Self()
					.WithService.DefaultInterfaces()
					.LifestyleTransient()
			);

			//解析依赖，并进行映射规则创建
			Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
			{
				var mappers = IocManager.IocContainer.ResolveAll<IDtoMapping>();

				foreach (var dtomap in mappers)
				{
					dtomap.CreateMapping(mapper);
				}
			});
		}
	}
}

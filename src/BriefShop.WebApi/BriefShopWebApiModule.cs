using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace BriefShop
{
    [DependsOn(typeof(AbpWebApiModule), typeof(BriefShopApplicationModule))]
    public class BriefShopWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(BriefShopApplicationModule).Assembly, "app")
                .Build();
        }
    }
}

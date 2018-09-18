using System.Reflection;
using Abp.Modules;

namespace BriefShop
{
    public class BriefShopCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

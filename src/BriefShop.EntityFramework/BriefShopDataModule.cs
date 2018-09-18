using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using BriefShop.EntityFramework;

namespace BriefShop
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(BriefShopCoreModule))]
    public class BriefShopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<BriefShopDbContext>(null);
        }
    }
}

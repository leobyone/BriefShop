using Abp.Application.Services;

namespace BriefShop
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BriefShopAppServiceBase : ApplicationService
    {
        protected BriefShopAppServiceBase()
        {
            LocalizationSourceName = BriefShopConsts.LocalizationSourceName;
        }
    }
}
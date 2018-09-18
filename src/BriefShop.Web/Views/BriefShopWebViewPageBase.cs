using Abp.Web.Mvc.Views;
using BriefShop.Web.Controllers;
using BriefShop.Web.Framework;
using BriefShop.Web.Framework.Controller;

namespace BriefShop.Web.Views
{
    public abstract class BriefShopWebViewPageBase : BriefShopWebViewPageBase<dynamic>
    {

    }

    public abstract class BriefShopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BriefShopWebViewPageBase()
        {
            LocalizationSourceName = BriefShopConsts.LocalizationSourceName;
        }

		public WebWorkContext WorkContext;

		public sealed override void InitHelpers()
		{
			base.InitHelpers();
			WorkContext = ((BriefShopControllerBase)(this.ViewContext.Controller)).WorkContext;
		}
	}
}
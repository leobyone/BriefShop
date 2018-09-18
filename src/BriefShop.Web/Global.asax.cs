using System;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Castle.Facilities.Logging;

namespace BriefShop.Web
{
    public class MvcApplication : AbpWebApplication<BriefShopWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
			var path = Server.MapPath("log4net.config");

			AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );

            base.Application_Start(sender, e);
        }
    }
}

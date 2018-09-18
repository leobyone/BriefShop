using Abp.Owin;
using BriefShop.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace BriefShop.Web
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseAbp();
		}
	}
}
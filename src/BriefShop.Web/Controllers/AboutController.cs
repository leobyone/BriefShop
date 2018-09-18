using System.Web.Mvc;

namespace BriefShop.Web.Controllers
{
    public class AboutController : BriefShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
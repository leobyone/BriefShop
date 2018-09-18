using System.Web.Mvc;

namespace BriefShop.Web.Controllers
{
    public class HomeController : BriefShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
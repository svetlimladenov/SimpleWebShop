using System.Web.UI;

namespace SimpleWebShop.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
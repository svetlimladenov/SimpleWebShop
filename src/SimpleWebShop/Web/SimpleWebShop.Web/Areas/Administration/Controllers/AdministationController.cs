using System.Web.Mvc;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class NavigationController : AdministrationBaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
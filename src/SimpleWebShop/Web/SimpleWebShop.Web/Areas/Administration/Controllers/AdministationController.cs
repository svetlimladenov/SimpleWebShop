using System.Web.Mvc;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class DashboardController : AdministrationBaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
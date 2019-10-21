using System.Web.Mvc;
using SimpleWebShop.Data;
using SimpleWebShop.Web.Infrastructure;

namespace SimpleWebShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeService someService;

        public HomeController(ISomeService someService)
        {
            this.someService = someService;
        }
        public ActionResult Index()
        {
            someService.Work();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
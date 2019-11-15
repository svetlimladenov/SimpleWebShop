using System.Linq;
using SimpleWebShop.Web.Services.Contracts;

namespace SimpleWebShop.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly ICategoriesServices categoriesServices;

        public HomeController(ICategoriesServices categoriesServices)
        {
            this.categoriesServices = categoriesServices;
        }
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]   
        //[OutputCache(Duration = 5 * 60, Location = OutputCacheLocation.ServerAndClient)]
        public ActionResult Categories()
        {
            return Json(this.categoriesServices.GetCategoriesForLinks().ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
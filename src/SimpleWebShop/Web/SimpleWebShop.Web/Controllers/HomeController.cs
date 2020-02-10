using System.Linq;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Services.Models.ViewModels.Home;

namespace SimpleWebShop.Web.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly ICategoriesServices categoriesServices;
        private readonly IProductsControlPanelServices productsControlPanelServices;

        public HomeController(ICategoriesServices categoriesServices, IProductsControlPanelServices productsControlPanelServices)
        {
            this.categoriesServices = categoriesServices;
            this.productsControlPanelServices = productsControlPanelServices;
        }
        public ActionResult Index()
        {
            var model = new HomeIndexViewModel()
            {
                CategoriesLinks = this.categoriesServices.GetCategoriesForLinks()
            };
            return this.View(model);
        }

        [HttpGet]   
        //[OutputCache(Duration = 5 * 60, Location = OutputCacheLocation.ServerAndClient)]
        public ActionResult Categories()
        {
            return Json(this.categoriesServices.GetCategoriesForLinks().ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult TestingSmth()
        {
            var products = this.productsControlPanelServices.GetAll(x => x.Name.Contains("f"));
            return this.Json(products,JsonRequestBehavior.AllowGet);
        }
    }
}
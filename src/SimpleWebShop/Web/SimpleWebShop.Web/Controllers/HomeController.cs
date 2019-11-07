using System.Web.UI;
using SimpleWebShop.Web.Services.Contracts;
using SimpleWebShop.Web.ViewModels.Home;

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
            var model = new HomeIndexViewModel()
            {
                CategoriesLinks = this.categoriesServices.GetCategoriesForLinks()
            };
            return this.View(model);
        }
    }
}
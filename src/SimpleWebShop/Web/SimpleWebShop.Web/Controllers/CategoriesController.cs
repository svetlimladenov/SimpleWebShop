using System.Web.Mvc;
using SimpleWebShop.Services.Data.Contracts;

namespace SimpleWebShop.Web.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoriesServices categoriesServices;

        public CategoriesController(ICategoriesServices categoriesServices)
        {
            this.categoriesServices = categoriesServices;
        }
        public ActionResult Index(string category, string admin)
        {
            ViewData["category"] = category;
            var viewModel = this.categoriesServices.GetCategoryViewModel(category);
            if (this.User.IsInRole("Administrator") && !string.IsNullOrEmpty(admin) && admin == "True")
            {
                return this.View("AdminIndex", viewModel);
            }
            //TODO: Finish show info if an admin(Edit, Delete, ...) is watching otherwise show info for normal customer
            //TODO: If the category has child categories list them otherwise list the products

            return this.View(viewModel);
        }   
    }
}
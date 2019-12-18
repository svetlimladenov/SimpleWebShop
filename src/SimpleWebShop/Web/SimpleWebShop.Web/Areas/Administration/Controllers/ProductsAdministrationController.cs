using System.Linq;
using System.Web.Mvc;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.Services;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class ProductsAdministrationController : AdministrationBaseController
    {
        private readonly ICategoriesServices categoriesServices;
        private readonly IAdminProductsServices adminProductsServices;

        public ProductsAdministrationController(
            ICategoriesServices categoriesServices, 
            IAdminProductsServices adminProductsServices
        )
        {
            this.categoriesServices = categoriesServices;
            this.adminProductsServices = adminProductsServices;
        }
        // GET: Administration/ProductsAdministration
        public ActionResult Create()
        {
            var viewModel = new CreateProductInputModel()
            {
                AllCategoriesNames = this.categoriesServices.GetAllWithDeletedCategories().Select(x => x.Name).ToArray(),
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateProductInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(inputModel);
            }
            this.adminProductsServices.CreateProduct(inputModel);
            return this.RedirectToAction("ProductsControlPanel", "Dashboard");
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using SimpleWebShop.Common;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.Services;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using SimpleWebShop.Web.Controllers;

namespace SimpleWebShop.Web.Areas.Administration.Controllers
{
    public class CategoriesAdministrationController : AdministrationBaseController
    {
        private readonly ICategoriesServices categoriesServices;
        private readonly IAdminCategoriesServices adminCategoriesServices;

        public CategoriesAdministrationController(ICategoriesServices categoriesServices, IAdminCategoriesServices adminCategoriesServices)
        {
            this.categoriesServices = categoriesServices;
            this.adminCategoriesServices = adminCategoriesServices;
        }

        public ActionResult Create()
        {
            var viewModel = new CreateCategoryInputModel()
            {
                AllFontAwesomeIcons = GlobalConstants.FontAwesomeClasses.ToList()
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //TODO: AutoValidateAntiForgeryToken
        public ActionResult Create(CreateCategoryInputModel inputModel)
        {   
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            this.adminCategoriesServices.CreateCategory(inputModel);
            return this.RedirectToAction("ProductsControlPanel", "Dashboard");
        }

        public ActionResult All()
        {
            var viewModel = this.categoriesServices.GetAllCategories();
            return this.View(viewModel);
        }

        public ActionResult Edit(string id)
        {
            ViewData["id"] = id;
            return this.View();
        }

        [HttpPost]
        public JsonResult Delete([Required]string id)
        {
            this.adminCategoriesServices.DeleteCategory(id);
            return this.Json(new[] {id});
        }
    }
}
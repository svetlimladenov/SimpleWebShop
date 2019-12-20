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
        public ActionResult Create(CreateCategoryInputModel inputModel)
        {   
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            this.adminCategoriesServices.CreateCategory(inputModel);
            return this.RedirectToAction("ProductsControlPanel", "Dashboard");
        }

        [HttpGet]
        public ActionResult All(int? p)
        {   
            int perPage = 5;
            int realPage;
            realPage = p ?? 1;
            var viewModel = this.categoriesServices.GetAllWithDeletedCategories(realPage, perPage);
            ViewData["counter"] = (realPage - 1) * perPage;
            var categoriesCount = this.categoriesServices.GetCategoriesCount();
            var pagesCount = categoriesCount % perPage + 1;
            ViewBag.pagesCount = pagesCount;
            ViewBag.pageNumber = realPage;
            return this.View(viewModel);    
        }

        public ActionResult Edit(string id)
        {
            if (TempData.ContainsKey("Edit"))
            {   
                id = TempData["Edit"].ToString();
            }
            ViewData["id"] = id;
            return this.View();
        }

        [HttpPost]
        public ActionResult BringBack([Required] string id)
        {
            this.adminCategoriesServices.BringBackCategory(id);
            return this.Json(new[] { id });
        }

        [HttpPost]
        public ActionResult Delete([Required] string id)
        {
            this.adminCategoriesServices.DeleteCategory(id);
            return this.Json(new[] { id });
        }
    }
}